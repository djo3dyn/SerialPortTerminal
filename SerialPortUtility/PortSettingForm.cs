using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialPortUtility
{
    public partial class PortSettingForm : Form
    {
        public SerialPort tempPortSetting;
        public PortSettingForm()
        {
            InitializeComponent();

            tempPortSetting = new SerialPort();

            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();

            Console.WriteLine("The following serial ports were found:");

            // Display each port name to the console.
            foreach (string port in ports)
            {
                Console.WriteLine(port);
                port_cmb.Items.Add(port);
            }

            //
            port_cmb.SelectedIndex = 0;
            baud_cmb.SelectedIndex = 0;
            data_cmb.SelectedIndex = 3;
            stopbit_cmb.SelectedIndex = 0;
            parity_cmb.SelectedIndex = 0;
            flow_cmb.SelectedIndex = 0;
        }

        private Parity m_parity = new Parity();
        private StopBits m_stopbit = new StopBits();
        private Handshake m_handshake = new Handshake();

        private void set_btn_Click(object sender, EventArgs e)
        {
            set_port();
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }

        private void set_port()
        {
            if (MainForm.mainPort.IsOpen == true)
            {
                try
                {
                    MainForm.mainPort.Close();
                    perfom_set_port();
                    MainForm.mainPort.Open();
                }
                catch (Exception ex)
                {
                    // Code to handle the exception goes here.
                    MessageBox.Show("Failed to Open Port : " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }
            else
            {
                perfom_set_port();
                this.Close();
            }
        }

        private void stopbit_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (stopbit_cmb.SelectedIndex)
            {
                case 0:
                    m_stopbit = StopBits.One;
                    break;
                case 1:
                    m_stopbit = StopBits.Two;
                    break;
            }

        }

        private void parity_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (parity_cmb.SelectedIndex)
            {
                case 0:
                    m_parity = Parity.None;
                    break;
                case 1:
                    m_parity = Parity.Even;
                    break;
                case 2:
                    m_parity = Parity.Odd;
                    break;
            }
        }

        private void perfom_set_port()
        {
            try
            {
                MainForm.mainPort.PortName = port_cmb.Text;
                MainForm.mainPort.BaudRate = Convert.ToInt32(baud_cmb.Text);
                MainForm.mainPort.DataBits = Convert.ToInt32(data_cmb.Text);
                MainForm.mainPort.StopBits = m_stopbit;
                MainForm.mainPort.Parity = m_parity;
                MainForm.mainPort.Handshake = m_handshake;
            }
            catch (System.IO.IOException ex)
            {
                MessageBox.Show("Failed to Set Port : " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.ArgumentException ey)
            {
                MessageBox.Show("Failed to Set Port : " + ey.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void flow_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (flow_cmb.SelectedIndex)
            {
                case 0:
                    m_handshake = Handshake.None;
                    break;
                case 1:
                    m_handshake = Handshake.RequestToSend;
                    break;
                case 2:
                    m_handshake = Handshake.XOnXOff;
                    break;
                case 3:
                    m_handshake = Handshake.RequestToSendXOnXOff;
                    break;
            }
        }
    }
}
