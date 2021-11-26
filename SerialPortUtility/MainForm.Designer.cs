namespace SerialPortUtility
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.open_btn = new System.Windows.Forms.Button();
            this.send_btn = new System.Windows.Forms.Button();
            this.sendstring_txt = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status_bar = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.rxcount_lbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txcount_lbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.string_rtb = new System.Windows.Forms.RichTextBox();
            this.setting_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.note_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.append_cmb = new System.Windows.Forms.ComboBox();
            this.sendtype_cmb = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.log_setting_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bin_check = new System.Windows.Forms.CheckBox();
            this.dec_check = new System.Windows.Forms.CheckBox();
            this.hex_check = new System.Windows.Forms.CheckBox();
            this.ascii_check = new System.Windows.Forms.CheckBox();
            this.datetime_check = new System.Windows.Forms.CheckBox();
            this.clear_btn = new System.Windows.Forms.Button();
            this.about_btn = new System.Windows.Forms.Button();
            this.input_err_prov = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_err_prov)).BeginInit();
            this.SuspendLayout();
            // 
            // open_btn
            // 
            this.open_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.open_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_btn.Location = new System.Drawing.Point(588, 12);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(112, 26);
            this.open_btn.TabIndex = 1;
            this.open_btn.Text = "Connect";
            this.open_btn.UseVisualStyleBackColor = true;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // send_btn
            // 
            this.send_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.send_btn.Location = new System.Drawing.Point(697, 54);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(110, 26);
            this.send_btn.TabIndex = 3;
            this.send_btn.Text = "Send";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // sendstring_txt
            // 
            this.sendstring_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendstring_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.sendstring_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.sendstring_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendstring_txt.Location = new System.Drawing.Point(13, 56);
            this.sendstring_txt.Name = "sendstring_txt";
            this.sendstring_txt.Size = new System.Drawing.Size(663, 22);
            this.sendstring_txt.TabIndex = 0;
            this.sendstring_txt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.sendstring_txt_KeyUp);
            this.sendstring_txt.Validated += new System.EventHandler(this.sendstring_txt_Validated);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_bar,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1,
            this.rxcount_lbl,
            this.toolStripStatusLabel3,
            this.txcount_lbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 739);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(846, 26);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "`";
            // 
            // status_bar
            // 
            this.status_bar.Name = "status_bar";
            this.status_bar.Size = new System.Drawing.Size(108, 20);
            this.status_bar.Text = "Disconnected...";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(27, 20);
            this.toolStripStatusLabel2.Text = "---";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(115, 20);
            this.toolStripStatusLabel1.Text = "Received Bytes :";
            // 
            // rxcount_lbl
            // 
            this.rxcount_lbl.Name = "rxcount_lbl";
            this.rxcount_lbl.Size = new System.Drawing.Size(17, 20);
            this.rxcount_lbl.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(133, 20);
            this.toolStripStatusLabel3.Text = "Transmitted Bytes :";
            // 
            // txcount_lbl
            // 
            this.txcount_lbl.Name = "txcount_lbl";
            this.txcount_lbl.Size = new System.Drawing.Size(17, 20);
            this.txcount_lbl.Text = "0";
            // 
            // string_rtb
            // 
            this.string_rtb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.string_rtb.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.string_rtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.string_rtb.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.string_rtb.ForeColor = System.Drawing.SystemColors.InfoText;
            this.string_rtb.HideSelection = false;
            this.string_rtb.Location = new System.Drawing.Point(16, 64);
            this.string_rtb.Name = "string_rtb";
            this.string_rtb.ReadOnly = true;
            this.string_rtb.Size = new System.Drawing.Size(794, 484);
            this.string_rtb.TabIndex = 5;
            this.string_rtb.Text = "Serial Port Terminal is Initialized...\nConnect to Port, Send and receive log goes" +
    " here...";
            this.string_rtb.WordWrap = false;
            // 
            // setting_btn
            // 
            this.setting_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setting_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setting_btn.Location = new System.Drawing.Point(12, 12);
            this.setting_btn.Name = "setting_btn";
            this.setting_btn.Size = new System.Drawing.Size(562, 26);
            this.setting_btn.TabIndex = 17;
            this.setting_btn.Text = "Port Setting : ";
            this.setting_btn.UseVisualStyleBackColor = true;
            this.setting_btn.Click += new System.EventHandler(this.setting_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.note_lbl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.append_cmb);
            this.groupBox1.Controls.Add(this.sendtype_cmb);
            this.groupBox1.Controls.Add(this.sendstring_txt);
            this.groupBox1.Controls.Add(this.send_btn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 615);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(822, 104);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send";
            // 
            // note_lbl
            // 
            this.note_lbl.AutoSize = true;
            this.note_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note_lbl.Location = new System.Drawing.Point(16, 81);
            this.note_lbl.Name = "note_lbl";
            this.note_lbl.Size = new System.Drawing.Size(680, 15);
            this.note_lbl.TabIndex = 25;
            this.note_lbl.Text = "*Use SPACE to sparate number (eg. 12 23 123 , A0 34 FA , 11010 11101 110) , max 8" +
    " bit number (0-255, 0-FF, 0-11111111)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Append :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Data Type :";
            // 
            // append_cmb
            // 
            this.append_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.append_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.append_cmb.FormattingEnabled = true;
            this.append_cmb.ItemHeight = 16;
            this.append_cmb.Items.AddRange(new object[] {
            "None",
            "CR",
            "LF",
            "CR+LF"});
            this.append_cmb.Location = new System.Drawing.Point(281, 20);
            this.append_cmb.Name = "append_cmb";
            this.append_cmb.Size = new System.Drawing.Size(87, 24);
            this.append_cmb.TabIndex = 5;
            this.append_cmb.SelectedIndexChanged += new System.EventHandler(this.append_cmb_SelectedIndexChanged);
            // 
            // sendtype_cmb
            // 
            this.sendtype_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sendtype_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendtype_cmb.FormattingEnabled = true;
            this.sendtype_cmb.ItemHeight = 16;
            this.sendtype_cmb.Items.AddRange(new object[] {
            "Text",
            "DEC",
            "HEX",
            "BIN"});
            this.sendtype_cmb.Location = new System.Drawing.Point(105, 20);
            this.sendtype_cmb.Name = "sendtype_cmb";
            this.sendtype_cmb.Size = new System.Drawing.Size(87, 24);
            this.sendtype_cmb.TabIndex = 4;
            this.sendtype_cmb.SelectedIndexChanged += new System.EventHandler(this.sendtype_cmb_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.log_setting_btn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.bin_check);
            this.groupBox2.Controls.Add(this.dec_check);
            this.groupBox2.Controls.Add(this.hex_check);
            this.groupBox2.Controls.Add(this.ascii_check);
            this.groupBox2.Controls.Add(this.datetime_check);
            this.groupBox2.Controls.Add(this.clear_btn);
            this.groupBox2.Controls.Add(this.string_rtb);
            this.groupBox2.Location = new System.Drawing.Point(12, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(822, 565);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Terminal Log";
            // 
            // log_setting_btn
            // 
            this.log_setting_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.log_setting_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_setting_btn.Location = new System.Drawing.Point(576, 25);
            this.log_setting_btn.Name = "log_setting_btn";
            this.log_setting_btn.Size = new System.Drawing.Size(112, 26);
            this.log_setting_btn.TabIndex = 26;
            this.log_setting_btn.Text = "Log Setting...";
            this.log_setting_btn.UseVisualStyleBackColor = true;
            this.log_setting_btn.Click += new System.EventHandler(this.log_setting_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Show Log :";
            // 
            // bin_check
            // 
            this.bin_check.AutoSize = true;
            this.bin_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bin_check.Location = new System.Drawing.Point(400, 29);
            this.bin_check.Name = "bin_check";
            this.bin_check.Size = new System.Drawing.Size(52, 21);
            this.bin_check.TabIndex = 21;
            this.bin_check.Text = "BIN";
            this.bin_check.UseVisualStyleBackColor = true;
            this.bin_check.Click += new System.EventHandler(this.All_CheckedChanged);
            // 
            // dec_check
            // 
            this.dec_check.AutoSize = true;
            this.dec_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dec_check.Location = new System.Drawing.Point(336, 29);
            this.dec_check.Name = "dec_check";
            this.dec_check.Size = new System.Drawing.Size(58, 21);
            this.dec_check.TabIndex = 10;
            this.dec_check.Text = "DEC";
            this.dec_check.UseVisualStyleBackColor = true;
            this.dec_check.Click += new System.EventHandler(this.All_CheckedChanged);
            // 
            // hex_check
            // 
            this.hex_check.AutoSize = true;
            this.hex_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hex_check.Location = new System.Drawing.Point(272, 29);
            this.hex_check.Name = "hex_check";
            this.hex_check.Size = new System.Drawing.Size(58, 21);
            this.hex_check.TabIndex = 9;
            this.hex_check.Text = "HEX";
            this.hex_check.UseVisualStyleBackColor = true;
            this.hex_check.Click += new System.EventHandler(this.All_CheckedChanged);
            // 
            // ascii_check
            // 
            this.ascii_check.AutoSize = true;
            this.ascii_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ascii_check.Location = new System.Drawing.Point(203, 29);
            this.ascii_check.Name = "ascii_check";
            this.ascii_check.Size = new System.Drawing.Size(57, 21);
            this.ascii_check.TabIndex = 8;
            this.ascii_check.Text = "Text";
            this.ascii_check.UseVisualStyleBackColor = true;
            this.ascii_check.Click += new System.EventHandler(this.All_CheckedChanged);
            // 
            // datetime_check
            // 
            this.datetime_check.AutoSize = true;
            this.datetime_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetime_check.Location = new System.Drawing.Point(96, 29);
            this.datetime_check.Name = "datetime_check";
            this.datetime_check.Size = new System.Drawing.Size(105, 21);
            this.datetime_check.TabIndex = 7;
            this.datetime_check.Text = "Time Stamp";
            this.datetime_check.UseVisualStyleBackColor = true;
            this.datetime_check.Click += new System.EventHandler(this.All_CheckedChanged);
            // 
            // clear_btn
            // 
            this.clear_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.Location = new System.Drawing.Point(697, 25);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(112, 26);
            this.clear_btn.TabIndex = 6;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // about_btn
            // 
            this.about_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.about_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about_btn.Location = new System.Drawing.Point(709, 12);
            this.about_btn.Name = "about_btn";
            this.about_btn.Size = new System.Drawing.Size(112, 26);
            this.about_btn.TabIndex = 21;
            this.about_btn.Text = "About...";
            this.about_btn.UseVisualStyleBackColor = true;
            this.about_btn.Click += new System.EventHandler(this.about_btn_Click);
            // 
            // input_err_prov
            // 
            this.input_err_prov.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.input_err_prov.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 765);
            this.Controls.Add(this.about_btn);
            this.Controls.Add(this.open_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.setting_btn);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(864, 804);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Port Terminal";
            this.Activated += new System.EventHandler(this.main_frm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_frm_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_err_prov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button open_btn;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.TextBox sendstring_txt;
        private System.Windows.Forms.Button setting_btn;
        internal System.Windows.Forms.RichTextBox string_rtb;
        private System.Windows.Forms.ToolStripStatusLabel status_bar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox sendtype_cmb;
        private System.Windows.Forms.ComboBox append_cmb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.CheckBox bin_check;
        private System.Windows.Forms.CheckBox dec_check;
        private System.Windows.Forms.CheckBox hex_check;
        private System.Windows.Forms.CheckBox ascii_check;
        private System.Windows.Forms.CheckBox datetime_check;
        private System.Windows.Forms.Button about_btn;
        private System.Windows.Forms.ErrorProvider input_err_prov;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label note_lbl;
        private System.Windows.Forms.Button log_setting_btn;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel rxcount_lbl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel txcount_lbl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

