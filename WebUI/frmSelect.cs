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
    public partial class frmSelect : Form
    {
        public frmSelect()
        {
            InitializeComponent();
        }

        private void frmSelect_Load(object sender, EventArgs e)
        {
            BinderTreeView();
        }

        /// <summary>
        /// 加载树节点
        /// </summary>
        void BinderTreeView()
        {
            try
            {
                DataTable colleges = TreeViewBLL.GetCollegesBLL();
                tvColleges.Nodes.Clear();


                foreach (DataRow row in colleges.Rows)
                {
                    TreeNode tn = new TreeNode(row["College_Name"].ToString());

                    tn.Name = row["College_ID"].ToString();
                    tn.Tag = "colleges";
                    tvColleges.Nodes.Add(tn);

                    DataTable speciality = TreeViewBLL.GetSpecBLL(row["College_ID"].ToString());
                    foreach (DataRow specrow in speciality.Rows)
                    {
                        TreeNode spec = new TreeNode(specrow["Speciality_Name"].ToString());
                        spec.Name = specrow["Speciality_ID"].ToString();
                        spec.Tag = "Speciality";
                        tn.Nodes.Add(spec);

                        DataTable classes = TreeViewBLL.GetClassesBLL(specrow["Speciality_ID"].ToString());

                        foreach (DataRow classrow in classes.Rows)
                        {
                            TreeNode classe = new TreeNode(classrow["Classes_Name"].ToString());
                            classe.Name = classrow["Classes_ID"].ToString();
                            classe.Tag = "Classes";
                            spec.Nodes.Add(classe);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("异常！");
            }
        }
        /// <summary>
        /// 
        /// 删除方法</summary>
        void DelectClass()
        {
            if(dgvClass.SelectedRows.Count>0)
            {
                try
                {
                    int n = dgvClass.SelectedRows.Count;
                    DialogResult result = MessageBox.Show("您确定要删除这"+Convert.ToString(n)+"项吗?","信息提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                    if(result==DialogResult.Yes)
                    {
                        for (int i = dgvClass.SelectedRows.Count - 1; i >= 0;i-- )
                        {
                            //获取要删除的班级名称
                            string ClassID = dgvClass.SelectedRows[i].Cells["班级编号"].Value.ToString();
                            //从数据库Classes表中将数据真正删除
                            ClassBLL.DeleteTreeViewByClassid(ClassID);
                            //从DataGridView中删除班信息
                            dgvClass.Rows.Remove(dgvClass.SelectedRows[i]);
                        }
                    }
                    toolStripButton3_Click(null, null);
                }
                catch 
                {

                    MessageBox.Show("对不起，存在该班级学生信息，不能删除该班级信息！");
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的班级信息");
            }
        }

        private void tvColleges_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (e == null)
                    return;
                
                if (e.Node.Tag.ToString() == "colleges")
                {
                    DataTable dt = ClassBLL.GetTreeViewByCollegeid(e.Node.Name);
                    dgvClass.DataSource = dt;
                }
                else if (e.Node.Tag.ToString() == "Speciality")
                {
                    DataTable dt = ClassBLL.GetTreeViewBySpecid(e.Node.Name);
                    dgvClass.DataSource = dt;
                }
                else if (e.Node.Tag.ToString() == "Classes")
                {
                    DataTable dt = ClassBLL.GetTreeViewByClassid(e.Node.Name);
                    dgvClass.DataSource = dt;
                }
                
            }
            catch
            {

                MessageBox.Show("失败！");
            }            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AddClass ad = new AddClass();
            ad.Owner = this;
            ad.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //删除班级
            DelectClass();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //刷新信息，重新绑定
            //树节点清空
            tvColleges.Nodes.Clear();
            //重新加载树
            BinderTreeView();
            //右边数据清空
            dgvClass.DataSource = null;
            ////展开所有节点
            //tvColleges.ExpandAll();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            SearchClass os = new SearchClass();
            os.Owner = this;
            os.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //修改班级信息
            if(dgvClass.SelectedRows.Count>1)
            {
                MessageBox.Show("只能选一条班级信息进行修改！","信息修改");
                return;
            }
            else if(dgvClass.SelectedRows.Count==0)
            {
                MessageBox.Show("请选择需要修改的班级！", "信息修改");
            }
            else
            {
                AddClass update = new AddClass();
                update.FromText = "修改班级信息";
                //将班级编号保存
                update.Tag = dgvClass.SelectedRows[0].Cells["班级编号"].Value;
                update.ShowDialog();

                if(update.DialogResult==DialogResult.OK)
                {
                    //刷新
                    toolStripButton3_Click(null,null);
                }
            }
        }
    }
}
