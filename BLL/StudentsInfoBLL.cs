using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using Model;

namespace BLL
{
    public class StudentsInfoBLL
    {
        public static DataTable GetStudentsInfoByClassID(string classid) 
        {
            StudensInfoDAL sid = new StudensInfoDAL();
            return sid.GetStudentsInfoByClassID(classid);
        }
        public static bool InsertStudentsInfo(Students s) 
        {
            StudensInfoDAL si = new StudensInfoDAL();
            return si.InsertStudent(s);
        }
        public static DataTable GetStudentInfoByID(string studentID)
        {
            StudensInfoDAL sda = new StudensInfoDAL();
            return sda.GetStudentInfoByID(studentID);
        }
        public static DataTable Get(string classID)
        {
            StudensInfoDAL sid = new StudensInfoDAL();
            return sid.Get(classID);
        }
        /// <summary>
        /// 根据学生id，获取学籍异动信息
        /// </summary>
        /// <param name="studentid">学生id</param>
        /// <returns></returns>
        public static DataTable GetChange(string studentid) 
        {
            StudensInfoDAL sid = new StudensInfoDAL();
            DataTable dt = sid.GetChange(studentid);
            return dt;
        }
        public static DataTable GetAward(string studentid)
        {
            StudensInfoDAL sid = new StudensInfoDAL();
            DataTable dt = sid.GetAward(studentid);
            return dt;
        }
        public static DataTable GetPunishment(string studentid)
        {
            StudensInfoDAL sid = new StudensInfoDAL();
            DataTable dt = sid.GetPunishment(studentid);
            return dt;
        }
        /// <summary>
        /// 获取异动类型
        /// </summary>
        /// <returns></returns>
        public static DataTable GetChangeType()
        {
            StudensInfoDAL sid = new StudensInfoDAL();
            return sid.GetChangeType();
        }
        public static DataTable GetAwardType()
        {
            StudensInfoDAL sid = new StudensInfoDAL();
            return sid.GetAwardType();
        }
        public static DataTable GetPunishmentAwardType()
        {
            StudensInfoDAL sid = new StudensInfoDAL();
            return sid.GetPunishmentAwardType();
        }
        /// <summary>
        /// 插入学籍异动记录
        /// </summary>
        /// <param name="typeid"></param>
        /// <param name="reason"></param>
        /// <param name="stuid"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public static int InsertChange(string typeid,string reason,string stuid,string date)
        {
            StudensInfoDAL sid = new StudensInfoDAL();
            return sid.InsertChange(typeid,reason,stuid,date);
        }
        /// <summary>
        /// 删除学籍异动记录
        /// </summary>
        /// <param name="changeid">异动记录id</param>
        /// <returns></returns>
        public static int  DeleteChange(string changeid)
        {
            StudensInfoDAL sid = new StudensInfoDAL();
            int i=sid.DeleteChange(changeid);
            return i;
        }
        /// <summary>
        /// 删除获奖记录
        /// </summary>
        /// <param name="awardid"></param>
        /// <returns></returns>
        public static int DeleteAward(string awardid)
        {
            StudensInfoDAL sid = new StudensInfoDAL();
            return sid.DeleteAward(awardid);
        }
        /// <summary>
        /// 根据学生id删除学生信息
        /// </summary>
        /// <param name="studentid"></param>
        /// <returns></returns>
        public static int DeleteStudent(string studentid)
        {
            StudensInfoDAL sid = new StudensInfoDAL();
            return sid.DeleteStudent(studentid);
        }
        /// <summary>
        /// 删除处分记录
        /// </summary>
        /// <param name="punishmentid"></param>
        /// <returns></returns>
        public static int DeletePunishment(string punishmentid)
        {
            StudensInfoDAL sid = new StudensInfoDAL();
            return sid.DelectPunishment(punishmentid);
        }
        /// <summary>
        /// 编辑学生信息
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int UpdateStudentInfo(Students s)
        {
            StudensInfoDAL sid = new StudensInfoDAL();
            return sid.UpdateStudentInfo(s);
        }
        public static string GetSpeYearName(string SpecialityID)
        {
            StudensInfoDAL sid = new StudensInfoDAL();
            return sid.GetSpeYearsName(SpecialityID);
        }
        /// <summary>
        /// 获取最大值
        /// </summary>
        /// <returns></returns>
        public static object GetMaxAward()
        {
            StudensInfoDAL sid = new StudensInfoDAL();
            return sid.GetMaxAward();
        }
        public static int InsertAwards(int Recode_ID,string Type_ID,string StudentID,string Content, string Reason,string date )
        {
            StudensInfoDAL sid = new StudensInfoDAL();
           return sid.InsertAwards(Recode_ID, Type_ID, StudentID, Content, Reason, date);
        }
        /// <summary>
        /// 获取最小值
        /// </summary>
        /// <returns></returns>
        public static object GetMinPunishment()
        {
            StudensInfoDAL sid = new StudensInfoDAL();
            return sid.GetMinPunishment();
        }
        public static int InsertPunishment(int Recode_ID, string Type_ID, string StudentID, string Content, string Reason, string date)
        {
            StudensInfoDAL sid = new StudensInfoDAL();
            return sid.InsertAwards(Recode_ID, Type_ID, StudentID, Content, Reason, date);
        }
        public static DataTable GetStudentByClassid(string Classid)
        {
            StudensInfoDAL sid = new StudensInfoDAL();
            return sid.GetStudentByClassid(Classid);
        }
    }
}
