using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SOLID_Principles._3_L
{
    class ReadOnlyFile : File
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }
        public string LoadText()
        {
            return "Read only file";
        }
        public void SaveText()
        {
            throw new IOException("Can't Save");
        }
    }
}
