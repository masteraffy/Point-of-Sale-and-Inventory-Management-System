using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace Phosclay.Inventory_Related
{
    public partial class ViewProducts : Form
    {
        private Size formOriginalSize;

        //panel
        private Rectangle pN1;

        //label
        private Rectangle Label1;
        private Rectangle Label2;
        private Rectangle Label3;
        private Rectangle Label4;

        //button
        private Rectangle btn1;
        private Rectangle btn2;
        private Rectangle btn3;
        private Rectangle btn4;
        private Rectangle btn5;
        private Rectangle btn6;

        //textbox, combobox, datetimepicker
        private Rectangle textboxsearch;
        private Rectangle textsearchID;
        private Rectangle comboboxsearh;
        private Rectangle dt1;
        private Rectangle dt2;

        //datagrid
        private Rectangle datagrid;

        public void autosize()
        {
            formOriginalSize = this.Size;
            //panel//
            pN1 = new Rectangle(pn1.Location.X, pn1.Location.Y, pn1.Width, pn1.Height);

            //label//
            Label1 = new Rectangle(lbl1.Location.X, lbl1.Location.Y, lbl1.Width, lbl1.Height);
            Label2= new Rectangle(lbl2.Location.X, lbl2.Location.Y, lbl2.Width, lbl2.Height);
            Label3 = new Rectangle(lbl3.Location.X, lbl3.Location.Y, lbl3.Width, lbl3.Height);
            Label4 = new Rectangle(lbl4.Location.X, lbl4.Location.Y, lbl4.Width, lbl4.Height);

            //button//
            btn1 = new Rectangle(btnrefresh.Location.X, btnrefresh.Location.Y, btnrefresh.Width, btnrefresh.Height);
            btn2 = new Rectangle(btnsearch.Location.X, btnsearch.Location.Y, btnsearch.Width, btnsearch.Height);
            btn3 = new Rectangle(btnPrint.Location.X, btnPrint.Location.Y, btnPrint.Width, btnPrint.Height);
            btn4 = new Rectangle(btnAdd.Location.X, btnAdd.Location.Y, btnAdd.Width, btnAdd.Height);
            btn5 = new Rectangle(btnUpdate.Location.X, btnUpdate.Location.Y, btnUpdate.Width, btnUpdate.Height);
            btn6 = new Rectangle(btnDelete.Location.X, btnDelete.Location.Y, btnDelete.Width, btnDelete.Height);

            //textbox, combobox, datetimepicker//
            textboxsearch = new Rectangle(txtsearchName.Location.X, txtsearchName.Location.Y, txtsearchName.Width, txtsearchName.Height);
            textsearchID = new Rectangle(txtSearchID.Location.X, txtSearchID.Location.Y, txtSearchID.Width, txtSearchID.Height);
            comboboxsearh = new Rectangle(cmbsearch.Location.X, cmbsearch.Location.Y, cmbsearch.Width, cmbsearch.Height);
            dt1 = new Rectangle(dateFrom.Location.X, dateFrom.Location.Y, dateFrom.Width, dateFrom.Height);
            dt2 = new Rectangle(dateTo.Location.X, dateTo.Location.Y, dateTo.Width, dateTo.Height);

            //datagrid//
            datagrid = new Rectangle(dgvProduct.Location.X, dgvProduct.Location.Y, dgvProduct.Width, dgvProduct.Height);
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

            //label//
            resizeControl(Label1, lbl1);
            resizeControl(Label2, lbl2);
            resizeControl(Label3, lbl3);
            resizeControl(Label4, lbl4);

            //button//
            resizeControl(btn1, btnrefresh);
            resizeControl(btn2, btnsearch);
            resizeControl(btn3, btnPrint);
            resizeControl(btn4, btnAdd);
            resizeControl(btn5, btnUpdate);
            resizeControl(btn6, btnDelete);

            //textbox, combobox, datetimepicker//
            resizeControl(textboxsearch, txtsearchName);
            resizeControl(textsearchID, txtSearchID);
            resizeControl(comboboxsearh, cmbsearch);
            resizeControl(dt1, dateFrom);
            resizeControl(dt2, dateTo);

            //datagrid//
            resizeControl(datagrid, dgvProduct);
        }



        MainConnection data = new MainConnection();
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter adpt;
        DataTable dt;
        public Point mouseLocation;
        //row index;
        private int row = 0;
        string username, usertype;
        string selectedUser;

        DateTime date = DateTime.Now;
        public ViewProducts(string username, string usertype)
        {
            InitializeComponent();
            con = new MySqlConnection();
            con.ConnectionString = data.getConnection();
            dateFrom.Value = DateTime.Now;
            dateTo.Value = DateTime.Now;
            this.username = username;
            this.usertype = usertype;
        }

        private void ViewProducts_Load(object sender, EventArgs e)
        {
            DatagridviewLoad();
            autosize();
            if(usertype == "Manager" || usertype == "Staff")
            {
                btnDelete.Enabled = false;
            }
            timer1.Enabled = true;
        }
        //function to load the datagrid

        public void DatagridviewLoad()
        {
            try
            {
                dt = new DataTable();
                adpt = new MySqlDataAdapter("Select ProductID, ProductName, Measurement, Price, Date, Description, Quantity, Status, Image from tblproduct " +
                    "ORDER BY ProductID", con);
                adpt.Fill(dt);
                dgvProduct.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on loading datagridview", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void cmbsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbsearch.SelectedIndex == 0)
            {
                txtsearchName.Visible = false;
                txtSearchID.Visible = true;
            }
            else
            {
                txtsearchName.Visible = true;
                txtSearchID.Visible = false;
            }
        }

        private void txtsearchName_TextChanged(object sender, EventArgs e)
        {
            dt = new DataTable();
            adpt = new MySqlDataAdapter("SELECT ProductID, ProductName, Measurement, Price, Date, Description, Quantity, Status, Image FROM tblproduct WHERE " +
                "ProductName LIKE '%" + txtsearchName.Text + "%' ", con);
            adpt.Fill(dt);
            dgvProduct.DataSource = dt;
        }
        private void txtSearchID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                adpt = new MySqlDataAdapter("Select ProductID, ProductName, Measurement, Price, Date, Description, Quantity, Status, Image from tblproduct " +
                    "WHERE ProductID LIKE '%" + txtSearchID.Text + "%' ", con);
                adpt.Fill(dt);
                dgvProduct.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on searching Product ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            errorProvider1.Clear();
            try
            {
                row = e.RowIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error on Cell Click datagridview", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                adpt = new MySqlDataAdapter("SELECT ProductID, ProductName, Measurement, Price, Date, Description, Quantity, Status, Image from tblproduct WHERE Date BETWEEN '" +
                    dateFrom.Value.ToString("yyyy-MM-dd") + "' AND '" + dateTo.Value.ToString("yyyy-MM-dd") + "' ORDER BY ProductID DESC", con);
                dt = new DataTable();
                adpt.Fill(dt);
                dgvProduct.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on searching date", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //insert logs//
        public void logs()
        {
            string action = "Deleted An Item ID:" + selectedUser.ToString() + " by: " + username.ToString();
            con.Open();
            cmd = new MySqlCommand("Insert into tbllogs (datelog, timelog, full_name, action, module)" +
                "Values('" + date.ToString("yyyy-MM-dd") + "', '" + date.ToString("HH:mm:ss") + "', '" + username.ToString() + "', '" + action.ToString() + "', 'Inventory')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                selectedUser = dgvProduct.Rows[row].Cells[0].Value.ToString();
                DialogResult dialog = MessageBox.Show("Are you sure you want to permanently delete this product?", "Message",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new MySqlCommand("DELETE FROM tblproduct WHERE ProductID = '" + selectedUser + "'", con);
                    cmd.ExecuteReader();
                    con.Close();

                    //insert logs//
                    logs();
                    MessageBox.Show("Product Deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ViewProducts del = (ViewProducts)Application.OpenForms["ViewProducts"];
                    del.DatagridviewLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Delete Button", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnrefresh_Click_1(object sender, EventArgs e)
        {
            DatagridviewLoad();
            txtSearchID.Text = "";
            cmbsearch.SelectedIndex = -1;
            dateTo.Value = DateTime.Now;
            dateFrom.Value = DateTime.Now;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Inventory_Related.PrintProducts print = new PrintProducts();
            print.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Inventory_Related.AddProduct add = new AddProduct("add", username);
            add.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedUser = dgvProduct.Rows[row].Cells[0].Value.ToString();
                UpdateProduct edit = new UpdateProduct(this, "Update", username);
                con.Open();
                cmd = new MySqlCommand("Select ProductID, ProductName, Measurement, Price, Date, Description, Quantity, Status, Image FROM tblproduct " +
                    "WHERE ProductID LIKE '" + selectedUser + "' ", con);
                cmd.ExecuteNonQuery();

                edit.txtProductID.Text = dgvProduct.Rows[row].Cells[0].Value.ToString();
                edit.txtProductName.Text = dgvProduct.Rows[row].Cells[1].Value.ToString();
                edit.cmbunit.Text = dgvProduct.Rows[row].Cells[2].Value.ToString();
                edit.txtPrice.Text = dgvProduct.Rows[row].Cells[3].Value.ToString();
                edit.gunaDateTimePicker1.Value = DateTime.Parse(dgvProduct.Rows[row].Cells[4].Value.ToString());
                edit.txtProductDesc.Text = dgvProduct.Rows[row].Cells[5].Value.ToString();
                edit.txtQuantity.Text = dgvProduct.Rows[row].Cells[6].Value.ToString();
                byte[] imgData = (byte[])dgvProduct.Rows[row].Cells[8].Value;
                MemoryStream ms = new MemoryStream(imgData);
                edit.pictureBox1.Image = Image.FromStream(ms);
                con.Close();
                edit.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Update button", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - mouseLocation.X;
                this.Top += e.Y - mouseLocation.Y;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToString("dddd, MMMM, dd, yyyy");
            lbltime.Text = DateTime.Now.ToString("hh:mm:ss:tt");
            timer1.Start();
        }

        private void ViewProducts_Resize(object sender, EventArgs e)
        {
            resizeChildrenControl();
        }
    }
}
