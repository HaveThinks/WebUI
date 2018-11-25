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
    public partial class AddScore : Form
    {
        public AddScore()
        {
            InitializeComponent();
        }

        bool islock = false;
        private void ClassesInfo_Load(object sender, EventArgs e)
        {
            if (islock)
                return;

            try
            {
                //绑定学院
                BinderColleges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

  
        private void BinderStudents(string classid)
        {
            islock = true;
            DataTable students = StudentsInfoBLL.GetStudentByClassid(classid);


            cmbBoxName.DataSource = students;
            cmbBoxName.DisplayMember = "Student_Name";
            cmbBoxName.ValueMember = "Student_ID";


            islock = false;
        }

        private void BinderColleges()
        {
            islock = true;

            DataTable colleges = TreeViewBLL.GetCollegesBLL();

            this.cmbBoxCollege.DataSource = colleges;
            this.cmbBoxCollege.DisplayMember = "College_Name";
            this.cmbBoxCollege.ValueMember = "College_ID";

            islock = false;
        }
        /// <summary>
        /// 根据学院id绑定专业
        /// </summary>
        /// <param name="collegeid"></param>
        private void BinderSpeciality(string collegeid)
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
        private void BinderClasses(string specid)
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
            //将原课程清空
            gbSubjects.Controls.Clear();
            if (cmbBoxCollege.Items.Count > 0)//判断学院下拉框是否选中值
            {
                //获取学院id
                string collegeid = cmbBoxCollege.SelectedValue.ToString();
                //绑定专业
                BinderSpeciality(collegeid);

            }
            //重新加载专业
            cmbBoxSpeciality_SelectedIndexChanged(null, null);
        }

        List<string> arrSubjectID = new List<string>();

        private void cmbBoxSpeciality_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (islock)
                return;
            if (cmbBoxSpeciality.Items.Count > 0)
            {
                //绑定班级
                string specialityid = cmbBoxSpeciality.SelectedValue.ToString();
                BinderClasses(specialityid);

            }
            //科目控件清除
            gbSubjects.Controls.Clear();
            //数组清空
            arrSubjectID.Clear();

            islock = false;

            //当选择好专业后，应显示该专业的所有科目
            DataTable subjectdt = ScoreBLL.GetSubjectBySpecID(cmbBoxSpeciality.SelectedValue.ToString());
            for (int i = 0; i < subjectdt.Rows.Count; i++)
            {
                Subject sj = new Subject();
                sj.labSubject.Text = subjectdt.Rows[i]["Subjects_Name"].ToString();
                //添加科目
                gbSubjects.Controls.Add(sj);
                //给用户控件定位
                //Point 定位位于System.Drawing命名空间，Point用x和y整数坐标来表示在二维平面的一个点
                sj.Location = new Point(10, 15 + 60 * i);

                //把id存到数组
                arrSubjectID.Add(subjectdt.Rows[i]["Subjects_ID"].ToString());
            }
            cmbBoxClass_SelectedIndexChanged(null, null);
        }
        private void cmbBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (islock)
                return;
           
            if(cmbBoxClass.Items.Count>0)
            {
                string classid = cmbBoxClass.SelectedValue.ToString();
                BinderStudents(classid);
            }
            islock = false;
            cmbBoxName_SelectedIndexChanged_1(null, null);
            
        }
        private void cmbBoxName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (islock)
                return;
            //当选择学生后显示该学生的编号
            string studentid = "0";

            if (cmbBoxName.SelectedValue != null)
            {
                studentid = cmbBoxName.SelectedValue.ToString();

                //根据学生id获取学生信息
                DataTable student = StudentsInfoBLL.GetStudentInfoByID(studentid);
                if (student.Rows.Count > 0)
                {
                    labelStuID.Text = student.Rows[0]["StudentNum"].ToString();
                }
                else
                {
                    labelStuID.Text = "0";
                }
            }
            else
            {
                labelStuID.Text = "0";
            }
            islock = false;

            //如果该学生已经录入成绩则显示成绩
            DataTable scoredt = ScoreBLL.GetScoreByStudentid(studentid);

            for (int i=0; i < scoredt.Rows.Count; i++)
            {
                Subject sj=(Subject)gbSubjects.Controls[i];
                sj.txtScore.Text = scoredt.Rows[i]["ExamScore"].ToString();
                //btnSubmit.Enabled = false;
            }


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                int success=0;
                int error=0;
                //学生id
                string studentid = cmbBoxName.SelectedValue.ToString();
                int count=gbSubjects.Controls.Count;
                for (int i = 0; i < count; i++)
                {
                    //科目id
                    string subjectid = arrSubjectID[i];
                    Subject sj=(Subject)gbSubjects.Controls[i];
                    //分数
                    string score = "0";
                    if(!string.IsNullOrEmpty(sj.txtScore.Text))
                    {
                        score = sj.txtScore.Text;
                    }

                    int r = ScoreBLL.InsertExamInation(studentid,subjectid,score);
                    if (r > 0)
                        success++;
                    else
                        error++;       
                    
                }
                int sum = success + error;
                MessageBox.Show("共插入"+sum+"行，成功"+success+"行，失败"+error+"行！");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误");
                throw new Exception(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                int success = 0;
                int error = 0;
                string studentid = cmbBoxName.SelectedValue.ToString();
                foreach (Subject sj in gbSubjects.Controls)
                {
                    string score = sj.txtScore.Text.Trim();
                    string subjectid=arrSubjectID[i];

                    int r = ScoreBLL.UpdateExamInation(score,studentid,subjectid);
                    if (r > 0)
                        success++;
                    else
                        error++;

                    i++;
                    
                }
                int sum = success + error;
                MessageBox.Show("共插入" + sum + "行，成功" + success + "行，失败" + error + "行！");
                this.Close();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}

  

