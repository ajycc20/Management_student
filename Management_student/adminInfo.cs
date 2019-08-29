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
    public partial class adminInfo : Form
    {
        loginForm Form1 = null;
        public adminInfo(loginForm Form4)
        {
            this.Form1 = Form4;
            InitializeComponent();
        }


        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.Close();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Management_student Version 1.0.0\nCreate by Group一百昏\nCopyright ©  2018");
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("无。。。");
        }

        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeAdmPsd Form = new changeAdmPsd();
            Form.Show();
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

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                string checkInfo = "";
                string strConnection = "Provider = Microsoft.Jet.OLEDB.4.0;";
                strConnection += @"Data Source=" + Application.StartupPath + "\\managem_student.mdb";
                OleDbConnection objConnection = new OleDbConnection(strConnection);
                objConnection.Open();
                OleDbCommand objCommand = new OleDbCommand("select * from information", objConnection);
                DataSet ds = new DataSet();
                OleDbDataAdapter sda = new OleDbDataAdapter("select * from information", objConnection);
                sda.Fill(ds, "information");
                OleDbDataReader reader = objCommand.ExecuteReader();
                if (radioButton_name.Checked)
                {
                    checkInfo = textBox_name.Text;
                }
                else if (radioButton_stuID.Checked)
                {
                    checkInfo = textBox_stuID.Text;
                }
                else if (radioButton_email.Checked)
                {
                    checkInfo = textBox_email.Text;
                }

                listViewInfo.Visible = true;
                dataGridView1.Visible = false;
                this.listViewInfo.Items.Clear();
                while (reader.Read())
                {
                    if (reader["name"].ToString().Equals(checkInfo) || reader["studentID"].ToString().Equals(checkInfo) || reader["email"].ToString().Equals(checkInfo))
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = reader["name"].ToString();
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

                //close reader
                reader.Close();
                objConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }
        private void searchAll_Click(object sender, EventArgs e)
        {
            string strConnection = "Provider = Microsoft.Jet.OLEDB.4.0;";
            strConnection += @"Data Source=" + Application.StartupPath + "\\managem_student.mdb";
            OleDbConnection objConnection = new OleDbConnection(strConnection);
            objConnection.Open();
            OleDbCommand objCommand = new OleDbCommand("select * from information", objConnection);
            DataSet ds = new DataSet();
            OleDbDataAdapter sda = new OleDbDataAdapter("select * from information", objConnection);
            sda.Fill(ds, "information");
            listViewInfo.Visible = false;
            dataGridView1.Visible = true;
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void 成绩修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeStuInfo Form = new changeStuInfo();
            Form.Show();
        }

        private void 成绩删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listViewInfo.SelectedItems.Count <= 0)
                MessageBox.Show("未选中删除项！");
            else
            {
                ListViewItem lvi = this.listViewInfo.SelectedItems[0];

                this.listViewInfo.Items.Remove(lvi);
                string strConnection = "Provider=Microsoft.Jet.OleDb.4.0;";
                strConnection += @"Data Source=" + Application.StartupPath + "\\managem_student.mdb";
                OleDbConnection objConnection = new OleDbConnection(strConnection);

                OleDbCommand cmd = new OleDbCommand("delete from information where name='" + lvi.Text.ToString() + "'", objConnection);
                objConnection.Open();
                cmd.ExecuteNonQuery();
                objConnection.Close();
                MessageBox.Show("删除成功！");
            }
        }

        private void 成绩分析ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("暂无。。");
        }

        private void 成绩添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddstuInfo Form = new AddstuInfo();
            Form.Show();
        }

    }
}
