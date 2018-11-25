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

namespace WebUI
{
    public partial class FormProperty : Form
    {
        string StudentID;
       public FormProperty (string ID)
        {
            InitializeComponent();
            StudentID = ID;
        }

        public FormProperty()
        {
            InitializeComponent();
        }

        private void FormProperty_Load(object sender, EventArgs e)
        {
            try
            {
                
                //表数据
                BinderStudentInfo();
                //学籍异动
                BinderChange();
                //获奖记录
                BinderAward();
                //处分记录
                BinderPunishment();
            }
            catch (Exception)
            {
                
                throw;
            }
            

        }
        void BinderStudentInfo()
        {
            try
            {
                DataTable student = StudentsInfoBLL.GetStudentInfoByID(StudentID);
                if (student == null)
                {
                    MessageBox.Show("没数据！");
                    return;
                }
                

                DataRow row = student.Rows[0];

                string classid = row["Student_Class"].ToString();
                DataTable students = StudentsInfoBLL.GetStudentsInfoByClassID(classid);
      
                DataRow stu=students.Rows[0];

                this.labelName.Text = row["Student_Name"].ToString();
                this.labelIDCardNum.Text = row["StudentCard"].ToString();
                this.labelBirthday.Text = row["StudentBirthDay"].ToString();
                this.labelEnterYear.Text=row["StudentEnterYear"].ToString();
                this.labelNative.Text = row["StudentOrigin"].ToString();
                this.labelHomeTel.Text = row["FamilyTel"].ToString();
                this.labelHomeAdd.Text = row["StudentAddress"].ToString();
                this.labelFlatTel.Text = row["DormTel"].ToString();
                this.labelMobile.Text = row["Mobile"].ToString();
                this.labelEmail.Text = row["Email"].ToString();

                this.labStuType.Text = stu["SpeYears_Name"].ToString();
                this.labelClass.Text = stu["Classes_Name"].ToString();
                this.labelSpeciality.Text = stu["Speciality_Name"].ToString();
                this.labelCollege.Text = stu["College_Name"].ToString();

                
                


                if (row["Student_Sex"].ToString() == "男")
                {
                    this.labelSex.Text = "男";
                }
                else
                {
                    this.labelSex.Text = "女";
                }
                if(!string.IsNullOrEmpty(row["StudentNum"].ToString()))
                {
                    labelStuID.Text = row["StudentNum"].ToString();
                    
                }
                else
                {
                    labelStuID.Text = "";
                }
                
            }

            catch (Exception)
            {
                
                throw;
            }
        }

        void BinderChange()
        {
            DataTable change = StudentsInfoBLL.GetChange(StudentID);
            dgvChanges.DataSource = change;
        }
        void BinderAward()
        {
            DataTable award = StudentsInfoBLL.GetAward(StudentID);
            dgvAwards.DataSource = award;
        }
        void BinderPunishment()
        {
            DataTable punishment = StudentsInfoBLL.GetPunishment(StudentID);
            dgvPunishments.DataSource = punishment;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EditForm ef = new EditForm();
            ef.Owner = this;
            ef.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label21.Text = DateTime.Now.ToString();
        }
    }
}
