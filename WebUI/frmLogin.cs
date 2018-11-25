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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //窗体加载事件，加载窗体时，显示验证码
            strCode = Getcode(ran.Next(4, 5));
            pictureBox1.Image = GetMap(strCode);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {           
            AdminInfo ai = new AdminInfo();
            ai.AdminName = this.txtUserName.Text;
            ai.AdminPwd = this.txtPwd.Text;
            bool dl = LoginBLL.AddAdminInfo(ai);
            if (dl)
            {
                if (tbx_Admin_Code.Text.Trim().ToLower() != strCode.ToLower())
                {
                    MessageBox.Show("验证码输入有误，请重新输入！");
                    strCode = Getcode(ran.Next(4, 5));
                    pictureBox1.Image = GetMap(strCode);
                    tbx_Admin_Code.Text = "";
                    return;
                }
                
                    MessageBox.Show("欢迎登录学生信息管理系统","信息提示",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    frmMain genxintance = new frmMain();
                    genxintance.Show();
                    this.Hide();
                
                
            }
            else 
            {
                MessageBox.Show("登录失败");
            }
            this.txtUserName.Text = "";
            this.txtPwd.Text = "";
        }
        #region  生成验证码
        //定义一个变量用来存储最终生成的验证码,初始值为空
        string strCode = "";
        //实例化一个对象，用来生成随机数
        Random ran = new Random();
        /// <summary>
        /// 定义一个函数，用来获取生成的验证码
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        string Getcode(int count)
        {
            string str = "2,3,4,5,6,7,8,9,q,w,e,r,t,y,u,i,o,p,a,s,d,f,g,h,j,k,l,z,x,c,v,b,n,m,Q,W,E,R,T,Y,U,I,O,P,A,D,S,F,G,H,J,K,L,Z,X,C,V,B,N,M";
            string[] strSp = str.Split(',');

            string ma = "";
            for (int i = 0; i < count; i++)
            {
                int index = ran.Next(0, strSp.Length);
                ma += strSp[index];
            }
            return ma;
        }
        //画验证码
        Bitmap GetMap(string str)
        {
            Bitmap bt = new Bitmap(pictureBox1.Width, pictureBox1.Height);//空画布
            Graphics g = Graphics.FromImage(bt);//在哪画
            SolidBrush sbr = new SolidBrush(Color.White);//底色
            g.FillRectangle(sbr, 0, 0, bt.Width, bt.Height);
            SolidBrush sbWord = new SolidBrush(Color.Black);//验证码
            g.DrawString(str, new Font("黑体", 17, FontStyle.Bold), sbWord, 10, 5);
            //干扰线
            for (int i = 0; i < 8; i++)
            {
                int x1 = ran.Next(0, bt.Width);
                int y1 = ran.Next(0, bt.Height);
                int x2 = ran.Next(0, bt.Width);
                int y2 = ran.Next(0, bt.Height);
                g.DrawLine(Pens.White, x1, y1, x2, y2);
            }
            for (int i = 0; i < 80; i++)
            {
                int x1 = ran.Next(0, bt.Width);
                int y1 = ran.Next(0, bt.Height);
                bt.SetPixel(x1, y1, Color.Red);
            }
            return bt;
        }
        #endregion   结束生成验证码


        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //点击验证码后，重新生成一个验证码
            strCode = Getcode(ran.Next(4, 5));
            pictureBox1.Image = GetMap(strCode);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            strCode = Getcode(ran.Next(4, 5));
            pictureBox1.Image = GetMap(strCode);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            frmRegsiter fr = new frmRegsiter();
            fr.Owner = this;
            fr.Show();
            this.Hide();
        }


    }
}
