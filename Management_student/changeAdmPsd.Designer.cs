namespace Management_student
{
    partial class changeAdmPsd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changeAdmPsd));
            this.cancel = new System.Windows.Forms.Button();
            this.certain = new System.Windows.Forms.Button();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.oldPassword = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.laber3 = new System.Windows.Forms.Label();
            this.laber1 = new System.Windows.Forms.Label();
            this.laber2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(215, 355);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 33);
            this.cancel.TabIndex = 15;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // certain
            // 
            this.certain.Location = new System.Drawing.Point(74, 355);
            this.certain.Name = "certain";
            this.certain.Size = new System.Drawing.Size(75, 33);
            this.certain.TabIndex = 14;
            this.certain.Text = "确定";
            this.certain.UseVisualStyleBackColor = true;
            this.certain.Click += new System.EventHandler(this.certain_Click);
            // 
            // newPassword
            // 
            this.newPassword.Location = new System.Drawing.Point(173, 281);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(117, 25);
            this.newPassword.TabIndex = 13;
            // 
            // oldPassword
            // 
            this.oldPassword.Location = new System.Drawing.Point(173, 172);
            this.oldPassword.Name = "oldPassword";
            this.oldPassword.Size = new System.Drawing.Size(117, 25);
            this.oldPassword.TabIndex = 12;
            // 
            // username
            // 
            this.username.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.username.Location = new System.Drawing.Point(173, 63);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(117, 25);
            this.username.TabIndex = 11;
            // 
            // laber3
            // 
            this.laber3.AutoSize = true;
            this.laber3.Font = new System.Drawing.Font("宋体", 12F);
            this.laber3.Location = new System.Drawing.Point(60, 286);
            this.laber3.Name = "laber3";
            this.laber3.Size = new System.Drawing.Size(89, 20);
            this.laber3.TabIndex = 10;
            this.laber3.Text = "新密码：";
            // 
            // laber1
            // 
            this.laber1.AutoSize = true;
            this.laber1.Font = new System.Drawing.Font("宋体", 12F);
            this.laber1.Location = new System.Drawing.Point(60, 68);
            this.laber1.Name = "laber1";
            this.laber1.Size = new System.Drawing.Size(89, 20);
            this.laber1.TabIndex = 9;
            this.laber1.Text = "用户名：";
            // 
            // laber2
            // 
            this.laber2.AutoSize = true;
            this.laber2.Font = new System.Drawing.Font("宋体", 12F);
            this.laber2.Location = new System.Drawing.Point(60, 177);
            this.laber2.Name = "laber2";
            this.laber2.Size = new System.Drawing.Size(89, 20);
            this.laber2.TabIndex = 8;
            this.laber2.Text = "原密码：";
            // 
            // changeAdmPsd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 424);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.certain);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.oldPassword);
            this.Controls.Add(this.username);
            this.Controls.Add(this.laber3);
            this.Controls.Add(this.laber1);
            this.Controls.Add(this.laber2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "changeAdmPsd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button certain;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.TextBox oldPassword;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label laber3;
        private System.Windows.Forms.Label laber1;
        private System.Windows.Forms.Label laber2;
    }
}