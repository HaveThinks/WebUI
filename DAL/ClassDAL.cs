using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace DAL
{
    public class ClassDAL
    {
        /// <summary>
        /// 插入班级
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public int InsertClasses(Classes c)
        {
            string sql = "insert into Classes values (@0,@1,@2,@3,@4)";
            return DataBaseHelper.cmdExecuteNonQuery(sql,c.Classes_ID,c.Classes_Name,c.Classes_Speciality,c.ClassHeadTeacher,c.Classes_PS);
        }

        /// <summary>
        /// 通过学院id查询科目名称，班级id，班级名称，备注，老师
        /// </summary>
        /// <param name="collegeid"></param>
        /// <returns></returns>
        public DataTable GetTreeViewByCollegeid(string collegeid)
        {
            string sql = "select Speciality_Name 科目名称,Classes_ID 班级编号,Classes_Name 班级名称,Classes_PS 备注,Teacher_Name 教师姓名"
            +" from Colleges,Speciality,Classes,Teacher" 
            +" where College_ID=Speciality_College"
            +" and Speciality_ID=Classes_Speciality"
            +" and ClassHeadTeacher=Teacher_ID and College_ID=@0";
            return DataBaseHelper.cmbSqlDataAdapter(sql,collegeid);
        }

        /// <summary>
        /// 通过科目id查询科目名称，班级id，班级名称，备注，老师
        /// </summary>
        /// <param name="specid"></param>
        /// <returns></returns>
        public DataTable GetTreeViewBySpecid(string specid)
        {
            string sql = "select Speciality_Name 科目名称,Classes_ID 班级编号,Classes_Name 班级名称,Classes_PS 备注,Teacher_Name 教师姓名"
            + " from Colleges,Speciality,Classes,Teacher"
            + " where College_ID=Speciality_College"
            + " and Speciality_ID=Classes_Speciality"
            + " and ClassHeadTeacher=Teacher_ID and Speciality_ID=@0";
            return DataBaseHelper.cmbSqlDataAdapter(sql, specid);
        }

        /// <summary>
        /// 通过班级id查询科目名称，班级id，班级名称，备注，老师
        /// </summary>
        /// <param name="classid"></param>
        /// <returns></returns>
        public DataTable GetTreeViewByClassid(string classid)
        {
            string sql = "select Speciality_Name 科目名称,Classes_ID 班级编号,Classes_Name 班级名称,Classes_PS 备注,Teacher_Name 教师姓名"
            + " from Colleges,Speciality,Classes,Teacher"
            + " where College_ID=Speciality_College"
            + " and Speciality_ID=Classes_Speciality"
            + " and ClassHeadTeacher=Teacher_ID and Classes_ID=@0";
            return DataBaseHelper.cmbSqlDataAdapter(sql, classid);
        }

        public int DeleteTreeViewByClassid(string classid)
        {
            string sql = "delete  from Classes where Classes_ID=@0";
            return DataBaseHelper.cmdExecuteNonQuery(sql,classid);
        }

        public DataTable GetInfoByClassid(string classid)
        {
            string sql = "select * from Colleges,Speciality,Classes,Teacher"
+" where College_ID=Speciality_College"
+" and Speciality_ID=Classes_Speciality"
+" and ClassHeadTeacher=Teacher_ID and Classes_ID=@0";
            return DataBaseHelper.cmbSqlDataAdapter(sql,classid);
        }
        public int UpdateClass(Classes c)
        {
            string sql = "update Classes set Classes_Name=@0,ClassHeadTeacher=@1,Classes_PS=@2 where Classes_ID=@3";
            return DataBaseHelper.cmdExecuteNonQuery(sql,c.Classes_Name,c.ClassHeadTeacher,c.Classes_PS,c.Classes_ID);
            

        }
        /// <summary>
        /// 模糊查询信息（班级名称）
        /// </summary>
        /// <param name="classname">班级名称</param>
        /// <param name="teachername">教师姓名</param>
        /// <returns></returns>
        public DataTable GetInfoLikeClassName(string classname,string teachername)
        {
            string sql = "select c.Classes_ID 班级名称,c.Classes_Name 班级编号,s.Speciality_Name 专业名称,t.Teacher_Name 教师姓名,c.Classes_PS 班级说明 "
+" from Classes as c,Teacher as t,Speciality as s"
+" where c.ClassHeadTeacher=t.Teacher_ID "
+" and c.Classes_Speciality=s.Speciality_ID"
+" and Classes_Name like '%'+@0+'%' "
+" and t.Teacher_Name like '%'+@1+'%'";
            return DataBaseHelper.cmbSqlDataAdapter(sql,classname,teachername);
        }
        /// <summary>
        /// 模糊查询信息(专业名称)
        /// </summary>
        /// <param name="specname">专业名称</param>
        /// <param name="teachername">教师姓名</param>
        /// <returns></returns>
        public DataTable GetInfoLikeSpecName(string specname,string teachername)
        {
            string sql = "select c.Classes_ID 班级名称,c.Classes_Name 班级编号,s.Speciality_Name 专业名称,t.Teacher_Name 教师姓名,c.Classes_PS 班级说明 "
+ " from Classes as c,Teacher as t,Speciality as s"
+ " where c.ClassHeadTeacher=t.Teacher_ID "
+ " and c.Classes_Speciality=s.Speciality_ID"
+ " and s.Speciality_Name like '%'+@0+'%' "
+ " and t.Teacher_Name like '%'+@1+'%'";
            return DataBaseHelper.cmbSqlDataAdapter(sql, specname, teachername);
        }
        /// <summary>
        /// 模糊查询信息（学院名称）
        /// </summary>
        /// <param name="collegename">学院名称</param>
        /// <param name="teachername">教师姓名</param>
        /// <returns></returns>
        public DataTable GetInfoLikeCollegeName(string collegename,string teachername)
        {
            string sql = "select c.Classes_ID 班级名称,c.Classes_Name 班级编号,s.Speciality_Name 专业名称,t.Teacher_Name 教师姓名,c.Classes_PS 班级说明 "
+ " from Classes as c,Teacher as t,Speciality as s,Colleges"
+ " where c.ClassHeadTeacher=t.Teacher_ID "
+ " and c.Classes_Speciality=s.Speciality_ID"
+ " and s.Speciality_College=Colleges.College_ID"
+ " and College_Name like '%'+@0+'%' "
+ " and t.Teacher_Name like '%'+@1+'%'";
            return DataBaseHelper.cmbSqlDataAdapter(sql, collegename, teachername);
        }
        /// <summary>
        /// 模糊查询（教师）
        /// </summary>
        /// <param name="teachername">教师姓名</param>
        /// <returns></returns>
        public DataTable GetInfoLikeTeacherName(string teachername)
        {
            string sql = "select c.Classes_ID 班级名称,c.Classes_Name 班级编号,s.Speciality_Name 专业名称,t.Teacher_Name 教师姓名,c.Classes_PS 班级说明 "
+ " from Classes as c,Teacher as t,Speciality as s,Colleges"
+ " where c.ClassHeadTeacher=t.Teacher_ID "
+ " and c.Classes_Speciality=s.Speciality_ID"
+ " and s.Speciality_College=Colleges.College_ID"
+ " and t.Teacher_Name like '%'+@0+'%'";
            return DataBaseHelper.cmbSqlDataAdapter(sql,teachername);
        }
    }
}
