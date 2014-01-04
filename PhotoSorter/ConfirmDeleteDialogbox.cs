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
    public partial class ConfirmDeleteDialogbox : Form
    {
        public ConfirmDeleteDialogbox()
        {
            InitializeComponent();
            warningLabel.Text = "Detta kommer att ta bort bilden permanent." + Environment.NewLine + "Detta val kan inte ångras!" + Environment.NewLine + "Ta bort ändå?";
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

    }
}
