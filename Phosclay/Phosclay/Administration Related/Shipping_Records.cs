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

namespace Phosclay
{
    public partial class Shipping_Records : Form
    {
        private string transnumber, category, status;
        private string username;
        MainConnection data = new MainConnection();
        DataSet ds;
        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;
        MySqlCommand mycmd = new MySqlCommand();
        Pos_Transaction_History pth;
        public Shipping_Records(string Username, string TransactionNumber, string Status)
        {
            InitializeComponent();
            this.transnumber = TransactionNumber;
            this.username = Username;
            this.status = Status;
            cn = new MySqlConnection();
            cn.ConnectionString = data.getConnection();
            buttonDisabler();
            getCheckoutTable();
            getDate();
        }

        public void buttonDisabler()
        {
            if (status == "Completed")
            {
                btnCancel.Enabled = false;
                btnComplete.Enabled = false;
            }
            else if (status == "Canceled")
            {
                btnCancel.Enabled = false;
                btnComplete.Enabled = false;
            }
            else
            {
                btnCancel.Enabled = true;
                btnComplete.Enabled = true;
            }
        }

        public void getCheckoutTable()
        {
            try
            {
                if(status == "Canceled")
                {
                    cn.Open();
                    cm = new MySqlCommand("select * from tblvoided  where transactionnumber = '" + transnumber + "' AND Status = 'Voided'", cn);
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        lblTransactionNumber.Text = dr["TransactionNumber"].ToString();
                        lblCustomerName.Text = dr["CustomerName"].ToString();
                        lblReferenceNumber.Text = dr["Reference"].ToString();
                        lblTotalAmount.Text = dr["TotalCost"].ToString();
                        lblDiscounts.Text = dr["Discount"].ToString();
                        lblPayment.Text = dr["TotalPaying"].ToString();
                        lblChange.Text = dr["RemainingBalance"].ToString();
                        lblSalesNote.Text = dr["SalesNote"].ToString();
                        lblShippingDate.Text = dr["ShippingDate"].ToString();
                        lblShippingMethod.Text = dr["ShippingMethod"].ToString();
                        lblPaymentOption.Text = dr["PaymentOption"].ToString();
                        lblTotalItems.Text = dr["TotalItems"].ToString();
                        category = dr["Receipt"].ToString();
                    }
                    cn.Close();
                }
                else
                {
                    cn.Open();
                    cm = new MySqlCommand("select * from tblcheckout  where transactionnumber = '" + transnumber + "'", cn);
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        lblTransactionNumber.Text = dr["TransactionNumber"].ToString();
                        lblCustomerName.Text = dr["CustomerName"].ToString();
                        lblReferenceNumber.Text = dr["Reference"].ToString();
                        lblTotalAmount.Text = dr["TotalCost"].ToString();
                        lblDiscounts.Text = dr["Discount"].ToString();
                        lblPayment.Text = dr["TotalPaying"].ToString();
                        lblChange.Text = dr["RemainingBalance"].ToString();
                        lblSalesNote.Text = dr["SalesNote"].ToString();
                        lblShippingDate.Text = dr["ShippingDate"].ToString();
                        lblShippingMethod.Text = dr["ShippingMethod"].ToString();
                        lblPaymentOption.Text = dr["PaymentOption"].ToString();
                        lblTotalItems.Text = dr["TotalItems"].ToString();
                        category = dr["Receipt"].ToString();
                    }
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = new DialogResult();
                result = MessageBox.Show("Are you sure you want to Complete this Order?", "Complete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new MySqlCommand("update tblshipped set status='Completed' where TransactionNumber ='" + transnumber + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    this.Close();
                    Manage_Shipping manage = (Manage_Shipping)Application.OpenForms["Manage_Shipping"];
                    manage.shipping();
                    manage.Completed();
                    manage.Pending();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Button Complete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Shipping_Records_Load(object sender, EventArgs e)
        {
            try
            {
                if(status == "Canceled")
                {
                    cn.Open();
                    DataTable dt = data.GetData("Select ProductName, Qty, Price from tblvoided_receipt where transactionnumber = '" + transnumber + "' AND Status = 'Voided'");
                    dgv1.DataSource = dt;
                    cn.Close();
                }
                else
                {
                    cn.Open();
                    DataTable dt = data.GetData("Select ProductName, Qty, Price from tblreceipt where transactionnumber = '" + transnumber + "'");
                    dgv1.DataSource = dt;
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Loading Records", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = new DialogResult();
                result = MessageBox.Show("Are you sure you want to Cancel this Order?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new MySqlCommand("update tblshipped set status='Canceled' where TransactionNumber ='" + transnumber + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void getDate()
        {
            try
            {
                if(status == "Canceled")
                {
                    cn.Open();
                    cm = new MySqlCommand("select * from tblvoided_receipt  where transactionnumber = '" + transnumber + "' And Status = 'Voided'", cn);
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        lblDate.Text = dr["Date"].ToString();
                    }
                    cn.Close();
                }
                else
                {
                    cn.Open();
                    cm = new MySqlCommand("select * from tblreceipt  where transactionnumber = '" + transnumber + "'", cn);
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        lblDate.Text = dr["Date"].ToString();
                    }
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

      
    }
}
