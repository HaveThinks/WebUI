namespace WebUI
{
    partial class AddClass
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPS = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtClassid = new System.Windows.Forms.TextBox();
            this.labClass = new System.Windows.Forms.Label();
            this.cmbBoxTeacher = new System.Windows.Forms.ComboBox();
            this.cmbBoxSpeciality = new System.Windows.Forms.ComboBox();
            this.cmbBoxCollege = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(359, 481);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 47;
            this.btnClose.Text = "取消";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(62, 481);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 46;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(369, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 45;
            this.label8.Text = "（后两位）";
            // 
            // tbPS
            // 
            this.tbPS.Location = new System.Drawing.Point(143, 271);
            this.tbPS.Multiline = true;
            this.tbPS.Name = "tbPS";
            this.tbPS.Size = new System.Drawing.Size(279, 165);
            this.tbPS.TabIndex = 44;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(143, 159);
            this.txtClass.Multiline = true;
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(279, 21);
            this.txtClass.TabIndex = 43;
            // 
            // txtClassid
            // 
            this.txtClassid.Location = new System.Drawing.Point(255, 118);
            this.txtClassid.MaxLength = 2;
            this.txtClassid.Multiline = true;
            this.txtClassid.Name = "txtClassid";
            this.txtClassid.Size = new System.Drawing.Size(95, 21);
            this.txtClassid.TabIndex = 42;
            // 
            // labClass
            // 
            this.labClass.AutoSize = true;
            this.labClass.Location = new System.Drawing.Point(141, 121);
            this.labClass.Name = "labClass";
            this.labClass.Size = new System.Drawing.Size(11, 12);
            this.labClass.TabIndex = 41;
            this.labClass.Text = "0";
            // 
            // cmbBoxTeacher
            // 
            this.cmbBoxTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxTeacher.FormattingEnabled = true;
            this.cmbBoxTeacher.Location = new System.Drawing.Point(143, 209);
            this.cmbBoxTeacher.Name = "cmbBoxTeacher";
            this.cmbBoxTeacher.Size = new System.Drawing.Size(279, 20);
            this.cmbBoxTeacher.TabIndex = 40;
            // 
            // cmbBoxSpeciality
            // 
            this.cmbBoxSpeciality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxSpeciality.FormattingEnabled = true;
            this.cmbBoxSpeciality.Location = new System.Drawing.Point(143, 63);
            this.cmbBoxSpeciality.Name = "cmbBoxSpeciality";
            this.cmbBoxSpeciality.Size = new System.Drawing.Size(279, 20);
            this.cmbBoxSpeciality.TabIndex = 39;
            this.cmbBoxSpeciality.SelectedIndexChanged += new System.EventHandler(this.cmbBoxSpeciality_SelectedIndexChanged);
            // 
            // cmbBoxCollege
            // 
            this.cmbBoxCollege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxCollege.FormattingEnabled = true;
            this.cmbBoxCollege.Location = new System.Drawing.Point(143, 16);
            this.cmbBoxCollege.Name = "cmbBoxCollege";
            this.cmbBoxCollege.Size = new System.Drawing.Size(279, 20);
            this.cmbBoxCollege.TabIndex = 38;
            this.cmbBoxCollege.SelectedIndexChanged += new System.EventHandler(this.cmbBoxCollege_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 37;
            this.label6.Text = "备注：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 36;
            this.label5.Text = "班主任：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 35;
            this.label4.Text = "班级名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 34;
            this.label3.Text = "班级编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 33;
            this.label2.Text = "专业：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 32;
            this.label1.Text = "学院：";
            // 
            // AddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 516);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbPS);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtClassid);
            this.Controls.Add(this.labClass);
            this.Controls.Add(this.cmbBoxTeacher);
            this.Controls.Add(this.cmbBoxSpeciality);
            this.Controls.Add(this.cmbBoxCollege);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加班级";
            this.Load += new System.EventHandler(this.AddClass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPS;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtClassid;
        private System.Windows.Forms.Label labClass;
        private System.Windows.Forms.ComboBox cmbBoxTeacher;
        private System.Windows.Forms.ComboBox cmbBoxSpeciality;
        private System.Windows.Forms.ComboBox cmbBoxCollege;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}