namespace WebUI
{
    partial class OrderScore
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
            this.dgvScore = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSearBySpec = new System.Windows.Forms.Button();
            this.cbScoreBySpec = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBoxSpeciality = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBoxSubject = new System.Windows.Forms.ComboBox();
            this.cmbBoxCollege = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSearBySpec1 = new System.Windows.Forms.Button();
            this.cbScoreByClass = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbBoxSubjects = new System.Windows.Forms.ComboBox();
            this.cmbBoxClass = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScore)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvScore
            // 
            this.dgvScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScore.Location = new System.Drawing.Point(12, 1);
            this.dgvScore.Name = "dgvScore";
            this.dgvScore.RowTemplate.Height = 23;
            this.dgvScore.Size = new System.Drawing.Size(734, 245);
            this.dgvScore.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(5, 286);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(755, 197);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSearBySpec);
            this.tabPage1.Controls.Add(this.cbScoreBySpec);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cmbBoxSpeciality);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cmbBoxSubject);
            this.tabPage1.Controls.Add(this.cmbBoxCollege);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(747, 171);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "按专业查询";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSearBySpec
            // 
            this.btnSearBySpec.Location = new System.Drawing.Point(607, 105);
            this.btnSearBySpec.Name = "btnSearBySpec";
            this.btnSearBySpec.Size = new System.Drawing.Size(75, 23);
            this.btnSearBySpec.TabIndex = 8;
            this.btnSearBySpec.Text = "查询";
            this.btnSearBySpec.UseVisualStyleBackColor = true;
            this.btnSearBySpec.Click += new System.EventHandler(this.btnSearBySpec_Click);
            // 
            // cbScoreBySpec
            // 
            this.cbScoreBySpec.AutoSize = true;
            this.cbScoreBySpec.Location = new System.Drawing.Point(507, 104);
            this.cbScoreBySpec.Name = "cbScoreBySpec";
            this.cbScoreBySpec.Size = new System.Drawing.Size(15, 14);
            this.cbScoreBySpec.TabIndex = 7;
            this.cbScoreBySpec.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "按总成绩排名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "专    业：";
            // 
            // cmbBoxSpeciality
            // 
            this.cmbBoxSpeciality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxSpeciality.FormattingEnabled = true;
            this.cmbBoxSpeciality.Location = new System.Drawing.Point(479, 45);
            this.cmbBoxSpeciality.Name = "cmbBoxSpeciality";
            this.cmbBoxSpeciality.Size = new System.Drawing.Size(203, 20);
            this.cmbBoxSpeciality.TabIndex = 4;
            this.cmbBoxSpeciality.SelectedIndexChanged += new System.EventHandler(this.cmbBoxSpeciality_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "按单科排名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "学      院：";
            // 
            // cmbBoxSubject
            // 
            this.cmbBoxSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxSubject.FormattingEnabled = true;
            this.cmbBoxSubject.Location = new System.Drawing.Point(145, 104);
            this.cmbBoxSubject.Name = "cmbBoxSubject";
            this.cmbBoxSubject.Size = new System.Drawing.Size(203, 20);
            this.cmbBoxSubject.TabIndex = 1;
            this.cmbBoxSubject.SelectedIndexChanged += new System.EventHandler(this.cmbBoxSubject_SelectedIndexChanged);
            // 
            // cmbBoxCollege
            // 
            this.cmbBoxCollege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxCollege.FormattingEnabled = true;
            this.cmbBoxCollege.Location = new System.Drawing.Point(145, 45);
            this.cmbBoxCollege.Name = "cmbBoxCollege";
            this.cmbBoxCollege.Size = new System.Drawing.Size(203, 20);
            this.cmbBoxCollege.TabIndex = 0;
            this.cmbBoxCollege.SelectedIndexChanged += new System.EventHandler(this.cmbBoxCollege_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSearBySpec1);
            this.tabPage2.Controls.Add(this.cbScoreByClass);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.cmbBoxSubjects);
            this.tabPage2.Controls.Add(this.cmbBoxClass);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(747, 171);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "按班级查询";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.ContextMenuStripChanged += new System.EventHandler(this.cmbBoxClass_SelectedIndexChanged);
            // 
            // btnSearBySpec1
            // 
            this.btnSearBySpec1.Location = new System.Drawing.Point(617, 104);
            this.btnSearBySpec1.Name = "btnSearBySpec1";
            this.btnSearBySpec1.Size = new System.Drawing.Size(75, 23);
            this.btnSearBySpec1.TabIndex = 17;
            this.btnSearBySpec1.Text = "查询";
            this.btnSearBySpec1.UseVisualStyleBackColor = true;
            this.btnSearBySpec1.Click += new System.EventHandler(this.btnSearBySpec1_Click);
            // 
            // cbScoreByClass
            // 
            this.cbScoreByClass.AutoSize = true;
            this.cbScoreByClass.Location = new System.Drawing.Point(517, 103);
            this.cbScoreByClass.Name = "cbScoreByClass";
            this.cbScoreByClass.Size = new System.Drawing.Size(15, 14);
            this.cbScoreByClass.TabIndex = 16;
            this.cbScoreByClass.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "按总成绩排名：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "按单科排名：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "班  级：";
            // 
            // cmbBoxSubjects
            // 
            this.cmbBoxSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxSubjects.FormattingEnabled = true;
            this.cmbBoxSubjects.Location = new System.Drawing.Point(155, 103);
            this.cmbBoxSubjects.Name = "cmbBoxSubjects";
            this.cmbBoxSubjects.Size = new System.Drawing.Size(203, 20);
            this.cmbBoxSubjects.TabIndex = 10;
            // 
            // cmbBoxClass
            // 
            this.cmbBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxClass.FormattingEnabled = true;
            this.cmbBoxClass.Location = new System.Drawing.Point(155, 44);
            this.cmbBoxClass.Name = "cmbBoxClass";
            this.cmbBoxClass.Size = new System.Drawing.Size(203, 20);
            this.cmbBoxClass.TabIndex = 9;
            this.cmbBoxClass.SelectedIndexChanged += new System.EventHandler(this.cmbBoxClass_SelectedIndexChanged);
            // 
            // OrderScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 480);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dgvScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "成绩查询";
            this.Load += new System.EventHandler(this.OrderScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScore)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvScore;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox cbScoreBySpec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBoxSpeciality;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBoxSubject;
        private System.Windows.Forms.ComboBox cmbBoxCollege;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSearBySpec;
        private System.Windows.Forms.Button btnSearBySpec1;
        private System.Windows.Forms.CheckBox cbScoreByClass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbBoxSubjects;
        private System.Windows.Forms.ComboBox cmbBoxClass;
    }
}