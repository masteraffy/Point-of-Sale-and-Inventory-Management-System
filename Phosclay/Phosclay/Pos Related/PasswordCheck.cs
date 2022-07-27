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
namespace Phosclay.Pos_Related
{
    public partial class PasswordCheck : Form
    {
        Pos_Transaction_History_Records pthr;
        Pos_Void_Transaction Povt;
        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;
        DateTime date = DateTime.Now;
        MainConnection data = new MainConnection();
        private string transactionNumber, reason, username, others, customerName, amountVoided;
        private string password;

        public PasswordCheck(string Transnumber, string Reason, string Others, string Username, string CustomerName, string AmountVoided, Pos_Transaction_History_Records pthr, Pos_Void_Transaction povt)
        {
            InitializeComponent();
            cn = new MySqlConnection();
            cn.ConnectionString = data.getConnection();

            this.transactionNumber = Transnumber;
            this.reason = Reason;
            this.others = Others;
            this.username = Username;
            this.customerName = CustomerName;
            this.amountVoided = AmountVoided;
            this.pthr = pthr;
            this.Povt = povt;
        }

        private void PasswordCheck_Load(object sender, EventArgs e)
        {
            lblTransaction.Text = transactionNumber;
            txtConfirmPassword.UseSystemPasswordChar = true;
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            checkPassword();
           if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                MessageBox.Show("Please Input Your Password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

           if(txtConfirmPassword.Text != password)
            {
                MessageBox.Show("Password does not Match, Please Try Again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                updateLatestTransaction();
                logs();
                MessageBox.Show("Transaction Voided!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                deleteTransaction();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkshow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkshow.Checked)
            {
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        public void checkPassword()
        {
            try
            {
                String usertype = "Owner";
                cn.Open();
                cm = new MySqlCommand("select password from tblaccount where Full_Name ='" + username + "' AND Usertype='"+usertype+"'", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                password = dr["password"].ToString();
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on checking password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void updateLatestTransaction()
        {
            try
            {
                cn.Open();
                cm = new MySqlCommand("update tblvoided set DateVoided ='" + date.ToString("MMM. dd, yyyy") + "', TimeVoided ='" + date.ToString("hh:mm:tt") + "', Reason ='" + reason + "', Status = 'Voided' where TransactionNumber ='" + transactionNumber + "'", cn);
                cm.ExecuteNonQuery();
                cn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error on Updating tblvoided",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //insert logs
        public void logs()
        {
            cn.Open();
            cm = new MySqlCommand("INSERT INTO tbllogs (datelog, timelog, full_name, action, module) VALUES ('" + date.ToString("yyyy-MM-dd") + "', '" + date.ToString("hh:mm:tt") + "', '"
                + username + "',  'Voided Transaction Number: " + transactionNumber + " by " + username + "', 'Void Transactions')", cn);
            cm.ExecuteNonQuery();
            cn.Close();
        }

        //delete from sales and checkout and shipping
        public void deleteTransaction()
        {
            try
            {
                //delete from tblcheckout
                cn.Open();
                cm = new MySqlCommand("DELETE FROM tblcheckout WHERE TransactionNumber = '" + transactionNumber + "'", cn);
                cm.ExecuteReader();
                cn.Close();
                //delete from tblreceipt
                cn.Open();
                cm = new MySqlCommand("DELETE FROM tblreceipt WHERE TransactionNumber = '" + transactionNumber + "'", cn);
                cm.ExecuteReader();
                cn.Close();
                //update tblshipped status
                cn.Open();
                cm = new MySqlCommand("UPDATE tblshipped SET Status = 'Canceled' WHERE TransactionNumber = '" + transactionNumber + "'", cn);
                cm.ExecuteReader();
                cn.Close();
                //update tblvoided receipt status
                cn.Open();
                cm = new MySqlCommand("UPDATE tblvoided_receipt SET Status = 'Voided', Date = '" + date.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE TransactionNumber = '" + transactionNumber + "'", cn);
                cm.ExecuteReader();
                cn.Close();

                this.Close();
                Povt.Close();
                pthr.Close();
                Pos_Transaction_History del = (Pos_Transaction_History)Application.OpenForms["Pos_Transaction_History"];
                del.dgvLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Delete Transaction",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

       
    }
}
