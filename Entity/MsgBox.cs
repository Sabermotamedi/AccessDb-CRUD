using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Entity
{
   public class MsgBox
    {
        public MsgBox()
        { }
        public MsgBox(string _CaptionState,string _MsgState , MessageBoxButtons _MsgButton)
        {
            CaptionState = _CaptionState;
            MsgState = _MsgState;
            MsgButtons = _MsgButton;
        }
        public string CaptionState { get; set; }
        public string MsgState { get; set; }
        public MessageBoxButtons MsgButtons { get; set; }
        public MessageBoxIcon MsgIcon { get; set; }
    }
}
