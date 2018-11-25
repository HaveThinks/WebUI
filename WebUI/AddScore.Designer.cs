namespace WebUI
{
    partial class AddScore
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
            this.cmbBoxCollege = new System.Windows.Forms.ComboBox();
            this.cmbBoxSpeciality = new System.Windows.Forms.ComboBox();
            this.cmbBoxClass = new System.Windows.Forms.ComboBox();
            this.cmbBoxName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelStuID = new System.Windows.Forms.Label();
            this.gbSubjects = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbBoxCollege
            // 
            this.cmbBoxCollege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxCollege.FormattingEnabled = true;
            this.cmbBoxCollege.Location = new System.Drawing.Point(176, 28);
            this.cmbBoxCollege.Name = "cmbBoxCollege";
            this.cmbBoxCollege.Size = new System.Drawing.Size(255, 20);
            this.cmbBoxCollege.TabIndex = 0;
            this.cmbBoxCollege.SelectedIndexChanged += new System.EventHandler(this.cmbBoxCollege_SelectedIndexChanged);
            // 
            // cmbBoxSpeciality
            // 
            this.cmbBoxSpeciality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxSpeciality.FormattingEnabled = true;
            this.cmbBoxSpeciality.Location = new System.Drawing.Point(176, 91);
            this.cmbBoxSpeciality.Name = "cmbBoxSpeciality";
            this.cmbBoxSpeciality.Size = new System.Drawing.Size(255, 20);
            this.cmbBoxSpeciality.TabIndex = 1;
            this.cmbBoxSpeciality.SelectedIndexChanged += new System.EventHandler(this.cmbBoxSpeciality_SelectedIndexChanged);
            // 
            // cmbBoxClass
            // 
            this.cmbBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxClass.FormattingEnabled = true;
            this.cmbBoxClass.Location = new System.Drawing.Point(176, 151);
            this.cmbBoxClass.Name = "cmbBoxClass";
            this.cmbBoxClass.Size = new System.Drawing.Size(255, 20);
            this.cmbBoxClass.TabIndex = 2;
            this.cmbBoxClass.SelectedIndexChanged += new System.EventHandler(this.cmbBoxClass_SelectedIndexChanged);
            // 
            // cmbBoxName
            // 
            this.cmbBoxName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxName.FormattingEnabled = true;
            this.cmbBoxName.Location = new System.Drawing.Point(176, 213);
            this.cmbBoxName.Name = "cmbBoxName";
            this.cmbBoxName.Size = new System.Drawing.Size(121, 20);
            this.cmbBoxName.TabIndex = 3;
            this.cmbBoxName.SelectedIndexChanged += new System.EventHandler(this.cmbBoxName_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "学院：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "专业：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "班级：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "姓名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "学号：";
            // 
            // labelStuID
            // 
            this.labelStuID.AutoSize = true;
            this.labelStuID.Location = new System.Drawing.Point(409, 220);
            this.labelStuID.Name = "labelStuID";
            this.labelStuID.Size = new System.Drawing.Size(11, 12);
            this.labelStuID.TabIndex = 9;
            this.labelStuID.Text = "0";
            // 
            // gbSubjects
            // 
            this.gbSubjects.Location = new System.Drawing.Point(66, 249);
            this.gbSubjects.Name = "gbSubjects";
            this.gbSubjects.Size = new System.Drawing.Size(365, 325);
            this.gbSubjects.TabIndex = 10;
            this.gbSubjects.TabStop = false;
            this.gbSubjects.Text = "请输入各科成绩";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(66, 597);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "修改成绩";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(345, 597);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "提交成绩";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // AddScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(575, 654);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gbSubjects);
            this.Controls.Add(this.labelStuID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoxName);
            this.Controls.Add(this.cmbBoxClass);
            this.Controls.Add(this.cmbBoxSpeciality);
            this.Controls.Add(this.cmbBoxCollege);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加成绩";
            this.Load += new System.EventHandler(this.ClassesInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBoxCollege;
        private System.Windows.Forms.ComboBox cmbBoxSpeciality;
        private System.Windows.Forms.ComboBox cmbBoxClass;
        private System.Windows.Forms.ComboBox cmbBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelStuID;
        private System.Windows.Forms.GroupBox gbSubjects;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSubmit;
    }
}