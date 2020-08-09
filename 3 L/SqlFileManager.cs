using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles._3_L
{
    public class SqlFileManager
    {
        public List<File> allFiles { get; set; }

        public string GetTextFromFiles()
        {
            StringBuilder objStrBuilder = new StringBuilder();
            foreach (var objFile in allFiles)
            {
                objStrBuilder.Append(objFile.LoadText());
            }
            return objStrBuilder.ToString();
        }
        public void SaveTextIntoFiles()
        {
            foreach (var objFile in allFiles)
            {
                if (!(objFile is ReadOnlyFile))
                    objFile.SaveText();
            }
        }
    }
}
