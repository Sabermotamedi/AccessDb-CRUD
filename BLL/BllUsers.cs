using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BllUsers
    {
        public DataTable dt = new DataTable();
        public DAL.DalUsers ObjDalUsers = new DAL.DalUsers();
        public DataTable CheckLogin(Users user)
        {
            dt.Clear();
            int i = 0;

            try
            {
                dt = ObjDalUsers.CheckLogin(user);
                if (dt != null && dt.Rows.Count > 0)
                {
                    if (dt.Rows[0][0].ToString() != string.Empty)
                    {
                        try
                        {
                            i = 1;
                            return dt;
                        }
                        catch (Exception)
                        {

                            throw;

                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return dt;

        }
    }
}
