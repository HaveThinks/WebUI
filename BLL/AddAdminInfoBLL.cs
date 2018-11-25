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
    public class AddAdminInfoBLL
    {
        public static bool AddAdminInfo(AdminInfo ai)
        {
            RegisterAdminInfoDAL raid = new RegisterAdminInfoDAL();
            DataTable dt = raid.GetAdminInfo(ai.AdminName);
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            else 
            {
                return raid.InsertAdminInfo(ai);
            }
        }
    }
}
