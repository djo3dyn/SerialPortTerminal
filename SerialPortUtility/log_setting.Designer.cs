
namespace SerialPortUtility
{
    partial class log_setting
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.info_check = new System.Windows.Forms.CheckBox();
            this.tx_log_check = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rxcolor_btn = new System.Windows.Forms.Button();
            this.rxcolor_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rxfont_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rxfont_btn = new System.Windows.Forms.Button();
            this.showrx_check = new System.Windows.Forms.CheckBox();
            this.rxname_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txcolor_btn = new System.Windows.Forms.Button();
            this.txcolor_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txfont_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txfont_btn = new System.Windows.Forms.Button();
            this.showtx_check = new System.Windows.Forms.CheckBox();
            this.txname_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.ok_btn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.infocolor_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.infofont_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.wordwrap_check = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.wordwrap_check);
            this.groupBox1.Controls.Add(this.info_check);
            this.groupBox1.Controls.Add(this.tx_log_check);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // info_check
            // 
            this.info_check.AutoSize = true;
            this.info_check.Location = new System.Drawing.Point(9, 59);
            this.info_check.Name = "info_check";
            this.info_check.Size = new System.Drawing.Size(81, 21);
            this.info_check.TabIndex = 1;
            this.info_check.Text = "Log Info";
            this.info_check.UseVisualStyleBackColor = true;
            this.info_check.CheckedChanged += new System.EventHandler(this.All_CheckCanged);
            // 
            // tx_log_check
            // 
            this.tx_log_check.AutoSize = true;
            this.tx_log_check.Location = new System.Drawing.Point(9, 32);
            this.tx_log_check.Name = "tx_log_check";
            this.tx_log_check.Size = new System.Drawing.Size(164, 21);
            this.tx_log_check.TabIndex = 0;
            this.tx_log_check.Text = "Log Transmitted Text";
            this.tx_log_check.UseVisualStyleBackColor = true;
            this.tx_log_check.CheckedChanged += new System.EventHandler(this.All_CheckCanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rxcolor_btn);
            this.groupBox2.Controls.Add(this.rxcolor_txt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.rxfont_txt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.rxfont_btn);
            this.groupBox2.Controls.Add(this.showrx_check);
            this.groupBox2.Controls.Add(this.rxname_txt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 134);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Receiving Log";
            // 
            // rxcolor_btn
            // 
            this.rxcolor_btn.Location = new System.Drawing.Point(266, 90);
            this.rxcolor_btn.Name = "rxcolor_btn";
            this.rxcolor_btn.Size = new System.Drawing.Size(82, 25);
            this.rxcolor_btn.TabIndex = 10;
            this.rxcolor_btn.Text = "Select...";
            this.rxcolor_btn.UseVisualStyleBackColor = true;
            this.rxcolor_btn.Click += new System.EventHandler(this.rxcolor_btn_Click);
            // 
            // rxcolor_txt
            // 
            this.rxcolor_txt.Location = new System.Drawing.Point(73, 93);
            this.rxcolor_txt.Name = "rxcolor_txt";
            this.rxcolor_txt.ReadOnly = true;
            this.rxcolor_txt.Size = new System.Drawing.Size(187, 22);
            this.rxcolor_txt.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Color";
            // 
            // rxfont_txt
            // 
            this.rxfont_txt.Location = new System.Drawing.Point(73, 60);
            this.rxfont_txt.Name = "rxfont_txt";
            this.rxfont_txt.ReadOnly = true;
            this.rxfont_txt.Size = new System.Drawing.Size(187, 22);
            this.rxfont_txt.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Font";
            // 
            // rxfont_btn
            // 
            this.rxfont_btn.Location = new System.Drawing.Point(266, 59);
            this.rxfont_btn.Name = "rxfont_btn";
            this.rxfont_btn.Size = new System.Drawing.Size(82, 25);
            this.rxfont_btn.TabIndex = 4;
            this.rxfont_btn.Text = "Select...";
            this.rxfont_btn.UseVisualStyleBackColor = true;
            this.rxfont_btn.Click += new System.EventHandler(this.rxfont_btn_Click);
            // 
            // showrx_check
            // 
            this.showrx_check.AutoSize = true;
            this.showrx_check.Location = new System.Drawing.Point(266, 28);
            this.showrx_check.Name = "showrx_check";
            this.showrx_check.Size = new System.Drawing.Size(115, 21);
            this.showrx_check.TabIndex = 3;
            this.showrx_check.Text = "Show On Log";
            this.showrx_check.UseVisualStyleBackColor = true;
            this.showrx_check.CheckedChanged += new System.EventHandler(this.All_CheckCanged);
            // 
            // rxname_txt
            // 
            this.rxname_txt.Location = new System.Drawing.Point(73, 29);
            this.rxname_txt.Name = "rxname_txt";
            this.rxname_txt.Size = new System.Drawing.Size(187, 22);
            this.rxname_txt.TabIndex = 1;
            this.rxname_txt.Validated += new System.EventHandler(this.rxname_txt_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txcolor_btn);
            this.groupBox3.Controls.Add(this.txcolor_txt);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txfont_txt);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txfont_btn);
            this.groupBox3.Controls.Add(this.showtx_check);
            this.groupBox3.Controls.Add(this.txname_txt);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 258);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(420, 134);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transmitting Log";
            // 
            // txcolor_btn
            // 
            this.txcolor_btn.Location = new System.Drawing.Point(266, 90);
            this.txcolor_btn.Name = "txcolor_btn";
            this.txcolor_btn.Size = new System.Drawing.Size(82, 25);
            this.txcolor_btn.TabIndex = 10;
            this.txcolor_btn.Text = "Select...";
            this.txcolor_btn.UseVisualStyleBackColor = true;
            this.txcolor_btn.Click += new System.EventHandler(this.txcolor_btn_Click);
            // 
            // txcolor_txt
            // 
            this.txcolor_txt.Location = new System.Drawing.Point(73, 93);
            this.txcolor_txt.Name = "txcolor_txt";
            this.txcolor_txt.ReadOnly = true;
            this.txcolor_txt.Size = new System.Drawing.Size(187, 22);
            this.txcolor_txt.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Color";
            // 
            // txfont_txt
            // 
            this.txfont_txt.Location = new System.Drawing.Point(73, 60);
            this.txfont_txt.Name = "txfont_txt";
            this.txfont_txt.ReadOnly = true;
            this.txfont_txt.Size = new System.Drawing.Size(187, 22);
            this.txfont_txt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Font";
            // 
            // txfont_btn
            // 
            this.txfont_btn.Location = new System.Drawing.Point(266, 59);
            this.txfont_btn.Name = "txfont_btn";
            this.txfont_btn.Size = new System.Drawing.Size(82, 25);
            this.txfont_btn.TabIndex = 4;
            this.txfont_btn.Text = "Select...";
            this.txfont_btn.UseVisualStyleBackColor = true;
            this.txfont_btn.Click += new System.EventHandler(this.txfont_btn_Click);
            // 
            // showtx_check
            // 
            this.showtx_check.AutoSize = true;
            this.showtx_check.Location = new System.Drawing.Point(266, 28);
            this.showtx_check.Name = "showtx_check";
            this.showtx_check.Size = new System.Drawing.Size(112, 21);
            this.showtx_check.TabIndex = 3;
            this.showtx_check.Text = "Show on Log";
            this.showtx_check.UseVisualStyleBackColor = true;
            this.showtx_check.CheckedChanged += new System.EventHandler(this.All_CheckCanged);
            // 
            // txname_txt
            // 
            this.txname_txt.Location = new System.Drawing.Point(73, 29);
            this.txname_txt.Name = "txname_txt";
            this.txname_txt.Size = new System.Drawing.Size(187, 22);
            this.txname_txt.TabIndex = 1;
            this.txname_txt.Validated += new System.EventHandler(this.txname_txt_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name ";
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(357, 515);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 25);
            this.cancel_btn.TabIndex = 12;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(276, 515);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(75, 25);
            this.ok_btn.TabIndex = 13;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.OK_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.infocolor_txt);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.infofont_txt);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Location = new System.Drawing.Point(12, 398);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(420, 100);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Info Log";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(266, 57);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(82, 25);
            this.button7.TabIndex = 10;
            this.button7.Text = "Select...";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // infocolor_txt
            // 
            this.infocolor_txt.Location = new System.Drawing.Point(73, 60);
            this.infocolor_txt.Name = "infocolor_txt";
            this.infocolor_txt.ReadOnly = true;
            this.infocolor_txt.Size = new System.Drawing.Size(187, 22);
            this.infocolor_txt.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Color";
            // 
            // infofont_txt
            // 
            this.infofont_txt.Location = new System.Drawing.Point(73, 27);
            this.infofont_txt.Name = "infofont_txt";
            this.infofont_txt.ReadOnly = true;
            this.infofont_txt.Size = new System.Drawing.Size(187, 22);
            this.infofont_txt.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Font";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(266, 26);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(82, 25);
            this.button8.TabIndex = 4;
            this.button8.Text = "Select...";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 519);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(235, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Note : Setting will applied to next log";
            // 
            // wordwrap_check
            // 
            this.wordwrap_check.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.wordwrap_check.AutoSize = true;
            this.wordwrap_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordwrap_check.Location = new System.Drawing.Point(199, 32);
            this.wordwrap_check.Name = "wordwrap_check";
            this.wordwrap_check.Size = new System.Drawing.Size(98, 21);
            this.wordwrap_check.TabIndex = 26;
            this.wordwrap_check.Text = "WordWrap";
            this.wordwrap_check.UseVisualStyleBackColor = true;
            this.wordwrap_check.CheckedChanged += new System.EventHandler(this.All_CheckCanged);
            // 
            // log_setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 553);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "log_setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log Setting";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox info_check;
        private System.Windows.Forms.CheckBox tx_log_check;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button rxcolor_btn;
        private System.Windows.Forms.TextBox rxcolor_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rxfont_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button rxfont_btn;
        private System.Windows.Forms.CheckBox showrx_check;
        private System.Windows.Forms.TextBox rxname_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button txcolor_btn;
        private System.Windows.Forms.TextBox txcolor_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txfont_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button txfont_btn;
        private System.Windows.Forms.CheckBox showtx_check;
        private System.Windows.Forms.TextBox txname_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox infocolor_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox infofont_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox wordwrap_check;
    }
}