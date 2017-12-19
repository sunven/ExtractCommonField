namespace ExtractCommonField
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.btnSelFile = new System.Windows.Forms.Button();
            this.btnSelDirectory = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(12, 12);
            this.txtClassName.Multiline = true;
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(260, 42);
            this.txtClassName.TabIndex = 0;
            this.txtClassName.Text = "CqBankXdbAssessmentResult1,CqBankXdbAssessmentResult2,CqBankXdbAssessmentResult3," +
    "CqBankXdbAssessmentResult4";
            // 
            // btnSelFile
            // 
            this.btnSelFile.Location = new System.Drawing.Point(12, 60);
            this.btnSelFile.Name = "btnSelFile";
            this.btnSelFile.Size = new System.Drawing.Size(120, 23);
            this.btnSelFile.TabIndex = 1;
            this.btnSelFile.Text = "选择文件";
            this.btnSelFile.UseVisualStyleBackColor = true;
            this.btnSelFile.Click += new System.EventHandler(this.btnSelFile_Click);
            // 
            // btnSelDirectory
            // 
            this.btnSelDirectory.Location = new System.Drawing.Point(152, 60);
            this.btnSelDirectory.Name = "btnSelDirectory";
            this.btnSelDirectory.Size = new System.Drawing.Size(120, 23);
            this.btnSelDirectory.TabIndex = 2;
            this.btnSelDirectory.Text = "选择目录";
            this.btnSelDirectory.UseVisualStyleBackColor = true;
            this.btnSelDirectory.Click += new System.EventHandler(this.btnSelDirectory_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(13, 90);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(259, 159);
            this.txtResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnSelDirectory);
            this.Controls.Add(this.btnSelFile);
            this.Controls.Add(this.txtClassName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "提取公共字段";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Button btnSelFile;
        private System.Windows.Forms.Button btnSelDirectory;
        private System.Windows.Forms.TextBox txtResult;
    }
}

