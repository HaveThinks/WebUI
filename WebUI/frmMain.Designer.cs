namespace WebUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.学生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.属性PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.排名CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.班级管理MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.班级浏览LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.班级查询SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.班级添加AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据字典DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更改个人资料CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.组织机构设置OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.参数类型设置TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看YToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具栏TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.状态栏SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.大图标LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.小图标MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.列表LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.详细信息DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于学生管理信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.tvColleges = new System.Windows.Forms.TreeView();
            this.lvStudentsInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生ToolStripMenuItem,
            this.成绩CToolStripMenuItem,
            this.系统SToolStripMenuItem,
            this.查看YToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1009, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 学生ToolStripMenuItem
            // 
            this.学生ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建NToolStripMenuItem,
            this.属性PToolStripMenuItem,
            this.编辑EToolStripMenuItem,
            this.删除DToolStripMenuItem,
            this.关闭XToolStripMenuItem});
            this.学生ToolStripMenuItem.Name = "学生ToolStripMenuItem";
            this.学生ToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.学生ToolStripMenuItem.Text = "学生(X)";
            // 
            // 新建NToolStripMenuItem
            // 
            this.新建NToolStripMenuItem.Name = "新建NToolStripMenuItem";
            this.新建NToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.新建NToolStripMenuItem.Text = "新建(N)";
            this.新建NToolStripMenuItem.Click += new System.EventHandler(this.新建NToolStripMenuItem_Click);
            // 
            // 属性PToolStripMenuItem
            // 
            this.属性PToolStripMenuItem.Name = "属性PToolStripMenuItem";
            this.属性PToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.属性PToolStripMenuItem.Text = "属性(P)";
            this.属性PToolStripMenuItem.Click += new System.EventHandler(this.属性PToolStripMenuItem_Click);
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.编辑EToolStripMenuItem.Text = "编辑(E)";
            this.编辑EToolStripMenuItem.Click += new System.EventHandler(this.编辑EToolStripMenuItem_Click);
            // 
            // 删除DToolStripMenuItem
            // 
            this.删除DToolStripMenuItem.Name = "删除DToolStripMenuItem";
            this.删除DToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.删除DToolStripMenuItem.Text = "删除(D)";
            this.删除DToolStripMenuItem.Click += new System.EventHandler(this.删除DToolStripMenuItem_Click);
            // 
            // 关闭XToolStripMenuItem
            // 
            this.关闭XToolStripMenuItem.Name = "关闭XToolStripMenuItem";
            this.关闭XToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.关闭XToolStripMenuItem.Text = "关闭(X)";
            this.关闭XToolStripMenuItem.Click += new System.EventHandler(this.关闭XToolStripMenuItem_Click);
            // 
            // 成绩CToolStripMenuItem
            // 
            this.成绩CToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.排名CToolStripMenuItem,
            this.添加AToolStripMenuItem});
            this.成绩CToolStripMenuItem.Name = "成绩CToolStripMenuItem";
            this.成绩CToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.成绩CToolStripMenuItem.Text = "成绩(C)";
            // 
            // 排名CToolStripMenuItem
            // 
            this.排名CToolStripMenuItem.Name = "排名CToolStripMenuItem";
            this.排名CToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.排名CToolStripMenuItem.Text = "排名(C)";
            this.排名CToolStripMenuItem.Click += new System.EventHandler(this.排名CToolStripMenuItem_Click);
            // 
            // 添加AToolStripMenuItem
            // 
            this.添加AToolStripMenuItem.Name = "添加AToolStripMenuItem";
            this.添加AToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.添加AToolStripMenuItem.Text = "添加(A)";
            this.添加AToolStripMenuItem.Click += new System.EventHandler(this.添加AToolStripMenuItem_Click);
            // 
            // 系统SToolStripMenuItem
            // 
            this.系统SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.班级管理MToolStripMenuItem,
            this.用户管理UToolStripMenuItem,
            this.数据字典DToolStripMenuItem,
            this.更改个人资料CToolStripMenuItem});
            this.系统SToolStripMenuItem.Name = "系统SToolStripMenuItem";
            this.系统SToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.系统SToolStripMenuItem.Text = "系统(S)";
            // 
            // 班级管理MToolStripMenuItem
            // 
            this.班级管理MToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.班级浏览LToolStripMenuItem,
            this.班级查询SToolStripMenuItem,
            this.班级添加AToolStripMenuItem});
            this.班级管理MToolStripMenuItem.Name = "班级管理MToolStripMenuItem";
            this.班级管理MToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.班级管理MToolStripMenuItem.Text = "班级管理(M)";
            // 
            // 班级浏览LToolStripMenuItem
            // 
            this.班级浏览LToolStripMenuItem.Name = "班级浏览LToolStripMenuItem";
            this.班级浏览LToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.班级浏览LToolStripMenuItem.Text = "班级浏览(L)";
            this.班级浏览LToolStripMenuItem.Click += new System.EventHandler(this.班级浏览LToolStripMenuItem_Click);
            // 
            // 班级查询SToolStripMenuItem
            // 
            this.班级查询SToolStripMenuItem.Name = "班级查询SToolStripMenuItem";
            this.班级查询SToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.班级查询SToolStripMenuItem.Text = "班级查询(S)";
            this.班级查询SToolStripMenuItem.Click += new System.EventHandler(this.班级查询SToolStripMenuItem_Click);
            // 
            // 班级添加AToolStripMenuItem
            // 
            this.班级添加AToolStripMenuItem.Name = "班级添加AToolStripMenuItem";
            this.班级添加AToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.班级添加AToolStripMenuItem.Text = "班级添加(A)";
            this.班级添加AToolStripMenuItem.Click += new System.EventHandler(this.班级添加AToolStripMenuItem_Click);
            // 
            // 用户管理UToolStripMenuItem
            // 
            this.用户管理UToolStripMenuItem.Name = "用户管理UToolStripMenuItem";
            this.用户管理UToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.用户管理UToolStripMenuItem.Text = "用户管理(U)";
            // 
            // 数据字典DToolStripMenuItem
            // 
            this.数据字典DToolStripMenuItem.Name = "数据字典DToolStripMenuItem";
            this.数据字典DToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.数据字典DToolStripMenuItem.Text = "数据字典(D)";
            // 
            // 更改个人资料CToolStripMenuItem
            // 
            this.更改个人资料CToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.组织机构设置OToolStripMenuItem,
            this.参数类型设置TToolStripMenuItem});
            this.更改个人资料CToolStripMenuItem.Name = "更改个人资料CToolStripMenuItem";
            this.更改个人资料CToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.更改个人资料CToolStripMenuItem.Text = "更改个人资料(C)";
            // 
            // 组织机构设置OToolStripMenuItem
            // 
            this.组织机构设置OToolStripMenuItem.Name = "组织机构设置OToolStripMenuItem";
            this.组织机构设置OToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.组织机构设置OToolStripMenuItem.Text = "组织机构设置(O)";
            // 
            // 参数类型设置TToolStripMenuItem
            // 
            this.参数类型设置TToolStripMenuItem.Name = "参数类型设置TToolStripMenuItem";
            this.参数类型设置TToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.参数类型设置TToolStripMenuItem.Text = "参数类型设置(T)";
            // 
            // 查看YToolStripMenuItem
            // 
            this.查看YToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.工具栏TToolStripMenuItem,
            this.状态栏SToolStripMenuItem,
            this.大图标LToolStripMenuItem,
            this.小图标MToolStripMenuItem,
            this.列表LToolStripMenuItem,
            this.详细信息DToolStripMenuItem,
            this.刷新EToolStripMenuItem});
            this.查看YToolStripMenuItem.Name = "查看YToolStripMenuItem";
            this.查看YToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.查看YToolStripMenuItem.Text = "查看(Y)";
            // 
            // 工具栏TToolStripMenuItem
            // 
            this.工具栏TToolStripMenuItem.Checked = true;
            this.工具栏TToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.工具栏TToolStripMenuItem.Name = "工具栏TToolStripMenuItem";
            this.工具栏TToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.工具栏TToolStripMenuItem.Text = "工具栏(T)";
            // 
            // 状态栏SToolStripMenuItem
            // 
            this.状态栏SToolStripMenuItem.Checked = true;
            this.状态栏SToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.状态栏SToolStripMenuItem.Name = "状态栏SToolStripMenuItem";
            this.状态栏SToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.状态栏SToolStripMenuItem.Text = "状态栏(S)";
            // 
            // 大图标LToolStripMenuItem
            // 
            this.大图标LToolStripMenuItem.Name = "大图标LToolStripMenuItem";
            this.大图标LToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.大图标LToolStripMenuItem.Text = "大图标(L)";
            // 
            // 小图标MToolStripMenuItem
            // 
            this.小图标MToolStripMenuItem.Name = "小图标MToolStripMenuItem";
            this.小图标MToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.小图标MToolStripMenuItem.Text = "小图标(M)";
            // 
            // 列表LToolStripMenuItem
            // 
            this.列表LToolStripMenuItem.Name = "列表LToolStripMenuItem";
            this.列表LToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.列表LToolStripMenuItem.Text = "列表(L)";
            // 
            // 详细信息DToolStripMenuItem
            // 
            this.详细信息DToolStripMenuItem.Checked = true;
            this.详细信息DToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.详细信息DToolStripMenuItem.Name = "详细信息DToolStripMenuItem";
            this.详细信息DToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.详细信息DToolStripMenuItem.Text = "详细信息(D)";
            // 
            // 刷新EToolStripMenuItem
            // 
            this.刷新EToolStripMenuItem.Name = "刷新EToolStripMenuItem";
            this.刷新EToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.刷新EToolStripMenuItem.Text = "刷新(E)";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于学生管理信息ToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助HToolStripMenuItem.Text = "帮助(H)";
            // 
            // 关于学生管理信息ToolStripMenuItem
            // 
            this.关于学生管理信息ToolStripMenuItem.Name = "关于学生管理信息ToolStripMenuItem";
            this.关于学生管理信息ToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.关于学生管理信息ToolStripMenuItem.Text = "关于学生管理信息系统(A)";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1009, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton1.Text = "新建";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton2.Text = "属性";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton3.Text = "编辑";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton4.Text = "删除";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton5.Text = "刷新";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // tvColleges
            // 
            this.tvColleges.Location = new System.Drawing.Point(12, 83);
            this.tvColleges.Name = "tvColleges";
            this.tvColleges.Size = new System.Drawing.Size(180, 338);
            this.tvColleges.TabIndex = 2;
            this.tvColleges.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvColleges_AfterSelect);
            // 
            // lvStudentsInfo
            // 
            this.lvStudentsInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvStudentsInfo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lvStudentsInfo.FullRowSelect = true;
            this.lvStudentsInfo.Location = new System.Drawing.Point(237, 83);
            this.lvStudentsInfo.Name = "lvStudentsInfo";
            this.lvStudentsInfo.Size = new System.Drawing.Size(742, 338);
            this.lvStudentsInfo.TabIndex = 3;
            this.lvStudentsInfo.UseCompatibleStateImageBehavior = false;
            this.lvStudentsInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "姓名";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "学号";
            this.columnHeader2.Width = 64;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "性别";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "所在学院";
            this.columnHeader4.Width = 113;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "所属学院";
            this.columnHeader5.Width = 125;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "入学年份";
            this.columnHeader6.Width = 104;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "学制";
            this.columnHeader7.Width = 98;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "籍贯";
            this.columnHeader8.Width = 105;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(458, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvStudentsInfo);
            this.Controls.Add(this.tvColleges);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息管理系统";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem 学生ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 属性PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 排名CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 班级管理MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 班级浏览LToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 班级查询SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 班级添加AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户管理UToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据字典DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更改个人资料CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 组织机构设置OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 参数类型设置TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看YToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具栏TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 状态栏SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 大图标LToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 小图标MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 列表LToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 详细信息DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刷新EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于学生管理信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.TreeView tvColleges;
        private System.Windows.Forms.ListView lvStudentsInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}