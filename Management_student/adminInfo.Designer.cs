namespace Management_student
{
    partial class adminInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminInfo));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.成绩查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩分析ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gruopBox1 = new System.Windows.Forms.GroupBox();
            this.searchAll = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_stuID = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.radioButton_email = new System.Windows.Forms.RadioButton();
            this.radioButton_stuID = new System.Windows.Forms.RadioButton();
            this.radioButton_name = new System.Windows.Forms.RadioButton();
            this.managem_studentDataSet = new Management_student.managem_studentDataSet();
            this.managemstudentDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listViewInfo = new System.Windows.Forms.ListView();
            this.姓名 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.学号 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.班级 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.性别 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.邮箱 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.课程1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.课程2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.课程3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gruopBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.managem_studentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managemstudentDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.成绩查询ToolStripMenuItem,
            this.成绩修改ToolStripMenuItem,
            this.成绩添加ToolStripMenuItem,
            this.成绩删除ToolStripMenuItem,
            this.成绩分析ToolStripMenuItem,
            this.修改密码ToolStripMenuItem,
            this.退出登录ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 成绩查询ToolStripMenuItem
            // 
            this.成绩查询ToolStripMenuItem.Name = "成绩查询ToolStripMenuItem";
            this.成绩查询ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.成绩查询ToolStripMenuItem.Text = "成绩查询";
            // 
            // 成绩修改ToolStripMenuItem
            // 
            this.成绩修改ToolStripMenuItem.Name = "成绩修改ToolStripMenuItem";
            this.成绩修改ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.成绩修改ToolStripMenuItem.Text = "成绩修改";
            this.成绩修改ToolStripMenuItem.Click += new System.EventHandler(this.成绩修改ToolStripMenuItem_Click);
            // 
            // 成绩添加ToolStripMenuItem
            // 
            this.成绩添加ToolStripMenuItem.Name = "成绩添加ToolStripMenuItem";
            this.成绩添加ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.成绩添加ToolStripMenuItem.Text = "成绩添加";
            this.成绩添加ToolStripMenuItem.Click += new System.EventHandler(this.成绩添加ToolStripMenuItem_Click);
            // 
            // 成绩删除ToolStripMenuItem
            // 
            this.成绩删除ToolStripMenuItem.Name = "成绩删除ToolStripMenuItem";
            this.成绩删除ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.成绩删除ToolStripMenuItem.Text = "成绩删除";
            this.成绩删除ToolStripMenuItem.Click += new System.EventHandler(this.成绩删除ToolStripMenuItem_Click);
            // 
            // 成绩分析ToolStripMenuItem
            // 
            this.成绩分析ToolStripMenuItem.Name = "成绩分析ToolStripMenuItem";
            this.成绩分析ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.成绩分析ToolStripMenuItem.Text = "成绩分析";
            this.成绩分析ToolStripMenuItem.Click += new System.EventHandler(this.成绩分析ToolStripMenuItem_Click);
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // 退出登录ToolStripMenuItem
            // 
            this.退出登录ToolStripMenuItem.Name = "退出登录ToolStripMenuItem";
            this.退出登录ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.退出登录ToolStripMenuItem.Text = "退出登录";
            this.退出登录ToolStripMenuItem.Click += new System.EventHandler(this.退出登录ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // gruopBox1
            // 
            this.gruopBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gruopBox1.Controls.Add(this.searchAll);
            this.gruopBox1.Controls.Add(this.search);
            this.gruopBox1.Controls.Add(this.textBox_email);
            this.gruopBox1.Controls.Add(this.textBox_stuID);
            this.gruopBox1.Controls.Add(this.textBox_name);
            this.gruopBox1.Controls.Add(this.radioButton_email);
            this.gruopBox1.Controls.Add(this.radioButton_stuID);
            this.gruopBox1.Controls.Add(this.radioButton_name);
            this.gruopBox1.Location = new System.Drawing.Point(12, 57);
            this.gruopBox1.Name = "gruopBox1";
            this.gruopBox1.Size = new System.Drawing.Size(895, 200);
            this.gruopBox1.TabIndex = 2;
            this.gruopBox1.TabStop = false;
            this.gruopBox1.Text = "信息查询";
            // 
            // searchAll
            // 
            this.searchAll.Location = new System.Drawing.Point(725, 84);
            this.searchAll.Name = "searchAll";
            this.searchAll.Size = new System.Drawing.Size(91, 33);
            this.searchAll.TabIndex = 7;
            this.searchAll.Text = "查询所有";
            this.searchAll.UseVisualStyleBackColor = true;
            this.searchAll.Click += new System.EventHandler(this.searchAll_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(617, 84);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 33);
            this.search.TabIndex = 6;
            this.search.Text = "查询";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // textBox_email
            // 
            this.textBox_email.Enabled = false;
            this.textBox_email.Location = new System.Drawing.Point(262, 139);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(216, 25);
            this.textBox_email.TabIndex = 5;
            // 
            // textBox_stuID
            // 
            this.textBox_stuID.Enabled = false;
            this.textBox_stuID.Location = new System.Drawing.Point(262, 87);
            this.textBox_stuID.Name = "textBox_stuID";
            this.textBox_stuID.Size = new System.Drawing.Size(216, 25);
            this.textBox_stuID.TabIndex = 4;
            // 
            // textBox_name
            // 
            this.textBox_name.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.textBox_name.Location = new System.Drawing.Point(262, 35);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(216, 25);
            this.textBox_name.TabIndex = 3;
            // 
            // radioButton_email
            // 
            this.radioButton_email.AutoSize = true;
            this.radioButton_email.Location = new System.Drawing.Point(96, 143);
            this.radioButton_email.Name = "radioButton_email";
            this.radioButton_email.Size = new System.Drawing.Size(73, 19);
            this.radioButton_email.TabIndex = 2;
            this.radioButton_email.Text = "邮箱：";
            this.radioButton_email.UseVisualStyleBackColor = true;
            this.radioButton_email.CheckedChanged += new System.EventHandler(this.radioButton_email_CheckedChanged);
            // 
            // radioButton_stuID
            // 
            this.radioButton_stuID.AutoSize = true;
            this.radioButton_stuID.Location = new System.Drawing.Point(96, 91);
            this.radioButton_stuID.Name = "radioButton_stuID";
            this.radioButton_stuID.Size = new System.Drawing.Size(73, 19);
            this.radioButton_stuID.TabIndex = 1;
            this.radioButton_stuID.TabStop = true;
            this.radioButton_stuID.Text = "学号：";
            this.radioButton_stuID.UseVisualStyleBackColor = true;
            this.radioButton_stuID.CheckedChanged += new System.EventHandler(this.radioButton_stuID_CheckedChanged);
            // 
            // radioButton_name
            // 
            this.radioButton_name.AutoSize = true;
            this.radioButton_name.Checked = true;
            this.radioButton_name.Location = new System.Drawing.Point(96, 39);
            this.radioButton_name.Name = "radioButton_name";
            this.radioButton_name.Size = new System.Drawing.Size(73, 19);
            this.radioButton_name.TabIndex = 0;
            this.radioButton_name.TabStop = true;
            this.radioButton_name.Text = "姓名：";
            this.radioButton_name.UseVisualStyleBackColor = true;
            this.radioButton_name.CheckedChanged += new System.EventHandler(this.radioButton_name_CheckedChanged);
            // 
            // managem_studentDataSet
            // 
            this.managem_studentDataSet.DataSetName = "managem_studentDataSet";
            this.managem_studentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // managemstudentDataSetBindingSource
            // 
            this.managemstudentDataSetBindingSource.DataSource = this.managem_studentDataSet;
            this.managemstudentDataSetBindingSource.Position = 0;
            // 
            // listViewInfo
            // 
            this.listViewInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.姓名,
            this.学号,
            this.班级,
            this.性别,
            this.邮箱,
            this.课程1,
            this.课程2,
            this.课程3});
            this.listViewInfo.Location = new System.Drawing.Point(12, 272);
            this.listViewInfo.Name = "listViewInfo";
            this.listViewInfo.Size = new System.Drawing.Size(895, 415);
            this.listViewInfo.TabIndex = 3;
            this.listViewInfo.UseCompatibleStateImageBehavior = false;
            this.listViewInfo.View = System.Windows.Forms.View.Details;
            // 
            // 姓名
            // 
            this.姓名.Text = "姓名";
            this.姓名.Width = 89;
            // 
            // 学号
            // 
            this.学号.Text = "学号";
            this.学号.Width = 86;
            // 
            // 班级
            // 
            this.班级.Text = "班级";
            this.班级.Width = 96;
            // 
            // 性别
            // 
            this.性别.Text = "性别";
            this.性别.Width = 97;
            // 
            // 邮箱
            // 
            this.邮箱.Text = "邮箱";
            this.邮箱.Width = 117;
            // 
            // 课程1
            // 
            this.课程1.Text = "语文";
            this.课程1.Width = 108;
            // 
            // 课程2
            // 
            this.课程2.Text = "数学";
            this.课程2.Width = 113;
            // 
            // 课程3
            // 
            this.课程3.Text = "英语";
            this.课程3.Width = 101;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column9,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(12, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(895, 415);
            this.dataGridView1.TabIndex = 4;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "ID";
            this.Column8.HeaderText = "序号";
            this.Column8.Name = "Column8";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "name";
            this.Column1.HeaderText = "姓名";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "studentID";
            this.Column2.HeaderText = "学号";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "class";
            this.Column3.HeaderText = "班级";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "sex";
            this.Column4.HeaderText = "性别";
            this.Column4.Name = "Column4";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "email";
            this.Column9.HeaderText = "邮箱";
            this.Column9.Name = "Column9";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "courseOne";
            this.Column5.HeaderText = "语文";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "courseTwo";
            this.Column6.HeaderText = "数学";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "courseThree";
            this.Column7.HeaderText = "英语";
            this.Column7.Name = "Column7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 11F);
            this.label1.Location = new System.Drawing.Point(737, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 5;
            // 
            // adminInfo
            // 
            this.AcceptButton = this.search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 699);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listViewInfo);
            this.Controls.Add(this.gruopBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "adminInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员信息";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gruopBox1.ResumeLayout(false);
            this.gruopBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.managem_studentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managemstudentDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 成绩查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩分析ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.GroupBox gruopBox1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_stuID;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.RadioButton radioButton_email;
        private System.Windows.Forms.RadioButton radioButton_stuID;
        private System.Windows.Forms.RadioButton radioButton_name;
        private System.Windows.Forms.BindingSource managemstudentDataSetBindingSource;
        private managem_studentDataSet managem_studentDataSet;
        private System.Windows.Forms.ListView listViewInfo;
        private System.Windows.Forms.ColumnHeader 姓名;
        private System.Windows.Forms.ColumnHeader 学号;
        private System.Windows.Forms.ColumnHeader 班级;
        private System.Windows.Forms.ColumnHeader 性别;
        private System.Windows.Forms.ColumnHeader 邮箱;
        private System.Windows.Forms.ColumnHeader 课程1;
        private System.Windows.Forms.ColumnHeader 课程2;
        private System.Windows.Forms.ColumnHeader 课程3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button searchAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}