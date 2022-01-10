using System;
using System.Windows.Forms;

namespace Dentist
{
    public partial class frmSetting : Form
    {
        BLL.PresentDB DBSaver = new BLL.PresentDB();
        MessageManager.MsgMngr ObjMsgMngr = new MessageManager.MsgMngr();
        public frmSetting()
        {
            InitializeComponent();
            txtSourceFile.Text = DBSaver.FullName;
        }
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            string SourceFile = SelectDB();
            if (SourceFile != string.Empty)
                if (DBSaver.SaveSource(SourceFile))
                {
                    ObjMsgMngr.ShowMng(Entity.GeneralEnum.Msg.SuccesInsertDataBase);
                    Application.Exit();
                }
                else
                    ObjMsgMngr.ShowMng(Entity.GeneralEnum.Msg.FailedInsertDatabase);
        }

        public string SelectDB()
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "انتخاب فایل منبع";
            fdlg.InitialDirectory = @"C:\";
            //fdlg.Filter = "Access 2013 File (*.accdb)|*.accdb";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
                return fdlg.FileName;
            return string.Empty;
        }
    }
}
