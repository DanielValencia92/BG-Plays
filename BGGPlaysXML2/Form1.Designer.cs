namespace BGGPlaysXML2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxDate = new System.Windows.Forms.GroupBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.dateTimePickerEND = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldedDaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldedDaysToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.underlineDaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shortFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bGGFormattedOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTipUser = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipCalendar = new System.Windows.Forms.ToolTip(this.components);
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxDate.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDate
            // 
            this.groupBoxDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDate.Controls.Add(this.buttonGenerate);
            this.groupBoxDate.Controls.Add(this.dateTimePickerEND);
            this.groupBoxDate.Controls.Add(this.label2);
            this.groupBoxDate.Controls.Add(this.label1);
            this.groupBoxDate.Controls.Add(this.textBoxUser);
            this.groupBoxDate.Controls.Add(this.label);
            this.groupBoxDate.Controls.Add(this.dateTimePicker);
            this.groupBoxDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxDate.Location = new System.Drawing.Point(16, 32);
            this.groupBoxDate.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDate.Name = "groupBoxDate";
            this.groupBoxDate.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDate.Size = new System.Drawing.Size(460, 153);
            this.groupBoxDate.TabIndex = 0;
            this.groupBoxDate.TabStop = false;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerate.Enabled = false;
            this.buttonGenerate.Location = new System.Drawing.Point(285, 117);
            this.buttonGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(167, 28);
            this.buttonGenerate.TabIndex = 2;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // dateTimePickerEND
            // 
            this.dateTimePickerEND.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerEND.Location = new System.Drawing.Point(8, 87);
            this.dateTimePickerEND.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerEND.Name = "dateTimePickerEND";
            this.dateTimePickerEND.Size = new System.Drawing.Size(443, 22);
            this.dateTimePickerEND.TabIndex = 5;
            this.toolTipCalendar.SetToolTip(this.dateTimePickerEND, "Limits plays retrieved from the start date to this date.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "End Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start Date";
            // 
            // textBoxUser
            // 
            this.textBoxUser.AcceptsReturn = true;
            this.textBoxUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUser.Location = new System.Drawing.Point(59, 119);
            this.textBoxUser.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(215, 22);
            this.textBoxUser.TabIndex = 2;
            this.textBoxUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTipUser.SetToolTip(this.textBoxUser, "Username from which to access plays logged on BGG.");
            this.textBoxUser.TextChanged += new System.EventHandler(this.textBoxUser_TextChanged);
            this.textBoxUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUser_KeyDown);
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(8, 123);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(42, 17);
            this.label.TabIndex = 1;
            this.label.Text = "User:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.Location = new System.Drawing.Point(8, 39);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(443, 22);
            this.dateTimePicker.TabIndex = 0;
            this.toolTipCalendar.SetToolTip(this.dateTimePicker, "Limits plays retrieved from this date to the end date.");
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutput.Location = new System.Drawing.Point(16, 192);
            this.textBoxOutput.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(459, 258);
            this.textBoxOutput.TabIndex = 1;
            this.textBoxOutput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxOutput_KeyDown);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(492, 28);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boldedDaysToolStripMenuItem,
            this.shortFormatToolStripMenuItem,
            this.bGGFormattedOutputToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // boldedDaysToolStripMenuItem
            // 
            this.boldedDaysToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boldedDaysToolStripMenuItem1,
            this.underlineDaysToolStripMenuItem});
            this.boldedDaysToolStripMenuItem.Name = "boldedDaysToolStripMenuItem";
            this.boldedDaysToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.boldedDaysToolStripMenuItem.Text = "Days Options";
            // 
            // boldedDaysToolStripMenuItem1
            // 
            this.boldedDaysToolStripMenuItem1.Checked = true;
            this.boldedDaysToolStripMenuItem1.CheckOnClick = true;
            this.boldedDaysToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.boldedDaysToolStripMenuItem1.Name = "boldedDaysToolStripMenuItem1";
            this.boldedDaysToolStripMenuItem1.Size = new System.Drawing.Size(184, 26);
            this.boldedDaysToolStripMenuItem1.Text = "Bolded Days";
            this.boldedDaysToolStripMenuItem1.Click += new System.EventHandler(this.boldedDaysToolStripMenuItem_Click);
            // 
            // underlineDaysToolStripMenuItem
            // 
            this.underlineDaysToolStripMenuItem.CheckOnClick = true;
            this.underlineDaysToolStripMenuItem.Name = "underlineDaysToolStripMenuItem";
            this.underlineDaysToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.underlineDaysToolStripMenuItem.Text = "Underline Days";
            // 
            // shortFormatToolStripMenuItem
            // 
            this.shortFormatToolStripMenuItem.CheckOnClick = true;
            this.shortFormatToolStripMenuItem.Name = "shortFormatToolStripMenuItem";
            this.shortFormatToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.shortFormatToolStripMenuItem.Text = "Short Format";
            this.shortFormatToolStripMenuItem.ToolTipText = "Does not differentiate by day.\r\nLumps all plays of the week together. ";
            this.shortFormatToolStripMenuItem.Click += new System.EventHandler(this.shortFormatToolStripMenuItem_Click);
            // 
            // bGGFormattedOutputToolStripMenuItem
            // 
            this.bGGFormattedOutputToolStripMenuItem.Checked = true;
            this.bGGFormattedOutputToolStripMenuItem.CheckOnClick = true;
            this.bGGFormattedOutputToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bGGFormattedOutputToolStripMenuItem.Name = "bGGFormattedOutputToolStripMenuItem";
            this.bGGFormattedOutputToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.bGGFormattedOutputToolStripMenuItem.Text = "BGG Formatted Output";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolTipUser
            // 
            this.toolTipUser.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipUser.ToolTipTitle = "BGG Username";
            // 
            // toolTipCalendar
            // 
            this.toolTipCalendar.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipCalendar.ToolTipTitle = "Calendar";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(492, 465);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.groupBoxDate);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(507, 502);
            this.Name = "Form1";
            this.Text = "BG Plays";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxDate.ResumeLayout(false);
            this.groupBoxDate.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerEND;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boldedDaysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shortFormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bGGFormattedOutputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boldedDaysToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem underlineDaysToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTipUser;
        private System.Windows.Forms.ToolTip toolTipCalendar;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

