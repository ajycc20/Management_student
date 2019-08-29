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
    public partial class studentInfo : Form
    {
        loginForm Form1 = null;
        public studentInfo(loginForm Form2)
        {
            this.Form1 = Form2;
            InitializeComponent();
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.Close();
        }

        private void radioButton_name_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton_name.Checked == true)
            {
                textBox_name.Enabled = true;
                textBox_name.ReadOnly = false;
            }
            else
            {
                textBox_name.Enabled = false;
                textBox_name.ReadOnly = true;
            }        
        }

        private void radioButton_stuID_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton_stuID.Checked == true)
            {
                textBox_stuID.Enabled = true;
                textBox_stuID.ReadOnly = false;
            }
            else
            {
                textBox_stuID.Enabled = false;
                textBox_stuID.ReadOnly = true;

            }

        }

        private void radioButton_email_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton_email.Checked == true)
            {
                textBox_email.Enabled = true;
                textBox_email.ReadOnly = false;

            }
            else
            {
                textBox_email.Enabled = false;
                textBox_email.ReadOnly = true;
            }

        }

        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Management_student Version 1.0.0\nCreate by Group一百昏\nCopyright ©  2018");
        }

        private void search_Click(object sender, EventArgs e)
        {
            string checkInfo = "";
            string strConnection = "Provider = Microsoft.Jet.OLEDB.4.0;";
            strConnection += @"Data Source=" + Application.StartupPath + "\\managem_student.mdb";
            OleDbConnection objConnection = new OleDbConnection(strConnection);
            objConnection.Open();
            OleDbCommand objCommand = new OleDbCommand("select * from information", objConnection);
            OleDbDataReader reader = objCommand.ExecuteReader();
            DataSet ds = new DataSet();
            OleDbDataAdapter sda = new OleDbDataAdapter("select * from information", objConnection);
            sda.Fill(ds, "information");
            
            if (radioButton_name.Checked)
            {
                checkInfo = textBox_name.Text;
            }
            else if(radioButton_stuID.Checked)
            {
                checkInfo = textBox_stuID.Text;
            }
            else if(radioButton_email.Checked)
            {
                checkInfo = textBox_email.Text;
            }
                //根据checkInfo显示学生信息
            if(checkInfo.Length == 0 || checkInfo.Trim() == string.Empty)
            {
                MessageBox.Show("请输入查询信息！");
            }
            else if(reader["name"].ToString() != checkInfo ||
                    reader["studentID"].ToString() != checkInfo ||
                    reader["email"].ToString() != checkInfo)
            {
                MessageBox.Show("请输入正确信息！");
            }
            else
            {
                this.listViewInfo.Items.Clear();
                //添加列标题

                while (reader.Read())
                {
                    if (reader["name"].ToString().Equals(checkInfo) ||
                    reader["studentID"].ToString().Equals(checkInfo) ||
                    reader["email"].ToString().Equals(checkInfo))
                    {
                        ListViewItem lvi = new ListViewItem();

                        lvi.Text = reader["ID"].ToString();
                        lvi.SubItems.Add(reader["name"].ToString());
                        lvi.SubItems.Add(reader["studentID"].ToString());
                        lvi.SubItems.Add(reader["class"].ToString());
                        lvi.SubItems.Add(reader["sex"].ToString());
                        lvi.SubItems.Add(reader["email"].ToString());
                        lvi.SubItems.Add(reader["courseOne"].ToString());
                        lvi.SubItems.Add(reader["courseTwo"].ToString());
                        lvi.SubItems.Add(reader["courseThree"].ToString());
                        this.listViewInfo.Items.Add(lvi);
                    }
                }
            }
            
            //close reader
            reader.Close();
            objConnection.Close();
        }


        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeStuPsd Form = new changeStuPsd();
            Form.Show();
        }

        private void 无成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请确认是否未参加考试！");
        }

        private void 用户信息错误ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请联系管理员！");
        }

        private void 成绩错误ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请联系老师！");
        }
    }
}
