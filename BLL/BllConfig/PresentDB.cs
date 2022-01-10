using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PresentDB
    {
        public PresentDB()
        {
            ShowDBAddress();
        }
        public string FullName { get; set; } 
        private void ShowDBAddress()
        {
            var objLoadSourecFile = new DAL.PresentDB();
            FullName = objLoadSourecFile.LoadSourecFile();
        }
         public bool SaveSource(string SourceFile)
        {
            return DAL.PresentDB.SourceFileSaver(SourceFile);
        }
    }
}
