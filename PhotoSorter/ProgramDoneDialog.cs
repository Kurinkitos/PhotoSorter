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
    public partial class ProgramDoneDialog : Form
    {
        public ProgramDoneDialog(int filesSaved, int filesDeleted)
        {
            InitializeComponent();
            infoLabel.Text = "Bilderna är nu sparade" + Environment.NewLine + filesSaved.ToString() + " bilder sparade" + Environment.NewLine + filesDeleted.ToString() + " bilder borttagna";
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
