namespace SkypeConversationExplorer
{
    partial class ExportDialog
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
            this.PdfRadioButton = new System.Windows.Forms.RadioButton();
            this.TextRadioButton = new System.Windows.Forms.RadioButton();
            this.htmlRadioButton = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PdfRadioButton);
            this.groupBox1.Controls.Add(this.TextRadioButton);
            this.groupBox1.Controls.Add(this.htmlRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(75, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Export to";
            // 
            // PdfRadioButton
            // 
            this.PdfRadioButton.AutoSize = true;
            this.PdfRadioButton.Location = new System.Drawing.Point(7, 68);
            this.PdfRadioButton.Name = "PdfRadioButton";
            this.PdfRadioButton.Size = new System.Drawing.Size(46, 17);
            this.PdfRadioButton.TabIndex = 2;
            this.PdfRadioButton.TabStop = true;
            this.PdfRadioButton.Text = "PDF";
            this.PdfRadioButton.UseVisualStyleBackColor = true;
            // 
            // TextRadioButton
            // 
            this.TextRadioButton.AutoSize = true;
            this.TextRadioButton.Location = new System.Drawing.Point(7, 44);
            this.TextRadioButton.Name = "TextRadioButton";
            this.TextRadioButton.Size = new System.Drawing.Size(46, 17);
            this.TextRadioButton.TabIndex = 1;
            this.TextRadioButton.TabStop = true;
            this.TextRadioButton.Text = "Text";
            this.TextRadioButton.UseVisualStyleBackColor = true;
            // 
            // htmlRadioButton
            // 
            this.htmlRadioButton.AutoSize = true;
            this.htmlRadioButton.Checked = true;
            this.htmlRadioButton.Location = new System.Drawing.Point(7, 20);
            this.htmlRadioButton.Name = "htmlRadioButton";
            this.htmlRadioButton.Size = new System.Drawing.Size(55, 17);
            this.htmlRadioButton.TabIndex = 0;
            this.htmlRadioButton.TabStop = true;
            this.htmlRadioButton.Text = "HTML";
            this.htmlRadioButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Browse...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveButton
            // 
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Location = new System.Drawing.Point(354, 89);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(273, 89);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // ExportDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 123);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ExportDialog";
            this.Text = "ExportDialog";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton PdfRadioButton;
        private System.Windows.Forms.RadioButton TextRadioButton;
        private System.Windows.Forms.RadioButton htmlRadioButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}