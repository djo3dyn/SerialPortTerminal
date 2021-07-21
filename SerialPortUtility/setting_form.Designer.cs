namespace SerialPortUtility
{
    partial class setting_frm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.set_btn = new System.Windows.Forms.Button();
            this.stopbit_cmb = new System.Windows.Forms.ComboBox();
            this.data_cmb = new System.Windows.Forms.ComboBox();
            this.baud_cmb = new System.Windows.Forms.ComboBox();
            this.port_cmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.parity_cmb = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.flow_cmb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // set_btn
            // 
            this.set_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.set_btn.Location = new System.Drawing.Point(38, 225);
            this.set_btn.Name = "set_btn";
            this.set_btn.Size = new System.Drawing.Size(105, 30);
            this.set_btn.TabIndex = 0;
            this.set_btn.Text = "Set";
            this.set_btn.UseVisualStyleBackColor = true;
            this.set_btn.Click += new System.EventHandler(this.set_btn_Click);
            // 
            // stopbit_cmb
            // 
            this.stopbit_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stopbit_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopbit_cmb.FormattingEnabled = true;
            this.stopbit_cmb.Items.AddRange(new object[] {
            "1",
            "2"});
            this.stopbit_cmb.Location = new System.Drawing.Point(169, 119);
            this.stopbit_cmb.Name = "stopbit_cmb";
            this.stopbit_cmb.Size = new System.Drawing.Size(105, 24);
            this.stopbit_cmb.TabIndex = 13;
            this.stopbit_cmb.SelectedIndexChanged += new System.EventHandler(this.stopbit_cmb_SelectedIndexChanged);
            // 
            // data_cmb
            // 
            this.data_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_cmb.FormattingEnabled = true;
            this.data_cmb.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.data_cmb.Location = new System.Drawing.Point(169, 89);
            this.data_cmb.Name = "data_cmb";
            this.data_cmb.Size = new System.Drawing.Size(105, 24);
            this.data_cmb.TabIndex = 12;
            // 
            // baud_cmb
            // 
            this.baud_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baud_cmb.FormattingEnabled = true;
            this.baud_cmb.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.baud_cmb.Location = new System.Drawing.Point(169, 59);
            this.baud_cmb.Name = "baud_cmb";
            this.baud_cmb.Size = new System.Drawing.Size(105, 24);
            this.baud_cmb.TabIndex = 11;
            // 
            // port_cmb
            // 
            this.port_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port_cmb.Location = new System.Drawing.Point(169, 29);
            this.port_cmb.Name = "port_cmb";
            this.port_cmb.Size = new System.Drawing.Size(105, 24);
            this.port_cmb.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Baud Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Data Bit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Stop Bit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Parity Bit";
            // 
            // parity_cmb
            // 
            this.parity_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parity_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parity_cmb.FormattingEnabled = true;
            this.parity_cmb.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.parity_cmb.Location = new System.Drawing.Point(169, 149);
            this.parity_cmb.Name = "parity_cmb";
            this.parity_cmb.Size = new System.Drawing.Size(105, 24);
            this.parity_cmb.TabIndex = 18;
            this.parity_cmb.SelectedIndexChanged += new System.EventHandler(this.parity_cmb_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(169, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 30);
            this.button1.TabIndex = 20;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Flow Control";
            // 
            // flow_cmb
            // 
            this.flow_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flow_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flow_cmb.FormattingEnabled = true;
            this.flow_cmb.Items.AddRange(new object[] {
            "None",
            "RTS/CTS",
            "XON/XOFF",
            "Both"});
            this.flow_cmb.Location = new System.Drawing.Point(169, 179);
            this.flow_cmb.Name = "flow_cmb";
            this.flow_cmb.Size = new System.Drawing.Size(105, 24);
            this.flow_cmb.TabIndex = 21;
            this.flow_cmb.SelectedIndexChanged += new System.EventHandler(this.flow_cmb_SelectedIndexChanged);
            // 
            // setting_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 306);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.flow_cmb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.parity_cmb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stopbit_cmb);
            this.Controls.Add(this.data_cmb);
            this.Controls.Add(this.baud_cmb);
            this.Controls.Add(this.port_cmb);
            this.Controls.Add(this.set_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "setting_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Port Setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button set_btn;
        private System.Windows.Forms.ComboBox stopbit_cmb;
        private System.Windows.Forms.ComboBox data_cmb;
        private System.Windows.Forms.ComboBox baud_cmb;
        private System.Windows.Forms.ComboBox port_cmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox parity_cmb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox flow_cmb;
    }
}