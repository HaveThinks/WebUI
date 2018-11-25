using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class TreeViewBLL
    {
        public static DataTable GetCollegesBLL()
        {
            TreeViewDAL tvd = new TreeViewDAL();
            return tvd.GentCollegeDAL();
        }
        public static DataTable GetSpecBLL(string collegeid)
        {
            TreeViewDAL tvd = new TreeViewDAL();
            return tvd.GetSpecDAL(collegeid);
        }
        public static DataTable GetClassesBLL(string specialityid) 
        {
            TreeViewDAL tvd = new TreeViewDAL();
            return tvd.GetClassesDAL(specialityid);
        }
    }
}
