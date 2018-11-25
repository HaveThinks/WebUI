namespace WebUI
{
    partial class Subject
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labSubject = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labSubject
            // 
            this.labSubject.AutoSize = true;
            this.labSubject.Location = new System.Drawing.Point(23, 36);
            this.labSubject.Name = "labSubject";
            this.labSubject.Size = new System.Drawing.Size(65, 12);
            this.labSubject.TabIndex = 0;
            this.labSubject.Text = "科目名称：";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(116, 33);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 21);
            this.txtScore.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(258, 36);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(29, 12);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "修改";
            // 
            // Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.labSubject);
            this.Name = "Subject";
            this.Size = new System.Drawing.Size(344, 76);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.Label labSubject;
        public System.Windows.Forms.TextBox txtScore;
    }
}
