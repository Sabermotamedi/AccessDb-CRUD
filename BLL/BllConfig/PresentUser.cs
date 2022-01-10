using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
   public class PresentUser
    {
        DAL.PresentUser ObjPresentUser = new DAL.PresentUser();
        public bool SaveUser(Entity.Users Users)
        {
            ObjPresentUser.SaveUser(Users);
            return true;
        }

        public Entity.Users LoadUser(Boolean Checked)
        {
            return ObjPresentUser.LoadUser(Checked);
        }

        public bool ClearUser()
        {
            ObjPresentUser.ClearUser();
            return true;
        }

        public bool Checked()
        {
            return ObjPresentUser.Checked;
        }
    }
}
