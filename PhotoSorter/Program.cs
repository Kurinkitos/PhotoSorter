using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoSorter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FilePath filePath = new FilePath("");
            FilePath outputPath = new FilePath("");
            Application.Run(new FolderSettingDialog(filePath, outputPath));
            
            Application.Run(new MainWindow(filePath, outputPath));
        }
    }
}
