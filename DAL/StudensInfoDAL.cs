using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class StudensInfoDAL
    {
        public static string strsql = ConfigurationManager.ConnectionStrings["Connectionstring"].ToString();
        /// <summary>
        /// 获取学生信息
        /// </summary>
        /// <param name="classid"></param>
        /// <returns></returns>
        public DataTable GetStudentsInfoByClassID(string classid) 
        {
            using(SqlConnection conn=new SqlConnection(strsql))
            {
                conn.Open();

                string sql = "select s.*,col.College_Name,spe.Speciality_Name,sy.SpeYears_Name,c.Classes_Name from Students s"
+" join Classes c on c.Classes_ID=s.Student_Class"
+" join Speciality spe on spe.Speciality_ID=c.Classes_Speciality"
+" join SpeYears sy on sy.SpeYears_ID=spe.Speciality_Years"
+" join Colleges col on col.College_ID=spe.Speciality_College where c.Classes_ID=@classid";
                SqlCommand cmd = new SqlCommand(sql,conn);

                SqlParameter sp = new SqlParameter("@classid",classid);
                cmd.Parameters.Add(sp);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return ds.Tables[0];
            }
        }
        public  bool InsertStudent(Students s) 
        {
            using(SqlConnection conn=new SqlConnection(strsql))
            {
                conn.Open();
                /*string sql = "insert into Students values(@0,@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12)";
                int i = DataBaseHelper.cmdExecuteNonQuery(sql,s.Student_Name,s.Student_Sex,s.StudentClass,s.StudentNum,s.StudentEnterYear,s.StudentOrigin,s.StudentBirthDay,s.StudentCard,s.StudentAddress,s.FamilyTel,s.DormTel,s.Mobile,s.Email);
                return i;*/
                string sql = "insert into Students values(@Student_Name,@Student_Sex,@StudentClass,@StudentNum,@StudentEnterYear,@StudentOrigin,@StudentBirthDay,@StudentCard,@StudentAddress,@FamilyTel,@DormTel,@Mobile,@Email)";
                SqlCommand cmd = new SqlCommand(sql, conn);


                SqlParameter sp = new SqlParameter("@Student_Name", s.Student_Name);
                cmd.Parameters.Add(sp);

                SqlParameter sp1 = new SqlParameter("@Student_Sex", s.Student_Sex);
                cmd.Parameters.Add(sp1);

                SqlParameter sp2 = new SqlParameter("@StudentClass", s.StudentClass);
                cmd.Parameters.Add(sp2);

                SqlParameter sp3 = new SqlParameter("@StudentNum", s.StudentNum);
                cmd.Parameters.Add(sp3);

                SqlParameter sp4 = new SqlParameter("@StudentEnterYear", s.StudentEnterYear);
                cmd.Parameters.Add(sp4);

                SqlParameter sp5 = new SqlParameter("@StudentOrigin", s.StudentOrigin);
                cmd.Parameters.Add(sp5);

                SqlParameter sp6 = new SqlParameter("@StudentBirthDay", s.StudentBirthDay);
                cmd.Parameters.Add(sp6);

                SqlParameter sp7 = new SqlParameter("@StudentCard", s.StudentCard);
                cmd.Parameters.Add(sp7);

                SqlParameter sp8 = new SqlParameter("@StudentAddress", s.StudentAddress);
                cmd.Parameters.Add(sp8);

                SqlParameter sp9 = new SqlParameter("@FamilyTel", s.FamilyTel);
                cmd.Parameters.Add(sp9);

                SqlParameter sp10 = new SqlParameter("@DormTel", s.DormTel);
                cmd.Parameters.Add(sp10);

                SqlParameter sp11 = new SqlParameter("@Mobile", s.Mobile);
                cmd.Parameters.Add(sp11);

                SqlParameter sp12 = new SqlParameter("@Email", s.Email);
                cmd.Parameters.Add(sp12);
                int i = cmd.ExecuteNonQuery();
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
        public DataTable Get(string classID)
        {
            string sql = "select * from  Classes cls where cls.Classes_ID=@0";
            DataTable dt = DataBaseHelper.cmbSqlDataAdapter(sql, classID);
            return dt;
        }
        public DataTable GetStudentInfoByID(string StudentID)
        { 
            using(SqlConnection conn=new SqlConnection(strsql))
            {
                string sql = "select * from Students where Student_ID=@0";
                /*SqlCommand cmd = new SqlCommand(sql,conn);

                SqlParameter sp = new SqlParameter("@studentid",StudentID);
                cmd.Parameters.Add(sp);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return ds.Tables[0];*/
                DataTable dt = DataBaseHelper.cmbSqlDataAdapter(sql,StudentID);
                return dt;
            }
        }
     
        /// <summary>
        /// 根据学生id，获取学籍异动信息
        /// </summary>
        /// <param name="studentid">学生id</param>
        /// <returns></returns>

        public DataTable GetChange(string studentid) 
        {
            string sql = "select ctr.ChangeTypeRecode_ID 异动编号,s.Student_Name 学生姓名,ct.ChangeTypes_Name 异动类型,ctr.ChangeReason 异动原因,ctr.ChangeDate 异动时间 from ChangeTypeRecode ctr "
+" join Students s on ctr.ChangeStudentID=s.Student_ID"
+" join ChangeTypes ct on ctr.ChangeTypes_ID=ct.ChangeTypes_ID"
+" where s.Student_ID=@0";
            DataTable dt = DataBaseHelper.cmbSqlDataAdapter(sql,studentid);
            return dt;
        }
        public DataTable GetAward(string studentid)
        {
            string sql = "select par.PunshmentAwardsRecode_ID 获奖编号,pat.PunishmentAwardTypes_Name 获奖类型,"
+ " s.Student_Name 学生姓名,par.PunshmentAwardsContent 获奖内容,"
+ " par.PunshmentAwardsReason 获奖原因,par.PunshmentAwardsDate 获奖时间 from PunshmentAwardsRecode par"
+" join PunishmentAwardTypes pat on par.PunshmentAwardsType_ID=pat.PunishmentAwardTypes_ID"
+" join Students s on s.Student_ID=par.PunshmentAwardStudentID"
+" where PunshmentAwardsRecode_ID>0 and Student_ID=@0";
            DataTable dt = DataBaseHelper.cmbSqlDataAdapter(sql,studentid);
            return dt;
        }
        public DataTable GetPunishment(string studentid)
        {
            string sql = "select par.PunshmentAwardsRecode_ID 处分编号,pat.PunishmentAwardTypes_Name 处分类型,"
+ " s.Student_Name 学生姓名,par.PunshmentAwardsContent 处分内容,"
+ " par.PunshmentAwardsReason 处分原因,par.PunshmentAwardsDate 处分时间 from PunshmentAwardsRecode par"
+ " join PunishmentAwardTypes pat on par.PunshmentAwardsType_ID=pat.PunishmentAwardTypes_ID"
+ " join Students s on s.Student_ID=par.PunshmentAwardStudentID"
+ " where PunshmentAwardsRecode_ID<0 and Student_ID=@0";
            DataTable dt = DataBaseHelper.cmbSqlDataAdapter(sql, studentid);
            return dt;
        }
        /// <summary>
        /// 获取异动类型
        /// </summary>
        /// <returns></returns>

        public DataTable GetChangeType()
        {
            string sql = "select * from ChangeTypes";
            DataTable dt = DataBaseHelper.cmbSqlDataAdapter(sql);
            return dt;
        }
        public DataTable GetAwardType()
        {
            string sql = "select * from PunishmentAwardTypes where PunishmentAwardTypes_ID>0";
            DataTable dt = DataBaseHelper.cmbSqlDataAdapter(sql);
            return dt;
        }
        public DataTable GetPunishmentAwardType()
        {
            string sql = "select * from PunishmentAwardTypes where PunishmentAwardTypes_ID<0";
            DataTable dt = DataBaseHelper.cmbSqlDataAdapter(sql);
            return dt;
        }
 
        /// <summary>
        /// 删除学籍异动记录
        /// </summary>
        /// <param name="changeid"></param>
        /// <returns></returns>
        public int DeleteChange(string changeid)
        {
            string sql = "delete from ChangeTypeRecode where ChangeTypeRecode_ID=@0";
            int i = DataBaseHelper.cmdExecuteNonQuery(sql,changeid);
            return i;

        }
        /// <summary>
        /// 删除获奖记录
        /// </summary>
        /// <param name="awardid"></param>
        /// <returns></returns>
        public int DeleteAward(string awardid)
        {
            string sql = "delete from PunshmentAwardsRecode where PunshmentAwardsRecode_ID=@0";
            return DataBaseHelper.cmdExecuteNonQuery(sql,awardid);

        }
        /// <summary>
        /// 删除处分记录
        /// </summary>
        /// <param name="punishmentid"></param>
        /// <returns></returns>
        public int DelectPunishment(string punishmentid)
        {
            string sql = "delete from PunshmentAwardsRecode where PunshmentAwardsRecode_ID=@0";
            return DataBaseHelper.cmdExecuteNonQuery(sql,punishmentid);
        }
        /// <summary>
        /// 根据学生id删除学生信息
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int DeleteStudent(string studentid)
        {
            string sql = "delete from Students where Student_ID=@0";
            return DataBaseHelper.cmdExecuteNonQuery(sql,studentid);
        }
        public int UpdateStudentInfo(Students s)
        {
            string sql = "update Students set Student_Name=@0,Student_Sex=@1,Student_Class=@2,StudentNum=@3,StudentEnterYear=@4,StudentOrigin=@5,StudentBirthDay=@6,StudentCard=@7,StudentAddress=@8,FamilyTel=@9,DormTel=@10,Mobile=@11,Email=@12 where Student_ID=@13";
            int i = DataBaseHelper.cmdExecuteNonQuery(sql, s.Student_Name, s.Student_Sex, s.StudentClass, s.StudentNum, s.StudentEnterYear, s.StudentOrigin, s.StudentBirthDay, s.StudentCard, s.StudentAddress, s.FamilyTel, s.DormTel, s.Mobile, s.Email,s.StudentID);
            return i;
        }
        //学制
        public string GetSpeYearsName(string SpecialityID)
        {
            string sql = "select sy.SpeYears_Name from SpeYears as sy join Speciality as sp on sp.Speciality_Years=sy.SpeYears_ID where sp.Speciality_ID=@0";
            return DataBaseHelper.cmdExecuteScalar(sql, SpecialityID).ToString();

        }
        /// <summary>
        /// 插入获奖记录
        /// </summary>
        /// <param name="Recode_ID"></param>
        /// <param name="Type_ID"></param>
        /// <param name="StudentID"></param>
        /// <param name="Content"></param>
        /// <param name="Reason"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public int InsertAwards(int Recode_ID,string Type_ID,string StudentID,string Content,string Reason,string date)
        {
            string sql = "insert into PunshmentAwardsRecode values(@0,@1,@2,@3,@4,@5)";
            return DataBaseHelper.cmdExecuteNonQuery(sql,Recode_ID,Type_ID,StudentID,Content,Reason,date);
        }

        public int InsertPunishment(int Recode_ID, string Type_ID, string StudentID, string Content, string Reason, string date)
        {
            string sql = "insert into PunshmentAwardsRecode values(@0,@1,@2,@3,@4,@5)";
            return DataBaseHelper.cmdExecuteNonQuery(sql, Recode_ID, Type_ID, StudentID, Content, Reason, date);
        }
        /// <summary>
        /// 插入学籍异动记录
        /// </summary>
        /// <param name="typeid"></param>
        /// <param name="reason"></param>
        /// <param name="stuid"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public int InsertChange(string typeid, string reason, string stuid, string date)
        {
            string sql = "insert into ChangeTypeRecode values(@0,@1,@2,@3)";
            int i = DataBaseHelper.cmdExecuteNonQuery(sql, typeid, reason, stuid, date);
            return i;
        }

        /// <summary>
        /// 获取最大值
        /// </summary>
        /// <returns></returns>
        public object GetMaxAward()
        {
            string sql = "select MAX(PunshmentAwardsRecode_ID) from PunshmentAwardsRecode";
            return DataBaseHelper.cmdExecuteScalar(sql);
        }

        public object GetMinPunishment()
        {
            string sql = "select MIN(PunshmentAwardsRecode_ID) from PunshmentAwardsRecode";
            return DataBaseHelper.cmdExecuteScalar(sql);
        }
        /// <summary>
        /// 根据班级id获取学生信息
        /// </summary>
        /// <param name="Classid"></param>
        /// <returns></returns>
        public DataTable GetStudentByClassid(string Classid)
        {
            string sql = "select * from Students where Student_Class=@0";
            return DataBaseHelper.cmbSqlDataAdapter(sql,Classid);
        }
        
    }
}
