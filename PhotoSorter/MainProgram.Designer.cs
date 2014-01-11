namespace PhotoSorter
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.CurrentPhotoBox = new System.Windows.Forms.PictureBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.currentFolder = new System.Windows.Forms.TextBox();
            this.fileCountTextBox = new System.Windows.Forms.TextBox();
            this.numberOfFilesLeftLabel = new System.Windows.Forms.Label();
            this.filePathTextboxLabel = new System.Windows.Forms.Label();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.widthBoxLabel = new System.Windows.Forms.Label();
            this.heightBoxLabel = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.lastModifiedTextBox = new System.Windows.Forms.TextBox();
            this.lastModifiedTextBoxLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.outputDropdown = new System.Windows.Forms.ComboBox();
            this.outputBrowserButton = new System.Windows.Forms.Button();
            this.outputFolderSelector = new System.Windows.Forms.FolderBrowserDialog();
            this.outputLabel = new System.Windows.Forms.Label();
            this.saveAndExitButton = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentPhotoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CurrentPhotoBox
            // 
            this.CurrentPhotoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentPhotoBox.Location = new System.Drawing.Point(12, 12);
            this.CurrentPhotoBox.Name = "CurrentPhotoBox";
            this.CurrentPhotoBox.Size = new System.Drawing.Size(859, 490);
            this.CurrentPhotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CurrentPhotoBox.TabIndex = 0;
            this.CurrentPhotoBox.TabStop = false;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(545, 508);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(64, 48);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "Nästa";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // currentFolder
            // 
            this.currentFolder.Location = new System.Drawing.Point(12, 575);
            this.currentFolder.Name = "currentFolder";
            this.currentFolder.ReadOnly = true;
            this.currentFolder.Size = new System.Drawing.Size(700, 20);
            this.currentFolder.TabIndex = 2;
            // 
            // fileCountTextBox
            // 
            this.fileCountTextBox.Location = new System.Drawing.Point(832, 575);
            this.fileCountTextBox.Name = "fileCountTextBox";
            this.fileCountTextBox.ReadOnly = true;
            this.fileCountTextBox.Size = new System.Drawing.Size(39, 20);
            this.fileCountTextBox.TabIndex = 3;
            // 
            // numberOfFilesLeftLabel
            // 
            this.numberOfFilesLeftLabel.AutoSize = true;
            this.numberOfFilesLeftLabel.Location = new System.Drawing.Point(829, 559);
            this.numberOfFilesLeftLabel.Name = "numberOfFilesLeftLabel";
            this.numberOfFilesLeftLabel.Size = new System.Drawing.Size(31, 13);
            this.numberOfFilesLeftLabel.TabIndex = 4;
            this.numberOfFilesLeftLabel.Text = "Antal";
            // 
            // filePathTextboxLabel
            // 
            this.filePathTextboxLabel.AutoSize = true;
            this.filePathTextboxLabel.Location = new System.Drawing.Point(12, 559);
            this.filePathTextboxLabel.Name = "filePathTextboxLabel";
            this.filePathTextboxLabel.Size = new System.Drawing.Size(79, 13);
            this.filePathTextboxLabel.TabIndex = 5;
            this.filePathTextboxLabel.Text = "Bildens sökväg";
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(718, 523);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.ReadOnly = true;
            this.widthTextBox.Size = new System.Drawing.Size(75, 20);
            this.widthTextBox.TabIndex = 6;
            // 
            // widthBoxLabel
            // 
            this.widthBoxLabel.AutoSize = true;
            this.widthBoxLabel.Location = new System.Drawing.Point(715, 507);
            this.widthBoxLabel.Name = "widthBoxLabel";
            this.widthBoxLabel.Size = new System.Drawing.Size(35, 13);
            this.widthBoxLabel.TabIndex = 7;
            this.widthBoxLabel.Text = "Bredd";
            // 
            // heightBoxLabel
            // 
            this.heightBoxLabel.AutoSize = true;
            this.heightBoxLabel.Location = new System.Drawing.Point(796, 507);
            this.heightBoxLabel.Name = "heightBoxLabel";
            this.heightBoxLabel.Size = new System.Drawing.Size(29, 13);
            this.heightBoxLabel.TabIndex = 8;
            this.heightBoxLabel.Text = "Höjd";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(799, 523);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.ReadOnly = true;
            this.heightTextBox.Size = new System.Drawing.Size(75, 20);
            this.heightTextBox.TabIndex = 9;
            // 
            // lastModifiedTextBox
            // 
            this.lastModifiedTextBox.Location = new System.Drawing.Point(718, 575);
            this.lastModifiedTextBox.Name = "lastModifiedTextBox";
            this.lastModifiedTextBox.ReadOnly = true;
            this.lastModifiedTextBox.Size = new System.Drawing.Size(105, 20);
            this.lastModifiedTextBox.TabIndex = 10;
            // 
            // lastModifiedTextBoxLabel
            // 
            this.lastModifiedTextBoxLabel.AutoSize = true;
            this.lastModifiedTextBoxLabel.Location = new System.Drawing.Point(715, 559);
            this.lastModifiedTextBoxLabel.Name = "lastModifiedTextBoxLabel";
            this.lastModifiedTextBoxLabel.Size = new System.Drawing.Size(76, 13);
            this.lastModifiedTextBoxLabel.TabIndex = 11;
            this.lastModifiedTextBoxLabel.Text = "Senast ändrad";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(405, 508);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(64, 48);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Ta bort";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(475, 508);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(64, 48);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Spara";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // outputDropdown
            // 
            this.outputDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputDropdown.FormattingEnabled = true;
            this.outputDropdown.Location = new System.Drawing.Point(12, 535);
            this.outputDropdown.Name = "outputDropdown";
            this.outputDropdown.Size = new System.Drawing.Size(249, 21);
            this.outputDropdown.TabIndex = 14;
            // 
            // outputBrowserButton
            // 
            this.outputBrowserButton.Location = new System.Drawing.Point(267, 535);
            this.outputBrowserButton.Name = "outputBrowserButton";
            this.outputBrowserButton.Size = new System.Drawing.Size(62, 23);
            this.outputBrowserButton.TabIndex = 15;
            this.outputBrowserButton.Text = "Bläddra";
            this.outputBrowserButton.UseVisualStyleBackColor = true;
            this.outputBrowserButton.Click += new System.EventHandler(this.outputBrowserButton_Click);
            // 
            // outputFolderSelector
            // 
            this.outputFolderSelector.ShowNewFolderButton = false;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(12, 516);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(111, 13);
            this.outputLabel.TabIndex = 16;
            this.outputLabel.Text = "Mapp att spara bilder i";
            // 
            // saveAndExitButton
            // 
            this.saveAndExitButton.Location = new System.Drawing.Point(633, 508);
            this.saveAndExitButton.Name = "saveAndExitButton";
            this.saveAndExitButton.Size = new System.Drawing.Size(76, 48);
            this.saveAndExitButton.TabIndex = 17;
            this.saveAndExitButton.Text = "Spara och Avsluta";
            this.saveAndExitButton.UseVisualStyleBackColor = true;
            this.saveAndExitButton.Click += new System.EventHandler(this.saveAndExitButton_Click);
            // 
            // undoButton
            // 
            this.undoButton.Location = new System.Drawing.Point(335, 508);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(64, 48);
            this.undoButton.TabIndex = 18;
            this.undoButton.Text = "Ångra";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 607);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.saveAndExitButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.outputBrowserButton);
            this.Controls.Add(this.outputDropdown);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.lastModifiedTextBoxLabel);
            this.Controls.Add(this.lastModifiedTextBox);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.heightBoxLabel);
            this.Controls.Add(this.widthBoxLabel);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.filePathTextboxLabel);
            this.Controls.Add(this.numberOfFilesLeftLabel);
            this.Controls.Add(this.fileCountTextBox);
            this.Controls.Add(this.currentFolder);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CurrentPhotoBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "PhotoSorter";
            ((System.ComponentModel.ISupportInitialize)(this.CurrentPhotoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CurrentPhotoBox;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.TextBox currentFolder;
        private System.Windows.Forms.TextBox fileCountTextBox;
        private System.Windows.Forms.Label numberOfFilesLeftLabel;
        private System.Windows.Forms.Label filePathTextboxLabel;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Label widthBoxLabel;
        private System.Windows.Forms.Label heightBoxLabel;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox lastModifiedTextBox;
        private System.Windows.Forms.Label lastModifiedTextBoxLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox outputDropdown;
        private System.Windows.Forms.Button outputBrowserButton;
        private System.Windows.Forms.FolderBrowserDialog outputFolderSelector;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button saveAndExitButton;
        private System.Windows.Forms.Button undoButton;
    }
}

