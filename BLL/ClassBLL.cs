using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using System.Data;

namespace BLL
{
    public static class ClassBLL
    {
        public static int InsertClasses(Classes c)
        {
            ClassDAL sid = new ClassDAL();
            return sid.InsertClasses(c);
        }
        public static DataTable GetTreeViewByCollegeid(string collegeid)
        {
            ClassDAL sid = new ClassDAL();
            return sid.GetTreeViewByCollegeid(collegeid);
        }

        public static DataTable GetTreeViewBySpecid(string specid)
        {
            ClassDAL sid = new ClassDAL();
            return sid.GetTreeViewBySpecid(specid);
        }

        public static DataTable GetTreeViewByClassid(string classid)
        {
            ClassDAL sid = new ClassDAL();
            return sid.GetTreeViewByClassid(classid);
        }
        public static int DeleteTreeViewByClassid(string classid)
        {
            ClassDAL sid = new ClassDAL();
            return sid.DeleteTreeViewByClassid(classid);
        }
        public static DataTable GetInfoByClassid(string classid)
        {
            ClassDAL sid = new ClassDAL();
            return sid.GetInfoByClassid(classid);
        }
        public static int UpdateClass(Classes c)
        {
            ClassDAL sid = new ClassDAL();
            return sid.UpdateClass(c);
        }

        public static DataTable GetInfoLikeClassName(string classname,string teachername)
        {
            ClassDAL sid = new ClassDAL();
            return sid.GetInfoLikeClassName(classname,teachername);
        }

        public static DataTable GetInfoLikeSpecName(string specname,string teachername)
        {
            ClassDAL sid = new ClassDAL();
            return sid.GetInfoLikeSpecName(specname,teachername);
        }
        public static DataTable GetInfoLikeCollegeName(string collegename,string teachername)
        {
            ClassDAL sid = new ClassDAL();
            return sid.GetInfoLikeCollegeName(collegename,teachername);
        }
        public static DataTable GetInfoLikeTeacherName(string teachername)
        {
            ClassDAL sid = new ClassDAL();
            return sid.GetInfoLikeTeacherName(teachername);
        }
    }
}
