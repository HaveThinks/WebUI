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
    public partial class OrderScore : Form
    {
        public OrderScore()
        {
            InitializeComponent();
        }
        bool islock = false;
        private void OrderScore_Load(object sender, EventArgs e)
        {
            BinderColleges();
            BinderClasses();
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
        void BinderSubject(string specid)
        {
            islock = true;

            DataTable Subject = ScoreBLL.GetSubjectToSpecID(specid);

            this.cmbBoxSubject.DataSource = Subject;
            this.cmbBoxSubject.DisplayMember = "Subjects_Name";
            this.cmbBoxSubject.ValueMember = "Subjects_ID";

            islock = false;
        }
        void BinderClasses()
        {
            islock = true;

            DataTable Speciality = ScoreBLL.GetClasses();

            this.cmbBoxClass.DataSource = Speciality;
            this.cmbBoxClass.DisplayMember = "Classes_Name";
            this.cmbBoxClass.ValueMember = "Classes_ID";

            islock = false;
        }

        void BinderSubjects(string specid)
        {
            islock = true;
            DataTable subject = ScoreBLL.GetSubjectGoSpecID(specid);

            this.cmbBoxSubjects.DataSource = subject;
            this.cmbBoxSubjects.DisplayMember = "Subjects_Name";
            this.cmbBoxSubjects.ValueMember = "Subjects_ID";

            islock = false;
        }

        private void cmbBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (islock)
                return;
            if (cmbBoxClass.Items.Count > 0)
            {
                try
                {
                    string specid = cmbBoxClass.SelectedValue.ToString();
                    BinderSubjects(specid);
                }
                catch (Exception)
                {
                    
                    throw;
                }
                
            }
        }

        private void cmbBoxSpeciality_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (islock)
                return;
            cmbBoxSubject.Controls.Clear();
            if (cmbBoxSpeciality.Items.Count > 0)
            {
                string specid = cmbBoxSpeciality.SelectedValue.ToString();
                BinderSubject(specid);
            }
            cmbBoxSubject_SelectedIndexChanged(null, null);
        }

        private void cmbBoxCollege_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (islock)
                return;
            if (cmbBoxCollege.Items.Count > 0)
            {
                string collegeid = cmbBoxCollege.SelectedValue.ToString();
                BinderSpeciality(collegeid);

            }
            //重新加载专业
            cmbBoxSpeciality_SelectedIndexChanged(null, null);
        }

        private void cmbBoxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearBySpec_Click(object sender, EventArgs e)
        {
            dgvScore.DataSource = null;
            if (cmbBoxSpeciality.SelectedIndex != -1)//判断是否选中专业
            {
                if (cmbBoxSubject.Items.Count > 0)
                {
                    #region 添加列
                    //声明表
                    DataTable scores = new DataTable();
                    //添加 第一列
                    DataColumn dc = new DataColumn("班级", typeof(string));
                    scores.Columns.Add(dc);
                    //添加 第二列
                    DataColumn dcname = new DataColumn("姓名", typeof(string));
                    scores.Columns.Add(dcname);

                    //动态添加每个列名（科目）
                    for (int i = 0; i < cmbBoxSubject.Items.Count; i++)
                    {
                        string subjectname = ((DataRowView)(cmbBoxSubject.Items[i]))["Subjects_Name"].ToString();
                        DataColumn dcsubject = new DataColumn(subjectname,typeof(int));
                        //设置默认值为0
                        dcsubject.DefaultValue = 0;
                        //添加列
                        scores.Columns.Add(dcsubject);

                    }
                    //总分
                    DataColumn dcscore = new DataColumn("总分", typeof(int));
                    scores.Columns.Add(dcscore);
                    #endregion

                    //填充数据
                    //专业id
                    string specid = cmbBoxSpeciality.SelectedValue.ToString();
                    //学生
                    DataTable students = ScoreBLL.GetStudentBySpecid(specid);
                    //成绩
                    DataTable exam = ScoreBLL.GetExamInationBySpecid(specid);

                    DataRow dr;
                    for (int i = 0; i < students.Rows.Count; i++)
                    {
                        dr = scores.NewRow();

                        dr["班级"] = students.Rows[i]["Classes_Name"].ToString();
                        dr["姓名"] = students.Rows[i]["Student_Name"].ToString();

                        //获取每个学生的所有科目
                        DataRow[] r = exam.Select("StudentID="+students.Rows[i]["Student_ID"].ToString());

                        string tempName;//临时存储科目名称
                        int tempScore;//临时存储成绩
                        int total=0;//总分
                        //填充每个学生的每个科目分数
                        for (int j = 0; j < r.Length;j++)
                        {
                             tempScore = (int)r[j]["ExamScore"];
                            tempName = ((DataRowView)(cmbBoxSubject.Items[j]))["Subjects_Name"].ToString();
                            dr[tempName] = tempScore;
                            //算总分
                            total += tempScore;

                        }
                        //填充总分
                        dr["总分"] = total;
                        scores.Rows.Add(dr);
                    }

                    DataView dv = scores.DefaultView;
                    //排序
                    if(cbScoreBySpec.Checked)
                    {
                        //根据总分排序
                        dv.Sort = "总分 desc";
                    }
                    else if(cmbBoxSubject.SelectedValue!=null)
                    {
                        //根据科目排序
                        dv.Sort = ((DataRowView)(cmbBoxSubject.SelectedItem))["Subjects_Name"].ToString() + " desc ";
                    }
                    dgvScore.DataSource = dv;

                }
            }
            else
            {
                MessageBox.Show("请选择专业！");
            }
        }

        private void btnSearBySpec1_Click(object sender, EventArgs e)
        {
            if (cmbBoxSubjects.SelectedIndex != -1)//判断是否选中班级
            {
                if (cmbBoxSubjects.Items.Count > 0)
                {
                    if (cmbBoxClass.Items.Count > 0)
                    {
                        #region 添加列
                        //声明表
                        DataTable scores = new DataTable();
                        //添加 第一列
                        DataColumn dc = new DataColumn("班级", typeof(string));
                        scores.Columns.Add(dc);
                        //添加 第二列
                        DataColumn dcname = new DataColumn("姓名", typeof(string));
                        scores.Columns.Add(dcname);

                        //动态添加每个列名（科目）
                        for (int i = 0; i < cmbBoxSubjects.Items.Count; i++)
                        {
                            string subjectname = ((DataRowView)(cmbBoxSubjects.Items[i]))["Subjects_Name"].ToString();
                            DataColumn dcsubject = new DataColumn(subjectname, typeof(int));
                            //设置默认值为0
                            dcsubject.DefaultValue = 0;
                            //添加列
                            scores.Columns.Add(dcsubject);
                        }


                        //总分
                        DataColumn dcscore = new DataColumn("总分", typeof(int));
                        scores.Columns.Add(dcscore);
                        #endregion

                        //填充数据
                        //班级id
                        string classid = cmbBoxClass.SelectedValue.ToString();
                        //学生
                        DataTable students = ScoreBLL.GetStudentByClassid(classid);
                        //成绩
                        DataTable exam = ScoreBLL.GetExamInationByClassid(classid);

                        DataRow dr;
                        for (int i = 0; i < students.Rows.Count; i++)
                        {
                            dr = scores.NewRow();
                            //填充第一列数据
                            dr["班级"] = students.Rows[i]["Classes_Name"].ToString();
                            //填充第二列数据
                            dr["姓名"] = students.Rows[i]["Student_Name"].ToString();

                            //获取每个学生的所有科目
                            DataRow[] r = exam.Select("StudentID=" + students.Rows[i]["Student_ID"].ToString());

                            string tempName;//临时存储科目名称
                            int tempScore;//临时存储成绩
                            int total = 0;//总分
                            //填充每个学生的每个科目分数
                            for (int j = 0; j < r.Length; j++)
                            {
                                tempScore = (int)r[j]["ExamScore"];
                                tempName = ((DataRowView)(cmbBoxSubjects.Items[j]))["Subjects_Name"].ToString();
                                dr[tempName] = tempScore;
                                //算总分
                                total += tempScore;

                            }
                            //填充总分
                            dr["总分"] = total;
                            scores.Rows.Add(dr);

                        }
                        DataView dv = scores.DefaultView;
                        //排序
                        if (cbScoreByClass.Checked)
                        {
                            //根据总分排序
                            dv.Sort = "总分 desc";
                        }
                        else if (cmbBoxSubjects.SelectedValue != null)
                        {
                            //根据科目排序
                            dv.Sort = ((DataRowView)(cmbBoxSubjects.SelectedItem))["Subjects_Name"].ToString() + " desc ";
                        }
                        dgvScore.DataSource = dv;
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择专业！");
            }
        }
    }
}
