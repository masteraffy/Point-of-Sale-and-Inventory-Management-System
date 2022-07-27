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
using DGVPrinterHelper;
namespace Phosclay
{
    public partial class Manage_Shipping : Form
    {
        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataAdapter adpt;
        MainConnection data = new MainConnection();
        private string username;
        string transnumber, status;
        public Manage_Shipping(string Username)
        {
            InitializeComponent();
            cn = new MySqlConnection();
            cn.ConnectionString = data.getConnection();
            this.username = Username;
            dateFrom.Value = DateTime.Now;
            dateTo.Value = DateTime.Now;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToString("dddd, MMMM, dd, yyyy");
            lbltime.Text = DateTime.Now.ToString("hh:mm:ss:tt:");
        }

        private void Manage_Shipping_Load(object sender, EventArgs e)
        {
            timer1.Start();
            shipping();
            Canceled();
            totalShipping();
            Pending();
            Completed();
            autosize();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void asToday()
        {
            string query = "SELECT COALESCE(COUNT(*),0) FROM tblshipped where Shipping_Date='" + DateTime.Now.ToString("MMM. dd, yyyy") + "' ";

            try
            {
                cn.Open();
                cm = new MySqlCommand(query, cn);
                Int32 row_count = Convert.ToInt32(cm.ExecuteScalar());
                cm.Dispose();
                cn.Close();

                lblTotalShipping.Text = row_count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void shipping()
        {
            try
            {
                DataTable dt = new DataTable();
                adpt = new MySqlDataAdapter("select * from tblshipped ORDER BY Shipping_Date DESC", cn);
                adpt.Fill(dt);
                dgv1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Product to be shipped", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        public void search()
        {
            try
            {
                DataTable dt = new DataTable();
                cn.Open();
                adpt = new MySqlDataAdapter("Select * from tblshipped where (Customer_Name Like '%" + txtSearch.Text + "%' OR TransactionNumber Like '%" + txtSearch.Text + "%'" +
                    "OR Amount Like '%" + txtSearch.Text + "%' OR Shipping_Method Like '%" + txtSearch.Text + "%' OR PaymentOption Like '%" + txtSearch.Text + "%' OR Status Like '%" + txtSearch.Text + "%')", cn);
                adpt.Fill(dt);
                dgv1.DataSource = dt;
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCheckDate_Click(object sender, EventArgs e)
        {
            searchbyDate();
        }
        public void searchbyDate()
        {
            try
            {
                DataTable dt = new DataTable();
                cn.Open();
                adpt = new MySqlDataAdapter("Select * from tblshipped WHERE Shipping_Date BETWEEN '" +
                    dateFrom.Value.ToString("MMM. dd, yyyy") + "' AND '" + dateTo.Value.ToString("MMM. dd, yyyy") + "' ORDER BY Shipping_Date DESC", cn);
                dt = new DataTable();
                adpt.Fill(dt);
                dgv1.DataSource = dt;
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on searching date", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void totalShipping()
        {
            try
            {
                    string query = "SELECT COALESCE(COUNT(*),0) FROM tblshipped";

                    cn.Open();
                    cm = new MySqlCommand(query, cn);
                    Int32 row_count = Convert.ToInt32(cm.ExecuteScalar());
                    cm.Dispose();
                    cn.Close();

                    lblTotalShipping.Text = row_count.ToString();               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in TotalShipping", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        public void Completed()
        {
            try
            {
                string query = "SELECT COALESCE(COUNT(*),0) FROM tblshipped where Status='Completed'";

                cn.Open();
                cm = new MySqlCommand(query, cn);
                Int32 row_count = Convert.ToInt32(cm.ExecuteScalar());
                cm.Dispose();
                cn.Close();

                lblCompleted.Text = row_count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Completed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Pending()
        {
            try
            {
                string query = "SELECT COALESCE(COUNT(*),0) FROM tblshipped where Status='Pending'";

                cn.Open();
                cm = new MySqlCommand(query, cn);
                Int32 row_count = Convert.ToInt32(cm.ExecuteScalar());
                cm.Dispose();
                cn.Close();

                lblPending.Text = row_count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Pending", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Canceled()
        {
            try
            {
                string query = "SELECT COALESCE(COUNT(*),0) FROM tblshipped where Status='Canceled'";

                cn.Open();
                cm = new MySqlCommand(query, cn);
                Int32 row_count = Convert.ToInt32(cm.ExecuteScalar());
                cm.Dispose();
                cn.Close();

                lblCanceled.Text = row_count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Canceled", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }      
        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgv1.CurrentRow.Selected = true;
                    transnumber = dgv1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    status = dgv1.Rows[e.RowIndex].Cells[8].Value.ToString();
                    Shipping_Records sr = new Shipping_Records(username, transnumber, status);
                    sr.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                adpt = new MySqlDataAdapter("SELECT * FROM tblshipped WHERE MONTH(TransacDate) = MONTH(CURRENT_DATE()) AND TransacDate > NOW()  - INTERVAL '" + cmbFilter.Text + "' day", cn);
                adpt.Fill(dt);
                dgv1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on ComboBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv1.Rows.Count > 0)
                {

                    Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                    xcelApp.Application.Workbooks.Add(Type.Missing);

                    for (int i = 1; i < dgv1.Columns.Count + 1; i++)
                    {
                        xcelApp.Cells[1, i] = dgv1.Columns[i - 1].HeaderText;
                    }

                    for (int i = 0; i < dgv1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgv1.Columns.Count; j++)
                        {
                            xcelApp.Cells[i + 2, j + 1] = dgv1.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    xcelApp.Columns.AutoFit();
                    xcelApp.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error on Button Excel",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void btnprint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Shipping Records";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.ToString("MM/dd/yyyy"));
            printer.SubTitleAlignment = StringAlignment.Center;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = false;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Center;
            printer.Footer = "Fragranza Phosclay";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintPreviewDataGridView(dgv1);
        }
        private void btnrefresh_Click(object sender, EventArgs e)
        {
            shipping();
            Canceled();
            Completed();
            Pending();
            txtSearch.Clear();
            cmbFilter.SelectedIndex = -1;
        }

        //*********************************** ResizeControl Design *************************************//

        private Size formOriginalSize;
        //label
        private Rectangle Label1;
        private Rectangle Label2;
        private Rectangle Label3;
        private Rectangle Label4;
        private Rectangle Label5;
        private Rectangle Label6;
        private Rectangle Label7;
        private Rectangle Label9;
        private Rectangle Label10;
        private Rectangle Label11;
        private Rectangle Label12;
        private Rectangle Label13;
        private Rectangle Label14;

        //combobox
        private Rectangle combobox1;
        private Rectangle combobox2;
        private Rectangle combobox3;

        //textbox
        private Rectangle TextBoxSearch;

        //button
        private Rectangle Button1;
        private Rectangle Button2;
        private Rectangle Button3;
        private Rectangle Button4;
        private Rectangle Button5;

        //datagridview//
        private Rectangle Datagrid;
        public void autosize()
        {
            formOriginalSize = this.Size;
            Label1 = new Rectangle(lbl4.Location.X, lbl4.Location.Y, lbl4.Width, lbl4.Height);
            Label2 = new Rectangle(lbl5.Location.X, lbl5.Location.Y, lbl5.Width, lbl5.Height);
            Label3 = new Rectangle(lbl7.Location.X, lbl7.Location.Y, lbl7.Width, lbl7.Height);
            Label4 = new Rectangle(lblCanceled.Location.X, lblCanceled.Location.Y, lblCanceled.Width, lblCanceled.Height);
            Label5 = new Rectangle(lblCompleted.Location.X, lblCompleted.Location.Y, lblCompleted.Width, lblCompleted.Height);
            Label6 = new Rectangle(label3.Location.X, label3.Location.Y, label3.Width, lbldate.Height);
            Label7 = new Rectangle(lblPending.Location.X, lblPending.Location.Y, lblPending.Width, lblPending.Height);
            Label9 = new Rectangle(lblTotalShipping.Location.X, lblTotalShipping.Location.Y, lblTotalShipping.Width, lblTotalShipping.Height);
            Label10 = new Rectangle(label1.Location.X, label1.Location.Y, label1.Width, label1.Height);
            Label11 = new Rectangle(label3.Location.X, label3.Location.Y, label3.Width, label3.Height);
            Label12 = new Rectangle(label4.Location.X, label4.Location.Y, label4.Width, label4.Height);
            Label13 = new Rectangle(label6.Location.X, label6.Location.Y, label6.Width, label6.Height);
            Label14 = new Rectangle(label8.Location.X, label8.Location.Y, label8.Width, label8.Height);

            //combobox//
            combobox1 = new Rectangle(cmbFilter.Location.X, cmbFilter.Location.Y, cmbFilter.Width, cmbFilter.Height);
            combobox2 = new Rectangle(dateFrom.Location.X, dateFrom.Location.Y, dateFrom.Width, dateFrom.Height);
            combobox3 = new Rectangle(dateTo.Location.X, dateTo.Location.Y, dateTo.Width, dateTo.Height);

            //textbox
            TextBoxSearch = new Rectangle(txtSearch.Location.X, txtSearch.Location.Y, txtSearch.Width, txtSearch.Height);

            //button
            Button1 = new Rectangle(btnCheckDate.Location.X, btnCheckDate.Location.Y, btnCheckDate.Width, btnCheckDate.Height);
            Button2 = new Rectangle(btnok.Location.X, btnok.Location.Y, btnok.Width, btnok.Height);
            Button3 = new Rectangle(btnprint.Location.X, btnprint.Location.Y, btnprint.Width, btnprint.Height);
            Button4 = new Rectangle(btnrefresh.Location.X, btnrefresh.Location.Y, btnrefresh.Width, btnrefresh.Height);
            Button5 = new Rectangle(btnexcel.Location.X, btnexcel.Location.Y, btnexcel.Width, btnexcel.Height);

            //datagrid//
            Datagrid = new Rectangle(dgv1.Location.X, dgv1.Location.Y, dgv1.Width, dgv1.Height);
        }


        private void resizeChildrenControl()
        {
            //label//
            resizeControl(Label1, lbl4);
            resizeControl(Label2, lbl5);
            resizeControl(Label3, lbl7);
            resizeControl(Label4, lblCanceled);
            resizeControl(Label5, lblCompleted);
            resizeControl(Label6, label3);
            resizeControl(Label7, lblPending);
            resizeControl(Label9, lblTotalShipping);
            resizeControl(Label10, label1);
            resizeControl(Label11, label3);
            resizeControl(Label12, label4);
            resizeControl(Label13, label6);
            resizeControl(Label14, label8);

            //combobox//
            resizeControl(combobox1, cmbFilter);
            resizeControl(combobox2, dateFrom);
            resizeControl(combobox3, dateTo);

            //datagrid//
            resizeControl(Datagrid, dgv1);

            //textbox
            resizeControl(TextBoxSearch, txtSearch);

            //button
            resizeControl(Button1, btnCheckDate);
            resizeControl(Button2, btnok);
            resizeControl(Button3, btnprint);
            resizeControl(Button4, btnrefresh);
            resizeControl(Button5, btnexcel);
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
        private void Manage_Shipping_Resize(object sender, EventArgs e)
        {
            resizeChildrenControl();
        }
    }
}
