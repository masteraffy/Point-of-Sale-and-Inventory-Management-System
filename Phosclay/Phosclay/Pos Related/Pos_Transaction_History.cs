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
    public partial class Pos_Transaction_History : Form
    {
        private Size formOriginalSize;
        //label
        private Rectangle Label1;
        private Rectangle Label2;
        private Rectangle Label3;
        private Rectangle Label4;
        private Rectangle Label5;

        //panel
        private Rectangle pN1;
        private Rectangle pN2;

        //textbox, combobox, datetimepicker
        private Rectangle textboxsearch;
        private Rectangle comboboxDate;
        private Rectangle comboboxMYFilter;
        private Rectangle comboboxCategory;
        private Rectangle comboboxPaymentOption;
        private Rectangle comboboxTransactionType;
        private Rectangle comboboxReceiptType;
        private Rectangle dt1;
        private Rectangle dt2;

        //button
        private Rectangle btn1;
        private Rectangle btn2;

        //datagrid
        private Rectangle datagrid1;
        private Rectangle datagrid2;

        public void autosize()
        {
            formOriginalSize = this.Size;
            //panel//
            pN1 = new Rectangle(pn1.Location.X, pn1.Location.Y, pn1.Width, pn1.Height);
            pN2 = new Rectangle(pn2.Location.X, pn2.Location.Y, pn2.Width, pn2.Height);

            //label//
            Label1 = new Rectangle(lbl1.Location.X, lbl1.Location.Y, lbl1.Width, lbl1.Height);
            Label2 = new Rectangle(lbl2.Location.X, lbl2.Location.Y, lbl2.Width, lbl2.Height);
            Label3 = new Rectangle(lbl3.Location.X, lbl3.Location.Y, lbl3.Width, lbl3.Height);
            Label4 = new Rectangle(lbl4.Location.X, lbl4.Location.Y, lbl4.Width, lbl4.Height);
            Label5 = new Rectangle(lbl5.Location.X, lbl5.Location.Y, lbl5.Width, lbl5.Height);

            //textbox, combobox, datetimepicker//
            textboxsearch = new Rectangle(txtSearch.Location.X, txtSearch.Location.Y, txtSearch.Width, txtSearch.Height);
            comboboxDate = new Rectangle(cmbDate.Location.X, cmbDate.Location.Y, cmbDate.Width, cmbDate.Height);
            comboboxCategory = new Rectangle(cmbCategory.Location.X, cmbCategory.Location.Y, cmbCategory.Width, cmbCategory.Height);
            comboboxPaymentOption = new Rectangle(cmbPaymentOption.Location.X, cmbPaymentOption.Location.Y, cmbPaymentOption.Width, cmbPaymentOption.Height);
            comboboxTransactionType = new Rectangle(cmbTransactionType.Location.X, cmbTransactionType.Location.Y, cmbTransactionType.Width, cmbTransactionType.Height);
            comboboxMYFilter = new Rectangle(cmbMYFilter.Location.X, cmbMYFilter.Location.Y, cmbMYFilter.Width, cmbMYFilter.Height);
            comboboxReceiptType = new Rectangle(cmbReceiptType.Location.X, cmbReceiptType.Location.Y, cmbReceiptType.Width, cmbReceiptType.Height);
            dt1 = new Rectangle(dateFrom.Location.X, dateFrom.Location.Y, dateFrom.Width, dateFrom.Height);
            dt2 = new Rectangle(dateTo.Location.X, dateTo.Location.Y, dateTo.Width, dateTo.Height);

            //button//
            btn1 = new Rectangle(btnCheckDate.Location.X, btnCheckDate.Location.Y, btnCheckDate.Width, btnCheckDate.Height);
            btn2 = new Rectangle(btnRefresh.Location.X, btnRefresh.Location.Y, btnRefresh.Width, btnRefresh.Height);

            //datagrid//
            datagrid1 = new Rectangle(dgv1.Location.X, dgv1.Location.Y, dgv1.Width, dgv1.Height);
            datagrid2 = new Rectangle(dgv2.Location.X, dgv2.Location.Y, dgv2.Width, dgv2.Height);
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

        private void resizeChildrenControl()
        {

            //panel//
            resizeControl(pN1, pn1);
            resizeControl(pN2, pn2);

            //label//
            resizeControl(Label1, lbl1);
            resizeControl(Label2, lbl2);
            resizeControl(Label3, lbl3);
            resizeControl(Label4, lbl4);
            resizeControl(Label5, lbl5);

            //button//
            resizeControl(btn1, btnCheckDate);
            resizeControl(btn2, btnRefresh);

            //datagrid//
            resizeControl(datagrid1, dgv1);
            resizeControl(datagrid2, dgv2);

            //textbox, combobox, datetimepicker//
            resizeControl(textboxsearch, txtSearch);
            resizeControl(comboboxDate, cmbDate);
            resizeControl(comboboxCategory, cmbCategory);
            resizeControl(comboboxPaymentOption, cmbPaymentOption);
            resizeControl(comboboxTransactionType, cmbTransactionType);
            resizeControl(comboboxMYFilter, cmbMYFilter);
            resizeControl(comboboxReceiptType, cmbReceiptType);
            resizeControl(dt1, dateFrom);
            resizeControl(dt2, dateTo);

        }

        MainConnection data = new MainConnection();
        DataTable dt;
        MySqlDataAdapter adpt;
        MySqlConnection con;
        string transnumber;
        string username;
        string action = "history";
        public Pos_Transaction_History(string username)
        {
            InitializeComponent();
            con = new MySqlConnection();
            con.ConnectionString = data.getConnection();
            this.username = username;
            dateFrom.Value = DateTime.Now;
            dateTo.Value = DateTime.Now;
        }
        public void dgvLoad()
        {
            timer1.Start();
            try
            {
                refresh();
                dt = new DataTable();
                adpt = new MySqlDataAdapter("Select TransactionNumber, Reference, TransactionType, CustomerName, PaymentOption," +
                    " TotalItems, TotalCost, Receipt, Receipt1, Date from tblcheckout ORDER BY Date DESC", con);
                adpt.Fill(dt);
                dgv1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on DataGridview Load",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(dgv1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgv1.CurrentRow.Selected = true;
                    transnumber = dgv1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    Pos_Related.Pos_Transaction_History_Records posh = new Pos_Related.Pos_Transaction_History_Records(transnumber, username, action) ;
                    posh.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void refresh()
        {
            txtSearch.Clear();
            cmbMYFilter.SelectedIndex = -1;
            cmbDate.SelectedIndex = -1;
            cmbPaymentOption.SelectedIndex = -1;
            cmbTransactionType.SelectedIndex = -1;
            cmbCategory.SelectedIndex = -1;
            cmbReceiptType.SelectedIndex = -1;
        }

        private void cmbMYFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbMYFilter.SelectedIndex == -1)
                {
                    cmbTransactionType.Visible = true;
                    cmbPaymentOption.Visible = false;
                    cmbDate.Visible = false;
                    cmbCategory.Visible = false;
                    cmbReceiptType.Visible = false;
                }
                else if(cmbMYFilter.SelectedIndex == 0)
                {
                    cmbTransactionType.Visible = true;
                    cmbPaymentOption.Visible = false;
                    cmbDate.Visible = false;
                    cmbCategory.Visible = false;
                    cmbReceiptType.Visible = false;
                }
                else if (cmbMYFilter.SelectedIndex == 1)
                {
                    cmbTransactionType.Visible = false;
                    cmbPaymentOption.Visible = true;
                    cmbDate.Visible = false;
                    cmbCategory.Visible = false;
                    cmbReceiptType.Visible = false;
                }
                else if(cmbMYFilter.SelectedIndex == 2)
                {
                    cmbTransactionType.Visible = false;
                    cmbPaymentOption.Visible = false;
                    cmbDate.Visible = true;
                    cmbCategory.Visible = false;
                    cmbReceiptType.Visible = false;
                }
                else if (cmbMYFilter.SelectedIndex == 3)
                {
                    cmbTransactionType.Visible = false;
                    cmbPaymentOption.Visible = false;
                    cmbDate.Visible = false;
                    cmbCategory.Visible = true;
                    cmbReceiptType.Visible = false;
                }
                else if(cmbMYFilter.SelectedIndex == 4)
                {
                    cmbTransactionType.Visible = false;
                    cmbPaymentOption.Visible = false;
                    cmbDate.Visible = false;
                    cmbCategory.Visible = false;
                    cmbReceiptType.Visible = true;
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
            dgvLoad();
        }
        private void cmbTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                adpt = new MySqlDataAdapter("Select TransactionNumber, Reference, TransactionType, CustomerName, PaymentOption," +
                    " TotalItems, TotalCost, Receipt, Receipt1, Date from tblcheckout where transactiontype ='" + cmbTransactionType.Text + "' ORDER BY Date DESC", con);
                adpt.Fill(dt);
                dgv1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbPaymentOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                adpt = new MySqlDataAdapter("Select TransactionNumber, Reference, TransactionType, CustomerName, PaymentOption," +
                    " TotalItems, TotalCost, Receipt, Receipt1, Date from tblcheckout where paymentoption ='" + cmbPaymentOption.Text + "' ORDER BY Date DESC", con);
                adpt.Fill(dt);
                dgv1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cmbDate.SelectedIndex == 0)
                {
                    dt = new DataTable();
                    adpt = new MySqlDataAdapter("Select TransactionNumber, Reference, TransactionType, CustomerName, PaymentOption," +
                    " TotalItems, TotalCost, Receipt, Receipt1, Date from tblcheckout ORDER BY Date DESC", con);
                    adpt.Fill(dt);
                    dgv1.DataSource = dt;
                }
                else if(cmbDate.SelectedIndex == 1)
                {
                    dt = new DataTable();
                    adpt = new MySqlDataAdapter("Select TransactionNumber, Reference, TransactionType, CustomerName, PaymentOption," +
                    " TotalItems, TotalCost, Receipt, Receipt1, Date from tblcheckout ORDER BY Date ASC", con);
                    adpt.Fill(dt);
                    dgv1.DataSource = dt;
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                adpt = new MySqlDataAdapter("Select TransactionNumber, Reference, TransactionType, CustomerName, PaymentOption," +
                    " TotalItems, TotalCost, Receipt, Receipt1, Date from tblcheckout Where CustomerName LIKE '%" + txtSearch.Text + "%' ORDER BY DATE DESC", con);
                adpt.Fill(dt);
                dgv1.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                adpt = new MySqlDataAdapter("Select TransactionNumber, Reference, TransactionType, CustomerName, PaymentOption," +
                    " TotalItems, TotalCost, Receipt, Receipt1, Date from tblcheckout where receipt ='" + cmbCategory.Text + "' ORDER BY Date DESC", con);
                adpt.Fill(dt);
                dgv1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbReceiptType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string acknowledgement = "Acknowledgement Receipt";
                string official = "Official Receipt";

                if (cmbReceiptType.SelectedIndex == 0)
                {
                    dt = new DataTable();
                    adpt = new MySqlDataAdapter("Select TransactionNumber, Reference, TransactionType, CustomerName, PaymentOption," +
                        " TotalItems, TotalCost, Receipt, Receipt1, Date from tblcheckout where receipt1 ='" + acknowledgement + "' ORDER BY Date DESC", con);
                    adpt.Fill(dt);
                    dgv1.DataSource = dt;
                }
                else if (cmbReceiptType.SelectedIndex == 1)
                {
                    dt = new DataTable();
                    adpt = new MySqlDataAdapter("Select TransactionNumber, Reference ,TransactionType, CustomerName, PaymentOption," +
                        " TotalItems, TotalCost, Receipt, Receipt1, Date from tblcheckout where receipt1 ='" + official + "' ORDER BY Date DESC", con);
                    adpt.Fill(dt);
                    dgv1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCheckDate_Click(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                adpt = new MySqlDataAdapter("Select TransactionNumber, Reference, TransactionType, CustomerName, PaymentOption," +
                    " TotalItems, TotalCost, Receipt, Receipt1, Date from tblcheckout WHERE Date Between '" + dateFrom.Value.ToString("MMM. dd, yyyy") + "' And '" + dateTo.Value.ToString("MMM. dd, yyyy") + "' ORDER BY DATE DESC", con);
                adpt.Fill(dt);
                dgv1.DataSource = dt;

            }
            catch(Exception ex)
            {   
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToString("dddd, MMMM, dd, yyyy");
            lbltime.Text = DateTime.Now.ToString("hh:mm:ss:tt");
        }

        private void Pos_Transaction_History_Load(object sender, EventArgs e)
        {
            autosize();
            dgvLoad();
        }

        private void Pos_Transaction_History_Resize(object sender, EventArgs e)
        {
            resizeChildrenControl();
        }
    }
}
