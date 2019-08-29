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
    public partial class changeStuInfo : Form
    {
        public changeStuInfo()
        {
            InitializeComponent();
        }

        private void quitInfo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changeInfo_Click(object sender, EventArgs e)
        {
            string sex;
            if (this.radioButtonMale.Checked)
                sex = "男";
            else
                sex = "女";
            string strConnection = "Provider = Microsoft.Jet.OLEDB.4.0;";
            strConnection += @"Data Source=" + Application.StartupPath + "\\managem_student.mdb";
            OleDbConnection objConnection = new OleDbConnection(strConnection);

            OleDbCommand cmd = new OleDbCommand("update information set name='" + this.textBoxName.Text + "'," +
                "studentID='" + this.textBoxStudentID.Text + "',class='" + this.textBoxClass.Text + "'," +
                "sex='" + sex + "',email='" + this.textBoxEmail.Text + "',courseOne='" + this.textBoxCourse1.Text + "'," +
                "courseTwo='" + this.textBoxCourse2.Text + "',courseThree='" + this.textBoxCourse3.Text + 
                "'where name='" + this.textBoxName.Text + "'", objConnection);

            objConnection.Open();

            if (cmd.ExecuteNonQuery() == 1 &&
                (textBoxName.Text.Trim() != string.Empty) &&
                (textBoxStudentID.Text.Trim() != string.Empty))
            {
                MessageBox.Show("成功修改 " + this.textBoxName.Text + " 同学的信息！");
                this.Close();
            }
            else
                MessageBox.Show("修改失败，请确认键入信息是否有误");

            objConnection.Close();
        }
    }
}
