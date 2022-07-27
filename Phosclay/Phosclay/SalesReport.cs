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
using System.Windows.Forms.DataVisualization.Charting;
namespace Phosclay
{
    public partial class SalesReport : Form
    {
        private Size formOriginalSize;
        private Rectangle s1;
        private Rectangle Label36;
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
        private Rectangle pN16;
        private Rectangle pN17;
        private Rectangle pN18;

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
        private Rectangle Label34;
        private Rectangle Label35;

        //chart
        private Rectangle c1;
        private Rectangle c2;
        private Rectangle c3;

        //combobox
        private Rectangle combobox1;
        private Rectangle combobox2;
        private Rectangle combobox3;
        private Rectangle combobox4;
        public void autosize()
        {
            formOriginalSize = this.Size;
            s1 = new Rectangle(separator.Location.X, separator.Location.Y, separator.Width, separator.Height);
            //panel//
            pN1 = new Rectangle(pn1.Location.X, pn1.Location.Y, pn1.Width, pn1.Height);
            pN2 = new Rectangle(pn2.Location.X, pn2.Location.Y, pn2.Width, pn2.Height);
            pN3 = new Rectangle(pn3.Location.X, pn3.Location.Y, pn3.Width, pn3.Height);
            pN4 = new Rectangle(pn4.Location.X, pn4.Location.Y, pn4.Width, pn4.Height);
            pN5 = new Rectangle(pn5.Location.X, pn5.Location.Y, pn5.Width, pn5.Height);
            pN6 = new Rectangle(pn6.Location.X, pn6.Location.Y, pn6.Width, pn6.Height);
            pN7 = new Rectangle(pn7.Location.X, pn7.Location.Y, pn7.Width, pn7.Height);
            pN8 = new Rectangle(pn8.Location.X, pn8.Location.Y, pn8.Width, pn8.Height);
            pN9 = new Rectangle(pn9.Location.X, pn9.Location.Y, pn9.Width, pn9.Height);
            pN10 = new Rectangle(pn10.Location.X, pn10.Location.Y, pn10.Width, pn10.Height);
            pN11 = new Rectangle(pn11.Location.X, pn11.Location.Y, pn11.Width, pn11.Height);
            pN12 = new Rectangle(pn12.Location.X, pn12.Location.Y, pn12.Width, pn12.Height);
            pN13 = new Rectangle(pn13.Location.X, pn13.Location.Y, pn13.Width, pn13.Height);
            pN14 = new Rectangle(pn14.Location.X, pn14.Location.Y, pn14.Width, pn14.Height);
            pN15 = new Rectangle(pn15.Location.X, pn15.Location.Y, pn15.Width, pn15.Height);
            pN16 = new Rectangle(pn16.Location.X, pn16.Location.Y, pn16.Width, pn16.Height);
            pN17 = new Rectangle(pn17.Location.X, pn17.Location.Y, pn17.Width, pn17.Height);
            pN18 = new Rectangle(pn18.Location.X, pn18.Location.Y, pn18.Width, pn18.Height);

            //label//
            Label1 = new Rectangle(lbl1.Location.X, lbl1.Location.Y, lbl1.Width, lbl1.Height);
            Label2 = new Rectangle(lbl2.Location.X, lbl2.Location.Y, lbl2.Width, lbl2.Height);
            Label3 = new Rectangle(lbl3.Location.X, lbl3.Location.Y, lbl3.Width, lbl3.Height);
            Label4 = new Rectangle(lbl4.Location.X, lbl4.Location.Y, lbl4.Width, lbl4.Height);
            Label5 = new Rectangle(lbl5.Location.X, lbl5.Location.Y, lbl5.Width, lbl5.Height);
            Label6 = new Rectangle(lbl6.Location.X, lbl6.Location.Y, lbl6.Width, lbl6.Height);
            Label7 = new Rectangle(lbl7.Location.X, lbl7.Location.Y, lbl1.Width, lbl1.Height);
            Label8 = new Rectangle(lbl8.Location.X, lbl8.Location.Y, lbl2.Width, lbl2.Height);
            Label9 = new Rectangle(lbl9.Location.X, lbl9.Location.Y, lbl3.Width, lbl3.Height);
            Label10 = new Rectangle(lbl10.Location.X, lbl10.Location.Y, lbl10.Width, lbl10.Height);
            Label11 = new Rectangle(lbl11.Location.X, lbl11.Location.Y, lbl11.Width, lbl11.Height);
            Label12 = new Rectangle(lbl12.Location.X, lbl12.Location.Y, lbl12.Width, lbl12.Height);
            Label13 = new Rectangle(lbl13.Location.X, lbl13.Location.Y, lbl13.Width, lbl13.Height);
            Label14 = new Rectangle(lbl14.Location.X, lbl14.Location.Y, lbl14.Width, lbl14.Height);
            Label15 = new Rectangle(lbl15.Location.X, lbl15.Location.Y, lbl15.Width, lbl15.Height);
            Label16 = new Rectangle(lbl16.Location.X, lbl16.Location.Y, lbl16.Width, lbl16.Height);
            Label17 = new Rectangle(lbl17.Location.X, lbl17.Location.Y, lbl17.Width, lbl17.Height);
            Label19 = new Rectangle(lbl19.Location.X, lbl19.Location.Y, lbl19.Width, lbl19.Height);
            Label20 = new Rectangle(lbl20.Location.X, lbl20.Location.Y, lbl20.Width, lbl20.Height);
            Label22 = new Rectangle(lbl22.Location.X, lbl22.Location.Y, lbl22.Width, lbl22.Height);
            Label23 = new Rectangle(lbl23.Location.X, lbl23.Location.Y, lbl23.Width, lbl23.Height);
            Label24 = new Rectangle(lbl24.Location.X, lbl24.Location.Y, lbl24.Width, lbl24.Height);
            Label25 = new Rectangle(lblFragranzaSalesToday.Location.X, lblFragranzaSalesToday.Location.Y, lblFragranzaSalesToday.Width, lblFragranzaSalesToday.Height);
            Label26 = new Rectangle(lblPhosclaySalesToday.Location.X, lblPhosclaySalesToday.Location.Y, lblPhosclaySalesToday.Width, lblPhosclaySalesToday.Height);
            Label27 = new Rectangle(lblFragranzaTransaction.Location.X, lblFragranzaTransaction.Location.Y, lblFragranzaTransaction.Width, lblFragranzaTransaction.Height);
            Label28 = new Rectangle(lblPhosclayTransaction.Location.X, lblPhosclayTransaction.Location.Y, lblPhosclayTransaction.Width, lblPhosclayTransaction.Height);
            Label29 = new Rectangle(lblperfumestocks.Location.X, lblperfumestocks.Location.Y, lblperfumestocks.Width, lblperfumestocks.Height);
            Label30 = new Rectangle(lblalcoholstocks.Location.X, lblalcoholstocks.Location.Y, lblalcoholstocks.Width, lblalcoholstocks.Height);
            Label31 = new Rectangle(lblNewCustomer.Location.X, lblNewCustomer.Location.Y, lblNewCustomer.Width, lblNewCustomer.Height);
            Label32 = new Rectangle(lblPhosSalesCat.Location.X, lblPhosSalesCat.Location.Y, lblPhosSalesCat.Width, lblPhosSalesCat.Height);
            Label33 = new Rectangle(lblfragsalesCat.Location.X, lblfragsalesCat.Location.Y, lblfragsalesCat.Width, lblfragsalesCat.Height);
            Label34 = new Rectangle(lblweekly.Location.X, lblweekly.Location.Y, lblweekly.Width, lblweekly.Height);
            Label35 = new Rectangle(lblmonthlySales.Location.X, lblmonthlySales.Location.Y, lblmonthlySales.Width, lblmonthlySales.Height);
            Label36 = new Rectangle(lbl36.Location.X, lbl36.Location.Y, lbl36.Width, lbl36.Height);

            //chart//
            c1 = new Rectangle(chart1.Location.X, chart1.Location.Y, chart1.Width, chart1.Height);
            c2 = new Rectangle(chart2.Location.X, chart2.Location.Y, chart2.Width, chart2.Height);
            c3 = new Rectangle(chart3.Location.X, chart3.Location.Y, chart3.Width, chart3.Height);

            //combobox//
            combobox2 = new Rectangle(cmbYSelect.Location.X, cmbYSelect.Location.Y, cmbYSelect.Width, cmbYSelect.Height);

        }

        private void resizeChildrenControl()
        {
            resizeControl(s1, separator);
            //combobox//
            resizeControl(combobox2, cmbYSelect);

            //chart//
            resizeControl(c1, chart1);
            resizeControl(c2, chart2);
            resizeControl(c3, chart3);

            //panel//
            resizeControl(pN1, pn1);
            resizeControl(pN2, pn2);
            resizeControl(pN3, pn3);
            resizeControl(pN4, pn4);
            resizeControl(pN5, pn5);
            resizeControl(pN6, pn6);
            resizeControl(pN7, pn7);
            resizeControl(pN8, pn8);
            resizeControl(pN9, pn9);
            resizeControl(pN10, pn10);
            resizeControl(pN11, pn11);
            resizeControl(pN12, pn12);
            resizeControl(pN13, pn13);
            resizeControl(pN14, pn14);
            resizeControl(pN15, pn15);
            resizeControl(pN16, pn16);
            resizeControl(pN17, pn17);
            resizeControl(pN18, pn18);

            //label//
            resizeControl(Label1, lbl1);
            resizeControl(Label2, lbl2);
            resizeControl(Label3, lbl3);
            resizeControl(Label4, lbl4);
            resizeControl(Label5, lbl5);
            resizeControl(Label6, lbl6);
            resizeControl(Label7, lbl7);
            resizeControl(Label8, lbl8);
            resizeControl(Label9, lbl9);
            resizeControl(Label10, lbl10);
            resizeControl(Label11, lbl11);
            resizeControl(Label12, lbl12);
            resizeControl(Label13, lbl13);
            resizeControl(Label14, lbl14);
            resizeControl(Label15, lbl15);
            resizeControl(Label16, lbl16);
            resizeControl(Label17, lbl17);
            resizeControl(Label19, lbl19);
            resizeControl(Label20, lbl20);
            resizeControl(Label22, lbl22);
            resizeControl(Label23, lbl23);
            resizeControl(Label24, lbl24);
            resizeControl(Label25, lblFragranzaSalesToday);
            resizeControl(Label26, lblPhosclaySalesToday);
            resizeControl(Label27, lblFragranzaTransaction);
            resizeControl(Label28, lblPhosclayTransaction);
            resizeControl(Label29, lblperfumestocks);
            resizeControl(Label30, lblalcoholstocks);
            resizeControl(Label31, lblNewCustomer);
            resizeControl(Label32, lblPhosSalesCat);
            resizeControl(Label33, lblfragsalesCat);
            resizeControl(Label34, lblweekly);
            resizeControl(Label35, lblmonthlySales);
            resizeControl(Label36, lbl36);
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

        MainConnection data = new MainConnection();
        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;
        string year = DateTime.Now.Year.ToString();
        public SalesReport()
        {
            InitializeComponent();
            cn = new MySqlConnection();
            cn.ConnectionString = data.getConnection();
            //Dashboard();
        }
        
        DateTime date = DateTime.Now;

        private void InventoryManagement_Load(object sender, EventArgs e)
        {
            timer1.Start();
            autosize();
            
            getNewCustomers();
            getFragranzaTransactions();
            getPhosclayTransactions();
            getFragranzaSalesToday();
            getPhosclaySalesToday();
            getSalesPercentage();
            PerfumeStock();
            AlcoholStocks();
            SalesTodayChart();
            monthYearchart();
            Yearchart();
            cmbMSelect.Text = DateTime.Now.ToString("MMMM");
            cmbYSelect.Text = DateTime.Now.Year.ToString();
            cmbMSelect.Visible = true;

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToString("dddd, MMMM, dd, yyyy");
            lbltime.Text = DateTime.Now.ToString("hh:mm:ss:tt");
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "error on loading New Customer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cn.Close();
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "error on loading on Fragranza Transaction", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cn.Close();
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
                MessageBox.Show(ex.Message, "error on loading on Phosclay Transaction", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cn.Close();
            }
        }

        public void getFragranzaSalesToday()
        {
            string query = "SELECT COALESCE(SUM(TotalCost),0) from tblcheckout where Receipt ='Fragranza' And DATE(Date) = CURDATE()";
            try
            {
                cn.Open();
                cm = new MySqlCommand(query, cn);
                Int32 row_count = Convert.ToInt32(cm.ExecuteScalar());
                cm.Dispose();
                cn.Close();

                lblFragranzaSalesToday.Text = row_count.ToString("#,##0.00");
                lblfragsalesCat.Text = row_count.ToString("#,##0.00");
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error on loading on FragranzaSalesToday", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void getPhosclaySalesToday()
        {
            string query = "SELECT COALESCE(SUM(TotalCost),0) from tblcheckout where Receipt ='Phosclay' And DATE(Date) = CURDATE()";
            try
            {
                cn.Open();
                cm = new MySqlCommand(query, cn);
                Int32 row_count = Convert.ToInt32(cm.ExecuteScalar());
                cm.Dispose();
                cn.Close();

                lblPhosclaySalesToday.Text = row_count.ToString("#,##0.00");
                lblPhosSalesCat.Text = row_count.ToString("#,##0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error on loading on phosclaySales Today", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cn.Close();
            }
        }

        public void getSalesPercentage()
        {
            try
            {
                int count = Convert.ToInt32(lblFragranzaTransaction.Text) + Convert.ToInt32(lblPhosclayTransaction.Text);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"error on loading on SalesPercentage", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void PerfumeStock()
        {
            
            string PerfumeStocks = "SELECT COALESCE(SUM(Quantity),0) FROM tblproduct WHERE Category= 'Perfume'";

            try
            {
                cn.Open();
                cm = new MySqlCommand(PerfumeStocks, cn);
                Int32 row_count = Convert.ToInt32(cm.ExecuteScalar());
                cm.Dispose();
                cn.Close();

                lblperfumestocks.Text = row_count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Counting Perfume Stock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cn.Close();
            }
        }
        public void AlcoholStocks()
        {

            string AlcoholStocks = "SELECT COALESCE(SUM(Quantity),0) FROM tblproduct WHERE Category= 'Alcohol'";

            try
            {
                cn.Open();
                cm = new MySqlCommand(AlcoholStocks, cn);
                Int32 row_count = Convert.ToInt32(cm.ExecuteScalar());
                cm.Dispose();
                cn.Close();

                lblalcoholstocks.Text = row_count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Counting Alcohol Stock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cn.Close();
            }
        }
        private void cmbMSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cmbMSelect.SelectedIndex == 0)
                {
                    string query = "SELECT COALESCE(SUM(TotalCost),0) from tblcheckout WHERE MONTH(Date) = '01' AND YEAR(Date) = YEAR(CURRENT_DATE())";
                    cn.Open();
                    cm = new MySqlCommand(query, cn);
                    Int32 row_count = Convert.ToInt32(cm.ExecuteScalar());
                    cm.Dispose();
                    cn.Close();

                    lblmonthlySales.Text = row_count.ToString("#,##0.00");
                    cn.Close();
                }
                else if(cmbMSelect.SelectedIndex == 1)
                {
                    string query = "SELECT COALESCE(SUM(TotalCost),0) from tblcheckout WHERE MONTH(Date) = '02' AND YEAR(Date) = YEAR(CURRENT_DATE())";
                    cn.Open();
                    cm = new MySqlCommand(query, cn);
                    Int32 row_count = Convert.ToInt32(cm.ExecuteScalar());
                    cm.Dispose();
                    cn.Close();

                    lblmonthlySales.Text = row_count.ToString("#,##0.00");
                    cn.Close();
                }
                else if (cmbMSelect.SelectedIndex == 2)
                {
                    string query = "SELECT COALESCE(SUM(TotalCost),0) from tblcheckout WHERE MONTH(Date) = '03' AND YEAR(Date) = YEAR(CURRENT_DATE())";
                    cn.Open();
                    cm = new MySqlCommand(query, cn);
                    Int32 row_count = Convert.ToInt32(cm.ExecuteScalar());
                    cm.Dispose();
                    cn.Close();

                    lblmonthlySales.Text = row_count.ToString("#,##0.00");
                    cn.Close();
                }
                else if (cmbMSelect.SelectedIndex == 3)
                {
                    string query = "SELECT COALESCE(SUM(TotalCost),0) from tblcheckout WHERE MONTH(Date) = '04' AND YEAR(Date) = YEAR(CURRENT_DATE())";
                    cn.Open();
                    cm = new MySqlCommand(query, cn);
                    Int32 row_count = Convert.ToInt32(cm.ExecuteScalar());
                    cm.Dispose();
                    cn.Close();

                    lblmonthlySales.Text = row_count.ToString("#,##0.00");
                    cn.Close();
                }
                else if (cmbMSelect.SelectedIndex == 4)
                {
                    string query = "SELECT COALESCE(SUM(TotalCost),0) from tblcheckout WHERE MONTH(Date) = '05' AND YEAR(Date) = YEAR(CURRENT_DATE())";
                    cn.Open();
                    cm = new MySqlCommand(query, cn);
                    Int32 row_count = Convert.ToInt32(cm.ExecuteScalar());
                    cm.Dispose();
                    cn.Close();

                    lblmonthlySales.Text = row_count.ToString("#,##0.00");
                    cn.Close();
                }
                else if (cmbMSelect.SelectedIndex == 5)
                {
                    string query = "SELECT COALESCE(SUM(TotalCost),0) from tblcheckout WHERE MONTH(Date) = '06' AND YEAR(Date) = YEAR(CURRENT_DATE())";
                    cn.Open();
                    cm = new MySqlCommand(query, cn);
                    Int32 row_count = Convert.ToInt32(cm.ExecuteScalar());
                    cm.Dispose();
                    cn.Close();

                    lblmonthlySales.Text = row_count.ToString("#,##0.00");
                    cn.Close();
                }
                else if (cmbMSelect.SelectedIndex == 6)
                {
                    string query = "SELECT COALESCE(SUM(TotalCost),0) from tblcheckout WHERE MONTH(Date) = '07' AND YEAR(Date) = YEAR(CURRENT_DATE())";
                    cn.Open();
                    cm = new MySqlCommand(query, cn);
                    Int32 row_count = Convert.ToInt32(cm.ExecuteScalar());
                    cm.Dispose();
                    cn.Close();

                    lblmonthlySales.Text = row_count.ToString("#,##0.00");
                    cn.Close();
                }
                else if (cmbMSelect.SelectedIndex == 7)
                {
                    string query = "SELECT COALESCE(SUM(TotalCost),0) from tblcheckout WHERE MONTH(Date) = '08' AND YEAR(Date) = YEAR(CURRENT_DATE())";
                    cn.Open();
                    cm = new MySqlCommand(query, cn);
                    Int32 row_count = Convert.ToInt32(cm.ExecuteScalar());
                    cm.Dispose();
                    cn.Close();

                    lblmonthlySales.Text = row_count.ToString("#,##0.00");
                    cn.Close();
                }
                else if (cmbMSelect.SelectedIndex == 8)
                {
                    string query = "SELECT COALESCE(SUM(TotalCost),0) from tblcheckout WHERE MONTH(Date) = '09' AND YEAR(Date) = YEAR(CURRENT_DATE())";
                    cn.Open();
                    cm = new MySqlCommand(query, cn);
                    Int32 row_count = Convert.ToInt32(cm.ExecuteScalar());
                    cm.Dispose();
                    cn.Close();

                    lblmonthlySales.Text = row_count.ToString("#,##0.00");
                    cn.Close();
                }
                else if (cmbMSelect.SelectedIndex == 9)
                {
                    string query = "SELECT COALESCE(SUM(TotalCost),0) from tblcheckout WHERE MONTH(Date) = '10' AND YEAR(Date) = YEAR(CURRENT_DATE())";
                    cn.Open();
                    cm = new MySqlCommand(query, cn);
                    Int32 row_count = Convert.ToInt32(cm.ExecuteScalar());
                    cm.Dispose();
                    cn.Close();

                    lblmonthlySales.Text = row_count.ToString("#,##0.00");
                    cn.Close();
                }
                else if (cmbMSelect.SelectedIndex == 10)
                {
                    string query = "SELECT COALESCE(SUM(TotalCost),0) from tblcheckout WHERE MONTH(Date) = '11' AND YEAR(Date) = YEAR(CURRENT_DATE())";
                    cn.Open();
                    cm = new MySqlCommand(query, cn);
                    Int32 row_count = Convert.ToInt32(cm.ExecuteScalar());
                    cm.Dispose();
                    cn.Close();

                    lblmonthlySales.Text = row_count.ToString("#,##0.00");
                    cn.Close();
                }
                else
                {
                    string query = "SELECT COALESCE(SUM(TotalCost),0) from tblcheckout WHERE MONTH(Date) = '12' AND YEAR(Date) = YEAR(CURRENT_DATE())";
                    cn.Open();
                    cm = new MySqlCommand(query, cn);
                    Int32 row_count = Convert.ToInt32(cm.ExecuteScalar());
                    cm.Dispose();
                    cn.Close();

                    lblmonthlySales.Text = row_count.ToString("#,##0.00");
                    cn.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Monthly Sales Combobox", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cn.Close();
            }
        }
        public void monthYearchart()
        {
            try
            {
                MySqlDataAdapter adpt = new MySqlDataAdapter("SELECT SUM(TotalCost), MONTH(Date) as Month from tblcheckout WHERE YEAR(Date) = YEAR(CURRENT_DATE()) GROUP BY MONTH(Date)", cn);
                DataSet ds = new DataSet();

                adpt.Fill(ds, "Sales");
                chart3.DataSource = ds.Tables["Sales"];

                chart3.Series["Sales"].XValueMember = "Month";
                chart3.Series["Sales"].YValueMembers = "SUM(TotalCost)";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on monthchart", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cn.Close();
            }
        }
        public void SalesTodayChart()
        {
            try
            {
                MySqlDataAdapter adpt = new MySqlDataAdapter("SELECT SUM(TotalCost), TransactionType from tblcheckout WHERE DATE(Date) = CURDATE() Group By TransactionType ", cn);
                DataSet ds = new DataSet();

                adpt.Fill(ds, "Sales");
                chart1.DataSource = ds.Tables["Sales"];

                chart1.Series["Sales"].XValueMember = "TransactionType";
                chart1.Series["Sales"].YValueMembers = "SUM(TotalCost)";
                chart1.Series[0].Label = "#PERCENT";
                chart1.Series[0].LegendText = "#VALX";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on SalesToday Chart", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cn.Close();
            }
        }
        public void Yearchart()
        {
            try
            {
                MySqlDataAdapter adpt = new MySqlDataAdapter("SELECT SUM(TotalCost), YEAR(Date) as Year from tblcheckout Group By YEAR(Date)", cn);
                DataSet ds = new DataSet();

                adpt.Fill(ds, "Sales");
                chart2.DataSource = ds.Tables["Sales"];

                chart2.Series["Sales"].XValueMember = "Year";
                chart2.Series["Sales"].YValueMembers = "SUM(TotalCost)";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Yearchart", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cn.Close();
            }
        }
        
        private void cmbYSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYSelect.SelectedIndex < 15)
            {
                yearlyReport();
            }
        }
        private void yearlyReport()
        {
            cn.Open();
            cm = new MySqlCommand("SELECT COALESCE(FORMAT(SUM(REPLACE(TotalCost, ',', '')), 0),0) from tblcheckout WHERE YEAR(Date) = '" + cmbYSelect.Text + "' ", cn);
            dr = cm.ExecuteReader();
            dr.Read();
            double sum = double.Parse(dr["COALESCE(FORMAT(SUM(REPLACE(TotalCost, ',', '')), 0),0)"].ToString());
            lblweekly.Text = sum.ToString("#,##0.00");
            cn.Close();

            cn.Open();
            cm = new MySqlCommand("SELECT COALESCE(FORMAT(SUM(REPLACE(TotalCost, ',', '')), 0),0) from tblcheckout WHERE Receipt = 'Phosclay' AND YEAR(Date) = '" + cmbYSelect.Text + "' ", cn);
            dr = cm.ExecuteReader();
            dr.Read();
            double phos = double.Parse(dr["COALESCE(FORMAT(SUM(REPLACE(TotalCost, ',', '')), 0),0)"].ToString());
            lblYPhosclay.Text = phos.ToString("#,##0.00");
            cn.Close();

            cn.Open();
            cm = new MySqlCommand("SELECT COALESCE(FORMAT(SUM(REPLACE(TotalCost, ',', '')), 0),0) from tblcheckout WHERE Receipt = 'Fragranza' AND YEAR(Date) = '" + cmbYSelect.Text + "' ", cn);
            dr = cm.ExecuteReader();
            dr.Read();
            double frag = double.Parse(dr["COALESCE(FORMAT(SUM(REPLACE(TotalCost, ',', '')), 0),0)"].ToString());
            lblYFragranza.Text = frag.ToString("#,##0.00");
            cn.Close();
        }
        private void SalesReport_Resize(object sender, EventArgs e)
        {
            resizeChildrenControl();
        }
    }
}
