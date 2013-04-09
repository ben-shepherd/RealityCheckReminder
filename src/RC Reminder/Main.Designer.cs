namespace RC_Reminder
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnToggle = new System.Windows.Forms.Button();
            this.cbStartup = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioTypeMsgBox = new System.Windows.Forms.RadioButton();
            this.radioTypeTaskbar = new System.Windows.Forms.RadioButton();
            this.linkLabelDefault = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbTime);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remind time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Minutes:";
            // 
            // cbTime
            // 
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Items.AddRange(new object[] {
            "15",
            "30",
            "45",
            "60",
            "120",
            "180",
            "240"});
            this.cbTime.Location = new System.Drawing.Point(75, 26);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(257, 21);
            this.cbTime.TabIndex = 0;
            this.cbTime.Text = "30";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMessage);
            this.groupBox2.Location = new System.Drawing.Point(12, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 70);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reminder message";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(25, 29);
            this.txtMessage.MaxLength = 50;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(307, 20);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.Text = "Are you dreaming? Do a reality check!";
            // 
            // btnToggle
            // 
            this.btnToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToggle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnToggle.Location = new System.Drawing.Point(294, 246);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(75, 23);
            this.btnToggle.TabIndex = 2;
            this.btnToggle.Text = "Enable";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new System.EventHandler(this.btn_Toggle);
            // 
            // cbStartup
            // 
            this.cbStartup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStartup.AutoSize = true;
            this.cbStartup.Location = new System.Drawing.Point(164, 250);
            this.cbStartup.Name = "cbStartup";
            this.cbStartup.Size = new System.Drawing.Size(114, 17);
            this.cbStartup.TabIndex = 3;
            this.cbStartup.Text = "Launch on Startup";
            this.cbStartup.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioTypeMsgBox);
            this.groupBox3.Controls.Add(this.radioTypeTaskbar);
            this.groupBox3.Location = new System.Drawing.Point(12, 169);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(332, 60);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Notifcation type";
            // 
            // radioTypeMsgBox
            // 
            this.radioTypeMsgBox.AutoSize = true;
            this.radioTypeMsgBox.Location = new System.Drawing.Point(25, 28);
            this.radioTypeMsgBox.Name = "radioTypeMsgBox";
            this.radioTypeMsgBox.Size = new System.Drawing.Size(88, 17);
            this.radioTypeMsgBox.TabIndex = 1;
            this.radioTypeMsgBox.TabStop = true;
            this.radioTypeMsgBox.Text = "Message box";
            this.radioTypeMsgBox.UseVisualStyleBackColor = true;
            // 
            // radioTypeTaskbar
            // 
            this.radioTypeTaskbar.AutoSize = true;
            this.radioTypeTaskbar.Location = new System.Drawing.Point(185, 28);
            this.radioTypeTaskbar.Name = "radioTypeTaskbar";
            this.radioTypeTaskbar.Size = new System.Drawing.Size(118, 17);
            this.radioTypeTaskbar.TabIndex = 0;
            this.radioTypeTaskbar.TabStop = true;
            this.radioTypeTaskbar.Text = "Taskbar notification";
            this.radioTypeTaskbar.UseVisualStyleBackColor = true;
            // 
            // linkLabelDefault
            // 
            this.linkLabelDefault.AutoSize = true;
            this.linkLabelDefault.Location = new System.Drawing.Point(12, 251);
            this.linkLabelDefault.Name = "linkLabelDefault";
            this.linkLabelDefault.Size = new System.Drawing.Size(95, 13);
            this.linkLabelDefault.TabIndex = 5;
            this.linkLabelDefault.TabStop = true;
            this.linkLabelDefault.Text = "Set default options";
            this.linkLabelDefault.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDefault_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(381, 280);
            this.Controls.Add(this.linkLabelDefault);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cbStartup);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reality Check Reminder";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.CheckBox cbStartup;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioTypeMsgBox;
        private System.Windows.Forms.RadioButton radioTypeTaskbar;
        private System.Windows.Forms.LinkLabel linkLabelDefault;
    }
}

