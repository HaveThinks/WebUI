using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Model;
using System.Configuration;

namespace DAL
{
    public class TreeViewDAL
    {
        private static string strsql = ConfigurationManager.ConnectionStrings["Connectionstring"].ToString();
        public DataTable GentCollegeDAL()
        {
            string sql = "select * from Colleges";
            using(SqlConnection conn=new SqlConnection(strsql))
            {
                conn.Open();

                SqlDataAdapter sda = new SqlDataAdapter(sql,conn);
                DataSet ds = new DataSet();

                sda.Fill(ds);
                return ds.Tables[0];
            }
        }
        public DataTable GetSpecDAL(string collegeid) 
        {
            string sql = "select Speciality_ID,Speciality_Name from Speciality where Speciality_College=@specCollege";
            using(SqlConnection conn=new SqlConnection(strsql))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql,conn);
                SqlParameter sp = new SqlParameter("@specCollege", collegeid);
                cmd.Parameters.Add(sp);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                sda.Fill(ds);
                return ds.Tables[0];
            }
        }
        public DataTable GetClassesDAL(string specialityid) 
        {
            string sql = "select Classes_ID,Classes_Name from Classes where Classes_Speciality=@classCollege";
            using(SqlConnection conn=new SqlConnection (strsql))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql,conn);
                SqlParameter sp = new SqlParameter("@classCollege", specialityid);
                cmd.Parameters.Add(sp);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                sda.Fill(ds);
                return ds.Tables[0];
            }
        }
    }
}
