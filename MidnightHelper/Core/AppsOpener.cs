using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;
using System.IO;

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
                catch {}
            }
        }
    }
}
