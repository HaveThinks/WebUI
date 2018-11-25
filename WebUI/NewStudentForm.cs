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
    public partial class NewStudentForm : Form
    {
        public NewStudentForm()
        {
            InitializeComponent();
        }

        bool islock = false;
        private void NewStudentForm_Load(object sender, EventArgs e)
        {
            if (islock)
                return;
            
            try
            {
                //绑定学院
                BinderColleges();
                if (cmbBoxCollege.Items.Count > 0)
                {
                    cmbBoxCollege.SelectedIndex = 0;
                    //绑定专业
                    BinderSpeciality(cmbBoxCollege.SelectedValue.ToString());
                    BinderSpeYears(cmbBoxSpeciality.SelectedValue.ToString());

                    if(cmbBoxSpeciality.Items.Count>0)
                    {
                        cmbBoxSpeciality.SelectedIndex = 0;
                        //绑定班级
                        BinderClasses(cmbBoxSpeciality.SelectedValue.ToString());
                        BinderSpeciality(cmbBoxCollege.SelectedValue.ToString());

                    }

                }
                

            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }

        }
        /// <summary>
        /// 学制
        /// </summary>
        /// <param name="SpecialityID"></param>
        private void BinderSpeYears(string SpecialityID)
        {
            labStuID.Text = StudentsInfoBLL.GetSpeYearName(SpecialityID);
        }
        void BinderColleges()
        {
            islock=true;

            DataTable colleges = TreeViewBLL.GetCollegesBLL();

            this.cmbBoxCollege.DataSource=colleges;
            this.cmbBoxCollege.DisplayMember = "College_Name";
            this.cmbBoxCollege.ValueMember="College_ID";

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

        private void cmbBoxCollege_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (islock)
                return;

            if (cmbBoxSpeciality.DataSource == null)
            {
                cmbBoxSpeciality.DataSource = null;
                return;
            }
            try
            {              
                BinderSpeciality(cmbBoxCollege.SelectedValue.ToString());
                BinderClasses(cmbBoxSpeciality.SelectedValue.ToString());
                BinderSpeYears(cmbBoxSpeciality.SelectedValue.ToString());

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cmbBoxSpeciality_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (islock)
                return;

            if (cmbBoxSpeciality.DataSource == null)
            {
                cmbBoxClass.DataSource = null;
                return;
            }
            try
            {

                BinderClasses(cmbBoxSpeciality.SelectedValue.ToString());
                BinderSpeYears(cmbBoxSpeciality.SelectedValue.ToString());

            }
            catch (Exception)
            {

                throw;
            }
        }
        bool checkIsTextNULL()
        {
            if(string.IsNullOrEmpty(TxtBoxName.Text))
            {
                MessageBox.Show("必须填写姓名");
                return false;
            }
            if (this.cmbBoxClass.SelectedValue == null)
            {
                MessageBox.Show("必须为学生选择班级！");
                return false;
            }  

            if(string.IsNullOrEmpty(this.TxtBoxName.Text))
            {
                MessageBox.Show("必须填学号！");
                return false;
            }
            if(this.txtBoxStuID.Text.Trim().Length!=4)
            {
                MessageBox.Show("学号不能含有空格并且长度必须为4个字符");
                return false;
            }

            if (string.IsNullOrEmpty(txtBoxNative.Text))
            {
                MessageBox.Show("学生籍贯不能为空！");
                return false;
            }
            
            //出生日期小于入学时间
            if (dateTimePickerBirth.Value > dtpEnterYear.Value)
            {
                MessageBox.Show("出生日期不能比入学日期小！");
                return false;
            }
   
            

            return true;
        }
        /// <summary>
        /// 提交数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!checkIsTextNULL())
                return;




            Students s = new Students();
            s.Student_Name = this.TxtBoxName.Text;
            s.Student_Sex = this.rdoBtnMale.Checked ? "男" : "女";

            s.StudentClass = cmbBoxClass.SelectedValue.ToString();
            s.StudentNum = cmbBoxClass.SelectedValue.ToString() + txtBoxStuID.Text;
            s.StudentEnterYear = dtpEnterYear.Value;
            s.StudentOrigin = txtBoxNative.Text;
            s.StudentBirthDay = dateTimePickerBirth.Value;
            s.StudentCard = txtBoxIDCardNum.Text;
            s.StudentAddress = txtBoxHomeAdd.Text;
            s.FamilyTel = txtBoxHomeTel.Text;
            s.DormTel = txtBoxflatTel.Text;
            s.Mobile = txtBoxEmail.Text;
            s.Email = txtBoxMobile.Text;

            bool b = StudentsInfoBLL.InsertStudentsInfo(s);
            if (b)
            {
                MessageBox.Show("成功");
                this.Close();                
            }
            else
            {
                MessageBox.Show("失败");
            }
               


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
