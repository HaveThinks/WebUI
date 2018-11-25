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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            bindTreeView();
            
        }
        void bindTreeView() 
        {
            try 
            {
                DataTable colleges = TreeViewBLL.GetCollegesBLL();
                tvColleges.Nodes.Clear();


                foreach(DataRow row in colleges.Rows)
                {
                    TreeNode tn = new TreeNode(row["College_Name"].ToString());

                    tn.Name = row["College_ID"].ToString();
                    tn.Tag = "colleges";
                    tvColleges.Nodes.Add(tn);

                    DataTable speciality = TreeViewBLL.GetSpecBLL(row["College_ID"].ToString());
                    foreach(DataRow specrow in speciality.Rows)
                    {
                        TreeNode spec = new TreeNode(specrow["Speciality_Name"].ToString());
                        spec.Name=specrow["Speciality_ID"].ToString();
                        spec.Tag = "Speciality";
                        tn.Nodes.Add(spec);

                        DataTable classes = TreeViewBLL.GetClassesBLL(specrow["Speciality_ID"].ToString());

                        foreach(DataRow classrow in classes.Rows)
                        {
                            TreeNode classe = new TreeNode(classrow["Classes_Name"].ToString());
                            classe.Name=classrow["Classes_ID"].ToString();
                            classe.Tag = "Classes";
                            spec.Nodes.Add(classe);
                        }
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("异常！");
            }
        }

        private void tvColleges_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (e == null)
                    return;
                if (e.Node.Tag.ToString() == "Classes")//表示选中班级
                {
                    DataTable dt = StudentsInfoBLL.GetStudentsInfoByClassID(e.Node.Name);
                    lvStudentsInfo.Items.Clear();

                    foreach (DataRow stu in dt.Rows)
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text=stu["Student_Name"].ToString();

                        lvi.Name = stu["Student_ID"].ToString();

                        lvi.SubItems.Add(stu["StudentNum"].ToString());
                        lvi.SubItems.Add(stu["Student_Sex"].ToString());
                        lvi.SubItems.Add(stu["College_Name"].ToString());
                        lvi.SubItems.Add(stu["Speciality_Name"].ToString());
                        lvi.SubItems.Add(stu["StudentEnterYear"].ToString());
                        lvi.SubItems.Add(stu["SpeYears_Name"].ToString());
                        lvi.SubItems.Add(stu["StudentOrigin"].ToString());

                        lvStudentsInfo.Items.Add(lvi);
                    }

                }

            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

        private void 新建NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewStudentForm nform = new NewStudentForm();
            nform.Owner = this;
            nform.Show();
        }

        private void 编辑EToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if(lvStudentsInfo.SelectedItems.Count==1)
           {
               string stuid = lvStudentsInfo.SelectedItems[0].Name;
               EditForm ef = new EditForm(stuid);
               ef.Owner = this;
               ef.Show();
           }
           else if (lvStudentsInfo.SelectedItems.Count > 1)
           {
               MessageBox.Show("只能选择一行！");
           }
           else 
           {
               MessageBox.Show("请选择一行！");
           }
        }

        private void 属性PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvStudentsInfo.SelectedItems.Count==1)
            {
                string stuid = lvStudentsInfo.SelectedItems[0].Name;
                FormProperty fp = new FormProperty(stuid);
                fp.Owner = this;
                fp.Show();
            }
            else if (lvStudentsInfo.SelectedItems.Count > 1)
            {
                MessageBox.Show("只能选择一行！");
            }
            else
            {
                MessageBox.Show("请选择一行！");
            }
        }
        private void 删除DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //获取学生ID
            if(lvStudentsInfo.SelectedItems.Count>0)
            {
                int success = 0;
                int error = 0;
                foreach (ListViewItem item in lvStudentsInfo.SelectedItems)
                {
                    string studentid = item.Name;
                    //写删除方法
                    int i = StudentsInfoBLL.DeleteStudent(studentid);
                     if (i > 0)
                       success++;
                   else
                       error++;
                }
                    //统计共执行多少行
                   int sum = success + error;
                   MessageBox.Show("共操作了" + sum + "行；成功" + success + "行，失败" + error + "行！");
            }
            else
            {
                MessageBox.Show("请选择一行或多行！");
            }
        }
        private void 关闭XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 添加AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScore clas = new AddScore();
            clas.Owner = this;
            clas.Show();
        }

        private void 排名CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderScore os = new OrderScore();
            os.Owner=this;
            os.Show();
        }

        private void 班级添加AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClass ac = new AddClass();
            ac.Owner = this;
            ac.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void 班级浏览LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSelect fs = new frmSelect();
            fs.Owner = this;
            fs.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            NewStudentForm nform = new NewStudentForm();
            nform.Owner = this;
            nform.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (lvStudentsInfo.SelectedItems.Count == 1)
            {
                string stuid = lvStudentsInfo.SelectedItems[0].Name;
                FormProperty fp = new FormProperty(stuid);
                fp.Owner = this;
                fp.Show();
            }
            else if (lvStudentsInfo.SelectedItems.Count > 1)
            {
                MessageBox.Show("只能选择一行！");
            }
            else
            {
                MessageBox.Show("请选择一行！");
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (lvStudentsInfo.SelectedItems.Count == 1)
            {
                string stuid = lvStudentsInfo.SelectedItems[0].Name;
                EditForm ef = new EditForm(stuid);
                ef.Owner = this;
                ef.Show();
            }
            else if (lvStudentsInfo.SelectedItems.Count > 1)
            {
                MessageBox.Show("只能选择一行！");
            }
            else
            {
                MessageBox.Show("请选择一行！");
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //获取学生ID
            if (lvStudentsInfo.SelectedItems.Count > 0)
            {
                int success = 0;
                int error = 0;
                foreach (ListViewItem item in lvStudentsInfo.SelectedItems)
                {
                    string studentid = item.Name;
                    //写删除方法
                    int i = StudentsInfoBLL.DeleteStudent(studentid);
                    if (i > 0)
                        success++;
                    else
                        error++;
                }
                //统计共执行多少行
                int sum = success + error;
                MessageBox.Show("共操作了" + sum + "行；成功" + success + "行，失败" + error + "行！");
                //清空listview选中行
                lvStudentsInfo.Items.Clear();

            }
            else
            {
                MessageBox.Show("请选择一行或多行！");
            }
        }

        private void 班级查询SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //查询班级
            SearchClass se = new SearchClass();
            se.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            //刷新信息，重新绑定
            //树节点清空
            tvColleges.Nodes.Clear();
            //重新加载树
            bindTreeView();
            //清空listview选中行
            lvStudentsInfo.Items.Clear();
            
        }

        private void toolStripButton5_Click_1(object sender, EventArgs e)
        {
            //刷新信息，重新绑定
            //树节点清空
            tvColleges.Nodes.Clear();
            //重新加载树
            bindTreeView();
            //展开所有节点
            tvColleges.ExpandAll();
        }


    }
}
