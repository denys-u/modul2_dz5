using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace modul2_dz5.LogerInfo
{
    public class FileService
    {
        public void Write(string path, string text)
        {
            File.WriteAllText(path,text);
        }
    }
}
