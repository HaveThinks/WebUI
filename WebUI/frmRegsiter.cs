using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BLL;

namespace WebUI
{
    public partial class frmRegsiter : Form
    {
        public frmRegsiter()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            AdminInfo ai = new AdminInfo();
            ai.AdminName = this.txtUserName.Text;
            ai.AdminPwd = this.txtPwd.Text;
            ai.AdminLevel = this.txtLevel.Text;

            if (AddAdminInfoBLL.AddAdminInfo(ai))
            {
                MessageBox.Show("成功！");
                frmLogin denglu=new frmLogin();
                denglu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("失败：用户名已存在或插入失败");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            frmLogin fl = new frmLogin();
            fl.Owner = this;
            fl.Show();
            this.Hide();
        }
    }
}
