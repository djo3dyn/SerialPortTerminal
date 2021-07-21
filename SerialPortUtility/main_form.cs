using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//Add Using
using System.IO.Ports;
using NumberFromString;

namespace SerialPortUtility
{
    public partial class main_frm : Form
    {
        public main_frm()
        {
            InitializeComponent();
            // Init Program
            SPU_Initialize();

        }
        /*=====================Public variable & function=============================*/

        //Main Port
        public static SerialPort main_port = new SerialPort();

        // Log Setting
        public static string rx_name;
        public static string tx_name;

        public static bool wordwrap_enable;
        public static bool txlog_enable;
        public static bool info_enable;
        public static bool rxname_enable;
        public static bool txname_enable;

        public static Color rx_color = Color.Red;
        public static Color tx_color = Color.Blue;
        public static Color inf_color = Color.Orange;
        public static Font rx_font ;
        public static Font tx_font ;
        public static Font inf_font ;

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
        private numberfromstring numberToSend = new numberfromstring();
        private numberfromstring numberReceive = new numberfromstring();

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
            main_port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            main_port.WriteTimeout = 2000;
            main_port.ReadTimeout = 2000;

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
            send_btn.Enabled = main_port.IsOpen; // Enable/Disable Send Button
            if (main_port.IsOpen == true)
            {
                open_btn.Text = "Disconnect";
                status_bar.Text = "Connected to : " + main_port.PortName;
                
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

            string_rtb.WordWrap = wordwrap_enable;
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
            string txt_baud = Convert.ToString(main_port.BaudRate);
            string txt_data = Convert.ToString(main_port.DataBits);
            string txt_stop = Convert.ToString(main_port.StopBits);
            string txt_parity = Convert.ToString(main_port.Parity);

            string label_buffer ="Port Setting : "+ main_port.PortName + "-" + txt_baud + "-" + txt_data + "-" + txt_stop + "-" + txt_parity+" (Click to change...)";
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
                if (info_enable)
                {
                    string temp = date_time_txt + "System : [INFO] " + _text_in;
                    Append_log(temp, inf_color, inf_font);
                }
                
            }
            else if (_type == 1) //Receive Log
            {
                set_text_log(numberReceive);

                string _tempname;
                if (rxname_enable) _tempname = rx_name + " : ";
                else _tempname = String.Empty;

                // Safe Write
                string _temp = date_time_txt + _tempname + ascii_txt + dec_txt + hex_txt + bin_txt ;
                SafeWriteText(_temp, rx_color , 0 , rx_font);
            }
            else if (_type == 2 ) // Transmit Log
            {
                if (txlog_enable)
                {
                    
                    set_text_log(numberToSend);

                    string _tempname;
                    if (txname_enable) _tempname = tx_name + " : ";
                    else _tempname = String.Empty;

                    string _temp = date_time_txt + _tempname + ascii_txt + dec_txt + hex_txt + bin_txt;
                    Append_log(_temp, tx_color, tx_font);
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
        private void set_text_log(numberfromstring _numobj)
        {
            // Initialize....................
            if (ascii_enabled) ascii_txt = "[ASCII] "+_numobj.get_string() +" ";
            else ascii_txt = string.Empty;

            if (dec_enabled) dec_txt = "[DEC] " + _numobj.get_string_dec() + " ";
            else dec_txt = string.Empty;

            if (hex_enabled) hex_txt = "[HEX] " + _numobj.get_string_hex() + " ";
            else hex_txt = string.Empty;

            if (bin_enabled) bin_txt = "[BIN] " + _numobj.get_string_bin() + " ";
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
            main_port.PortName = AppSetting.Default.ComName;
            main_port.BaudRate = AppSetting.Default.ComBaudRate;
            main_port.DataBits = AppSetting.Default.ComDataBit;
            main_port.Parity = AppSetting.Default.ComParity;
            main_port.StopBits = AppSetting.Default.ComStopBits;
            main_port.Handshake = AppSetting.Default.ComHandshake;

            // Sending
            sendtype_cmb.SelectedIndex = AppSetting.Default.SendType;
            append_cmb.SelectedIndex = AppSetting.Default.SendAppend;

            // Logging
            wordwrap_enable = AppSetting.Default.LogWordWrap;
            tx_name = AppSetting.Default.LogTxName;
            rx_name = AppSetting.Default.LogRxName;
            tx_font = AppSetting.Default.LogTxFont;
            rx_font = AppSetting.Default.LogRxFont;
            inf_font = AppSetting.Default.LogInfFont;
            tx_color = AppSetting.Default.LogTXColor;
            rx_color = AppSetting.Default.LogRXColor;
            inf_color = AppSetting.Default.LogInfoColor;
            txlog_enable = AppSetting.Default.LogTxEn;
            info_enable = AppSetting.Default.LogInfoEn;
            txname_enable = AppSetting.Default.LogTxNameEn;
            rxname_enable = AppSetting.Default.LogRxNameEn;
            time_enabled = AppSetting.Default.LogTime;
            ascii_enabled = AppSetting.Default.LogASCII;
            dec_enabled = AppSetting.Default.LogDEC;
            hex_enabled = AppSetting.Default.LogHEX;
            bin_enabled = AppSetting.Default.LogBIN;

        }

        private void SaveSetting()
        {
            AppSetting.Default.ComName = main_port.PortName;
            AppSetting.Default.ComBaudRate = main_port.BaudRate;
            AppSetting.Default.ComDataBit = main_port.DataBits;
            AppSetting.Default.ComParity = main_port.Parity;
            AppSetting.Default.ComStopBits = main_port.StopBits;
            AppSetting.Default.ComHandshake = main_port.Handshake;

            // Sending
            AppSetting.Default.SendType = sendtype_cmb.SelectedIndex;
            AppSetting.Default.SendAppend = append_cmb.SelectedIndex;

            // Logging
            AppSetting.Default.LogWordWrap = wordwrap_enable;

            AppSetting.Default.LogTxName = tx_name;
            AppSetting.Default.LogRxName = rx_name;

            AppSetting.Default.LogTxFont = tx_font;
            AppSetting.Default.LogRxFont = rx_font;
            AppSetting.Default.LogInfFont = inf_font;

            AppSetting.Default.LogTXColor = tx_color;
            AppSetting.Default.LogRXColor = rx_color;
            AppSetting.Default.LogInfoColor = inf_color;

            AppSetting.Default.LogTxEn = txlog_enable;
            AppSetting.Default.LogInfoEn = info_enable;

            AppSetting.Default.LogTxNameEn = txname_enable;
            AppSetting.Default.LogRxNameEn = rxname_enable;

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
                if (main_port.IsOpen != true)
                {
                    main_port.Open();
                    
                    if (!first_connect)
                    {
                        string_rtb.Clear();
                        first_connect = true;
                    }
                    log_act(0, "Port Connected to : " + main_port.PortName);
                }
                else
                {
                    main_port.Close();
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
            if (main_port.IsOpen==true)
            {
                string text_send = sendstring_txt.Text;
                if (append_text != null) text_send += append_text;
                byte[] number_send = numberToSend.get_number_byte();
                try
                {
                    if (conv_result == 0)
                    {
                        main_port.Write(number_send, 0, number_send.Length);
                        log_act(2, text_send);
                        tx_count += (uint)numberToSend.get_number_count();
                        txcount_lbl.Text = tx_count.ToString();
                    }
                    else if (conv_result == 3)
                    {
                        main_port.Write(text_send);
                        log_act(2, text_send);
                        tx_count += (uint)numberToSend.get_number_count();
                        txcount_lbl.Text = tx_count.ToString();
                    }
                    main_port.DiscardOutBuffer();
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
            setting_frm set_frm = new setting_frm();
            set_frm.Show();
        }

        private void main_frm_Activated(object sender, EventArgs e)
        {
            Update_label();
            Port_open_close_act();
            string_rtb.WordWrap = wordwrap_enable;
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
            about_form a_frm = new about_form();
            a_frm.Show();
        }

        private void main_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSetting();
        }

        private void log_setting_btn_Click(object sender, EventArgs e)
        {
            log_setting log_frm = new log_setting();
            log_frm.Show();
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
