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
    public partial class Overview : Form
    {
        private Size formOriginalSize;
        //label
        private Rectangle Label1;
        private Rectangle Label2;
        private Rectangle Label3;
        private Rectangle Label4;
        private Rectangle Label5;
        private Rectangle Label6;
        private Rectangle Label7;
        private Rectangle Label8;
        private Rectangle Label9;
        private Rectangle Label10;
        private Rectangle Label11;
        private Rectangle Label12;
        private Rectangle Label13;
        private Rectangle Label14;
        private Rectangle Label15;
        private Rectangle Label16;
        private Rectangle Label17;
        private Rectangle Label18;
        private Rectangle Label19;
        private Rectangle Label20;
        private Rectangle Label21;
        private Rectangle Label22;
        private Rectangle Label23;
        private Rectangle Label24;
        private Rectangle Label25;
        private Rectangle Label26;
        private Rectangle Label27;
        private Rectangle Label28;
        private Rectangle Label29;
        private Rectangle Label30;
        private Rectangle Label31;
        private Rectangle Label32;
        private Rectangle Label33;

        //panel
        private Rectangle pN1;
        private Rectangle pN2;
        private Rectangle pN3;
        private Rectangle pN4;
        private Rectangle pN5;
        private Rectangle pN6;
        private Rectangle pN7;
        private Rectangle pN8;
        private Rectangle pN9;
        private Rectangle pN10;
        private Rectangle pN11;
        private Rectangle pN12;
        private Rectangle pN13;
        private Rectangle pN14;
        private Rectangle pN15;

        //combobox
        private Rectangle combobox1;
        private Rectangle combobox2;
        private Rectangle combobox3;

        //chart
        private Rectangle c1;
        private Rectangle c2;
        //datagridview//
        private Rectangle Datagrid;
        public void autosize()
        {
            formOriginalSize = this.Size;
            Label9 = new Rectangle(lbl9.Location.X, lbl9.Location.Y, lbl9.Width, lbl9.Height);
            Label1 = new Rectangle(lbl1.Location.X, lbl1.Location.Y, lbl1.Width, lbl1.Height);
            Label2 = new Rectangle(lbl2.Location.X, lbl2.Location.Y, lbl2.Width, lbl2.Height);
            Label4 = new Rectangle(lbl4.Location.X, lbl4.Location.Y, lbl4.Width, lbl4.Height);
            Label13 = new Rectangle(lbl13.Location.X, lbl13.Location.Y, lbl13.Width, lbl13.Height);
            Label6 = new Rectangle(lbl6.Location.X, lbl6.Location.Y, lbl6.Width, lbl6.Height);
            Label7 = new Rectangle(lbl7.Location.X, lbl7.Location.Y, lbl1.Width, lbl1.Height);
            Label8 = new Rectangle(lbl8.Location.X, lbl8.Location.Y, lbl2.Width, lbl2.Height);
            Label14 = new Rectangle(lbl14.Location.X, lbl14.Location.Y, lbl14.Width, lbl14.Height);
            Label10 = new Rectangle(lbl10.Location.X, lbl10.Location.Y, lbl10.Width, lbl10.Height);
            Label27 = new Rectangle(lblSalesToday.Location.X, lblSalesToday.Location.Y, lblSalesToday.Width, lblSalesToday.Height);
            Label28 = new Rectangle(lblPhosclayTransaction.Location.X, lblPhosclayTransaction.Location.Y, lblPhosclayTransaction.Width, lblPhosclayTransaction.Height);
            Label29 = new Rectangle(lblFragranzaTransaction.Location.X, lblFragranzaTransaction.Location.Y, lblFragranzaTransaction.Width, lblFragranzaTransaction.Height);
            Label30 = new Rectangle(lblTotalCustomer.Location.X, lblTotalCustomer.Location.Y, lblTotalCustomer.Width, lblTotalCustomer.Height);
            Label31 = new Rectangle(lblNewCustomer.Location.X, lblNewCustomer.Location.Y, lblNewCustomer.Width, lblNewCustomer.Height);
            Label32 = new Rectangle(lblMonthlySales.Location.X, lblMonthlySales.Location.Y, lblMonthlySales.Width, lblMonthlySales.Height);
            Label33 = new Rectangle(label33.Location.X, label33.Location.Y, label33.Width, label33.Height);

            //panel//
            pN1 = new Rectangle(pn1.Location.X, pn1.Location.Y, pn1.Width, pn1.Height);
            pN2 = new Rectangle(pn2.Location.X, pn2.Location.Y, pn2.Width, pn2.Height);
            pN3 = new Rectangle(pn3.Location.X, pn3.Location.Y, pn3.Width, pn3.Height);
            pN5 = new Rectangle(pn5.Location.X, pn5.Location.Y, pn5.Width, pn5.Height);
            pN6 = new Rectangle(pn6.Location.X, pn6.Location.Y, pn6.Width, pn6.Height);
            pN10 = new Rectangle(pn10.Location.X, pn10.Location.Y, pn10.Width, pn10.Height);
            pN11 = new Rectangle(pn11.Location.X, pn11.Location.Y, pn11.Width, pn11.Height);
            pN12 = new Rectangle(pn12.Location.X, pn12.Location.Y, pn12.Width, pn12.Height);
            pN14 = new Rectangle(pn14.Location.X, pn14.Location.Y, pn14.Width, pn14.Height);

            //chart//
            c1 = new Rectangle(chart1.Location.X, chart1.Location.Y, chart1.Width, chart1.Height);
            c2 = new Rectangle(chart3.Location.X, chart3.Location.Y, chart3.Width, chart3.Height);

            //combobox//
            combobox1 = new Rectangle(cmbTodaySales.Location.X, cmbTodaySales.Location.Y, cmbTodaySales.Width, cmbTodaySales.Height);
            combobox2 = new Rectangle(cmbMonthlySalesReport.Location.X, cmbMonthlySalesReport.Location.Y, cmbMonthlySalesReport.Width, cmbMonthlySalesReport.Height);
            combobox3 = new Rectangle(cmbTopsales.Location.X, cmbTopsales.Location.Y, cmbTopsales.Width, cmbTopsales.Height);

            //datagrid//
            Datagrid = new Rectangle(dataGridView1.Location.X, dataGridView1.Location.Y, dataGridView1.Width, dataGridView1.Height);
        }


        private void resizeChildrenControl()
        {
            //label//
            resizeControl(Label1, lbl1);
            resizeControl(Label2, lbl2);
            resizeControl(Label4, lbl4);
            //resizeControl(Label5, lbl5);
            resizeControl(Label6, lbl6);
            resizeControl(Label7, lbl7);
            resizeControl(Label8, lbl8);
            resizeControl(Label9, lbl9);
            resizeControl(Label10, lbl10);
            resizeControl(Label13, lbl13);
            resizeControl(Label14, lbl14);;
            resizeControl(Label17, lbl17);
            resizeControl(Label27, lblSalesToday);
            resizeControl(Label28, lblPhosclayTransaction);
            resizeControl(Label29, lblFragranzaTransaction);
            resizeControl(Label30, lblTotalCustomer);
            resizeControl(Label31, lblNewCustomer);
            resizeControl(Label32, lblMonthlySales);
            resizeControl(Label33, label33);

            //panel//
            resizeControl(pN1, pn1);
            resizeControl(pN2, pn2);
            resizeControl(pN3, pn3);
            resizeControl(pN5, pn5);
            resizeControl(pN6, pn6);
            resizeControl(pN10, pn10);
            resizeControl(pN11, pn11);
            resizeControl(pN12, pn12);
            resizeControl(pN14, pn14);

            //combobox//
            resizeControl(combobox1, cmbTodaySales);
            resizeControl(combobox2, cmbMonthlySalesReport);
            resizeControl(combobox3, cmbTopsales);

            //chart//
            resizeControl(c1, chart1);
            resizeControl(c2, chart3);

            //datagrid//
            resizeControl(Datagrid, dataGridView1);
        }
        private void resizeControl(Rectangle OriginalControlRect, Control control)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);


            int newX = (int)(OriginalControlRect.X * xRatio);
            int newY = (int)(OriginalControlRect.Y * yRatio);

            int newWidth = (int)(OriginalControlRect.Width * xRatio);
            int newHeight = (int)(OriginalControlRect.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
        }

        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;
        DataTable dt;
        MySqlDataAdapter adpt;
        DateTime date = DateTime.Now;
        string month = DateTime.Now.ToString("MMMM");
        string year = DateTime.Now.ToString("yyyy");
        MainConnection data = new MainConnection();
        public Overview()
        {
            InitializeComponent();
            cn = new MySqlConnection();
            cn.ConnectionString = data.getConnection();
            getFragranzaSalesToday();
            getFragranzaTransactions();
            getPhosclayTransactions();
            todaysChart();
            getTotalCustomers();
            getNewCustomers();
            monthChart();
            monthlysales();
            salesToday();
            LoadData();
        }

        private void Overview_Load(object sender, EventArgs e)
        {
            cmbTodaySales.SelectedIndex = -1;
            timer1.Start();
            autosize();
        }
        private void LoadData()
        {
            try
            {
                dt = new DataTable();
                adpt = new MySqlDataAdapter("select tblreceipt.ProductName,(sum(tblreceipt.Qty)) AS TOTALCOUNT from tblreceipt GROUP BY ProductName ORDER BY TOTALCOUNT DESC", cn);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on loading datagridview", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void getFragranzaTransactions()
        {
            try
            {
                cn.Open();
                cm = new MySqlCommand("Select COUNT(Receipt) from tblcheckout where Receipt ='Fragranza' And DATE(Date) = CURDATE()", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                lblFragranzaTransaction.Text = dr["COUNT(Receipt)"].ToString();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error on Getfragranza Transaction",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public void getPhosclayTransactions()
        {
            try
            {
  
                cn.Open();
                cm = new MySqlCommand("Select COUNT(Receipt) from tblcheckout where Receipt ='Phosclay' And DATE(Date) = CURDATE()", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                lblPhosclayTransaction.Text = dr["COUNT(Receipt)"].ToString();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error on GetPhosclay Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void getNewCustomers()
        {
            try
            {
                cn.Open();
                cm = new MySqlCommand("Select COUNT(dateRegistered) from tblposcustomerinfo where dateRegistered ='" + date.ToString("MMM. dd, yyyy") + "'", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                lblNewCustomer.Text = dr["COUNT(dateRegistered)"].ToString();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on getNewCustomer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void getTotalCustomers()
        {
            try
            {
                cn.Open();
                cm = new MySqlCommand("Select COUNT(FullName) from tblposcustomerinfo", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                lblTotalCustomer.Text = dr["COUNT(Fullname)"].ToString();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on getTotalCustomer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void salesToday()
        {
            try
            {
                cn.Open();
                cm = new MySqlCommand("SELECT COALESCE(SUM(REPLACE(TOTALCOST, ',', '')), 0) FROM tblcheckout WHERE DATE(Date) = CURDATE()", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                double sum = double.Parse(dr["COALESCE(SUM(REPLACE(TOTALCOST, ',', '')), 0)"].ToString());
                lblSalesToday.Text = sum.ToString("#,##0.00");
                cn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on SalesToday Overview", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void getFragranzaSalesToday()
        {
            try
            {
                cn.Open();
                cm = new MySqlCommand("SELECT COALESCE(SUM(REPLACE(TOTALCOST, ',', '')), 0) FROM tblcheckout WHERE Receipt ='Fragranza' AND DATE(Date) = CURDATE()", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                double sum = double.Parse(dr["COALESCE(SUM(REPLACE(TOTALCOST, ',', '')), 0)"].ToString());
                lblSalesToday.Text = sum.ToString("#,##0.00");
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Getfragranza SalesToday Overview", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void getPhosclaySalesToday()
        {
            try
            {
                cn.Open();
                cm = new MySqlCommand("SELECT COALESCE(SUM(REPLACE(TOTALCOST, ',', '')), 0) from tblcheckout where Receipt ='Phosclay' And DATE(Date) = CURDATE()", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                double sum = double.Parse(dr["COALESCE(SUM(REPLACE(TOTALCOST, ',', '')), 0)"].ToString());
                lblSalesToday.Text = sum.ToString("#,##0.00");
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on GetPhosclay SalesToday Overview", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void todaysChart()
        {
            try
            {
                MySqlDataAdapter adpt = new MySqlDataAdapter("SELECT SUM(Amount), Receipt from tblcheckout WHERE DATE(Date) = CURDATE() Group By Receipt ", cn);
                DataSet ds = new DataSet();

                adpt.Fill(ds, "Sales");
                chart1.DataSource = ds.Tables["Sales"];

                chart1.Series["Sales"].XValueMember = "Receipt";
                chart1.Series["Sales"].YValueMembers = "SUM(Amount)";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on monthchart", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cn.Close();
            }
        }
        private void monthChart()
        {
            try
            {
                MySqlDataAdapter adpt = new MySqlDataAdapter("SELECT SUM(TotalCost), MONTH(Date) as Month from tblcheckout WHERE Year(Date) = Year(CURRENT_DATE()) GROUP BY MONTH(Date)", cn);
                DataSet ds = new DataSet();

                adpt.Fill(ds, "MonthlySales");
                chart3.DataSource = ds.Tables["MonthlySales"];

                chart3.Series["MonthlySales"].XValueMember = "Month";
                chart3.Series["MonthlySales"].YValueMembers = "SUM(TotalCost)";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on monthchart", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cn.Close();
            }
        }
        private void monthlysales()
        {
            string query = "SELECT COALESCE(SUM(TotalCost),0) from tblcheckout WHERE MONTH(Date) = MONTH(CURRENT_DATE()) AND YEAR(Date) = YEAR(CURRENT_DATE())";
            try
            {
                cn.Open();
                cm = new MySqlCommand(query, cn);
                Int32 row_count = Convert.ToInt32(cm.ExecuteScalar());
                cm.Dispose();
                cn.Close();

                lblMonthlySales.Text = row_count.ToString("#,##0.00");
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Monthly Sales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cn.Close();
            }
        }
        private void cmbMonthlySalesReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbMonthlySalesReport.SelectedIndex == 0)
                {
                    string query = "SELECT COALESCE(SUM(TotalCost),0) from tblcheckout WHERE Receipt = 'Fragranza' AND YEAR(Date) = YEAR(CURRENT_DATE()) And MONTH(Date) = MONTH(CURRENT_DATE())";
                    cn.Open();
                    cm = new MySqlCommand(query, cn);
                    Int32 row_count = Convert.ToInt32(cm.ExecuteScalar());
                    cm.Dispose();
                    cn.Close();

                    lblMonthlySales.Text = row_count.ToString("#,##0.00");
                    cn.Close();
                }
                else
                {
                    string query = "SELECT COALESCE(SUM(TotalCost),0) from tblcheckout WHERE Receipt = 'Phosclay' AND YEAR(Date) = YEAR(CURRENT_DATE()) And MONTH(Date) = MONTH(CURRENT_DATE())";
                    cn.Open();
                    cm = new MySqlCommand(query, cn);
                    Int32 row_count = Convert.ToInt32(cm.ExecuteScalar());
                    cm.Dispose();
                    cn.Close();

                    lblMonthlySales.Text = row_count.ToString("#,##0.00");
                    cn.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Monthly sales ComboBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cn.Close();
            }
        }
        private void cmbTodaySales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTodaySales.SelectedIndex == 0)
            {
                getFragranzaSalesToday();
            }
            else if (cmbTodaySales.SelectedIndex == 1)
            {
                getPhosclaySalesToday();
            }
            
        }

        private void lblSalesReport_Click(object sender, EventArgs e)
        {
            SalesReport sr = new SalesReport();
            sr.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToString("dddd, MMMM, dd, yyyy");
            lbltime.Text = DateTime.Now.ToString("hh:mm:ss:tt");
        }

        private void Overview_Resize(object sender, EventArgs e)
        {
            resizeChildrenControl();
        }

        private void cmbTopsales_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                adpt = new MySqlDataAdapter("select tblreceipt.ProductName,(sum(tblreceipt.Qty)) AS TOTALCOUNT from tblreceipt where MONTH(Date) = MONTH(CURRENT_DATE()) AND Date > NOW()  - INTERVAL '" + 
                    cmbTopsales.Text + "' day GROUP BY ProductName ORDER BY TOTALCOUNT DESC", cn);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error on Top Sales",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
