using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace PassBook
{
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }

        config o = new config();
        private void Transaction_Load(object sender, EventArgs e)
        {
            string sql = "select LID, LNAME FROM ledger";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, o.con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbLedger.DataSource = dt;
            cbLedger.DisplayMember = "LNAME";
            cbLedger.ValueMember = "LID";
            cbLedger.SelectedIndex = -1;
            loadgrid();



        }

        private void btnClearTransaction_Click(object sender, EventArgs e)
        {
            cbAccount.SelectedIndex = -1;
            cbLedger.SelectedIndex = -1;
            cbTransType.SelectedIndex = -1;
            tbTID.Text = "0";
            tbAmount.Text = "";
            tbDescription.Text = "";
            tbTransactionDetails.Text = "";
            tbSearchTransaction.Text = "";
        }

        DataTable dtTrans;

        public void loadgrid()
        {
        string sql = "select b.TID, l.LNAME, b.TTYPE, b.TDATE as `DATE`, b.TRANS_TYPE, b.DESCRIPTION_TEXT," +
        "b.TRANS_DETAILS, b.CR, b.DR from bank_transaction b inner join ledger l on l.LID = b.LID " +
         "order by TDATE desc;";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, o.con);
            dtTrans = new DataTable();
            da.Fill(dtTrans);
            dataGridView2.DataSource = dtTrans;

        }

        private void btnSaveTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                if(cbAccount.SelectedIndex == -1)
                {
                    errorProviderTransaction.SetError(cbAccount, "Please select an Account Type");
                    cbAccount.Focus();
                    return;
                }
                if(cbLedger.SelectedIndex == -1)
                {
                    errorProviderTransaction.SetError(cbLedger, "Please select a Ledger");
                    cbLedger.Focus();
                    return;
                }
                if (cbTransType.SelectedIndex == -1)
                {
                    errorProviderTransaction.SetError(cbTransType, "Please select a Transaction Type");
                    cbTransType.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(tbAmount.Text))
                {
                    errorProviderTransaction.SetError(tbAmount, "Enter the Amount");
                    tbAmount.Focus();
                    return;
                }
                errorProviderTransaction.Clear();

                string ttype = MySqlHelper.EscapeString(cbAccount.Text);
                string tdate = dtpTransaction.Value.ToString("yyyy-MM-dd");
                string lid = MySqlHelper.EscapeString(cbLedger.SelectedValue.ToString());
                string trans_type = MySqlHelper.EscapeString(cbTransType.Text);
                string description = MySqlHelper.EscapeString(tbDescription.Text);
                string trans_details = MySqlHelper.EscapeString(tbTransactionDetails.Text);
                string amt = MySqlHelper.EscapeString(tbAmount.Text);
                string tid = MySqlHelper.EscapeString(tbTID.Text);
                string cr = "0";
                string dr = "0";
                if(ttype == "Credit")
                {
                    cr = amt;
                }
                else
                {
                    dr = amt;
                }
                string sql;
                if(tid == "0")
                {
                    sql = "insert into bank_transaction(TTYPE, TDATE, LID, TRANS_TYPE, DESCRIPTION_TEXT," +
                    "TRANS_DETAILS, CR, DR) values('"+ttype+ "','" + tdate + "','" 
                    + lid + "','" + trans_type + "','" + description + "','" + trans_details + "','" 
                    + cr + "','" + dr + "')";
                }
                else
                {
                    sql = "update bank_transaction set TTYPE='" + ttype + "', TDATE='" + tdate + "'," +
                    "LID='" + lid + "', TRANS_TYPE='" + trans_type + "',DESCRIPTION_TEXT='" + description +
                    "',TRANS_DETAILS='" + trans_details + "', CR='" + cr + "',DR='" + dr + "' where TID='" + tid + "'";
                }
                MySqlCommand cmd = new MySqlCommand(sql, o.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Transaction details added sucessfully");
                loadgrid();
                btnClearTransaction_Click(sender, e);
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

        private void dataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                tbTID.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbLedger.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbTransType.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpTransaction.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
                cbTransType.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbDescription.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
                tbTransactionDetails.Text = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();

                if (dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString() == "0")
                {
                    tbAmount.Text = dataGridView2.Rows[e.RowIndex].Cells[8].Value.ToString();
                }

                else
                {
                    tbAmount.Text = dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString();
                }
            }
        }

        private void tbSearchTransaction_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtTrans);
            dv.RowFilter = "LNAME like '%" + tbSearchTransaction.Text + "%' or TRANS_DETAILS like '%"
            + tbSearchTransaction.Text + "%'";
            dataGridView2.DataSource = dv;
        }

        private void btnDeleteTransaction_Click(object sender, EventArgs e)
        {
            if(tbTID.Text != "0")
            {
                if(MessageBox.Show("Are you sure you want to Delete?", "Delete", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information) == DialogResult.OK)
                {
                    try
                    {
                        string tid = MySqlHelper.EscapeString(tbTID.Text);
                        string sql = "delete from bank_transaction where TID='" + tid + "'";
                        MySqlCommand cmd = new MySqlCommand(sql, o.con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Bank transaction detail deleted sucessfully");
                        loadgrid();
                        btnClearTransaction_Click(sender, e);
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
            else
            {
                MessageBox.Show("Please select a record to delete");
            }
        }
    }
}
