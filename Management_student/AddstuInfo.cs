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
    public partial class AddstuInfo : Form
    {
        public AddstuInfo()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string sex;
            if (this.radioButtonMale.Checked)
                sex = "男";
            else
                sex = "女";
            string strConnection = "Provider = Microsoft.Jet.OLEDB.4.0;";
            strConnection += @"Data Source=" + Application.StartupPath + "\\managem_student.mdb";
            OleDbConnection objConnection = new OleDbConnection(strConnection);

            OleDbCommand cmd = new OleDbCommand("insert into [information]" +
                "([name],[studentID],[class],[sex],[email],[courseOne],[courseTwo],[courseThree])values" +
                "('" + this.textBoxName.Text +"','" + this.textBoxStudentID.Text + "','" + 
                this.textBoxClass.Text + "','" + sex + "','" + this.textBoxEmail.Text + "','" + 
                this.textBoxCourse1.Text + "','" + this.textBoxCourse2.Text + "','" + 
                this.textBoxCourse3.Text + "')", objConnection);

            OleDbCommand cmd2 = new OleDbCommand("insert into [student]" +
                "([username],[password],[studentID])values" + "('" +
                this.textBoxName.Text + "','" + this.textBoxPsd.Text + "','" +
                this.textBoxStudentID.Text + "')", objConnection);

            objConnection.Open();

            if (cmd2.ExecuteNonQuery() == 1 && cmd.ExecuteNonQuery() == 1 &&
                (textBoxName.Text.Trim() != string.Empty) &&
                (textBoxStudentID.Text.Trim() != string.Empty))
            {
                MessageBox.Show("成功添加 " + this.textBoxName.Text + " 同学的信息！");
                this.Close();
            }
            else
                MessageBox.Show("添加失败，请确认是否添加该同学相关信息");

            objConnection.Close();
        }

        private void quitInfo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
