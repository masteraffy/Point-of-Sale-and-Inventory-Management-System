using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Phosclay
{
    
    public partial class Pos_Checkout : Form
    {
        public String[][] Productsqty = { }; public int quantityLess = 0;

        private string totalItems, transtype, transactiontype;
        private string totalCost, discount;
        int errorCount = 0;
        string transnumber;
        DateTime date = DateTime.Now;
        MainConnection data = new MainConnection();
        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;
        Point_of_Sale ps;
        Dashboard ds;
        string username, action;
        string productname, productquantity;
        string qty;
        int decrement1;

        public Pos_Checkout(string totalItems, string discount, string totalCost, string transtype, Point_of_Sale ps, string transactiontype, String username, Dashboard ds, String action)
        {
            InitializeComponent();
            //
            cn = new MySqlConnection();
            cn.ConnectionString = data.getConnection();
            //
            this.totalItems = totalItems;
            this.discount = discount;
            this.totalCost = totalCost;
            this.transtype = transtype;
            this.ps = ps;
            this.transactiontype = transactiontype;
            this.username = username;
            this.ds = ds;
            this.action = action;
            getValue();
            GenerateID();
        }

        private void Pos_Checkout_Load(object sender, EventArgs e)
        {
            getDataSettingsShipping();
            shippingDate.Value = DateTime.Now;
            Ttype();
            search();
            txtTotalPay.Text = "0.00";
        }
        private void GenerateID()
        {
            Random r = new Random();

            txtReference.Text = "REF-000" + r.Next(00, 10000000).ToString();
        }

        public void Ttype()
        {
            if (transtype == "WI")
            {
                cmbShipping.Enabled = false;
                txtShippingTerms.Enabled = false;
                shippingDate.Enabled = false;
            }
            else if (transtype == "DEL")
            {
                cmbShipping.Enabled = true;
                txtShippingTerms.Enabled = true;
                shippingDate.Enabled = true;
            }
        }
        private void cmbPaymentOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPaymentOption.SelectedIndex == 0)
            {
                txtReference.Enabled = false;
            }
            else if (cmbPaymentOption.SelectedIndex == 1)
            {
                txtReference.Enabled = true;
            }
            else if (cmbPaymentOption.SelectedIndex == 2)
            {
                txtReference.Enabled = true;
            }
            else if (cmbPaymentOption.SelectedIndex == 3)
            {
                txtReference.Enabled = true;
            }
            else if (cmbPaymentOption.SelectedIndex == 4)
            {
                txtReference.Enabled = false;
            }
        }

        public void getValue()
        {
            txtTotalItems.Text = totalItems.ToString();
            txtDiscounts.Text = discount.ToString();
            txtTotalCost.Text = totalCost.ToString();
        }

        public void productDecrement2()
        {
            try
            {
                int a = 0;
                DataTable dtCodes = new DataTable();
                using (MySqlDataAdapter adp = new MySqlDataAdapter("select ProductName, Qty from tblreceipt where date = 'Sep. 12, 2021' and time ='00:21:46'", cn))
                {
                    adp.Fill(dtCodes);
                }

                foreach (DataRow row in dtCodes.Rows)
                {
                    
                    productname = row["ProductName"].ToString();
                    productquantity = row["Qty"].ToString();

                    Productsqty[a][0] = row["ProductName"].ToString();
                    Productsqty[a][1] = row["Qty"].ToString();
                    a += 1;

                    DataTable dt = new DataTable();
                    using (MySqlDataAdapter sda = new MySqlDataAdapter("select * from tblproduct where productname = '" + productname + "'", cn))
                    {
                        sda.Fill(dt);
                    }

                    foreach (DataRow row1 in dt.Rows)
                    {
                        int[] array = new int[0];
                        Convert.ToInt32(qty);
                        Convert.ToInt32(productquantity);
                        decrement1 = Convert.ToInt32(qty) - Convert.ToInt32(productquantity);                        
                    }                 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTotalPay_TextChanged(object sender, EventArgs e)
        {
            if (txtTotalPay.Text == "")
            {
                txtRemainingBalance.Text = txtTotalCost.Text;
            }
        }
        private void btnExact_Click_1(object sender, EventArgs e)
        {
            txtAmount.Text = txtTotalCost.Text;
            txtTotalPay.Text = txtAmount.Text;
            double pay = double.Parse(txtTotalPay.Text);
            double cost = double.Parse(txtTotalCost.Text);
            double rm = cost - pay;
            txtRemainingBalance.Text = rm.ToString();
            if (Convert.ToDouble(txtAmount.Text) < Convert.ToDouble(txtTotalCost.Text))
            {
                lblChange.Visible = false;
                lblremainingbalance.Visible = true;
            }
            else if (Convert.ToDouble(txtAmount.Text) > Convert.ToDouble(txtTotalCost.Text))
            {
                lblChange.Visible = true;
                lblremainingbalance.Visible = false;
            }
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
           if(cmbShipping.Enabled == true)
            {
                try
                {

                    if (Convert.ToDouble(txtRemainingBalance.Text) == 0.00 || Convert.ToDouble(txtTotalPay.Text) > Convert.ToDouble(txtTotalCost.Text))
                    {
                        Validate1();
                        if (errorCount == 0)
                        {
                            //insert data into tblcheckout//
                            Random r = new Random();
                            transnumber = "0000" + r.Next(00, 1000000000).ToString();
                            data.executeSQL("INSERT INTO tblcheckout (TransactionNumber, TransactionType, CustomerName, PaymentOption, Reference, Amount, SalesNote, ShippingMethod, ShippingDate, ShippingTerms, TotalItems, TotalPaying, Discount, TotalCost, RemainingBalance, Receipt, Receipt1, Date) VALUES " +
                                    "('" + transnumber + "', '" + transactiontype + "', '" + txtCustomer.Text + "', '" + cmbPaymentOption.Text + "', '" + txtReference.Text + "','" + txtAmount.Text + "', '" +
                                    txtSalesNote.Text + "', '" + cmbShipping.Text + "', '" + shippingDate.Text + "', '" + txtShippingTerms.Text + "', '" + txtTotalItems.Text + "', '" +
                                    txtTotalPay.Text + "', '" + txtDiscounts.Text + "', '" + txtTotalCost.Text + "', '" + txtRemainingBalance.Text + "', '" + cmbReceipt.Text + "', '" + cmbReceipt2.Text + "', '" + date.ToString("yyyy-MM-dd HH:mm:ss") + "')");
                            //insert date into tblvoid
                            data.executeSQL("INSERT INTO tblvoided (TransactionNumber, TransactionType, CustomerName, PaymentOption, Reference, Amount, SalesNote, ShippingMethod, ShippingDate, ShippingTerms, TotalItems, TotalPaying, Discount, TotalCost, RemainingBalance, Receipt, Receipt1, Date, Status) VALUES " +
                                    "('" + transnumber + "', '" + transactiontype + "', '" + txtCustomer.Text + "', '" + cmbPaymentOption.Text + "', '" + txtReference.Text + "','" + txtAmount.Text + "', '" +
                                    txtSalesNote.Text + "', '" + cmbShipping.Text + "', '" + shippingDate.Text + "', '" + txtShippingTerms.Text + "', '" + txtTotalItems.Text + "', '" +
                                    txtTotalPay.Text + "', '" + txtDiscounts.Text + "', '" + txtTotalCost.Text + "', '" + txtRemainingBalance.Text + "', '" + cmbReceipt.Text + "', '" + cmbReceipt2.Text + "', '" + date.ToString("yyyy-MM-dd HH:mm:ss") + "', 'Active')");
                            if (data.rowAffected > 0)
                            {
                                if (cmbReceipt.SelectedIndex == 0)
                                {
                                    cn.Open();
                                    cm = new MySqlCommand("select * from tblproduct  ", cn);
                                    dr = cm.ExecuteReader();
                                    dr.Read();
                                    DataTable dt = data.GetData("select * from tblposcustomerinfo where Fullname ='" + txtCustomer.Text + "'");
                                    string customername = dt.Rows[0][0].ToString();
                                    string companyname = dt.Rows[0][1].ToString();
                                    string address = dt.Rows[0][2].ToString();
                                    string city = dt.Rows[0][3].ToString();
                                    string contactnumber = dt.Rows[0][4].ToString();


                                    Pos_Receipt_Fragranza prf = new Pos_Receipt_Fragranza(cmbReceipt2.Text, customername, companyname, address, city, contactnumber, cmbShipping.Text, cmbPaymentOption.Text, shippingDate.Text, this, date.ToString("MMM. dd, yyyy"), txtReference.Text, txtRemainingBalance.Text, ps, username, ds);

                                    for (int a = 0; a < dgv2.Rows.Count; a++)
                                    {
                                        int n = prf.dgv3.Rows.Add();
                                        a = n;
                                        prf.dgv3.Rows[n].Cells[0].Value = dgv2.Rows[n].Cells[0].Value.ToString();
                                        prf.dgv3.Rows[n].Cells[1].Value = dgv2.Rows[n].Cells[1].Value.ToString();
                                        prf.dgv3.Rows[n].Cells[2].Value = dgv2.Rows[n].Cells[2].Value.ToString();
                                        prf.dgv3.Rows[n].Cells[3].Value = dgv2.Rows[n].Cells[3].Value.ToString();

                                        //insert data into tblreceipt
                                        data.executeSQL("Insert into tblreceipt (TransactionNumber, CustomerName, ProductName, Qty, Price, TotalAmount, Date)" +
                                            "Values('" + transnumber + "', '" + txtCustomer.Text + "', '" + dgv2.Rows[n].Cells[1].Value.ToString() + "', '" + dgv2.Rows[n].Cells[2].Value.ToString() + "', '" +
                                            dgv2.Rows[n].Cells[3].Value.ToString() + "', '" + txtTotalCost.Text + "', '" + date.ToString("yyyy-MM-dd HH:mm:ss") + "')");
                                        //insert data into tblvoided receipt
                                        data.executeSQL("Insert into tblvoided_receipt (TransactionNumber, CustomerName, ProductName, Qty, Price, TotalAmount, Status)" +
                                            "Values('" + transnumber + "', '" + txtCustomer.Text + "', '" + dgv2.Rows[n].Cells[1].Value.ToString() + "', '" + dgv2.Rows[n].Cells[2].Value.ToString() + "', '" +
                                            dgv2.Rows[n].Cells[3].Value.ToString() + "', '" + txtTotalCost.Text + "', 'Active')");

                                    }

                                    //insert data into tblLogs
                                    data.executeSQL("Insert into tblLogs (datelog, timelog, full_name, action, module)" +
                                        "Values('" + date.ToString("yyyy-MM-dd") + "', '" + date.ToString("hh:mm:tt") + "', '" + username.ToString() + "', 'Checked Out Transaction Number: " + transnumber.ToString() + " by: " + username.ToString() + "', 'POS')");
               
                                    //insert data into tblshipped
                                    data.executeSQL("insert into tblshipped (TransactionNumber, Customer_Name, Quantity, Amount, Shipping_Method, PaymentOption, ShippingTerms, Shipping_Date, Status, TransacDate)" +
                                    "Values('" + transnumber + "', '" + txtCustomer.Text + "',  '" + txtTotalItems.Text + "', '" + txtAmount.Text + "', '" + cmbShipping.Text + "', '" + cmbPaymentOption.Text + "', '" + 
                                    txtShippingTerms.Text + "', '" + shippingDate.Text + "', 'Pending', '" + date.ToString("yyyy-MM-dd HH:mm:ss") + "')");
                                    prf.ShowDialog();
                                    cn.Close();
                                }

                                if (cmbReceipt.SelectedIndex == 1)
                                {
                                    cn.Open();
                                    cm = new MySqlCommand("select * from tblproduct  ", cn);
                                    dr = cm.ExecuteReader();
                                    dr.Read();
                                    DataTable dt = data.GetData("select * from tblposcustomerinfo where Fullname ='" + txtCustomer.Text + "'");
                                    string customername = dt.Rows[0][0].ToString();
                                    string address = dt.Rows[0][2].ToString();
                                    string contactnumber = dt.Rows[0][4].ToString();


                                    Pos_Receipt_Phosclay prp = new Pos_Receipt_Phosclay(cmbReceipt2.Text, customername, address, contactnumber, date.ToString("MMM. dd, yyyy"), this, txtRemainingBalance.Text, txtReference.Text, username, ds);

                                    for (int a = 0; a < dgv2.Rows.Count; a++)
                                    {
                                        int n = prp.dgv4.Rows.Add();
                                        a = n;
                                        prp.dgv4.Rows[n].Cells[0].Value = dgv2.Rows[n].Cells[0].Value.ToString();
                                        prp.dgv4.Rows[n].Cells[1].Value = dgv2.Rows[n].Cells[1].Value.ToString();
                                        prp.dgv4.Rows[n].Cells[2].Value = dgv2.Rows[n].Cells[2].Value.ToString();
                                        prp.dgv4.Rows[n].Cells[3].Value = dgv2.Rows[n].Cells[3].Value.ToString();

                                        //insert data into tblreceipt
                                        data.executeSQL("Insert into tblreceipt (TransactionNumber, CustomerName, ProductName, Qty, Price, TotalAmount, Date)" +
                                            "Values('" + transnumber + "', '" + txtCustomer.Text + "', '" + dgv2.Rows[n].Cells[1].Value.ToString() + "', '" + dgv2.Rows[n].Cells[2].Value.ToString() + "', '" +
                                            dgv2.Rows[n].Cells[3].Value.ToString() + "', '" + txtTotalCost.Text + "', '" + date.ToString("yyyy-MM-dd HH:mm:ss") + "')");
                                        //insert data into tblvoided receipt
                                        data.executeSQL("Insert into tblvoided_receipt (TransactionNumber, CustomerName, ProductName, Qty, Price, TotalAmount, Status)" +
                                            "Values('" + transnumber + "', '" + txtCustomer.Text + "', '" + dgv2.Rows[n].Cells[1].Value.ToString() + "', '" + dgv2.Rows[n].Cells[2].Value.ToString() + "', '" +
                                            dgv2.Rows[n].Cells[3].Value.ToString() + "', '" + txtTotalCost.Text + "', 'Active')");
                                    }
                                    //insert data into tblLogs
                                    data.executeSQL("Insert into tblLogs (datelog, timelog, full_name, action, module)" +
                                        "Values('" + date.ToString("yyyy-MM-dd") + "', '" + date.ToString("hh:mm:tt") + "', '" + username.ToString() + "', 'Checked Out Transaction Number: " + transnumber.ToString() + " by: " + username.ToString() + "', 'POS')");

                                    //insert data into tblshipped
                                    data.executeSQL("insert into tblshipped (TransactionNumber, Customer_Name, Quantity, Amount, Shipping_Method, PaymentOption, ShippingTerms, Shipping_Date, Status, TransacDate)" +
                                    "Values('" + transnumber + "', '" + txtCustomer.Text + "',  '" + txtTotalItems.Text + "', '" + txtAmount.Text + "', '" + cmbShipping.Text + "', '" + cmbPaymentOption.Text + "', '" +
                                    txtShippingTerms.Text + "', '" + shippingDate.Text + "', 'Pending', '" + date.ToString("yyyy-MM-dd HH:mm:ss") + "')");
                                    prp.ShowDialog();
                                    cn.Close();
                                    this.Hide();
                                }
                                
                            }

                            Point_of_Sale pos = new Point_of_Sale(ds, username);
                            pos.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Payment is not enough, can't proceed to checkout!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Checkout Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cn.Close();
                }
            }
           else if (cmbShipping.Enabled == false)
            {
                checkout();
            }
        }

        public void checkout()
        {
            try
            {

                if (Convert.ToDouble(txtRemainingBalance.Text) == 0.00 || Convert.ToDouble(txtTotalPay.Text) > Convert.ToDouble(txtTotalCost.Text))
                {
                    Validate1();
                    if (errorCount == 0)
                    {
                        //insert data into tblcheckout//
                        Random r = new Random();
                        transnumber = "0000" + r.Next(00, 1000000000).ToString();
                        data.executeSQL("INSERT INTO tblcheckout (TransactionNumber, TransactionType, CustomerName, PaymentOption, Reference, Amount, SalesNote, ShippingMethod, ShippingDate, ShippingTerms, TotalItems, TotalPaying, Discount, TotalCost, RemainingBalance, Receipt, Receipt1, Date) VALUES " +
                                "('" + transnumber + "', '" + transactiontype + "', '" + txtCustomer.Text + "', '" + cmbPaymentOption.Text + "', '" + txtReference.Text + "','" + txtAmount.Text + "', '" +
                                txtSalesNote.Text + "', '" + cmbShipping.Text + "', '" + shippingDate.Text + "', '" + txtShippingTerms.Text + "', '" + txtTotalItems.Text + "', '" +
                                txtTotalPay.Text + "', '" + txtDiscounts.Text + "', '" + txtTotalCost.Text + "', '" + txtRemainingBalance.Text + "', '" + cmbReceipt.Text + "', '" + cmbReceipt2.Text + "', '" + date.ToString("yyyy-MM-dd HH:mm:ss") + "')");

                        //insert date into tblvoid
                        data.executeSQL("INSERT INTO tblvoided (TransactionNumber, TransactionType, CustomerName, PaymentOption, Reference, Amount, SalesNote, ShippingMethod, ShippingDate, ShippingTerms, TotalItems, TotalPaying, Discount, TotalCost, RemainingBalance, Receipt, Receipt1, Date, Status) VALUES " +
                                "('" + transnumber + "', '" + transactiontype + "', '" + txtCustomer.Text + "', '" + cmbPaymentOption.Text + "', '" + txtReference.Text + "','" + txtAmount.Text + "', '" +
                                txtSalesNote.Text + "', '" + cmbShipping.Text + "', '" + shippingDate.Text + "', '" + txtShippingTerms.Text + "', '" + txtTotalItems.Text + "', '" +
                                txtTotalPay.Text + "', '" + txtDiscounts.Text + "', '" + txtTotalCost.Text + "', '" + txtRemainingBalance.Text + "', '" + cmbReceipt.Text + "', '" + cmbReceipt2.Text + "', '" + date.ToString("yyyy-MM-dd HH:mm:ss") + "', 'Active')");
                        if (data.rowAffected > 0)
                        {
                            if (cmbReceipt.SelectedIndex == 0)
                            {
                                cn.Open();
                                cm = new MySqlCommand("select * from tblproduct  ", cn);
                                dr = cm.ExecuteReader();
                                dr.Read();
                                DataTable dt = data.GetData("select * from tblposcustomerinfo where Fullname ='" + txtCustomer.Text + "'");
                                string customername = dt.Rows[0][0].ToString();
                                string companyname = dt.Rows[0][1].ToString();
                                string address = dt.Rows[0][2].ToString();
                                string city = dt.Rows[0][3].ToString();
                                string contactnumber = dt.Rows[0][4].ToString();

                                Pos_Receipt_Fragranza prf = new Pos_Receipt_Fragranza(cmbReceipt2.Text, customername, companyname, address, city, contactnumber, cmbShipping.Text, cmbPaymentOption.Text, shippingDate.Text, this, date.ToString("MMM. dd, yyyy"), txtReference.Text, txtRemainingBalance.Text, ps, username, ds);

                                for (int a = 0; a < dgv2.Rows.Count; a++)
                                {
                                    int n = prf.dgv3.Rows.Add();
                                    a = n;
                                    prf.dgv3.Rows[n].Cells[0].Value = dgv2.Rows[n].Cells[0].Value.ToString();
                                    prf.dgv3.Rows[n].Cells[1].Value = dgv2.Rows[n].Cells[1].Value.ToString();
                                    prf.dgv3.Rows[n].Cells[2].Value = dgv2.Rows[n].Cells[2].Value.ToString();
                                    prf.dgv3.Rows[n].Cells[3].Value = dgv2.Rows[n].Cells[3].Value.ToString();

                                    //insert data into tblreceipt
                                    data.executeSQL("Insert into tblreceipt (TransactionNumber, CustomerName, ProductName, Qty, Price, TotalAmount, Date)" +
                                        "Values('" + transnumber + "', '" + txtCustomer.Text + "', '" + dgv2.Rows[n].Cells[1].Value.ToString() + "', '" + dgv2.Rows[n].Cells[2].Value.ToString() + "', '" +
                                        dgv2.Rows[n].Cells[3].Value.ToString() + "', '" + txtTotalCost.Text + "', '" + date.ToString("yyyy-MM-dd HH:mm:ss") + "')");
                                    //insert data into tblvoided receipt
                                    data.executeSQL("Insert into tblvoided_receipt (TransactionNumber, CustomerName, ProductName, Qty, Price, TotalAmount, Status)" +
                                        "Values('" + transnumber + "', '" + txtCustomer.Text + "', '" + dgv2.Rows[n].Cells[1].Value.ToString() + "', '" + dgv2.Rows[n].Cells[2].Value.ToString() + "', '" +
                                        dgv2.Rows[n].Cells[3].Value.ToString() + "', '" + txtTotalCost.Text + "', 'Active')");
                                }

                                //insert data into tblLogs
                                data.executeSQL("Insert into tblLogs (datelog, timelog, full_name, action, module) Values ('" + date.ToString("yyyy-MM-dd") + "', '" + date.ToString("hh:mm:tt") + "', '" + 
                                    username.ToString() + "', 'Checked Out Transaction Number: " + transnumber.ToString() + " by: " + username.ToString() + "', 'POS')");

                                prf.ShowDialog();
                                cn.Close();
                            }

                            if (cmbReceipt.SelectedIndex == 1)
                            {
                                cn.Open();
                                cm = new MySqlCommand("select * from tblproduct  ", cn);
                                dr = cm.ExecuteReader();
                                dr.Read();
                                DataTable dt = data.GetData("select * from tblposcustomerinfo where Fullname ='" + txtCustomer.Text + "'");
                                string customername = dt.Rows[0][0].ToString();
                                string address = dt.Rows[0][2].ToString();
                                string contactnumber = dt.Rows[0][4].ToString();


                                Pos_Receipt_Phosclay prp = new Pos_Receipt_Phosclay(cmbReceipt2.Text, customername, address, contactnumber, date.ToString("MMM. dd, yyyy"), this, txtRemainingBalance.Text, txtReference.Text, username, ds);

                                for (int a = 0; a < dgv2.Rows.Count; a++)
                                {
                                    int n = prp.dgv4.Rows.Add();
                                    a = n;
                                    prp.dgv4.Rows[n].Cells[0].Value = dgv2.Rows[n].Cells[0].Value.ToString();
                                    prp.dgv4.Rows[n].Cells[1].Value = dgv2.Rows[n].Cells[1].Value.ToString();
                                    prp.dgv4.Rows[n].Cells[2].Value = dgv2.Rows[n].Cells[2].Value.ToString();
                                    prp.dgv4.Rows[n].Cells[3].Value = dgv2.Rows[n].Cells[3].Value.ToString();

                                    //insert data into tblreceipt
                                    data.executeSQL("Insert into tblreceipt (TransactionNumber, CustomerName, ProductName, Qty, Price, TotalAmount, Date)" +
                                        "Values('" + transnumber + "', '" + txtCustomer.Text + "', '" + dgv2.Rows[n].Cells[1].Value.ToString() + "', '" + dgv2.Rows[n].Cells[2].Value.ToString() + "', '" +
                                        dgv2.Rows[n].Cells[3].Value.ToString() + "', '" + txtTotalCost.Text + "', '" + date.ToString("yyyy-MM-dd HH:mm:ss") + "')");
                                    //insert data into tblvoided receipt
                                    data.executeSQL("Insert into tblvoided_receipt (TransactionNumber, CustomerName, ProductName, Qty, Price, TotalAmount, Status)" +
                                        "Values('" + transnumber + "', '" + txtCustomer.Text + "', '" + dgv2.Rows[n].Cells[1].Value.ToString() + "', '" + dgv2.Rows[n].Cells[2].Value.ToString() + "', '" +
                                        dgv2.Rows[n].Cells[3].Value.ToString() + "', '" + txtTotalCost.Text + "', 'Active')");
                                }
                                
                                //insert data into tblLogs
                                data.executeSQL("Insert into tblLogs (datelog, timelog, full_name, action, module)" +
                                        "Values('" + date.ToString("yyyy-MM-dd") + "', '" + date.ToString("hh:mm:tt") + "', '" + username.ToString() + "', 'Checked Out Transaction Number: " + transnumber.ToString() + " by: " + username.ToString() + "', 'POS')");

                                prp.ShowDialog();
                                cn.Close();
                            }
                        }

                        Point_of_Sale pos = new Point_of_Sale(ds, username);
                        pos.Close();
                    }

                }

                else
                {
                    MessageBox.Show("Payment is not enough, can't proceed to checkout!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Checkout Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cn.Close();
            }
        }

        private void txtAmount_TextChanged_1(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtAmount.Text) || txtAmount.Text == "")
                {
                    txtTotalPay.Text = "0.00";
                }
                if (txtAmount.Text == "100" || txtAmount.Text == "100.00")
                {
                    txtTotalPay.Text = "100";

                }
                txtTotalPay.Text = txtAmount.Text;
                double pay = double.Parse(txtTotalPay.Text);
                double cost = double.Parse(txtTotalCost.Text);
                double rm = cost - pay;
                txtRemainingBalance.Text = rm.ToString();

                if (Convert.ToDouble(txtAmount.Text) < Convert.ToDouble(txtTotalCost.Text))
                {
                    lblChange.Visible = false;
                    lblremainingbalance.Visible = true;

                }
                else if (Convert.ToDouble(txtAmount.Text) > Convert.ToDouble(txtTotalCost.Text))
                {
                    lblChange.Visible = true;
                    lblremainingbalance.Visible = false;
                    double rmr = System.Math.Abs(-rm);
                    txtRemainingBalance.Text = rmr.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on text amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cn.Close();
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {

            search();
            
        }
        public void search()
        {
            try
            {
                string query = "SELECT FullName from tblposcustomerinfo where FullName Like '%" + txtCustomer.Text + "%'";
                cm = new MySqlCommand(query,cn);
                cn.Open();
                dr = cm.ExecuteReader();
                AutoCompleteStringCollection customername = new AutoCompleteStringCollection();
                while(dr.Read())
                {
                    customername.Add(dr.GetString(0));
                }
                txtCustomer.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtCustomer.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtCustomer.AutoCompleteCustomSource = customername;
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Text Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            cmbPaymentOption.SelectedIndex = -1;
            txtAmount.Text = "0.00";
            txtSalesNote.Clear();
        }

        private void btnNewCustomer_Click_1(object sender, EventArgs e)
        {
            Pos_Related.Pos_Customer_Info ps = new Pos_Related.Pos_Customer_Info();
            ps.ShowDialog();
        }
       

        public void getDataSettingsShipping()
        {
            try
            {
                DataTable dt = data.GetData("select * from tblsettings where Form = 'PosShippingCategory'");
                cmbShipping.ValueMember = "Category";
                cmbShipping.DataSource = dt;
                cmbShipping.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on getDataSettings Shipping", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cn.Close();
            }
        }

        public void Validate1()
        {
            errorCount = 0;
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(txtCustomer.Text))
            {
                errorProvider1.SetError(txtCustomer, "This Field is Required");
                errorCount++;
            }
            if (cmbPaymentOption.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbPaymentOption, "This Field is Required");
                errorCount++;
            }

            if (cmbReceipt.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbReceipt, "This Field is Required");
                errorCount++;
            }

            if (cmbReceipt2.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbReceipt2, "This Field is Required");
                errorCount++;
            }

            if (string.IsNullOrEmpty(txtAmount.Text))
            {
                errorProvider1.SetError(txtAmount, "This Field is Required");
                errorCount++;
            }

            if (txtReference.Enabled == true)
            {
                if (string.IsNullOrEmpty(txtReference.Text))
                {
                    errorProvider1.SetError(txtReference, "This Field is Required");
                    errorCount++;
                }
            }
        }
    }
}
