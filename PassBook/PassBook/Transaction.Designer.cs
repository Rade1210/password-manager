
namespace PassBook
{
    partial class Transaction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbTID = new System.Windows.Forms.TextBox();
            this.btnDeleteTransaction = new System.Windows.Forms.Button();
            this.btnClearTransaction = new System.Windows.Forms.Button();
            this.btnSaveTransaction = new System.Windows.Forms.Button();
            this.tbSearchTransaction = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpTransaction = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.tbTransactionDetails = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.cbTransType = new System.Windows.Forms.ComboBox();
            this.cbLedger = new System.Windows.Forms.ComboBox();
            this.cbAccount = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.errorProviderTransaction = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tbTID);
            this.splitContainer1.Panel1.Controls.Add(this.btnDeleteTransaction);
            this.splitContainer1.Panel1.Controls.Add(this.btnClearTransaction);
            this.splitContainer1.Panel1.Controls.Add(this.btnSaveTransaction);
            this.splitContainer1.Panel1.Controls.Add(this.tbSearchTransaction);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.dtpTransaction);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.tbAmount);
            this.splitContainer1.Panel1.Controls.Add(this.tbTransactionDetails);
            this.splitContainer1.Panel1.Controls.Add(this.tbDescription);
            this.splitContainer1.Panel1.Controls.Add(this.cbTransType);
            this.splitContainer1.Panel1.Controls.Add(this.cbLedger);
            this.splitContainer1.Panel1.Controls.Add(this.cbAccount);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer1.Size = new System.Drawing.Size(816, 555);
            this.splitContainer1.SplitterDistance = 386;
            this.splitContainer1.TabIndex = 0;
            // 
            // tbTID
            // 
            this.tbTID.Location = new System.Drawing.Point(431, 94);
            this.tbTID.Name = "tbTID";
            this.tbTID.Size = new System.Drawing.Size(44, 25);
            this.tbTID.TabIndex = 35;
            this.tbTID.Text = "0";
            this.tbTID.Visible = false;
            // 
            // btnDeleteTransaction
            // 
            this.btnDeleteTransaction.Location = new System.Drawing.Point(327, 342);
            this.btnDeleteTransaction.Name = "btnDeleteTransaction";
            this.btnDeleteTransaction.Size = new System.Drawing.Size(63, 27);
            this.btnDeleteTransaction.TabIndex = 34;
            this.btnDeleteTransaction.Text = "Delete";
            this.btnDeleteTransaction.UseVisualStyleBackColor = true;
            this.btnDeleteTransaction.Click += new System.EventHandler(this.btnDeleteTransaction_Click);
            // 
            // btnClearTransaction
            // 
            this.btnClearTransaction.Location = new System.Drawing.Point(258, 342);
            this.btnClearTransaction.Name = "btnClearTransaction";
            this.btnClearTransaction.Size = new System.Drawing.Size(63, 27);
            this.btnClearTransaction.TabIndex = 33;
            this.btnClearTransaction.Text = "Clear";
            this.btnClearTransaction.UseVisualStyleBackColor = true;
            this.btnClearTransaction.Click += new System.EventHandler(this.btnClearTransaction_Click);
            // 
            // btnSaveTransaction
            // 
            this.btnSaveTransaction.Location = new System.Drawing.Point(190, 342);
            this.btnSaveTransaction.Name = "btnSaveTransaction";
            this.btnSaveTransaction.Size = new System.Drawing.Size(62, 27);
            this.btnSaveTransaction.TabIndex = 32;
            this.btnSaveTransaction.Text = "Save";
            this.btnSaveTransaction.UseVisualStyleBackColor = true;
            this.btnSaveTransaction.Click += new System.EventHandler(this.btnSaveTransaction_Click);
            // 
            // tbSearchTransaction
            // 
            this.tbSearchTransaction.Location = new System.Drawing.Point(431, 53);
            this.tbSearchTransaction.Name = "tbSearchTransaction";
            this.tbSearchTransaction.Size = new System.Drawing.Size(100, 25);
            this.tbSearchTransaction.TabIndex = 31;
            this.tbSearchTransaction.TextChanged += new System.EventHandler(this.tbSearchTransaction_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(375, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "Search";
            // 
            // dtpTransaction
            // 
            this.dtpTransaction.CustomFormat = "dd-MM-yyyy hh:mm:ss";
            this.dtpTransaction.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTransaction.Location = new System.Drawing.Point(625, 53);
            this.dtpTransaction.Name = "dtpTransaction";
            this.dtpTransaction.Size = new System.Drawing.Size(153, 25);
            this.dtpTransaction.TabIndex = 29;
            this.dtpTransaction.Value = new System.DateTime(2021, 12, 15, 13, 14, 7, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(582, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Amount";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(453, 295);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(138, 25);
            this.tbAmount.TabIndex = 26;
            // 
            // tbTransactionDetails
            // 
            this.tbTransactionDetails.Location = new System.Drawing.Point(193, 295);
            this.tbTransactionDetails.Name = "tbTransactionDetails";
            this.tbTransactionDetails.Size = new System.Drawing.Size(176, 25);
            this.tbTransactionDetails.TabIndex = 25;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(153, 179);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(246, 80);
            this.tbDescription.TabIndex = 24;
            // 
            // cbTransType
            // 
            this.cbTransType.FormattingEnabled = true;
            this.cbTransType.Items.AddRange(new object[] {
            "Received",
            "Cheque",
            "RTGS\\IMPS"});
            this.cbTransType.Location = new System.Drawing.Point(153, 137);
            this.cbTransType.Name = "cbTransType";
            this.cbTransType.Size = new System.Drawing.Size(180, 25);
            this.cbTransType.TabIndex = 23;
            // 
            // cbLedger
            // 
            this.cbLedger.FormattingEnabled = true;
            this.cbLedger.Location = new System.Drawing.Point(153, 95);
            this.cbLedger.Name = "cbLedger";
            this.cbLedger.Size = new System.Drawing.Size(180, 25);
            this.cbLedger.TabIndex = 22;
            // 
            // cbAccount
            // 
            this.cbAccount.FormattingEnabled = true;
            this.cbAccount.Items.AddRange(new object[] {
            "Credit",
            "Debit"});
            this.cbAccount.Location = new System.Drawing.Point(153, 53);
            this.cbAccount.Name = "cbAccount";
            this.cbAccount.Size = new System.Drawing.Size(180, 25);
            this.cbAccount.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Transaction Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Trans-Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ledger";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Account";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(816, 165);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_RowHeaderMouseDoubleClick);
            // 
            // errorProviderTransaction
            // 
            this.errorProviderTransaction.ContainerControl = this;
            // 
            // Transaction
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(816, 555);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Transaction";
            this.Text = "Transaction Details";
            this.Load += new System.EventHandler(this.Transaction_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTransaction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox tbSearchTransaction;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpTransaction;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.TextBox tbTransactionDetails;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.ComboBox cbTransType;
        private System.Windows.Forms.ComboBox cbLedger;
        private System.Windows.Forms.ComboBox cbAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnDeleteTransaction;
        private System.Windows.Forms.Button btnClearTransaction;
        private System.Windows.Forms.Button btnSaveTransaction;
        private System.Windows.Forms.TextBox tbTID;
        private System.Windows.Forms.ErrorProvider errorProviderTransaction;
    }
}