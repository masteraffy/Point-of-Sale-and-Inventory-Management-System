using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Phosclay
{
    public partial class ViewRawMaterials : Form
    {
        private Size formOriginalSize;
        //autosize//
        //panel//
        private Rectangle pn1;

        //label//
        private Rectangle Label1;
        private Rectangle Label2;

        //textbox, datagrid, datetimepicker
        private Rectangle textSearch;
        private Rectangle dt1;
        private Rectangle dt2;
        private Rectangle datagrid;

        //button//
        private Rectangle btn1;
        private Rectangle btn2;
        private Rectangle btn3;
        private Rectangle btn4;
        private Rectangle btn5;
        private Rectangle btn6;
        public void autosize()
        {
            formOriginalSize = this.Size;
            //panel//
            pn1 = new Rectangle(pN1.Location.X, pN1.Location.Y, pN1.Width, pN1.Height);

            //label//
            Label1 = new Rectangle(lbl1.Location.X, lbl1.Location.Y, lbl1.Width, lbl1.Height);
            Label2 = new Rectangle(lbl2.Location.X, lbl2.Location.Y, lbl2.Width, lbl2.Height);

            //textbox, datagrid, datetimepicker
            textSearch = new Rectangle(txtSearch.Location.X, txtSearch.Location.Y, txtSearch.Width, txtSearch.Height);
            datagrid = new Rectangle(dgvRawMaterial.Location.X, dgvRawMaterial.Location.Y, dgvRawMaterial.Width, dgvRawMaterial.Height);
            dt1 = new Rectangle(dateFrom.Location.X, dateFrom.Location.Y, dateFrom.Width, dateFrom.Height);
            dt2 = new Rectangle(dateTo.Location.X, dateTo.Location.Y, dateTo.Width, dateTo.Height);

            //button
            btn1 = new Rectangle(btnrefresh.Location.X, btnrefresh.Location.Y, btnrefresh.Width, btnrefresh.Height);
            btn2 = new Rectangle(btnPrint.Location.X, btnPrint.Location.Y, btnPrint.Width, btnPrint.Height);
            btn3 = new Rectangle(btnsearch.Location.X, btnsearch.Location.Y, btnsearch.Width, btnsearch.Height);
            btn4 = new Rectangle(btnAdd.Location.X, btnAdd.Location.Y, btnAdd.Width, btnAdd.Height);
            btn5 = new Rectangle(btnUpdate.Location.X, btnUpdate.Location.Y, btnUpdate.Width, btnUpdate.Height);
            btn6 = new Rectangle(btnDelete.Location.X, btnDelete.Location.Y, btnDelete.Width, btnDelete.Height);
        }

        private void resizeChildrenControl()
        {
            //panel//
            resizeControl(pn1, pN1);

            //label//
            resizeControl(Label1, lbl1);
            resizeControl(Label2, lbl2);

            //textbox, datagrid, datetimepicker
            resizeControl(textSearch, txtSearch);
            resizeControl(datagrid, dgvRawMaterial);
            resizeControl(dt1, dateFrom);
            resizeControl(dt2, dateTo);

            //button
            resizeControl(btn1, btnrefresh);
            resizeControl(btn2, btnPrint);
            resizeControl(btn3, btnsearch);
            resizeControl(btn4, btnAdd);
            resizeControl(btn5, btnUpdate);
            resizeControl(btn6, btnDelete);
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
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter adpt;
        DataTable dt;

        string selectedUser;
        string username;

        DateTime date = DateTime.Now;
        public ViewRawMaterials(string username)
        {
            InitializeComponent();
            con = new MySqlConnection();
            con.ConnectionString = data.getConnection();
            dateFrom.Value = DateTime.Now;
            dateTo.Value = DateTime.Now;

            this.username = username;
        }
        public void refresh()
        {
            try
            {
                dt = new DataTable();
                adpt = new MySqlDataAdapter("SELECT * FROM tblmaterial ORDER BY Material_ID", con);
                adpt.Fill(dt);
                dgvRawMaterial.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on loading datagridview", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ViewRawMaterials_Load(object sender, EventArgs e)
        {
            refresh();
            autosize();
            timer1.Enabled = true;
            
        }
        private int row = 0;
        private void dgvRawMaterial_CellClick(object sender, DataGridViewCellEventArgs e)
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
                dt = new DataTable();
                adpt = new MySqlDataAdapter("SELECT * FROM tblmaterial WHERE Date BETWEEN '" + dateFrom.Value.ToString("yyyy-MM-dd") + "' AND '" +
                    dateTo.Value.ToString("yyyy-MM-dd") + "'", con);
                adpt.Fill(dt);
                dgvRawMaterial.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on searching date", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                adpt = new MySqlDataAdapter("SELECT * FROM tblmaterial WHERE Material_ID LIKE '%" + txtSearch.Text + "%'", con);
                adpt.Fill(dt);
                dgvRawMaterial.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on searching", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Inventory_Related.PrintMaterial print = new Inventory_Related.PrintMaterial();
            print.Show();
        }
        public void logs()
        {
            string action = "Deleted Raw Item ID:" + selectedUser.ToString() + " by: " + username.ToString();
            con.Open();
            cmd = new MySqlCommand("Insert into tbllogs (datelog, timelog, full_name, action, module)" +
                "Values('" + date.ToString("yyyy-MM-dd") + "', '" + date.ToString("HH:mm:ss") + "', '" + username.ToString() + "', '" + action.ToString() + "', 'Inventory')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void btnrefresh_Click(object sender, EventArgs e)
        {
            refresh();
            txtSearch.Text = "";
            dateFrom.Value = DateTime.Now;
            dateTo.Value = DateTime.Now;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                selectedUser = dgvRawMaterial.Rows[row].Cells[1].Value.ToString();
                DialogResult dialog = MessageBox.Show("Are you sure you want to delete this material?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new MySqlCommand("DELETE FROM tblmaterial WHERE Material_ID = '" + selectedUser + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    //insert logs//
                    logs();
                    MessageBox.Show("Raw material deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ViewRawMaterials del = (ViewRawMaterials)Application.OpenForms["ViewRawMaterials"];
                    del.refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Delete button", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateRawMaterials update = new UpdateRawMaterials(this, username);
                con.Open();
                cmd = new MySqlCommand("SELECT * FROM tblmaterial WHERE Material_ID LIKE '" + dgvRawMaterial.Rows[row].Cells[0].Value.ToString() + "' ", con);
                cmd.ExecuteNonQuery();

                update.txttransacttion.Text = dgvRawMaterial.Rows[row].Cells[0].Value.ToString();
                update.txtItemID.Text = dgvRawMaterial.Rows[row].Cells[1].Value.ToString();
                update.txtMaterials.Text = dgvRawMaterial.Rows[row].Cells[2].Value.ToString();
                update.DateTimePicker1.Value = DateTime.Parse(dgvRawMaterial.Rows[row].Cells[3].Value.ToString());
                update.txtDescription.Text = dgvRawMaterial.Rows[row].Cells[4].Value.ToString();
                update.txtcompany.Text = dgvRawMaterial.Rows[ row].Cells[5].Value.ToString();
                update.txtcontact.Text = dgvRawMaterial.Rows[row ].Cells[6].Value.ToString();
                update.txtMeasurement.Text = dgvRawMaterial.Rows[row].Cells[7].Value.ToString();
                update.txtQuantity.Text = dgvRawMaterial.Rows[row].Cells[8].Value.ToString();
                update.txtCost.Text = dgvRawMaterial.Rows[row].Cells[9].Value.ToString();
                byte[] imgData = (byte[])dgvRawMaterial.Rows[row].Cells[11].Value;
                MemoryStream ms = new MemoryStream(imgData);
                update.pictureBox1.Image = Image.FromStream(ms);
                con.Close();
                update.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on update button", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddRawMaterials add = new AddRawMaterials("add", username); ;
            add.Show();
        }
        public Point mouseLocation;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - mouseLocation.X;
                this.Top += e.Y - mouseLocation.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(e.X, e.Y);
        }

        private void ViewRawMaterials_Resize(object sender, EventArgs e)
        {
            resizeChildrenControl();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToString("dddd, MMMM, dd, yyyy");
            lbltime.Text = DateTime.Now.ToString("hh:mm:ss:tt");
            timer1.Start();
        }
    }
}
