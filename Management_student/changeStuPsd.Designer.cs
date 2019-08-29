namespace Management_student
{
    partial class changeStuPsd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changeStuPsd));
            this.laber2 = new System.Windows.Forms.Label();
            this.laber1 = new System.Windows.Forms.Label();
            this.laber3 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.oldPassword = new System.Windows.Forms.TextBox();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.certain = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // laber2
            // 
            this.laber2.AutoSize = true;
            this.laber2.Font = new System.Drawing.Font("宋体", 12F);
            this.laber2.Location = new System.Drawing.Point(59, 180);
            this.laber2.Name = "laber2";
            this.laber2.Size = new System.Drawing.Size(89, 20);
            this.laber2.TabIndex = 0;
            this.laber2.Text = "原密码：";
            // 
            // laber1
            // 
            this.laber1.AutoSize = true;
            this.laber1.Font = new System.Drawing.Font("宋体", 12F);
            this.laber1.Location = new System.Drawing.Point(59, 71);
            this.laber1.Name = "laber1";
            this.laber1.Size = new System.Drawing.Size(89, 20);
            this.laber1.TabIndex = 1;
            this.laber1.Text = "用户名：";
            // 
            // laber3
            // 
            this.laber3.AutoSize = true;
            this.laber3.Font = new System.Drawing.Font("宋体", 12F);
            this.laber3.Location = new System.Drawing.Point(59, 289);
            this.laber3.Name = "laber3";
            this.laber3.Size = new System.Drawing.Size(89, 20);
            this.laber3.TabIndex = 2;
            this.laber3.Text = "新密码：";
            // 
            // username
            // 
            this.username.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.username.Location = new System.Drawing.Point(172, 66);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(117, 25);
            this.username.TabIndex = 3;
            // 
            // oldPassword
            // 
            this.oldPassword.Location = new System.Drawing.Point(172, 175);
            this.oldPassword.Name = "oldPassword";
            this.oldPassword.Size = new System.Drawing.Size(117, 25);
            this.oldPassword.TabIndex = 4;
            // 
            // newPassword
            // 
            this.newPassword.Location = new System.Drawing.Point(172, 284);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(117, 25);
            this.newPassword.TabIndex = 5;
            // 
            // certain
            // 
            this.certain.Location = new System.Drawing.Point(73, 358);
            this.certain.Name = "certain";
            this.certain.Size = new System.Drawing.Size(75, 33);
            this.certain.TabIndex = 6;
            this.certain.Text = "确定";
            this.certain.UseVisualStyleBackColor = true;
            this.certain.Click += new System.EventHandler(this.certain_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(214, 358);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 33);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // changeStuPsd
            // 
            this.AcceptButton = this.certain;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "changeStuPsd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laber2;
        private System.Windows.Forms.Label laber1;
        private System.Windows.Forms.Label laber3;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox oldPassword;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.Button certain;
        private System.Windows.Forms.Button cancel;
    }
}