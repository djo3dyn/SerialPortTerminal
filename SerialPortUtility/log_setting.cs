using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SerialPortUtility
{
    public partial class log_setting : Form
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

        public log_setting()
        {
            InitializeComponent();
            load_setting();
        }

        private void set_setting()
        {
            main_frm.rx_name = rx_name;
            main_frm.tx_name = tx_name;

            main_frm.wordwrap_enable = wordwrap_enable;
            main_frm.txlog_enable = txlog_enable;
            main_frm.info_enable = info_enable;
            main_frm.rxname_enable = rxname_enable ;
            main_frm.txname_enable = txname_enable ;

            main_frm.rx_color = rx_color;
            main_frm.tx_color = tx_color;
            main_frm.inf_color = inf_color;
            main_frm.rx_font = rx_font;
            main_frm.tx_font = tx_font;
            main_frm.inf_font = inf_font;
        }

        private void load_setting()
        {
            rx_name = main_frm.rx_name;
            rxname_txt.Text = rx_name; // Set
            tx_name = main_frm.tx_name;
            txname_txt.Text = tx_name; // Set

            wordwrap_enable = main_frm.wordwrap_enable;
            wordwrap_check.Checked = main_frm.wordwrap_enable;
            txlog_enable = main_frm.txlog_enable;
            tx_log_check.Checked = txlog_enable;// check set
            info_enable = main_frm.info_enable;
            info_check.Checked = info_enable; // set
            rxname_enable = main_frm.rxname_enable;
            showrx_check.Checked = rxname_enable; // set
            txname_enable = main_frm.txname_enable;
            showtx_check.Checked = txname_enable; // set

            rx_color = main_frm.rx_color;
            rxcolor_txt.Text = rx_color.Name.ToString();
            tx_color = main_frm.tx_color;
            txcolor_txt.Text = tx_color.Name.ToString();
            inf_color = main_frm.inf_color;
            infocolor_txt.Text = inf_color.Name.ToString();
            rx_font = main_frm.rx_font;
            rxfont_txt.Text = rx_font.Name.ToString()+","+ rx_font.Size.ToString();
            tx_font = main_frm.tx_font;
            txfont_txt.Text = tx_font.Name.ToString() + "," + tx_font.Size.ToString(); ;
            inf_font = main_frm.inf_font;
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
