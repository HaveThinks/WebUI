using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;
using Model;

namespace WebUI
{
    public partial class EditForm : Form
    {
        string StudentID;
        public EditForm(string ID)
        {
            InitializeComponent();
            StudentID = ID;
        }

        public EditForm()
        {
            // TODO: Complete member initialization
        }

        bool islock = false;
        private void EditForm_Load(object sender, EventArgs e)
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
                   
                    

                    if (cmbBoxSpeciality.Items.Count > 0)
                    {
                        cmbBoxSpeciality.SelectedIndex = 0;
                        //绑定班级
                        BinderClasses(cmbBoxSpeciality.SelectedValue.ToString());
                        BinderSpeciality(cmbBoxCollege.SelectedValue.ToString());

                    }

                }
                  

            try
            {
                BinderStudentInfo();
            }
            catch 
            {
                
                MessageBox.Show("");
                this.Close();
            }
            //学籍异动
            BinderChange();
            //获奖记录
            BinderAward();
            //处分记录
            BinderPunishment();
            //学籍异动类型
           BinderChangeType();
            //奖励类型
           BinderAwardType();
            //处分类型
           BinderPunishmentAwardType();
          

          

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        void BinderStudentInfo() 
        {
            try
            {
                DataTable student = StudentsInfoBLL.GetStudentInfoByID(StudentID);
                if (student==null)
                {
                    MessageBox.Show("没数据！");
                    return;
                }
                DataRow row=student.Rows[0];

                this.txtBoxName.Text = row["Student_Name"].ToString();
                this.txtBoxNum.Text = row["StudentNum"].ToString();
                
                this.txtBoxIDCardNum.Text = row["StudentCard"].ToString();
                this.txtBoxNative.Text = row["StudentOrigin"].ToString();
                this.txtBoxHomeTel.Text = row["FamilyTel"].ToString();
                this.txtBoxHomeAdd.Text = row["StudentAddress"].ToString();
                this.txtBoxflatTel.Text = row["DormTel"].ToString();
                this.txtBoxMobile.Text = row["Mobile"].ToString();
                this.txtBoxEmail.Text = row["Email"].ToString();             

                /*DataTable dt=StudentsInfoBLL.
                BinderColleges();
                BinderSpeciality(CollegeID);
                BinderClasses(SpecialityID);
                string classID=row["StudentClass"].ToString();
                if(cmbBoxCollege.Items.Count>0)
                {
                    cmbBoxCollege.SelectedValue=college
                }*/
                if (row["Student_Sex"].ToString() == "男")
                { 
                    rdoBtnMale.Checked = true; 
                }
                else
                { 
                    rdoBtnFemale.Checked = true; 
                }
               
                if (!string.IsNullOrEmpty(row["StudentBirthDay"].ToString()))
                {
                    this.dateTimePickerBirth.Value = (DateTime)row["StudentBirthDay"];
                }
                else
                {
                    this.dateTimePickerBirth.Value = DateTime.Now;
                }
                //学号
                if (!string.IsNullOrEmpty(row["StudentNum"].ToString()))
                {
                    string num = row["StudentNum"].ToString();
                    txtBoxNum.Text = num.Substring(num.Length - 4);
                }
                else
                {
                    txtBoxNum.Text = "";
                }
                if (!string.IsNullOrEmpty(row["StudentEnterYear"].ToString()))
                {
                    this.dateTimePickerDate.Value = (DateTime)row["StudentEnterYear"];
                }
                else
                {
                    this.dateTimePickerDate.Value=DateTime.Now;
                }

            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);


            }

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
        //学籍异动
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
        void BinderChangeType()
        {
            DataTable changetype = StudentsInfoBLL.GetChangeType();
            cmbChangeType.DataSource = changetype;
            cmbChangeType.DisplayMember = "ChangeTypes_Name";
            cmbChangeType.ValueMember = "ChangeTypes_ID";
        }
        void BinderAwardType()
        {
            DataTable AwardType = StudentsInfoBLL.GetAwardType();
            cmbAwardType.DataSource = AwardType;
            cmbAwardType.DisplayMember = "PunishmentAwardTypes_Name";
            cmbAwardType.ValueMember = "PunishmentAwardTypes_ID";
        }
        void BinderPunishmentAwardType()
        {
            DataTable punishmentawardtype = StudentsInfoBLL.GetPunishmentAwardType();
            cmbPunishmentType.DataSource = punishmentawardtype;
            cmbPunishmentType.DisplayMember = "PunishmentAwardTypes_Name";
            cmbPunishmentType.ValueMember = "PunishmentAwardTypes_ID";
        }
        private void BinderSpeYears(string SpecialityID)
        {
            LableBoxStuType.Text = StudentsInfoBLL.GetSpeYearName(SpecialityID);
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
                BinderSpeYears(cmbBoxSpeciality.SelectedValue.ToString());
                BinderClasses(cmbBoxSpeciality.SelectedValue.ToString());

            }
            catch (Exception)
            {

                throw;
            }
        }

 

        private void btnAddChange_Click(object sender, EventArgs e)
        {
            string typeid = cmbChangeType.SelectedValue.ToString();
            string changedate = dateTimeChange.Value.ToString();
            string studentid = StudentID;
            string changeReason = txtChangeReason.Text;
            int i = StudentsInfoBLL.InsertChange(typeid,changeReason,studentid,changedate);
            if(i>0)
            {
                MessageBox.Show("成功！");
                BinderChange();
            }
            else
            {
                MessageBox.Show("失败！");
            }
        }

        private void btnDelecteChange_Click(object sender, EventArgs e)
        {
            int success = 0;
            int error = 0;
            //判断是否选中行
            if(dgvChanges.SelectedRows.Count>0)
            {
                //循环
                foreach (DataGridViewRow row in dgvChanges.SelectedRows)
                {
                    string changeid=row.Cells[0].Value.ToString();
                   int i=StudentsInfoBLL.DeleteChange(changeid);
                   if (i > 0)
                       success++;
                   else
                       error++;
                }
                    //统计共执行多少行
                   int sum = success + error;
                   MessageBox.Show("共操作了"+sum+"行；成功"+success+"行，失败"+error+"行！");

                   BinderChange();
                }
            }

        private void btnDelecteAward_Click(object sender, EventArgs e)
        {
            int success = 0;
            int error = 0;
            //判断是否选中行
            if (dgvAwards.SelectedRows.Count > 0)
            {
                //循环
                foreach (DataGridViewRow row in dgvAwards.SelectedRows)
                {
                    string awardid = row.Cells[0].Value.ToString();
                    int i = StudentsInfoBLL.DeleteAward(awardid);
                    if (i > 0)
                        success++;
                    else
                        error++;
                }
                //统计共执行多少行
                int sum = success + error;
                MessageBox.Show("共操作了" + sum + "行；成功" + success + "行，失败" + error + "行！");

                BinderAward();
            }
        }
        private void btnDelectePunishment_Click(object sender, EventArgs e)
        {
            int success = 0;
            int error = 0;
            //判断是否选中行
            if (dgvPunishments.SelectedRows.Count > 0)
            {
                //循环
                foreach (DataGridViewRow row in dgvPunishments.SelectedRows)
                {
                    string punishmentid = row.Cells[0].Value.ToString();
                    int i = StudentsInfoBLL.DeletePunishment(punishmentid);
                    if (i > 0)
                        success++;
                    else
                        error++;
                }
                int sum = success + error;
                MessageBox.Show("共操作了" + sum + "行；成功" + success + "行，失败" + error + "行！");

                BinderPunishment();
            }
        }


        private void btnAddAward_Click(object sender, EventArgs e)
        {
            try
            {
                //获取id最大值
                object obj = StudentsInfoBLL.GetMaxAward();
                int id = 1;
                //最大值为空,数据表没记录
                if (obj == null)
                    id = 1;
                //只有处分，没有奖励
                if (Convert.ToInt32(obj) < 1)
                    id = 1;
                else
                    id = Convert.ToInt32(obj) + 1;




                int Recode_ID = id;

                string Type_ID = cmbAwardType.SelectedValue.ToString();
                string Content = txtAwardContent.Text;
                string Reason = txtAwardReason.Text;
                string Date = dateTimeAward.Value.ToString();

                int r = StudentsInfoBLL.InsertAwards(id, Type_ID, StudentID, Content, Reason, Date);

                if (r > 0)
                {
                    MessageBox.Show("成功！");
                    BinderAward();
                }
                else
                {
                    MessageBox.Show("失败！");
                }
            }
            catch (Exception)
            {
                
                throw;
            }        
        }
        private void btnAddPunishment_Click(object sender, EventArgs e)
        {
            try
            {
                //获取id最小值
                object obj = StudentsInfoBLL.GetMinPunishment();
                int ii = Convert.ToInt32(obj);

                int id = -1;
                //表记录为空
                if (obj == null)
                    id = -1;
                //只有奖励，没有处分
                if (Convert.ToInt32(obj) > -1)
                    id = -1;
                else
                    id = ii-1;




                int Recode_ID = id;

                string Type_ID = cmbPunishmentType.SelectedValue.ToString();
                string Content = cmbPunishmentType.Text;
                string Reason =txtPunishmentReason.Text;
                string Date = dateTimePunishment.Value.ToString();

                int r = StudentsInfoBLL.InsertPunishment(id, Type_ID, StudentID, Content, Reason, Date);

                if (r > 0)
                {
                    MessageBox.Show("成功！");
                    BinderPunishment();
                }
                else
                {
                    MessageBox.Show("失败！");
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }    

        bool checkIsTextNULL()
        {
            if (string.IsNullOrEmpty(txtBoxName.Text))
            {
                MessageBox.Show("必须填写姓名");
                return false;
            }
            if (this.cmbBoxClass.SelectedValue == null)
            {
                MessageBox.Show("必须为学生选择班级！");
                return false;
            }

            if (string.IsNullOrEmpty(this.txtBoxName.Text))
            {
                MessageBox.Show("必须填学号！");
                return false;
            }
            if (this.txtBoxNum.Text.Trim().Length != 4)
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
            if (dateTimePickerBirth.Value > dateTimePickerDate.Value)
            {
                MessageBox.Show("出生日期不能比入学日期小！");
                return false;
            }
            return true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!checkIsTextNULL())
                return;

            Students s = new Students();
            s.StudentID = Convert.ToInt32(StudentID);
            s.Student_Name = this.txtBoxName.Text;
            s.Student_Sex = this.rdoBtnMale.Checked ? "男" : "女";

            s.StudentClass = cmbBoxClass.SelectedValue.ToString();
            s.StudentNum = cmbBoxClass.SelectedValue.ToString() + txtBoxNum.Text;
            s.StudentEnterYear = dateTimePickerDate.Value;
            s.StudentOrigin = txtBoxNative.Text;
            s.StudentBirthDay = dateTimePickerBirth.Value;
            s.StudentCard = txtBoxIDCardNum.Text;
            s.StudentAddress = txtBoxHomeAdd.Text;
            s.FamilyTel = txtBoxHomeTel.Text;
            s.DormTel = txtBoxflatTel.Text;
            s.Mobile = txtBoxEmail.Text;
            s.Email = txtBoxMobile.Text;

            int i = StudentsInfoBLL.UpdateStudentInfo(s);
            if (i > 0)
            {
                MessageBox.Show("成功！");
                this.Close();
            }
            else 
            {
                MessageBox.Show("失败！");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label13.Text = DateTime.Now.ToString();
        }


    }          
}
    

