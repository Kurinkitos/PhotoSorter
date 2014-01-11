using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoSorter
{
    public partial class MainWindow : Form
    {
        List<Picture> pictureInput = new List<Picture>();
        List<Picture> savedPictures = new List<Picture>();
        List<Picture> picturesForDeletion = new List<Picture>();
        Queue<Picture> undoQueue = new Queue<Picture>();
        FilePath outputFolder;
        int filesSaved = 0, filesDeleted = 0;
        public MainWindow(FilePath filePathIn, FilePath outputPathIn)
        {
            InitializeComponent();
            currentFolder.Text = filePathIn.filePath;
            outputFolder = outputPathIn;


            string[] files = FileUtillity.GetFiles(currentFolder.Text, "*.jpg").ToArray<string>();
            foreach (string file in files)
            {
                DateTime lastModified = File.GetLastWriteTime(file);
                pictureInput.Add(new Picture(file, lastModified));
            }
            fileCountTextBox.Text = Convert.ToString(pictureInput.Count());

            outputDropdown.Items.Add(outputFolder.filePath);
            outputDropdown.SelectedItem = outputDropdown.Items[0];

            pictureInput.Sort();
            if (pictureInput.Count() > 0)
            {
                CurrentPhotoBox.Load(pictureInput[0].filePath);
                currentFolder.Text = pictureInput[0].filePath;

                widthTextBox.Text = CurrentPhotoBox.Image.Width.ToString() + "px";
                heightTextBox.Text = CurrentPhotoBox.Image.Height.ToString() + "px";

                lastModifiedTextBox.Text = pictureInput[0].lastModified.ToString();

            }
        }

        private void requestNextPicture()
        {
            if (pictureInput.Count() > 1)
            {
                pictureInput.RemoveAt(0);
                fileCountTextBox.Text = pictureInput.Count().ToString();
                CurrentPhotoBox.Load(pictureInput[0].filePath);
                currentFolder.Text = pictureInput[0].filePath;

                widthTextBox.Text = CurrentPhotoBox.Image.Width.ToString() + "px";
                heightTextBox.Text = CurrentPhotoBox.Image.Height.ToString() + "px";

                lastModifiedTextBox.Text = pictureInput[0].lastModified.ToString();
            }
            else
            {
                //set the picture to null
                if (pictureInput.Count() > 0)
                {
                    pictureInput.RemoveAt(0);
                    CurrentPhotoBox.Image = null;

                    fileCountTextBox.Text = "0";

                    currentFolder.Text = null;

                    widthTextBox.Text = null;
                    heightTextBox.Text = null;

                    lastModifiedTextBox.Text = null;
                }
            }
        }

        private void save()
        {
            foreach (Picture item in savedPictures)
            {
                System.IO.FileInfo fi = new System.IO.FileInfo(item.filePath);
                File.Copy(item.filePath, System.IO.Path.Combine(outputFolder.filePath, fi.Name), true);
                filesSaved++;
            }
            foreach (Picture item in picturesForDeletion)
            {
                Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(item.filePath, Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin);
                filesDeleted++;
            }
            Properties.Settings.Default.Save();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (pictureInput.Count() > 0)
            {
                undoQueue.Enqueue(pictureInput[0]);
                requestNextPicture();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (pictureInput.Count() > 0)
            {
                savedPictures.Add(pictureInput[0]);
                undoQueue.Enqueue(pictureInput[0]);
                requestNextPicture();
            }
        }

        private void outputBrowserButton_Click(object sender, EventArgs e)
        {
            outputFolderSelector.ShowDialog();
            outputDropdown.Items.Add(outputFolderSelector.SelectedPath);
            outputDropdown.SelectedItem = outputDropdown.Items[outputDropdown.Items.IndexOf(outputFolderSelector.SelectedPath)];
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (pictureInput.Count() > 0)
            {
                picturesForDeletion.Add(pictureInput[0]);
                undoQueue.Enqueue(pictureInput[0]);
                requestNextPicture();
            }
        }

        private void saveAndExitButton_Click(object sender, EventArgs e)
        {
            save();
            this.Hide();
            ProgramDoneDialog dialog = new ProgramDoneDialog(filesSaved, filesDeleted);
            dialog.ShowDialog();
            Close();
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            if (undoQueue.Count() > 0)
            {
                Picture undoBuffer = undoQueue.Dequeue();
                savedPictures.Remove(undoBuffer);

                picturesForDeletion.Remove(undoBuffer);


                pictureInput.Insert(0, undoBuffer);
                fileCountTextBox.Text = pictureInput.Count().ToString();
                CurrentPhotoBox.Load(pictureInput[0].filePath);
                currentFolder.Text = pictureInput[0].filePath;

                widthTextBox.Text = CurrentPhotoBox.Image.Width.ToString() + "px";
                heightTextBox.Text = CurrentPhotoBox.Image.Height.ToString() + "px";

                lastModifiedTextBox.Text = pictureInput[0].lastModified.ToString();

                
            }
        }
    }
}
