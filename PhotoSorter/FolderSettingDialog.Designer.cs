namespace PhotoSorter
{
    partial class FolderSettingDialog
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
            this.folderPathTextBox = new System.Windows.Forms.TextBox();
            this.browserButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.outputPathTextBox = new System.Windows.Forms.TextBox();
            this.browserButtonOutput = new System.Windows.Forms.Button();
            this.outputFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.inputFolderLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // folderPathTextBox
            // 
            this.folderPathTextBox.Location = new System.Drawing.Point(12, 26);
            this.folderPathTextBox.Name = "folderPathTextBox";
            this.folderPathTextBox.Size = new System.Drawing.Size(337, 20);
            this.folderPathTextBox.TabIndex = 0;
            // 
            // browserButton
            // 
            this.browserButton.Location = new System.Drawing.Point(355, 25);
            this.browserButton.Name = "browserButton";
            this.browserButton.Size = new System.Drawing.Size(75, 20);
            this.browserButton.TabIndex = 1;
            this.browserButton.Text = "Bläddra";
            this.browserButton.UseVisualStyleBackColor = true;
            this.browserButton.Click += new System.EventHandler(this.browserButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(174, 95);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "OK";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // outputPathTextBox
            // 
            this.outputPathTextBox.Location = new System.Drawing.Point(12, 69);
            this.outputPathTextBox.Name = "outputPathTextBox";
            this.outputPathTextBox.Size = new System.Drawing.Size(337, 20);
            this.outputPathTextBox.TabIndex = 3;
            // 
            // browserButtonOutput
            // 
            this.browserButtonOutput.Location = new System.Drawing.Point(355, 68);
            this.browserButtonOutput.Name = "browserButtonOutput";
            this.browserButtonOutput.Size = new System.Drawing.Size(75, 20);
            this.browserButtonOutput.TabIndex = 4;
            this.browserButtonOutput.Text = "Bläddra";
            this.browserButtonOutput.UseVisualStyleBackColor = true;
            this.browserButtonOutput.Click += new System.EventHandler(this.browserButtonOutput_Click);
            // 
            // inputFolderLabel
            // 
            this.inputFolderLabel.AutoSize = true;
            this.inputFolderLabel.Location = new System.Drawing.Point(13, 7);
            this.inputFolderLabel.Name = "inputFolderLabel";
            this.inputFolderLabel.Size = new System.Drawing.Size(200, 13);
            this.inputFolderLabel.TabIndex = 5;
            this.inputFolderLabel.Text = "Välj vilken mapp du vill sortera bilder ifrån";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Välj vilken mapp som bilderna ska sparas i";
            // 
            // FolderSettingDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 130);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputFolderLabel);
            this.Controls.Add(this.browserButtonOutput);
            this.Controls.Add(this.outputPathTextBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.browserButton);
            this.Controls.Add(this.folderPathTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FolderSettingDialog";
            this.Text = "Välj Mapp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox folderPathTextBox;
        private System.Windows.Forms.Button browserButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox outputPathTextBox;
        private System.Windows.Forms.Button browserButtonOutput;
        private System.Windows.Forms.FolderBrowserDialog outputFolderBrowserDialog;
        private System.Windows.Forms.Label inputFolderLabel;
        private System.Windows.Forms.Label label1;
    }
}