namespace Modul2_dz5.LogerInfo
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public class FileService
    {
        public void Write(string path, string text)
        {
            File.WriteAllText(path,text);
        }
    }
}
