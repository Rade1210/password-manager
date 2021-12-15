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
    public partial class Ledger : Form
    {
        public Ledger()
        {
            InitializeComponent();
        }
        config o = new config();
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbLname.Text = "";
            tbBank.Text = "";
            tbBranch.Text = "";
            tbAccount.Text = "";
            tbIFSC.Text = "";
            tbSearch.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {


                if (string.IsNullOrEmpty(tbLname.Text))
                {
                    errorProvider1.SetError(tbLname, "Enter the Ledger name");
                    tbLname.Focus();
                    return;
                }

                string lname = MySqlHelper.EscapeString(tbLname.Text);
                string bank = MySqlHelper.EscapeString(tbBank.Text);
                string branch = MySqlHelper.EscapeString(tbBranch.Text);
                string accno = MySqlHelper.EscapeString(tbAccount.Text);
                string ifsc = MySqlHelper.EscapeString(tbIFSC.Text);

                string sql = "insert into ledger(LNAME, BANK, BRANCH, ACCNO, IFSC) values('" + lname + "'," +
                    "'" + bank + "','" + branch + "','" + accno + "','" + ifsc + "')";

                

                MySqlCommand cmd = new MySqlCommand(sql, o.con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Ledger Details Added Successfuly");

                btnClear_Click(sender, e);
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
