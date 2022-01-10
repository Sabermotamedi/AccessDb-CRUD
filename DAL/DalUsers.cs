using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
   public class DalUsers
    {
        DALMain ObjDalMain = new DALMain();
        public DataTable CheckLogin(Users user)
        {
            return ObjDalMain.ExecuteDataAdapter("select User, Password from[Users] WHERE User = \"" + user.User + "\" and Password = \"" + user.Pass + "\" ");
        }
    }
}
