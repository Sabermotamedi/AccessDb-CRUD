using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class PresentUser
    {
        public bool Checked = Properties.Settings.Default.Checked;
        public bool SaveUser(Entity.Users CurrentUser)
        {
            Properties.Settings.Default.Username = CurrentUser.User.ToString();
            Properties.Settings.Default.Pass = CurrentUser.Pass.ToString();
            Properties.Settings.Default.Checked = true;
            Properties.Settings.Default.Save();
            return true;
        }
        public Entity.Users LoadUser(Boolean Checked)
        {
            var CurrentUser = new Entity.Users();
            if (Properties.Settings.Default.Checked == Checked)
            {
                CurrentUser.User = Properties.Settings.Default.Username;
                CurrentUser.Pass = Properties.Settings.Default.Pass;
                return CurrentUser;
            }
            else
            {
                CurrentUser.User = string.Empty;
                CurrentUser.Pass = string.Empty;
                return CurrentUser;
            }

        }

        public bool ClearUser()
        {
            Properties.Settings.Default.Username = string.Empty;
            Properties.Settings.Default.Pass = string.Empty;
            Properties.Settings.Default.Checked = false;
            Properties.Settings.Default.Save();

            return true;
        }
    }
}
