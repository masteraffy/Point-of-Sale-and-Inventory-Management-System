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
    public partial class Pos_Manage_Void : Form
    {
        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;
        MainConnection data = new MainConnection();
        MySqlDataAdapter adpt;
        string transactionNumber, username, action;

        public Pos_Manage_Void(string Username)
        {
            InitializeComponent();
            cn = new MySqlConnection();
            cn.ConnectionString = data.getConnection();
            this.username = Username;
            dateFrom.Value = DateTime.Now;
            dateTo.Value = DateTime.Now;
            autosize();
        }

        //display grid
        public void load()
        {
            try
            {
                DataTable dt = new DataTable();
                cn.Open();
                adpt = new MySqlDataAdapter("select TransactionNumber, TransactionType, CustomerName, PaymentOption, Reference, TotalItems, TotalCost, Receipt, Receipt1, Date, DateVoided, " +
                    "TimeVoided, Reason from tblvoided where Status = 'Voided' ORDER BY DateVoided AND TimeVoided DESC",cn);
                adpt.Fill(dt);
                dgv1.DataSource = dt;
                cn.Close();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Pos_Manage_Void_Load(object sender, EventArgs e)
        {
            load();
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToString("dddd, MMMM, dd, yyyy");
            lbltime.Text = DateTime.Now.ToString("hh:mm:ss:tt:");
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void searchbyDate()
        {
            try
            {
                DataTable dt = new DataTable();
                adpt = new MySqlDataAdapter(" select TransactionNumber, TransactionType, CustomerName, PaymentOption, Reference, TotalItems, TotalCost, Receipt, Receipt1, Date, DateVoided, TimeVoided, Reason from tblvoided WHERE DateVoided BETWEEN '" +
                    dateFrom.Value.ToString("MMM. dd, yyyy") + "' AND '" + dateTo.Value.ToString("MMM. dd, yyyy") + "' AND Status = 'Voided' ORDER BY DateVoided DESC", cn);
                dt = new DataTable();
                adpt.Fill(dt);
                dgv1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on searching date", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void searchByCustomerName()
        {
            
            try
            {
                DataTable dt = new DataTable();
                cn.Open();
                adpt = new MySqlDataAdapter("Select TransactionNumber, TransactionType, CustomerName, PaymentOption, Reference, TotalItems, TotalCost, Receipt, Receipt1, Date, DateVoided, TimeVoided, Reason from tblvoided where (CustomerName Like '%" + txtSearch.Text + "%' OR TransactionNumber Like '%" + txtSearch.Text + "%'" +
                    "OR Amount Like '%" + txtSearch.Text + "%' OR TransactionType Like '%" + txtSearch.Text + "%' OR PaymentOption Like '%" + txtSearch.Text + "%') AND Status = 'Voided'", cn);
                adpt.Fill(dt);
                dgv1.DataSource = dt;
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on search customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchByCustomerName();
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
                MessageBox.Show(ex.Message, "Error on Button Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnrefresh_Click(object sender, EventArgs e)
        {
            load();
            txtSearch.Text = "";
            dateFrom.Value = DateTime.Now;
            dateTo.Value = DateTime.Now;
        }

        private void btnCheckDate_Click(object sender, EventArgs e)
        {
            searchbyDate();
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                action = "void";
                if (dgv1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgv1.CurrentRow.Selected = true;
                    transactionNumber = dgv1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    Pos_Related.Pos_Transaction_History_Records posh = new Pos_Related.Pos_Transaction_History_Records(transactionNumber, username, action);
                    posh.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Cell Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //*********************************** ResizeControl Design *************************************//

        private Size formOriginalSize;

        //label
        private Rectangle Label1;
        private Rectangle Label2;

        //combobox
        private Rectangle combobox2;
        private Rectangle combobox3;

        //textbox
        private Rectangle TextBoxSearch;

        //button
        private Rectangle Button1;
        private Rectangle Button2;
        private Rectangle Button3;
        private Rectangle Button4;

        //datagridview//
        private Rectangle Datagrid;
        public void autosize()
        {
            formOriginalSize = this.Size;

            //label
            Label1 = new Rectangle(lbl4.Location.X, lbl4.Location.Y, lbl4.Width, lbl4.Height);
            Label2 = new Rectangle(lbl5.Location.X, lbl5.Location.Y, lbl5.Width, lbl5.Height);

            //combobox//
            combobox2 = new Rectangle(dateFrom.Location.X, dateFrom.Location.Y, dateFrom.Width, dateFrom.Height);
            combobox3 = new Rectangle(dateTo.Location.X, dateTo.Location.Y, dateTo.Width, dateTo.Height);

            //textbox
            TextBoxSearch = new Rectangle(txtSearch.Location.X, txtSearch.Location.Y, txtSearch.Width, txtSearch.Height);

            //button
            Button1 = new Rectangle(btnCheckDate.Location.X, btnCheckDate.Location.Y, btnCheckDate.Width, btnCheckDate.Height);
            Button2 = new Rectangle(btnok.Location.X, btnok.Location.Y, btnok.Width, btnok.Height);
            Button3 = new Rectangle(btnexcel.Location.X, btnexcel.Location.Y, btnexcel.Width, btnexcel.Height);
            Button4 = new Rectangle(btnrefresh.Location.X, btnrefresh.Location.Y, btnrefresh.Width, btnrefresh.Height);

            //datagrid//
            Datagrid = new Rectangle(dgv1.Location.X, dgv1.Location.Y, dgv1.Width, dgv1.Height);
        }

        private void resizeChildrenControl()
        {
            //label
            resizeControl(Label1, lbl4);
            resizeControl(Label2, lbl5);

            //combobox//
            resizeControl(combobox2, dateFrom);
            resizeControl(combobox3, dateTo);

            //datagrid//
            resizeControl(Datagrid, dgv1);

            //textbox
            resizeControl(TextBoxSearch, txtSearch);

            //button
            resizeControl(Button1, btnCheckDate);
            resizeControl(Button2, btnok);
            resizeControl(Button3, btnexcel);
            resizeControl(Button4, btnrefresh);
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
        private void Pos_Manage_Void_Resize(object sender, EventArgs e)
        {
            resizeChildrenControl();
        }
    }
}
