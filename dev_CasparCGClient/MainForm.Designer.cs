namespace dev_CasparCGClient
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lb_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_ServerAddress = new System.Windows.Forms.Label();
            this.tb_ServerAddress = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_lockChannel = new System.Windows.Forms.Button();
            this.tb_channel = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_clearChannel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_MediaFiles = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_SpeechStartTime = new System.Windows.Forms.DateTimePicker();
            this.l_ClockOn = new System.Windows.Forms.Label();
            this.btn_lockSpeech = new System.Windows.Forms.Button();
            this.lbl_help = new System.Windows.Forms.Label();
            this.cb_ClockOnClears = new System.Windows.Forms.CheckBox();
            this.lbl_Clock = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_channel)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lb_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 511);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(928, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lb_status
            // 
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(53, 17);
            this.lb_status.Text = "lb_status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(928, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lb_ServerAddress
            // 
            this.lb_ServerAddress.AutoSize = true;
            this.lb_ServerAddress.Location = new System.Drawing.Point(21, 110);
            this.lb_ServerAddress.Name = "lb_ServerAddress";
            this.lb_ServerAddress.Size = new System.Drawing.Size(133, 13);
            this.lb_ServerAddress.TabIndex = 2;
            this.lb_ServerAddress.Text = "CasparCG Server Address:";
            // 
            // tb_ServerAddress
            // 
            this.tb_ServerAddress.Location = new System.Drawing.Point(160, 107);
            this.tb_ServerAddress.Name = "tb_ServerAddress";
            this.tb_ServerAddress.Size = new System.Drawing.Size(168, 20);
            this.tb_ServerAddress.TabIndex = 3;
            this.tb_ServerAddress.Text = "vtr6.sch.bme.hu";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(334, 105);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 4;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_lockChannel
            // 
            this.btn_lockChannel.BackgroundImage = global::dev_CasparCGClient.Properties.Resources.lock_unlock;
            this.btn_lockChannel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_lockChannel.Location = new System.Drawing.Point(556, 104);
            this.btn_lockChannel.Name = "btn_lockChannel";
            this.btn_lockChannel.Size = new System.Drawing.Size(32, 24);
            this.btn_lockChannel.TabIndex = 6;
            this.btn_lockChannel.UseVisualStyleBackColor = true;
            this.btn_lockChannel.Click += new System.EventHandler(this.btn_lockChannel_Click);
            // 
            // tb_channel
            // 
            this.tb_channel.Location = new System.Drawing.Point(495, 107);
            this.tb_channel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tb_channel.Name = "tb_channel";
            this.tb_channel.Size = new System.Drawing.Size(55, 20);
            this.tb_channel.TabIndex = 7;
            this.tb_channel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Channel:";
            // 
            // btn_clearChannel
            // 
            this.btn_clearChannel.BackColor = System.Drawing.SystemColors.Control;
            this.btn_clearChannel.Location = new System.Drawing.Point(611, 105);
            this.btn_clearChannel.Name = "btn_clearChannel";
            this.btn_clearChannel.Size = new System.Drawing.Size(111, 23);
            this.btn_clearChannel.TabIndex = 9;
            this.btn_clearChannel.Text = "Clear channel (F12)";
            this.btn_clearChannel.UseVisualStyleBackColor = false;
            this.btn_clearChannel.Click += new System.EventHandler(this.btn_clearChannel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(611, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Óra fel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(692, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Óra le";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(851, 105);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Beszéd videó:";
            // 
            // lb_MediaFiles
            // 
            this.lb_MediaFiles.FormattingEnabled = true;
            this.lb_MediaFiles.Location = new System.Drawing.Point(160, 166);
            this.lb_MediaFiles.Name = "lb_MediaFiles";
            this.lb_MediaFiles.Size = new System.Drawing.Size(390, 82);
            this.lb_MediaFiles.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Beszéd indításának időpontja:";
            // 
            // dtp_SpeechStartTime
            // 
            this.dtp_SpeechStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_SpeechStartTime.Location = new System.Drawing.Point(161, 135);
            this.dtp_SpeechStartTime.Name = "dtp_SpeechStartTime";
            this.dtp_SpeechStartTime.Size = new System.Drawing.Size(167, 20);
            this.dtp_SpeechStartTime.TabIndex = 16;
            this.dtp_SpeechStartTime.Value = new System.DateTime(2019, 1, 1, 0, 0, 5, 0);
            // 
            // l_ClockOn
            // 
            this.l_ClockOn.AutoSize = true;
            this.l_ClockOn.BackColor = System.Drawing.Color.Red;
            this.l_ClockOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_ClockOn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.l_ClockOn.Location = new System.Drawing.Point(635, 183);
            this.l_ClockOn.Name = "l_ClockOn";
            this.l_ClockOn.Size = new System.Drawing.Size(105, 29);
            this.l_ClockOn.TabIndex = 17;
            this.l_ClockOn.Text = "Óra fenn";
            // 
            // btn_lockSpeech
            // 
            this.btn_lockSpeech.BackgroundImage = global::dev_CasparCGClient.Properties.Resources.lock_unlock;
            this.btn_lockSpeech.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_lockSpeech.Location = new System.Drawing.Point(556, 195);
            this.btn_lockSpeech.Name = "btn_lockSpeech";
            this.btn_lockSpeech.Size = new System.Drawing.Size(32, 24);
            this.btn_lockSpeech.TabIndex = 18;
            this.btn_lockSpeech.UseVisualStyleBackColor = true;
            this.btn_lockSpeech.Click += new System.EventHandler(this.btn_lockSpeech_Click);
            // 
            // lbl_help
            // 
            this.lbl_help.AutoSize = true;
            this.lbl_help.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_help.ForeColor = System.Drawing.Color.Red;
            this.lbl_help.Location = new System.Drawing.Point(1, 63);
            this.lbl_help.Name = "lbl_help";
            this.lbl_help.Size = new System.Drawing.Size(254, 25);
            this.lbl_help.TabIndex = 19;
            this.lbl_help.Text = "Csatlakozz a szerverhez!";
            // 
            // cb_ClockOnClears
            // 
            this.cb_ClockOnClears.AutoSize = true;
            this.cb_ClockOnClears.Location = new System.Drawing.Point(611, 134);
            this.cb_ClockOnClears.Name = "cb_ClockOnClears";
            this.cb_ClockOnClears.Size = new System.Drawing.Size(134, 17);
            this.cb_ClockOnClears.TabIndex = 20;
            this.cb_ClockOnClears.Text = "Óra fel üríti a csatornát";
            this.cb_ClockOnClears.UseVisualStyleBackColor = true;
            // 
            // lbl_Clock
            // 
            this.lbl_Clock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Clock.AutoSize = true;
            this.lbl_Clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Clock.Location = new System.Drawing.Point(406, 24);
            this.lbl_Clock.Name = "lbl_Clock";
            this.lbl_Clock.Size = new System.Drawing.Size(109, 39);
            this.lbl_Clock.TabIndex = 21;
            this.lbl_Clock.Text = "label4";
            this.lbl_Clock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::dev_CasparCGClient.Properties.Resources.bss_logo_kiindulas_atlatszo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(928, 533);
            this.Controls.Add(this.lbl_Clock);
            this.Controls.Add(this.cb_ClockOnClears);
            this.Controls.Add(this.lbl_help);
            this.Controls.Add(this.btn_lockSpeech);
            this.Controls.Add(this.l_ClockOn);
            this.Controls.Add(this.dtp_SpeechStartTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_MediaFiles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_clearChannel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_channel);
            this.Controls.Add(this.btn_lockChannel);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.tb_ServerAddress);
            this.Controls.Add(this.lb_ServerAddress);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Budavári Schönherz Stúdió - CasparCG Custom Client";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_channel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lb_ServerAddress;
        private System.Windows.Forms.TextBox tb_ServerAddress;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.ToolStripStatusLabel lb_status;
        private System.Windows.Forms.Button btn_lockChannel;
        private System.Windows.Forms.NumericUpDown tb_channel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_clearChannel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb_MediaFiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_SpeechStartTime;
        private System.Windows.Forms.Label l_ClockOn;
        private System.Windows.Forms.Button btn_lockSpeech;
        private System.Windows.Forms.Label lbl_help;
        private System.Windows.Forms.CheckBox cb_ClockOnClears;
        private System.Windows.Forms.Label lbl_Clock;
    }
}

