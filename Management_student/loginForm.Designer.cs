namespace Management_student
{
    partial class loginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BoxUser = new System.Windows.Forms.TextBox();
            this.BoxPassword = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.managem_studentDataSet = new Management_student.managem_studentDataSet();
            this.student = new System.Windows.Forms.RadioButton();
            this.admin = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managem_studentDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14F);
            this.label1.Location = new System.Drawing.Point(121, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户：";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(170, 312);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 30);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "登录";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Location = new System.Drawing.Point(299, 312);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(75, 30);
            this.buttonQuit.TabIndex = 6;
            this.buttonQuit.Text = "取消";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14F);
            this.label2.Location = new System.Drawing.Point(121, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(151, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "学生成绩管理系统";
            // 
            // BoxUser
            // 
            this.BoxUser.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.BoxUser.Location = new System.Drawing.Point(206, 128);
            this.BoxUser.Multiline = true;
            this.BoxUser.Name = "BoxUser";
            this.BoxUser.Size = new System.Drawing.Size(168, 24);
            this.BoxUser.TabIndex = 1;
            // 
            // BoxPassword
            // 
            this.BoxPassword.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.BoxPassword.Location = new System.Drawing.Point(206, 168);
            this.BoxPassword.Multiline = true;
            this.BoxPassword.Name = "BoxPassword";
            this.BoxPassword.PasswordChar = '*';
            this.BoxPassword.Size = new System.Drawing.Size(168, 24);
            this.BoxPassword.TabIndex = 2;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.managem_studentDataSet;
            this.bindingSource1.Position = 0;
            // 
            // managem_studentDataSet
            // 
            this.managem_studentDataSet.DataSetName = "managem_studentDataSet";
            this.managem_studentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student
            // 
            this.student.AutoSize = true;
            this.student.Location = new System.Drawing.Point(170, 245);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(58, 19);
            this.student.TabIndex = 3;
            this.student.Text = "学生";
            this.student.UseVisualStyleBackColor = true;
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.Location = new System.Drawing.Point(299, 245);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(73, 19);
            this.admin.TabIndex = 4;
            this.admin.Text = "管理员";
            this.admin.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("黑体", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(185, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 7;
            // 
            // loginForm
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 376);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.student);
            this.Controls.Add(this.BoxPassword);
            this.Controls.Add(this.BoxUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.loginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managem_studentDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BoxUser;
        private System.Windows.Forms.TextBox BoxPassword;
        private System.Windows.Forms.BindingSource bindingSource1;
        private managem_studentDataSet managem_studentDataSet;
        private System.Windows.Forms.RadioButton student;
        private System.Windows.Forms.RadioButton admin;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
    }
}

