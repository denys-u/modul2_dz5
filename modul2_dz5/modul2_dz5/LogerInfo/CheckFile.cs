namespace Modul2_dz5.LogerInfo
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public class CheckFile
    {
        private FileInfo fileInfo = new FileInfo(LoggerFilePath);

        public static string LoggerFilePath { get; set; }
    }
}
