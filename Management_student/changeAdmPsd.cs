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
    public partial class changeAdmPsd : Form
    {
        public changeAdmPsd()
        {
            InitializeComponent();
        }

        private void certain_Click(object sender, EventArgs e)
        {
            string user = username.Text;
            string password = oldPassword.Text;
            string strConnection = "Provider=Microsoft.Jet.OleDb.4.0;";
            strConnection += @"Data Source=" + Application.StartupPath + "\\managem_student.mdb";
            OleDbConnection objConnection = new OleDbConnection(strConnection);
            objConnection.Open();
            OleDbCommand objCommand = new OleDbCommand("select * from admin", objConnection);
            DataSet ds = new DataSet();
            OleDbDataAdapter sda = new OleDbDataAdapter("select * from admin ", objConnection); ;
            sda.Fill(ds, "admin");
            OleDbDataReader reader = objCommand.ExecuteReader();
            int i;
            for (i = 0; i < ds.Tables["admin"].Rows.Count; i++)
            {
                reader.Read();
                if (reader["username"].Equals(user) && reader["password"].Equals(password))
                {
                    string s = "update admin set [username]='" + user + "',[password]='" + this.newPassword.Text + "' where [username]= '" + user + "'";
                    OleDbCommand cmd = new OleDbCommand(s, objConnection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("修改成功！");
                    break;
                }
            }
            
            reader.Close();
            objConnection.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
