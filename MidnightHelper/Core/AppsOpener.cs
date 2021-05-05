using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace MidnightHelper.Core
{
    class AppsOpener
    {
        AppsPathes pathes => new AppsPathes(Environment.CurrentDirectory + "\'AppsPathes.txt");

        public void OpenApps()
        {
            foreach(var path in pathes.AppPathes)
            {
                try
                {
                    Process.Start(path);
                }
                catch(FileNotFoundException) 
                {
                    MessageBox.Show($"Невозможно открыть приложение по пути {path}");
                }
            }
        }
    }
}
