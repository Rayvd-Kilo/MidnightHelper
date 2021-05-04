using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MidnightHelper.Core
{
    class AppsPathes
    {
        public string[] AppPathes { get; set; }

        public AppsPathes(string filePath)
        {
            AppPathes = File.ReadAllLines(filePath);
        }
    }
}
