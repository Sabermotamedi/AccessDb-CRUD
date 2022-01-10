using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
   public class Document
    {
        #region "Property"
        public int DocNO { get; set; }
        public string NatCode { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Father { get; set; }
        public string PicNumber { get; set; }
        public string Phonenumber { get; set; }
        public string Mobile { get; set; }
        public string Dec { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updateed_at { get; set; }
        #endregion
    }
}
