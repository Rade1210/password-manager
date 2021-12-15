using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        config o = new config();

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit" , MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Application.Exit();
            }
       
        }

      

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUsername.Text))
            {
                errorProvider1.SetError(tbUsername, "Enter the username");
                tbUsername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(tbPassword.Text))
            {
                errorProvider1.SetError(tbPassword, "Enter the password");
                tbPassword.Focus();
                return;
            }
            string uname = MySqlHelper.EscapeString(tbUsername.Text);
            string upass = MySqlHelper.EscapeString(tbPassword.Text);

            string sql = "select * from admin_logs where UNAME='"+ uname +"' and UPASS='"+ upass +"'";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, o.con);

            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                Home frm = new Home(dt.Rows[0][1].ToString());
                frm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                tbUsername.Focus();
            }


        }
    }
}
