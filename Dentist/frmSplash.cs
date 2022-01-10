
using System;
using System.Data;
using System.Windows.Forms;
using Entity;

namespace Dentist
{
    public partial class frmSplash : Form
    {
        #region "Fiald"
        public int i = 0;
        public Users User = new Users();
        public BLL.PresentUser ObjPresentUser = new BLL.PresentUser();
        public BLL.BllClientele ObjBll = new BLL.BllClientele();
        public BLL.BllUsers ObjbllUsers = new BLL.BllUsers();
        public MessageManager.MsgMngr MessageMngr = new MessageManager.MsgMngr();
        #endregion

        #region "contractor"
        public frmSplash()
        {
            InitializeComponent();
            TxtUser.KeyDown += txt_KeyDown;
            TxtPass.KeyDown += txt_KeyDown;
            RecursiveSetKeyDown(this);
            User = ObjPresentUser.LoadUser(ObjPresentUser.Checked());
            TxtUser.Text = User.User;
            TxtPass.Text = User.Pass;
            Chkremember.Checked = ObjPresentUser.Checked();
        }
        #endregion

        #region "Event"
        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            User.User = TxtUser.Text;
            User.Pass = TxtPass.Text;
            if (e.KeyCode == Keys.Enter)
                Login();

        }

        private void _KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void RecursiveSetKeyDown(Control c)
        {
            c.KeyDown += _KeyDown;

            if (c.Controls.Count != 0)
            {
                foreach (Control innerC in c.Controls)
                {
                    RecursiveSetKeyDown(innerC);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            User.User = TxtUser.Text;
            User.Pass = TxtPass.Text;
            Login();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            frmSetting frmsetting = new frmSetting();
            frmsetting.ShowDialog();
        }

        #endregion

        #region "Method"
        private GeneralEnum.Msg CheckUserPass()
        {
            if (CheckTextBox())
            {
                DataTable dt = ObjbllUsers.CheckLogin(User);
                if (dt.Rows.Count > 0)
                {
                    User.User = dt.Rows[0][0].ToString();
                    User.Pass = dt.Rows[0][1].ToString();
                   
                    return GeneralEnum.Msg.SuccesLogin;
                }
            }
            return GeneralEnum.Msg.FailedLogin;
        }

        private void Login()
        {
            if (CheckUserPass() == GeneralEnum.Msg.SuccesLogin)
            {
                RememberUser();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (CheckUserPass() == GeneralEnum.Msg.FailedLogin)
                MessageMngr.ShowMng(GeneralEnum.Msg.FailedLogin);
        }

        internal void RememberUser()
        {
            var Remember = new BLL.PresentUser();
            var _User = new Users(TxtUser.Text, TxtPass.Text);
            if (Chkremember.Checked == true)
                  Remember.SaveUser(_User);
            else
                Remember.ClearUser();
            
        }

        private bool CheckTextBox()
        {
            if (TxtUser.Text.Trim() != string.Empty && TxtPass.Text.Trim() != string.Empty)
                return true;

            return false;
        }

        private void ClearTextBox()
        {
            TxtUser.Clear();
            TxtPass.Clear();
            TxtUser.Focus();
            TxtUser.SelectAll();
        }

        #endregion
    }
}
