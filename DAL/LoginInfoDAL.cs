using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Model;

namespace DAL
{
    public class LoginInfoDAL
    {
        private static string strsql = ConfigurationManager.ConnectionStrings["Connectionstring"].ToString();
        public DataTable GetAdminInfo(AdminInfo ai)
        { 
            using(SqlConnection conn=new SqlConnection(strsql))
            {
                conn.Open();
                string sql = "select * from AdminInfo where Admin_Name=@AddminName and Admin_Password=@AddminPwd ";
                SqlDataAdapter sda = new SqlDataAdapter(sql,conn);

                sda.SelectCommand.Parameters.Clear();
                sda.SelectCommand.Parameters.AddWithValue("@AddminName",ai.AdminName);
                sda.SelectCommand.Parameters.AddWithValue("@AddminPwd", ai.AdminPwd);

                DataSet ds = new DataSet();
                sda.Fill(ds,"UserInfo");
                return ds.Tables["UserInfo"];
            }
        }
    }
}
