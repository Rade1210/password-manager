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
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbCurrentPassword.Text = "";
            tbNewPassword.Text = "";
            tbConfirmPassword.Text = "";
        }

        config o = new config();

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbCurrentPassword.Text))
                {
                    errorProviderSettings.SetError(tbCurrentPassword, "Enter Current Password");
                    tbCurrentPassword.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(tbNewPassword.Text))
                {
                    errorProviderSettings.SetError(tbNewPassword, "Enter New Password");
                    tbNewPassword.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(tbConfirmPassword.Text))
                {
                    errorProviderSettings.SetError(tbConfirmPassword, "Confirm Password");
                    tbConfirmPassword.Focus();
                    return;
                }
                string currentPass = MySqlHelper.EscapeString(tbCurrentPassword.Text);
                string newPass = MySqlHelper.EscapeString(tbNewPassword.Text);
                string confirmPass = MySqlHelper.EscapeString(tbConfirmPassword.Text);
                errorProviderSettings.Clear();
                string sql = "select * from admin_logs where upass='" + currentPass + "' and ID=1";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, o.con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if(dt.Rows.Count == 1)
                {
                    if(newPass == confirmPass)
                    {
                        sql = "update admin_logs set upass='" + newPass + "' where ID=1";
                        MySqlCommand cmd = new MySqlCommand(sql, o.con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Password updated sucessfully");
                    }
                    else
                    {
                        MessageBox.Show("Passwords must match");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid password");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(o.con.State == ConnectionState.Open)
                {
                    o.con.Close();
                }
            }
        }
    }
}
