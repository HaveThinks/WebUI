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
    public partial class AddClass : Form
    {
        public string FromText;
        string classid;
        public AddClass()
        {
            InitializeComponent();
        }
        bool islock = false;

        private void AddClass_Load(object sender, EventArgs e)
        {
            
            //绑定学院名称
            BinderColleges(); 
            //绑定教师
            BinderTeacher();


            //修改班级信息
            if(FromText=="修改班级信息")
            {
                this.Text = FromText;
                btnOK.Text = "确定修改";
                //获取要修改的班级信息的编号（班级id不能修改，因此连带学院和专业都不能修改）
                classid = this.Tag.ToString();

                DataTable dt = ClassBLL.GetInfoByClassid(classid);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmbBoxCollege.Text = dt.Rows[i]["College_Name"].ToString();

                    BinderSpeciality(dt.Rows[i]["College_ID"].ToString());
                    cmbBoxSpeciality.Text = dt.Rows[i]["Speciality_Name"].ToString();

                    labClass.Text = classid.Substring(0,4);
                    txtClassid.Text = classid.Substring(4,2);
                    cmbBoxCollege.Enabled = false;
                    cmbBoxSpeciality.Enabled = false;
                    txtClassid.Enabled = false;
                    txtClass.Text = dt.Rows[i]["Classes_Name"].ToString();
                    cmbBoxTeacher.Text = dt.Rows[i]["Teacher_Name"].ToString();
                    tbPS.Text = dt.Rows[i]["Classes_PS"].ToString();
                }

            }
        }

        void BinderTeacher()
        {
            islock = true;
            DataTable teacher = ScoreBLL.GetTeacher();

            this.cmbBoxTeacher.DataSource = teacher;
            this.cmbBoxTeacher.DisplayMember="Teacher_Name";
            this.cmbBoxTeacher.ValueMember="Teacher_ID";

            islock=false;
        }
        void BinderSpec()
        {
            islock = true;
            labClass.Text = cmbBoxSpeciality.SelectedValue.ToString();

            islock = false;
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
        private void cmbBoxCollege_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if (cmbBoxCollege.SelectedValue.ToString()!="")//判断学院下拉框是否选中值
            {
                //获取学院id
                string collegeid = cmbBoxCollege.SelectedValue.ToString();
                //绑定专业
                BinderSpeciality(collegeid);

            }
        }

        private void cmbBoxSpeciality_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if(cmbBoxSpeciality.SelectedValue.ToString()!="")
            {
                BinderSpec();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //添加班级功能
            if(FromText==null)
            {
                //添加新班级，除备注外的所有信息都不允许为空
                if(cmbBoxCollege.Text.ToString()=="")
                {
                    MessageBox.Show("学院信息不能为空！请添加学院信息","信息提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }
                if(cmbBoxSpeciality.Text.ToString()=="")
                {
                    MessageBox.Show("专业信息不能为空！请添加学院信息", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if(txtClassid.Text.Trim()=="")
                {
                    MessageBox.Show("班级编号不能为空！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if(txtClass.Text.Trim()=="")
                {
                    MessageBox.Show("班级名称不能为空！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if(cmbBoxTeacher.Text.ToString()=="")
                {
                    MessageBox.Show("班主任信息不能为空！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //班级编号仅限两位
                if(txtClassid.Text.Trim().Length!=2)
                {
                    MessageBox.Show("班级编号需写两位！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //将班级信息存入Classes表中
                try
                {
                    Classes c = new Classes();
                    c.Classes_ID = labClass.Text + txtClassid.Text;
                    c.Classes_Name = txtClass.Text;
                    c.Classes_Speciality = cmbBoxSpeciality.SelectedValue.ToString();
                    c.ClassHeadTeacher = Convert.ToInt32(cmbBoxTeacher.SelectedValue.ToString());
                    c.Classes_PS = tbPS.Text;

                    int i = ClassBLL.InsertClasses(c);
                    if (i > 0)
                    {
                        MessageBox.Show("添加班级成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                        txtClassid.Text = "";
                        txtClass.Text = "";
                        tbPS.Text = "";
                    }
                
                    else
                    {
                        MessageBox.Show("添加班级失败", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }               
                }
                catch
                {

                    MessageBox.Show("已经存在班级编号，请重新填写！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                }

            }

            if(FromText=="修改班级信息")
            {
                Classes c = new Classes();
                c.Classes_Name = txtClass.Text.Trim();
                c.ClassHeadTeacher = Convert.ToInt32(cmbBoxTeacher.SelectedValue);
                c.Classes_PS = tbPS.Text;
                c.Classes_ID = labClass.Text + txtClassid.Text;

               int i = ClassBLL.UpdateClass(c);
                if (i > 0)
                {
                    MessageBox.Show("修改班级信息成功", "信息提示");
                }

                else
                {
                    MessageBox.Show("修改班级信息失败", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }               
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
           

            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
