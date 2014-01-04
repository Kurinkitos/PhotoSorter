using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoSorter
{
    public partial class FolderSettingDialog : Form
    {
        FilePath filePath;
        FilePath outputPath;
        public FolderSettingDialog(FilePath filePathIn, FilePath outputPathIn)
        {
            filePath = filePathIn;
            outputPath = outputPathIn;
            InitializeComponent();

            folderPathTextBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            outputPathTextBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private void browserButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            folderPathTextBox.Text = folderBrowserDialog.SelectedPath;
            filePath.filePath = folderPathTextBox.Text;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            filePath.filePath = folderPathTextBox.Text;
            outputPath.filePath = outputPathTextBox.Text;

            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void browserButtonOutput_Click(object sender, EventArgs e)
        {
            outputFolderBrowserDialog.ShowDialog();
            outputPathTextBox.Text = outputFolderBrowserDialog.SelectedPath;
            outputPath.filePath = outputPathTextBox.Text;
        }
    }
}
