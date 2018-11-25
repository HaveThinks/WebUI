using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DataBaseHelper
    {
        private static string strsql = ConfigurationManager.ConnectionStrings["Connectionstring"].ToString();
        
        public static DataTable cmbSqlDataAdapter(string sql,params object[] param) 
        {
            using (SqlConnection conn = new SqlConnection(strsql))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    for (int i = 0; i < param.Length;i++ )
                    {
                        SqlParameter sp = new SqlParameter("@"+i,param[i]);
                        cmd.Parameters.Add(sp);
                    }
                     //适配器
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    sda.Fill(ds);
                    return ds.Tables[0];
                }
            } 
            
        }
        public static int cmdExecuteNonQuery(string sql, params object[] param)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strsql))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        for (int i = 0; i < param.Length; i++)
                        {
                            SqlParameter sp = new SqlParameter("@" + i, param[i]);
                            cmd.Parameters.Add(sp);
                        }
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception es)
            {
                throw new Exception(es.Message);
            }
            
            
        }
        //返回结果集第一行
        public static object cmdExecuteScalar(string sql,params object[] param)
        {
            using(SqlConnection conn=new SqlConnection(strsql))
            {
                conn.Open();
                using(SqlCommand cmd=new SqlCommand(sql,conn))
                {
                    for (int i = 0; i < param.Length; i++)
                    {
                        SqlParameter sp = new SqlParameter("@"+i,param[i]);
                        cmd.Parameters.Add(sp);
                    }
                    return cmd.ExecuteScalar();
                }
            }
        }
    }
}
