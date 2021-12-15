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
            tbLID.Text = "0";
        }

        DataTable dtLedger;
        public void loadgrid()
        {
            string sql = "select * from ledger";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, o.con);
            dtLedger = new DataTable();
            da.Fill(dtLedger);
            dataGridView1.DataSource = dtLedger;



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
                string lid = MySqlHelper.EscapeString(tbLID.Text);

                errorProvider1.Clear();

                string sql; 

                if(lid == "0" )
                {
                    sql = "insert into ledger(LNAME, BANK, BRANCH, ACCNO, IFSC) values('" + lname + "'," +
                    "'" + bank + "','" + branch + "','" + accno + "','" + ifsc + "')";
                }

                else
                {
                    sql = "update ledger set LNAME = '" + lname + "', BANK = '" + bank + "', " +
                    "BRANCH = '" + branch + "', ACCNO = '" + accno + "', IFSC = '" + ifsc + 
                    "' where LID='"+ lid+ "'";
                }
     

                

                MySqlCommand cmd = new MySqlCommand(sql, o.con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Ledger Details Added Successfuly");

                loadgrid();

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

        private void Ledger_Load(object sender, EventArgs e)
        {
            loadgrid();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtLedger);
            dv.RowFilter = "LNAME like '%" + tbSearch.Text + "%'";
            dataGridView1.DataSource = dv;

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                tbLID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbLname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbBank.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbBranch.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbAccount.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbIFSC.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }
    }
}
