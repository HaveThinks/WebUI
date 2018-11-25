using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Model;

namespace WebUI
{
    public partial class SearchClass : Form
    {
        public SearchClass()
        {
            InitializeComponent();
        }
        bool islock = false;

        private void SearchClass_Load(object sender, EventArgs e)
        {
            if (islock)
                return;

            
            //绑定学院
            BinderColleges();
            cmbBoxCollege.Text = "";
            
            //绑定教师
            BinderTeacher();
            cmbBoxTeacher.Text = "";
            
       }
        
        void BinderColleges()
        {
            islock = true;

            DataTable colleges = TreeViewBLL.GetCollegesBLL();

            this.cmbBoxCollege.DataSource = colleges;
            this.cmbBoxCollege.DisplayMember = "College_Name";
            this.cmbBoxCollege.ValueMember = "College_ID";

            islock = false;
        }
        void BinderSpeciality(string collegeid)
        {
            islock = true;

            DataTable Speciality = TreeViewBLL.GetSpecBLL(collegeid);

            this.cmbBoxSpeciality.DataSource = Speciality;
            this.cmbBoxSpeciality.DisplayMember = "Speciality_Name";
            this.cmbBoxSpeciality.ValueMember = "Speciality_ID";

            islock = false;
        }
        /// <summary>
        /// 根据专业ID绑定班级
        /// </summary>
        /// <param name="specid"></param>
        void BinderClasses(string specid)
        {
            islock = true;

            DataTable Speciality = TreeViewBLL.GetClassesBLL(specid);

            this.cmbBoxClass.DataSource = Speciality;
            this.cmbBoxClass.DisplayMember = "Classes_Name";
            this.cmbBoxClass.ValueMember = "Classes_ID";

            islock = false;
        }
        void BinderTeacher()
        {
            islock = true;
            DataTable teacher = ScoreBLL.GetTeacher();

            this.cmbBoxTeacher.DataSource = teacher;
            this.cmbBoxTeacher.DisplayMember = "Teacher_Name";
            this.cmbBoxTeacher.ValueMember = "Teacher_ID";

            islock = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // 查询信息——可以根据其中任意多个条件进行查询
            if(cmbBoxCollege.Text.Trim()==""&&cmbBoxSpeciality.Text.Trim()==""&&cmbBoxClass.Text.Trim()==""&&cmbBoxTeacher.Text.Trim()=="")
            {
                MessageBox.Show("至少选择一个条件进行查询！","信息提示");
                return;
            }
            string name = "";
            DataTable result = new DataTable();
            //如果没有教师名称
            if (cmbBoxTeacher.Text.Trim() == "")
            {
                if (cmbBoxClass.Text.Trim() != "")
                {
                    name = cmbBoxClass.Text;
                    //模糊查询（班级名称）
                    result = ClassBLL.GetInfoLikeClassName(name, "");
                }
                else if (cmbBoxSpeciality.Text.Trim() != "")
                {
                    name = cmbBoxSpeciality.Text;
                    //模糊查询（专业名称）
                    result = ClassBLL.GetInfoLikeSpecName(name, "");
                }
                else if (cmbBoxCollege.Text.Trim() != "")
                {
                    name = cmbBoxCollege.Text;
                    //模糊查询（学院名称）
                    result = ClassBLL.GetInfoLikeCollegeName(name, "");
                }
            }
            else
            {
                string tName = cmbBoxTeacher.Text;
                if(cmbBoxClass.Text.Trim()!="")
                {
                    name = cmbBoxClass.Text;
                    result = ClassBLL.GetInfoLikeClassName(name,tName);
                }
                else if(cmbBoxSpeciality.Text.Trim()!="")
                {
                    name = cmbBoxSpeciality.Text;
                    result = ClassBLL.GetInfoLikeSpecName(name,tName);
                }
                else if(cmbBoxCollege.Text.Trim()!="")
                {
                    name = cmbBoxCollege.Text;
                    result = ClassBLL.GetInfoLikeCollegeName(name,tName);
                }
                else
                {
                    result = ClassBLL.GetInfoLikeTeacherName(tName);
                }
            }
            if(result.Rows.Count==0)
            {
                MessageBox.Show("没有符合查询条件的记录，请重新选择！","信息提示");
            }
            dataGridView1.DataSource = result;

        }

        private void cmbBoxCollege_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (islock)
                return;
            
                //获取学院id
                string collegeid = cmbBoxCollege.SelectedValue.ToString();
                //绑定专业
                BinderSpeciality(collegeid);
                cmbBoxSpeciality.Text = "";

            
            //重新加载专业
            cmbBoxSpeciality_SelectedIndexChanged(null, null);
        }

        private void cmbBoxSpeciality_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (islock)
                return;
            
                //绑定班级
                string specialityid = cmbBoxSpeciality.SelectedValue.ToString();
                BinderClasses(specialityid);
                cmbBoxClass.Text = "";

            
            islock = false;
        }

      
    }
}
