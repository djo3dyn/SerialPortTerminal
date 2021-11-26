using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
//Add Using
using System.IO.Ports;
using System.Xml.Serialization;
using System.IO;

namespace SerialPortUtility
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            // Init Program
            SPU_Initialize();

        }
        /*=====================Public variable & function=============================*/

        //Main Port
        public static SerialPort mainPort = new SerialPort();

        // Log Setting
        public static string rxName;
        public static string txName;

        public static bool wordwarpEnable;
        public static bool txLogEnable;
        public static bool infoEnable;
        public static bool rxNameEnable;
        public static bool txNameEnable;

        public static Color rxColor = Color.Red;
        public static Color txColor = Color.Blue;
        public static Color infColor = Color.Orange;
        public static Font rxFont ;
        public static Font txFont ;
        public static Font infFont ;

       /*=====================Private variable & function============================*/

        // Add SafeCall to Write to rich text box
        private delegate void SafeCallDelegate(string text);

        // Misc.
        private int send_base_number = 10;
        private string append_text = null;
        private int conv_result = 3;
        private bool first_connect = false;

        // Logging variable
        DateTime localTime;
        private string date_time_txt;
        private string ascii_txt;
        private string dec_txt;
        private string hex_txt;
        private string bin_txt;

        // Check Box Enable/Disable
        private bool time_enabled;
        private bool ascii_enabled;
        private bool dec_enabled;
        private bool hex_enabled;
        private bool bin_enabled;

        // Add Number From String
        private NumberString numberToSend = new NumberString();
        private NumberString numberReceive = new NumberString();

        // Textbox Send History
        private AutoCompleteStringCollection ascii_history = new AutoCompleteStringCollection();
        private AutoCompleteStringCollection dec_history = new AutoCompleteStringCollection();
        private AutoCompleteStringCollection hex_history = new AutoCompleteStringCollection();
        private AutoCompleteStringCollection bin_history = new AutoCompleteStringCollection();

        // Counter
        private UInt32 rx_count;
        private UInt32 tx_count;


        // Startup All Program
        private void SPU_Initialize()
        {
            // Serial Port Init
            mainPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            mainPort.WriteTimeout = 2000;
            mainPort.ReadTimeout = 2000;

            // Load Setting...
            LoadSetting();

            // Load Display
            load_ui_display();
            Update_label();
            Port_open_close_act();

            // Other Display
            numberReceive.replace_CR_LF(".", ".");
            numberToSend.replace_CR_LF(".", ".");

            // Check Program ;
            Console.WriteLine("Initialized...");

        }

        private void Port_open_close_act()
        {
            send_btn.Enabled = mainPort.IsOpen; // Enable/Disable Send Button
            if (mainPort.IsOpen == true)
            {
                open_btn.Text = "Disconnect";
                status_bar.Text = "Connected to : " + mainPort.PortName;
                
            }
            else
            {
                open_btn.Text = "Connect";
                status_bar.Text = "Disconnected.";
            }
        }

        private void load_ui_display()
        {
            datetime_check.Checked = time_enabled;
            ascii_check.Checked = ascii_enabled;
            dec_check.Checked = dec_enabled;
            hex_check.Checked = hex_enabled;
            bin_check.Checked = bin_enabled;

            string_rtb.WordWrap = wordwarpEnable;
        }

        // Serial Port Receive -------------------------------------------------------*
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();

            //Logging Action
            numberReceive.set_string(indata); ;
            log_act(1);
            rx_count += (uint)numberReceive.get_number_count();
            rxcount_lbl.Text = rx_count.ToString();
        }

        private void Update_label()
        {
            string txt_baud = Convert.ToString(mainPort.BaudRate);
            string txt_data = Convert.ToString(mainPort.DataBits);
            string txt_stop = Convert.ToString(mainPort.StopBits);
            string txt_parity = Convert.ToString(mainPort.Parity);

            string label_buffer ="Port Setting : "+ mainPort.PortName + "-" + txt_baud + "-" + txt_data + "-" + txt_stop + "-" + txt_parity+" (Click to change...)";
            setting_btn.Text = label_buffer;
        }

        // Safe Write textBox
        private void SafeWriteText(string _text, Color _textColor , int _length , Font _font)
        {
            if (string_rtb.InvokeRequired)
            {
                MethodInvoker del = delegate { SafeWriteText(_text, _textColor , _length , _font); };
                string_rtb.Invoke(del);
                return;
            }

            Append_log(_text, _textColor , _font);
        }

        private void log_act(int _type, string _text_in = " ")
        {
            // Append Date & Time
            localTime = DateTime.Now; // Update Date Time ;
            if (time_enabled) date_time_txt = localTime.ToLongTimeString() + " ";
            else date_time_txt = String.Empty;

            if (_type == 0) // Append info
            {
                if (infoEnable)
                {
                    string temp = date_time_txt + "System : [INFO] " + _text_in;
                    Append_log(temp, infColor, infFont);
                }
                
            }
            else if (_type == 1) //Receive Log
            {
                SetTextLog(numberReceive);

                string _tempname;
                if (rxNameEnable) _tempname = rxName + " : ";
                else _tempname = String.Empty;

                // Safe Write
                string _temp = date_time_txt + _tempname + ascii_txt + dec_txt + hex_txt + bin_txt ;
                SafeWriteText(_temp, rxColor , 0 , rxFont);
            }
            else if (_type == 2 ) // Transmit Log
            {
                if (txLogEnable)
                {
                    
                    SetTextLog(numberToSend);

                    string _tempname;
                    if (txNameEnable) _tempname = txName + " : ";
                    else _tempname = String.Empty;

                    string _temp = date_time_txt + _tempname + ascii_txt + dec_txt + hex_txt + bin_txt;
                    Append_log(_temp, txColor, txFont);
                }
                
            }
   
        }

        private void Append_log(string _text , Color _color , Font _font)
        {
            // Pre append
            string_rtb.SelectionStart = string_rtb.TextLength;
            string_rtb.SelectionLength = 0;
            string_rtb.SelectionFont = _font;
            string_rtb.SelectionColor = _color;
            // append text
            string_rtb.AppendText(_text);
            // new line
            string_rtb.AppendText("\n");
            // Post append
            string_rtb.SelectionColor = string_rtb.ForeColor;
            string_rtb.SelectionStart = string_rtb.Text.Length;
            string_rtb.ScrollToCaret();
        }
        private void SetTextLog(NumberString _numobj)
        {

            bool textOnly = ascii_enabled & !(time_enabled | dec_enabled | hex_enabled | bin_enabled);
            bool decOnly = dec_enabled & !(time_enabled | ascii_enabled | hex_enabled | bin_enabled);
            bool hexOnly = hex_enabled & !(time_enabled | dec_enabled | ascii_enabled | bin_enabled);
            bool binOnly = bin_enabled & !(time_enabled | dec_enabled | hex_enabled | ascii_enabled);

            // Initialize....................
            if (ascii_enabled && !textOnly) ascii_txt = "[ASCII] " + _numobj.get_string() + " ";
            else if (ascii_enabled && textOnly) ascii_txt =_numobj.get_string();
            else ascii_txt = string.Empty;

            if (dec_enabled && !decOnly) dec_txt = "[DEC] " + _numobj.get_string_dec() + " ";
            else if (dec_enabled && decOnly) dec_txt = _numobj.get_string_dec();
            else dec_txt = string.Empty;

            if (hex_enabled && !hexOnly) hex_txt = "[HEX] " + _numobj.get_string_hex() + " ";
            else if (hex_enabled && hexOnly) hex_txt = _numobj.get_string_hex();
            else hex_txt = string.Empty;

            if (bin_enabled && !binOnly) bin_txt = "[BIN] " + _numobj.get_string_bin() + " ";
            if (bin_enabled && binOnly) bin_txt = _numobj.get_string_bin();
            else bin_txt = string.Empty;
        }

        private void add_history(string _text )
        {
            switch (sendtype_cmb.SelectedIndex)
            {
                case 0:
                    ascii_history.Add(_text);
                    break;
                case 1:
                    dec_history.Add(_text);
                    break;
                case 2:
                    hex_history.Add(_text);
                    break;
                case 3:
                    bin_history.Add(_text);
                    break;
            }
        }

        // Load Settings
        private void LoadSetting()
        {
            // Comm Port
            
            mainPort.PortName = AppSetting.Default.ComName;
            mainPort.BaudRate = AppSetting.Default.ComBaudRate;
            mainPort.DataBits = AppSetting.Default.ComDataBit;
            mainPort.Parity = AppSetting.Default.ComParity;
            mainPort.StopBits = AppSetting.Default.ComStopBits;
            mainPort.Handshake = AppSetting.Default.ComHandshake;

            // Sending
            sendtype_cmb.SelectedIndex = AppSetting.Default.SendType;
            append_cmb.SelectedIndex = AppSetting.Default.SendAppend;

            // Logging
            wordwarpEnable = AppSetting.Default.LogWordWrap;
            txName = AppSetting.Default.LogTxName;
            rxName = AppSetting.Default.LogRxName;
            txFont = AppSetting.Default.LogTxFont;
            rxFont = AppSetting.Default.LogRxFont;
            infFont = AppSetting.Default.LogInfFont;
            txColor = AppSetting.Default.LogTXColor;
            rxColor = AppSetting.Default.LogRXColor;
            infColor = AppSetting.Default.LogInfoColor;
            txLogEnable = AppSetting.Default.LogTxEn;
            infoEnable = AppSetting.Default.LogInfoEn;
            txNameEnable = AppSetting.Default.LogTxNameEn;
            rxNameEnable = AppSetting.Default.LogRxNameEn;
            time_enabled = AppSetting.Default.LogTime;
            ascii_enabled = AppSetting.Default.LogASCII;
            dec_enabled = AppSetting.Default.LogDEC;
            hex_enabled = AppSetting.Default.LogHEX;
            bin_enabled = AppSetting.Default.LogBIN;

        }

        private void SaveSetting()
        {
            AppSetting.Default.ComName = mainPort.PortName;
            AppSetting.Default.ComBaudRate = mainPort.BaudRate;
            AppSetting.Default.ComDataBit = mainPort.DataBits;
            AppSetting.Default.ComParity = mainPort.Parity;
            AppSetting.Default.ComStopBits = mainPort.StopBits;
            AppSetting.Default.ComHandshake = mainPort.Handshake;
         

            // Sending
            AppSetting.Default.SendType = sendtype_cmb.SelectedIndex;
            AppSetting.Default.SendAppend = append_cmb.SelectedIndex;

            // Logging
            AppSetting.Default.LogWordWrap = wordwarpEnable;

            AppSetting.Default.LogTxName = txName;
            AppSetting.Default.LogRxName = rxName;

            AppSetting.Default.LogTxFont = txFont;
            AppSetting.Default.LogRxFont = rxFont;
            AppSetting.Default.LogInfFont = infFont;

            AppSetting.Default.LogTXColor = txColor;
            AppSetting.Default.LogRXColor = rxColor;
            AppSetting.Default.LogInfoColor = infColor;

            AppSetting.Default.LogTxEn = txLogEnable;
            AppSetting.Default.LogInfoEn = infoEnable;

            AppSetting.Default.LogTxNameEn = txNameEnable;
            AppSetting.Default.LogRxNameEn = rxNameEnable;

            AppSetting.Default.LogTime = time_enabled;
            AppSetting.Default.LogASCII = ascii_enabled;
            AppSetting.Default.LogDEC = dec_enabled;
            AppSetting.Default.LogHEX = hex_enabled;
            AppSetting.Default.LogBIN = bin_enabled;

            // Perfom save
            AppSetting.Default.Save();
        }

        /*=====================================Generated UI Event Code==========================================*/
        private void open_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Code to try goes here.
                if (mainPort.IsOpen != true)
                {
                    mainPort.Open();
                    
                    if (!first_connect)
                    {
                        string_rtb.Clear();
                        first_connect = true;
                    }
                    log_act(0, "Port Connected to : " + mainPort.PortName);
                }
                else
                {
                    mainPort.Close();
                    log_act(0, "Port Disconnected.");

                    rx_count = 0;
                    rxcount_lbl.Text = rx_count.ToString();
                    tx_count = 0;
                    txcount_lbl.Text = tx_count.ToString();
                }
            }
            catch (Exception ex)
            {
                // Code to handle the exception goes here.
                MessageBox.Show("Failed to Open Port : "+ ex.Message , "Error!", MessageBoxButtons.OK ,MessageBoxIcon.Error );
            }
            finally
            {
                // Code to execute after the try (and possibly catch) blocks
                // goes here.
                // Serial Port Change Action Event
                Port_open_close_act();
            }
           
        }
        //----------------------****************************------------------------------------
        private void send_btn_Click(object sender, EventArgs e)
        {
            if (mainPort.IsOpen==true)
            {
                string text_send = sendstring_txt.Text;
                if (append_text != null) text_send += append_text;
                byte[] number_send = numberToSend.get_number_byte();
                try
                {
                    if (conv_result == 0)
                    {
                        mainPort.Write(number_send, 0, number_send.Length);
                        log_act(2, text_send);
                        tx_count += (uint)numberToSend.get_number_count();
                        txcount_lbl.Text = tx_count.ToString();
                    }
                    else if (conv_result == 3)
                    {
                        mainPort.Write(text_send);
                        log_act(2, text_send);
                        tx_count += (uint)numberToSend.get_number_count();
                        txcount_lbl.Text = tx_count.ToString();
                    }
                    mainPort.DiscardOutBuffer();
                    add_history(sendstring_txt.Text);
                    sendstring_txt.Clear();
                }
                catch(Exception ex)
                { 
                    // Code to handle the exception goes here.
                    MessageBox.Show("Failed to Send : " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void setting_btn_Click(object sender, EventArgs e)
        {
            PortSettingForm set_frm = new PortSettingForm();
            set_frm.Show();
        }

        private void main_frm_Activated(object sender, EventArgs e)
        {
            Update_label();
            Port_open_close_act();
            string_rtb.WordWrap = wordwarpEnable;
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            string_rtb.Clear();
        }

        private void sendtype_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (sendtype_cmb.SelectedIndex)
            {
                case 0: // String
                    send_base_number = 0;
                    note_lbl.Visible = false;
                    sendstring_txt.AutoCompleteCustomSource = ascii_history;
                    break;
                case 1: // Decimal
                    send_base_number = 10;
                    note_lbl.Visible = true;
                    sendstring_txt.AutoCompleteCustomSource = dec_history;
                    break;
                case 2: // Hexadecimal
                    send_base_number = 16;
                    sendstring_txt.AutoCompleteCustomSource = hex_history;
                    note_lbl.Visible = true;
                    break;
                case 3: // Binary
                    send_base_number = 2;
                    note_lbl.Visible = true;
                    sendstring_txt.AutoCompleteCustomSource = bin_history;
                    break;
            }
        }

        private void append_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (append_cmb.SelectedIndex)
            {
                case 0: // Append None
                    append_text = null;
                    break;
                case 1: // Append CR
                    append_text = "\r";
                    break;
                case 2: // Append LF
                    append_text = "\n";
                    break;
                case 3: // Append CR+LF
                    append_text = "\r\n";
                    break;
            }
        }

        private void sendstring_txt_Validated(object sender, EventArgs e)
        {
            string temp_text = sendstring_txt.Text;
            if (send_base_number != 0 && temp_text != String.Empty) // Convertion Result from number ;
            {
                conv_result = numberToSend.set_string(temp_text, send_base_number , append_cmb.SelectedIndex);
                switch(conv_result)
                {
                    case 0:
                        input_err_prov.SetError(sendstring_txt, String.Empty);
                        break;
                    case 1:
                        input_err_prov.SetError(sendstring_txt, "Input number invalid!");
                        break;
                    case 2:
                        input_err_prov.SetError(sendstring_txt, "Number too large!");
                        break;
                }
            }
            else if (send_base_number == 0 && temp_text != String.Empty)
            {
                if (append_text != null) temp_text += append_text;
                int res = numberToSend.set_string(temp_text);
                conv_result = 3; // Convertion Result = 3 mean it text when base number = 0;
                input_err_prov.SetError(sendstring_txt, String.Empty);
            }
            else if (sendstring_txt.Text == String.Empty)
            {
                conv_result = 4; // Convertion Result = 4 mean string input is empty
            }
        }

        private void All_CheckedChanged(object sender, EventArgs e)
        {
            time_enabled = datetime_check.Checked;
            ascii_enabled = ascii_check.Checked;
            dec_enabled = dec_check.Checked;
            hex_enabled = hex_check.Checked;
            bin_enabled = bin_check.Checked;
        }

        private void about_btn_Click(object sender, EventArgs e)
        {
            AboutForm a_frm = new AboutForm();
            a_frm.ShowDialog();
        }

        private void main_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSetting();
        }

        private void log_setting_btn_Click(object sender, EventArgs e)
        {
            LogSettingForm log_frm = new LogSettingForm();
            log_frm.ShowDialog();
        }

        private void sendstring_txt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)
            {
                sendstring_txt_Validated(this, new EventArgs());
                send_btn_Click(this, new EventArgs());
                e.Handled = true;

            }
        }
    }
}
