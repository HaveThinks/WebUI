using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public static class ScoreBLL
    {
        public static DataTable GetSubjectBySpecID(string specid)
        {
            ScoreDAL sid = new ScoreDAL();
            return sid.GetSubjectBySpecID(specid);
        }
        /// <summary>
        /// 插入成绩
        /// </summary>
        /// <param name="studentid">学生id</param>
        /// <param name="subjectid">科目id</param>
        /// <param name="score">成绩</param>
        /// <returns></returns>
        public static int InsertExamInation(string studentid,string subjectid,string score)
        {
            ScoreDAL sid = new ScoreDAL();
            return sid.InsertExamInation(studentid,subjectid,score);
        }
        public static DataTable GetScoreByStudentid(string studentid)
        {
            ScoreDAL sd = new ScoreDAL();
            return sd.GetScoreByStudentid(studentid);
        }
        /// <summary>
        /// 根据学生id，科目id修改成绩
        /// </summary>
        /// <param name="score">成绩</param>
        /// <param name="studentid">学生id</param>
        /// <param name="subjectid">科目id</param>
        /// <returns></returns>
         public static int UpdateExamInation(string score,string studentid,string subjectid)
        {
            ScoreDAL sid = new ScoreDAL();
            return sid.UpdateExamInation(score,studentid,subjectid);
        }

        public static DataTable GetSubjectToSpecID(string specid)
         {
             ScoreDAL sid = new ScoreDAL();
             return sid.GetSubjectToSpecID(specid);
         }
        public static DataTable GetClasses()
        {
            ScoreDAL sid = new ScoreDAL();
            return sid.GetClasses();
        }
        public static DataTable GetSubjectGoSpecID(string specid)
        {
            ScoreDAL sid = new ScoreDAL();
            return sid.GetSubjectGoSpecID(specid);
        }

        /// <summary>
        /// 根据专业id获取成绩
        /// </summary>
        /// <param name="specid"></param>
        /// <returns></returns>
        public static DataTable GetExamInationBySpecid(string specid)
        {
            ScoreDAL sid = new ScoreDAL();
            return sid.GetExamInationBySpecid(specid);
        }
        /// <summary>
        /// 根据专业id获取学生id，学生姓名，学生班级
        /// </summary>
        /// <param name="specid"></param>
        /// <returns></returns>
        public static DataTable GetStudentBySpecid(string specid)
        {
            ScoreDAL sid = new ScoreDAL();
            return sid.GetStudentBySpecid(specid);
        }

        public static DataTable GetStudentByClassid(string classid)
        {
            ScoreDAL sid = new ScoreDAL();
            return sid.GetStudentByClassid(classid);
        }
        public static DataTable GetExamInationByClassid(string classid)
        {
            ScoreDAL sid = new ScoreDAL();
            return sid.GetExamInationByClassid(classid);
        }

        public static DataTable GetTeacher ()
        {
            ScoreDAL sid = new ScoreDAL();
            return sid.GetTeacher();
        }
    }
}
