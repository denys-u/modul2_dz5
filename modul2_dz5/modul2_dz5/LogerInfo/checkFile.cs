using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace modul2_dz5.LogerInfo
{
    public class CheckFile
    {
        FileInfo fileInfo = new FileInfo(LoggerFilePath);
        
        public static string LoggerFilePath { get; set; }

    }
}
