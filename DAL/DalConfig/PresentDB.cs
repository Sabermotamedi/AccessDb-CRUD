using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class PresentDB
    {
        public string LoadSourecFile()
        {
            string SourceFile = Properties.Settings.Default.SourceFile;
            return SourceFile;
        }

        public static bool SourceFileSaver(string SourceFile)
        {
            try
            {
                DAL.Properties.Settings.Default.SourceFile = SourceFile;
                Properties.Settings.Default.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
