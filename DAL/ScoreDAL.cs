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
    public class ScoreDAL
    {
        /// <summary>
        /// 根据专业id获取科目
        /// </summary>
        /// <param name="specid"></param>
        /// <returns></returns>
        public DataTable GetSubjectBySpecID(string specid)
        {
            string sql = "select * from Subject s join Sect_Subjects ss on s.Subjects_ID=ss.Subjects_ID where ss.Sepc_ID=@0";
            return DataBaseHelper.cmbSqlDataAdapter(sql,specid);
        }

        /// <summary>
        /// 插入成绩
        /// </summary>
        /// <param name="studentid">学生id</param>
        /// <param name="subjectsid">科目id</param>
        /// <param name="score">成绩</param>
        /// <returns></returns>

        public int InsertExamInation(string studentid,string subjectid,string score)
        {
            string sql = "insert into Examination values(@0,@1,@2)";
            return DataBaseHelper.cmdExecuteNonQuery(sql,studentid,subjectid,score);
        }
        /// <summary>
        /// 根据学生id查询成绩
        /// </summary>
        /// <param name="studentid">学生id</param>
        /// <returns></returns>
        public DataTable GetScoreByStudentid(string studentid)
        {
            string sql = "select * from Examination where StudentID=@0";
            return DataBaseHelper.cmbSqlDataAdapter(sql,studentid);
        }
        /// <summary>
        /// 根据学生id，科目id修改成绩
        /// </summary>
        /// <param name="score">成绩</param>
        /// <param name="studentid">学生id</param>
        /// <param name="subjectid">科目id</param>
        /// <returns></returns>
        public int UpdateExamInation(string score,string studentid,string subjectid)
        {
            string sql = "update ExamInation set ExamScore=@0 where StudentID=@1 and SubjectsID=@2";
            return DataBaseHelper.cmdExecuteNonQuery(sql,score,studentid,subjectid);
        }

        /// <summary>
        /// 根据专业id获取科目
        /// </summary>
        /// <param name="specid"></param>
        /// <returns></returns>
        public DataTable GetSubjectToSpecID(string specid)
        {
            string sql = "select s.Subjects_Name,s.Subjects_ID from Subject s join Sect_Subjects ss on s.Subjects_ID=ss.Subjects_ID where ss.Sepc_ID=@0";
            return DataBaseHelper.cmbSqlDataAdapter(sql,specid);
        }
        /// <summary>
        /// 获取班级
        /// </summary>
        /// <returns></returns>
        public DataTable GetClasses()
        {
            string sql = "select * from Classes";
            return DataBaseHelper.cmbSqlDataAdapter(sql);
        }
        /// <summary>
        /// 根据班级id获取专业id，专业名称
        /// </summary>
        /// <param name="specid"></param>
        /// <returns></returns>
        public DataTable GetSubjectGoSpecID(string specid)
        {
            string sql = "select sb.Subjects_Name,sb.Subjects_ID from Classes clas" 
+" join Sect_Subjects ss on clas.Classes_Speciality=ss.Sepc_ID" 
+" join Subject sb on sb.Subjects_ID=ss.Subjects_ID"
+ " where clas.Classes_ID=@0";
            return DataBaseHelper.cmbSqlDataAdapter(sql,specid);
        }
        /// <summary>
        /// 根据专业id获取成绩
        /// </summary>
        /// <param name="specid"></param>
        /// <returns></returns>
        public DataTable GetExamInationBySpecid(string specid)
        {
            string sql = "select * from Examination e join Sect_Subjects ss on e.SubjectsID=ss.Subjects_ID where ss.Sepc_ID=@0";
            return DataBaseHelper.cmbSqlDataAdapter(sql,specid);
        }
        /// <summary>
        /// 根据专业id获取学生id，学生姓名，学生班级
        /// </summary>
        /// <param name="specid"></param>
        /// <returns></returns>
        public DataTable GetStudentBySpecid(string specid)
        {
            string sql = "select s.Student_ID,s.Student_Name,c.Classes_Name from Students s join Classes c on s.Student_Class=c.Classes_ID where c.Classes_Speciality=@0";
            return DataBaseHelper.cmbSqlDataAdapter(sql,specid);
        }
        public DataTable GetStudentByClassid(string classid)
        {
            string sql = "select s.Student_ID,s.Student_Name,c.Classes_Name from Students s join Classes c on s.Student_Class=c.Classes_ID where s.Student_Class=@0";
            return DataBaseHelper.cmbSqlDataAdapter(sql,classid);
        }
        public DataTable GetExamInationByClassid(string classid)
        {
            string sql = "select * from Examination e  join Students s on e.StudentID=s.Student_ID where s.Student_Class=@0";
            return DataBaseHelper.cmbSqlDataAdapter(sql,classid);
        }

        public DataTable GetTeacher()
        {
            string sql = "select * from Teacher";
            return DataBaseHelper.cmbSqlDataAdapter(sql);
        }

    }
}
