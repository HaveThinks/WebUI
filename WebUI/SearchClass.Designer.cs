namespace WebUI
{
    partial class SearchClass
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBoxTeacher = new System.Windows.Forms.ComboBox();
            this.cmbBoxClass = new System.Windows.Forms.ComboBox();
            this.cmbBoxSpeciality = new System.Windows.Forms.ComboBox();
            this.cmbBoxCollege = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(696, 206);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(583, 171);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbBoxTeacher);
            this.groupBox1.Controls.Add(this.cmbBoxClass);
            this.groupBox1.Controls.Add(this.cmbBoxSpeciality);
            this.groupBox1.Controls.Add(this.cmbBoxCollege);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 219);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // cmbBoxTeacher
            // 
            this.cmbBoxTeacher.FormattingEnabled = true;
            this.cmbBoxTeacher.Location = new System.Drawing.Point(220, 178);
            this.cmbBoxTeacher.Name = "cmbBoxTeacher";
            this.cmbBoxTeacher.Size = new System.Drawing.Size(252, 20);
            this.cmbBoxTeacher.TabIndex = 17;
            // 
            // cmbBoxClass
            // 
            this.cmbBoxClass.FormattingEnabled = true;
            this.cmbBoxClass.Location = new System.Drawing.Point(220, 123);
            this.cmbBoxClass.Name = "cmbBoxClass";
            this.cmbBoxClass.Size = new System.Drawing.Size(252, 20);
            this.cmbBoxClass.TabIndex = 16;
            // 
            // cmbBoxSpeciality
            // 
            this.cmbBoxSpeciality.FormattingEnabled = true;
            this.cmbBoxSpeciality.Location = new System.Drawing.Point(220, 70);
            this.cmbBoxSpeciality.Name = "cmbBoxSpeciality";
            this.cmbBoxSpeciality.Size = new System.Drawing.Size(252, 20);
            this.cmbBoxSpeciality.TabIndex = 15;
            this.cmbBoxSpeciality.SelectedIndexChanged += new System.EventHandler(this.cmbBoxSpeciality_SelectedIndexChanged);
            // 
            // cmbBoxCollege
            // 
            this.cmbBoxCollege.FormattingEnabled = true;
            this.cmbBoxCollege.Location = new System.Drawing.Point(220, 19);
            this.cmbBoxCollege.Name = "cmbBoxCollege";
            this.cmbBoxCollege.Size = new System.Drawing.Size(252, 20);
            this.cmbBoxCollege.TabIndex = 14;
            this.cmbBoxCollege.SelectedIndexChanged += new System.EventHandler(this.cmbBoxCollege_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "班主任：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "班级：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "专业：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "学院：";
            // 
            // SearchClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 485);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "班级查询信息";
            this.Load += new System.EventHandler(this.SearchClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbBoxTeacher;
        private System.Windows.Forms.ComboBox cmbBoxClass;
        private System.Windows.Forms.ComboBox cmbBoxSpeciality;
        private System.Windows.Forms.ComboBox cmbBoxCollege;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}