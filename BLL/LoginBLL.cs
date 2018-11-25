using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using Model;


namespace BLL
{
    public class LoginBLL
    {
        public static bool AddAdminInfo(AdminInfo ai) 
        {
            LoginInfoDAL raid = new LoginInfoDAL();
            DataTable dt = raid.GetAdminInfo(ai);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
