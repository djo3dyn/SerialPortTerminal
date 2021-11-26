using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SerialPortUtility
{
    public partial class LogSettingForm : Form
    {
        private FontDialog fontDlg = new FontDialog();
        private ColorDialog colorDlg = new ColorDialog();

        private string rx_name;
        private string tx_name;

        private bool wordwrap_enable;
        private bool txlog_enable;
        private bool info_enable;
        private bool rxname_enable;
        private bool txname_enable;

        private Color rx_color ;
        private Color tx_color ;
        private Color inf_color ;
        private Font rx_font;
        private Font tx_font;
        private Font inf_font;

        public LogSettingForm()
        {
            InitializeComponent();
            load_setting();
        }

        private void set_setting()
        {
            MainForm.rxName = rx_name;
            MainForm.txName = tx_name;

            MainForm.wordwarpEnable = wordwrap_enable;
            MainForm.txLogEnable = txlog_enable;
            MainForm.infoEnable = info_enable;
            MainForm.rxNameEnable = rxname_enable ;
            MainForm.txNameEnable = txname_enable ;

            MainForm.rxColor = rx_color;
            MainForm.txColor = tx_color;
            MainForm.infColor = inf_color;
            MainForm.rxFont = rx_font;
            MainForm.txFont = tx_font;
            MainForm.infFont = inf_font;
        }

        private void load_setting()
        {
            rx_name = MainForm.rxName;
            rxname_txt.Text = rx_name; // Set
            tx_name = MainForm.txName;
            txname_txt.Text = tx_name; // Set

            wordwrap_enable = MainForm.wordwarpEnable;
            wordwrap_check.Checked = MainForm.wordwarpEnable;
            txlog_enable = MainForm.txLogEnable;
            tx_log_check.Checked = txlog_enable;// check set
            info_enable = MainForm.infoEnable;
            info_check.Checked = info_enable; // set
            rxname_enable = MainForm.rxNameEnable;
            showrx_check.Checked = rxname_enable; // set
            txname_enable = MainForm.txNameEnable;
            showtx_check.Checked = txname_enable; // set

            rx_color = MainForm.rxColor;
            rxcolor_txt.Text = rx_color.Name.ToString();
            tx_color = MainForm.txColor;
            txcolor_txt.Text = tx_color.Name.ToString();
            inf_color = MainForm.infColor;
            infocolor_txt.Text = inf_color.Name.ToString();
            rx_font = MainForm.rxFont;
            rxfont_txt.Text = rx_font.Name.ToString()+","+ rx_font.Size.ToString();
            tx_font = MainForm.txFont;
            txfont_txt.Text = tx_font.Name.ToString() + "," + tx_font.Size.ToString(); ;
            inf_font = MainForm.infFont;
            infofont_txt.Text = inf_font.Name.ToString() + "," + inf_font.Size.ToString(); ;
        }

        private Color get_color(Color _obj)
        {
            colorDlg.Color = _obj;
            DialogResult result = colorDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                return colorDlg.Color;
            }
            else
            {
                return _obj;
            }
        }

        private Font get_font(Font _obj)
        {
            fontDlg.Font = _obj;
            DialogResult result = fontDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                return fontDlg.Font;
            }
            else
            {
                return _obj;
            }
        }

        private void All_CheckCanged(object sender, EventArgs e)
        {
            txlog_enable = tx_log_check.Checked;
            info_enable = info_check.Checked;
            rxname_enable = showrx_check.Checked;
            txname_enable = showtx_check.Checked;
            wordwrap_enable = wordwrap_check.Checked;
        }

        private void Apply_font_text(Font _font , TextBox _txtbox)
        {
            _txtbox.Text = _font.Name.ToString() + "," + _font.Size.ToString();
        }

        private void Apply_color_text(Color _color, TextBox _txtbox)
        {
            _txtbox.Text = _color.Name.ToString();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            set_setting();
            this.Close();
        }


        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rxname_txt_Validated(object sender, EventArgs e)
        {
            rx_name = rxname_txt.Text;
        }

        private void txname_txt_Validated(object sender, EventArgs e)
        {
            tx_name = txname_txt.Text;
        }

        private void rxfont_btn_Click(object sender, EventArgs e)
        {
            rx_font = get_font(rx_font);
            Apply_font_text(rx_font, rxfont_txt);

        }

        private void rxcolor_btn_Click(object sender, EventArgs e)
        {
            rx_color = get_color(rx_color);
            Apply_color_text(rx_color, rxcolor_txt);
        }

        private void txfont_btn_Click(object sender, EventArgs e)
        {
            tx_font = get_font(tx_font);
            Apply_font_text(tx_font, txfont_txt);
        }

        private void txcolor_btn_Click(object sender, EventArgs e)
        {
            tx_color = get_color(tx_color);
            Apply_color_text(tx_color, txcolor_txt);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            inf_font = get_font(inf_font);
            Apply_font_text(inf_font, infofont_txt);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            inf_color = get_color(inf_color);
            Apply_color_text(inf_color, infocolor_txt);
        }
    }
}
