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
    public class RegisterAdminInfoDAL
    {
        private static string strsql=ConfigurationManager.ConnectionStrings["Connectionstring"].ToString();
       public DataTable GetAdminInfo(string name)
        {
            using (SqlConnection conn = new SqlConnection(strsql))
            {
                conn.Open();
                string sql = "select * from AdminInfo where Admin_Name='" + name + "'";
                SqlDataAdapter sda = new SqlDataAdapter(sql,conn);

                DataSet ds = new DataSet();
                sda.Fill(ds,"UserInfo");
                return ds.Tables["UserInfo"];
            }
        }
       public bool InsertAdminInfo(AdminInfo ai)
       {
           using (SqlConnection conn = new SqlConnection(strsql))
           {
               conn.Open();
               string sql = string.Format("insert into AdminInfo values ('{0}','{1}','{2}')",ai.AdminName,ai.AdminPwd,ai.AdminLevel);
               SqlCommand cmd = new SqlCommand(sql,conn);

               int i=cmd.ExecuteNonQuery();
               if (i > 0)
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
}

