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
    }
}
