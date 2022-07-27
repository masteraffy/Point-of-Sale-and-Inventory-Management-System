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
    public partial class Pos_Transaction_History_Records : Form
    {
        private string transnumber, category;
        string username;
        MainConnection data = new MainConnection();
        DataSet ds;
        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;
        MySqlCommand mycmd = new MySqlCommand();
        Pos_Transaction_History pth;
        string action;
        public Pos_Transaction_History_Records(string transnumber, string username, string Action)
        {
            InitializeComponent();
            this.transnumber = transnumber;
            this.username = username;
            this.action = Action;
            cn = new MySqlConnection();
            cn.ConnectionString = data.getConnection();
            actionLoads();
            getCheckoutTable();
            getDate();
            

        }

        public void actionLoads()
        {
            if (action == "void")
            {
                lblHeader.Text = "Voided Transaction Records";
                btnVoidTransaction.Enabled = false;
            }
            else
            {
                lblHeader.Text = "Transaction Records";
                btnVoidTransaction.Enabled = true;
            }            
        }
        private void Pos_Transaction_History_Records_Load(object sender, EventArgs e)
        {
            
            try
            {
               if(action == "void")
                {
                    DataTable dt = data.GetData("Select ProductName, Qty, Price from tblvoided_receipt where transactionnumber = '" + transnumber + "'");
                    dgv1.DataSource = dt;
                }
                else
                {
                    DataTable dt = data.GetData("Select ProductName, Qty, Price from tblreceipt where transactionnumber = '" + transnumber + "'");
                    dgv1.DataSource = dt;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Load receipt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void getCheckoutTable()
        {
            try
            {
                if(action == "void")
                {
                    cn.Open();
                    cm = new MySqlCommand("select * from tblvoided  where transactionnumber = '" + transnumber + "'", cn);
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

                if(action == "history")
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void getDate()
        {
            try
            {
                if(action == "void")
                {
                    cn.Open();
                    cm = new MySqlCommand("select * from tblvoided_receipt  where transactionnumber = '" + transnumber + "'", cn);
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        lblDate.Text = dr["Date"].ToString();
                    }
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
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Get Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVoidTransaction_Click(object sender, EventArgs e)
        {
            Pos_Void_Transaction povt = new Pos_Void_Transaction(lblTransactionNumber.Text, username, lblCustomerName.Text, lblTotalAmount.Text, this);
            povt.Show();
            
        }
    }
}
