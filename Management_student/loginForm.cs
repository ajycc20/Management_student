using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Management_student
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //判断登录状态并弹出对应提示框
            if((BoxUser.Text.Trim()==string.Empty)||(BoxPassword.Text.Trim()==string.Empty))
            {
                MessageBox.Show("请输入用户名或密码");
            }
            else
            {
                if(this.student.Checked==true) // 学生登录
                {
                    string user = BoxUser.Text;
                    string password = BoxPassword.Text;
                    string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;";

                    //string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\bin\\Debug\\managem_student.mdb";

                    strConnection += @"Data Source=" + Application.StartupPath + "\\managem_student.mdb";

                    OleDbConnection objConnection = new OleDbConnection(strConnection);
                    objConnection.Open();
                    OleDbCommand objCommand = new OleDbCommand("select * from student", objConnection);
                    DataSet ds = new DataSet();
                    OleDbDataAdapter sda = new OleDbDataAdapter("select * from student", objConnection);
                    sda.Fill(ds, "student");
                    OleDbDataReader reader = objCommand.ExecuteReader();
                    int i;
                    for(i = 0; i < ds.Tables["student"].Rows.Count; i++)
                    {
                        reader.Read();
                        if (reader["username"].Equals(user) && reader["password"].Equals(password))
                        {
                            this.DialogResult = DialogResult.OK;
                            studentInfo Form2 = new studentInfo(this);
                            Form2.Show();
                            this.Hide();
                            break;
                        }
                    }
                    if (i == ds.Tables["student"].Rows.Count)
                        MessageBox.Show("用户名或者密码输入有误！");
                    //关闭Reader
                    reader.Close();
                    objConnection.Close();
                    

                }
                else if(this.admin.Checked==true)  //管理员
                {
                    string user = BoxUser.Text;
                    string password = BoxPassword.Text;
                    string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;";
                    strConnection += @"Data Source=" + Application.StartupPath + "\\managem_student.mdb";
                    OleDbConnection objConnection = new OleDbConnection(strConnection);
                    objConnection.Open();
                    OleDbCommand objCommand = new OleDbCommand("select * from admin", objConnection);
                    DataSet ds = new DataSet();
                    OleDbDataAdapter sda = new OleDbDataAdapter("select * from admin", objConnection);
                    sda.Fill(ds, "admin");
                    OleDbDataReader reader = objCommand.ExecuteReader();
                    int i;
                    for (i = 0; i < ds.Tables["admin"].Rows.Count; i++)
                    {
                        reader.Read();
                        if (reader["username"].Equals(user) && reader["password"].Equals(password))
                        {
                            this.DialogResult = DialogResult.OK;
                            adminInfo Form4 = new adminInfo(this);
                            Form4.Show();
                            this.Hide();
                            break;
                        }
                    }
                    if (i == ds.Tables["admin"].Rows.Count)
                        MessageBox.Show("用户名或者密码输入有误！");
                    //关闭Reader
                    reader.Close();
                    objConnection.Close();
                }
            }
        }
        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = System.DateTime.Now;
            label4.Text = dt.ToString();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
