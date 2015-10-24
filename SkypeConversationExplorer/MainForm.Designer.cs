namespace SkypeConversationExplorer
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainDbPathTextBox = new System.Windows.Forms.TextBox();
            this.openMainDbButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openMainDbDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.exportButton = new System.Windows.Forms.Button();
            this.messageListView = new System.Windows.Forms.ListView();
            this.Timestamp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Message = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateToCheckBox = new System.Windows.Forms.CheckBox();
            this.dateFromCheckBox = new System.Windows.Forms.CheckBox();
            this.dateToPicker = new System.Windows.Forms.DateTimePicker();
            this.dateFromPicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.contactBox = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SkypeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DisplayName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainDbPathTextBox
            // 
            this.mainDbPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainDbPathTextBox.Location = new System.Drawing.Point(4, 16);
            this.mainDbPathTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.mainDbPathTextBox.Name = "mainDbPathTextBox";
            this.mainDbPathTextBox.Size = new System.Drawing.Size(1137, 20);
            this.mainDbPathTextBox.TabIndex = 0;
            // 
            // openMainDbButton
            // 
            this.openMainDbButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openMainDbButton.Location = new System.Drawing.Point(1144, 16);
            this.openMainDbButton.Margin = new System.Windows.Forms.Padding(2);
            this.openMainDbButton.Name = "openMainDbButton";
            this.openMainDbButton.Size = new System.Drawing.Size(68, 21);
            this.openMainDbButton.TabIndex = 2;
            this.openMainDbButton.Text = "Browse...";
            this.openMainDbButton.UseVisualStyleBackColor = true;
            this.openMainDbButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.mainDbPathTextBox);
            this.groupBox1.Controls.Add(this.openMainDbButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1216, 47);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main DB";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Enabled = false;
            this.tabControl.Location = new System.Drawing.Point(12, 59);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1216, 568);
            this.tabControl.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.exportButton);
            this.tabPage1.Controls.Add(this.messageListView);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1208, 542);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Messages";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // exportButton
            // 
            this.exportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exportButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exportButton.Location = new System.Drawing.Point(1128, 516);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 23);
            this.exportButton.TabIndex = 2;
            this.exportButton.Text = "Export...";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // messageListView
            // 
            this.messageListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Timestamp,
            this.Author,
            this.Message});
            this.messageListView.FullRowSelect = true;
            this.messageListView.Location = new System.Drawing.Point(4, 67);
            this.messageListView.Margin = new System.Windows.Forms.Padding(2);
            this.messageListView.Name = "messageListView";
            this.messageListView.Size = new System.Drawing.Size(1200, 444);
            this.messageListView.TabIndex = 1;
            this.messageListView.UseCompatibleStateImageBehavior = false;
            this.messageListView.View = System.Windows.Forms.View.Details;
            // 
            // Timestamp
            // 
            this.Timestamp.Text = "Timestamp";
            this.Timestamp.Width = 110;
            // 
            // Author
            // 
            this.Author.Text = "Author";
            this.Author.Width = 94;
            // 
            // Message
            // 
            this.Message.Text = "Message";
            this.Message.Width = 1075;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dateToCheckBox);
            this.groupBox2.Controls.Add(this.dateFromCheckBox);
            this.groupBox2.Controls.Add(this.dateToPicker);
            this.groupBox2.Controls.Add(this.dateFromPicker);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.contactBox);
            this.groupBox2.Location = new System.Drawing.Point(4, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(1200, 58);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter";
            // 
            // dateToCheckBox
            // 
            this.dateToCheckBox.AutoSize = true;
            this.dateToCheckBox.Location = new System.Drawing.Point(390, 11);
            this.dateToCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.dateToCheckBox.Name = "dateToCheckBox";
            this.dateToCheckBox.Size = new System.Drawing.Size(61, 17);
            this.dateToCheckBox.TabIndex = 7;
            this.dateToCheckBox.Text = "Date to";
            this.dateToCheckBox.UseVisualStyleBackColor = true;
            this.dateToCheckBox.CheckedChanged += new System.EventHandler(this.dateToCheckBox_CheckedChanged);
            // 
            // dateFromCheckBox
            // 
            this.dateFromCheckBox.AutoSize = true;
            this.dateFromCheckBox.Location = new System.Drawing.Point(190, 11);
            this.dateFromCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.dateFromCheckBox.Name = "dateFromCheckBox";
            this.dateFromCheckBox.Size = new System.Drawing.Size(72, 17);
            this.dateFromCheckBox.TabIndex = 6;
            this.dateFromCheckBox.Text = "Date from";
            this.dateFromCheckBox.UseVisualStyleBackColor = true;
            this.dateFromCheckBox.CheckedChanged += new System.EventHandler(this.dateFromCheckBox_CheckedChanged);
            // 
            // dateToPicker
            // 
            this.dateToPicker.Enabled = false;
            this.dateToPicker.Location = new System.Drawing.Point(390, 30);
            this.dateToPicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateToPicker.Name = "dateToPicker";
            this.dateToPicker.Size = new System.Drawing.Size(196, 20);
            this.dateToPicker.TabIndex = 5;
            this.dateToPicker.ValueChanged += new System.EventHandler(this.dateToPicker_ValueChanged);
            // 
            // dateFromPicker
            // 
            this.dateFromPicker.Enabled = false;
            this.dateFromPicker.Location = new System.Drawing.Point(190, 30);
            this.dateFromPicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateFromPicker.Name = "dateFromPicker";
            this.dateFromPicker.Size = new System.Drawing.Size(196, 20);
            this.dateFromPicker.TabIndex = 3;
            this.dateFromPicker.ValueChanged += new System.EventHandler(this.dateFromPicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Conversation Partner";
            // 
            // contactBox
            // 
            this.contactBox.FormattingEnabled = true;
            this.contactBox.Location = new System.Drawing.Point(7, 30);
            this.contactBox.Margin = new System.Windows.Forms.Padding(2);
            this.contactBox.Name = "contactBox";
            this.contactBox.Size = new System.Drawing.Size(179, 21);
            this.contactBox.TabIndex = 0;
            this.contactBox.SelectedIndexChanged += new System.EventHandler(this.contactBox_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1208, 542);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Calls";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(1208, 542);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Contacts";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SkypeName,
            this.DisplayName});
            this.listView1.Location = new System.Drawing.Point(6, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1197, 531);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // SkypeName
            // 
            this.SkypeName.Text = "Skype Name";
            // 
            // DisplayName
            // 
            this.DisplayName.Text = "Display Name";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1236, 638);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Skype Conversation Explorer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox mainDbPathTextBox;
        private System.Windows.Forms.Button openMainDbButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openMainDbDialog;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView messageListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox contactBox;
        private System.Windows.Forms.DateTimePicker dateFromPicker;
        private System.Windows.Forms.DateTimePicker dateToPicker;
        private System.Windows.Forms.CheckBox dateToCheckBox;
        private System.Windows.Forms.CheckBox dateFromCheckBox;
        private System.Windows.Forms.ColumnHeader Timestamp;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader Message;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader SkypeName;
        private System.Windows.Forms.ColumnHeader DisplayName;
    }
}

