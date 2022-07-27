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
using Microsoft.VisualBasic;

namespace Phosclay.Pos_Related
{
    public partial class Pos_Void_Transaction : Form
    {
        private string transnumber, username, customername, amountvoided;
        Pos_Transaction_History_Records pthr;
        public Pos_Void_Transaction(string Transnumber, string username, string CustomerName, string AmountVoided, Pos_Transaction_History_Records Pthr)
        {
            InitializeComponent();
            this.transnumber = Transnumber;
            this.username = username;
            this.customername = CustomerName;
            this.amountvoided = AmountVoided;
            this.pthr = Pthr;
        }
        private void btnVoid_Click(object sender, EventArgs e)
        {
                PasswordCheck pc = new PasswordCheck(transnumber, cmbReason.Text, txtOthers.Text, username, customername, amountvoided,pthr, this);
                pc.ShowDialog();
            
            
        }

        private void Pos_Void_Transaction_Load(object sender, EventArgs e)
        {
            txtTransactionNumber.Text = transnumber;
            
        }

        public void others()
        {
            if (cmbReason.SelectedIndex == 4)
            {
                txtOthers.Enabled = true;
            }
            else
            {
                txtOthers.Enabled = false;
            }
        }

        private void cmbReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            others();
        }
    }
}
