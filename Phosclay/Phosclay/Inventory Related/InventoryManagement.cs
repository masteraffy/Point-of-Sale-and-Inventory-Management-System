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
    public partial class InventoryManagement : Form
    {
        //autosize//
        //panel//
        private Rectangle pn1;
        private Rectangle pn2;
        private Rectangle pn3;
        private Rectangle pn4;
        private Rectangle pn5;
        private Rectangle pn6;
        private Rectangle pn7;
        private Rectangle pn8;
        private Rectangle pn9;
        private Rectangle pn10;
        private Rectangle pn11;
        private Rectangle pn12;
        private Rectangle pn13;
        //end panel//

        //button//
        private Rectangle btn1;
        private Rectangle btn2;
        //end button//

        //label//
        private Rectangle Label1;
        private Rectangle Label2;
        private Rectangle Label3;
        private Rectangle Label4;
        private Rectangle Label5;
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
        private Rectangle LabelTotalProduct;
        private Rectangle LabelOut;
        private Rectangle LabelStock;
        private Rectangle LabelRaw;
        //end label//

        //chart//
        private Rectangle Chart1;
        //end chart//

        //datagridview//
        private Rectangle Datagrid;
        //end datagridview//
        private Size formOriginalSize;

        public void autosize()
        {
            formOriginalSize = this.Size;
            //panel//
            pn1 = new Rectangle(pN1.Location.X, pN1.Location.Y, pN1.Width, pN1.Height);
            pn2 = new Rectangle(pN2.Location.X, pN2.Location.Y, pN2.Width, pN2.Height);
            pn3 = new Rectangle(pN3.Location.X, pN3.Location.Y, pN3.Width, pN3.Height);
            pn4 = new Rectangle(pN4.Location.X, pN4.Location.Y, pN4.Width, pN4.Height);
            pn5 = new Rectangle(pN5.Location.X, pN5.Location.Y, pN5.Width, pN5.Height);
            pn6 = new Rectangle(pN6.Location.X, pN6.Location.Y, pN6.Width, pN6.Height);
            pn7 = new Rectangle(pN7.Location.X, pN7.Location.Y, pN7.Width, pN7.Height);
            pn8 = new Rectangle(pN8.Location.X, pN8.Location.Y, pN8.Width, pN8.Height);
            pn9 = new Rectangle(pN9.Location.X, pN9.Location.Y, pN9.Width, pN9.Height);
            pn10 = new Rectangle(pN10.Location.X, pN10.Location.Y, pN10.Width, pN10.Height);
            pn11 = new Rectangle(pN11.Location.X, pN11.Location.Y, pN11.Width, pN11.Height);
            pn12 = new Rectangle(pN12.Location.X, pN12.Location.Y, pN12.Width, pN12.Height);
            pn13 = new Rectangle(pN13.Location.X, pN13.Location.Y, pN13.Width, pN13.Height);

            //button//
            btn1 = new Rectangle(btnProduct.Location.X, btnProduct.Location.Y, btnProduct.Width, btnProduct.Height);
            btn2 = new Rectangle(btnRawMaterial.Location.X, btnRawMaterial.Location.Y, btnRawMaterial.Width, btnRawMaterial.Height);

            //label//
            Label1 = new Rectangle(lbl1.Location.X, lbl1.Location.Y, lbl1.Width, lbl1.Height);
            Label2 = new Rectangle(lbl2.Location.X, lbl2.Location.Y, lbl2.Width, lbl2.Height);
            Label3 = new Rectangle(lbl3.Location.X, lbl3.Location.Y, lbl3.Width, lbl3.Height);
            Label4 = new Rectangle(lbl4.Location.X, lbl4.Location.Y, lbl4.Width, lbl4.Height);
            Label5 = new Rectangle(lbl5.Location.X, lbl5.Location.Y, lbl5.Width, lbl5.Height);
            Label7 = new Rectangle(lbl7.Location.X, lbl7.Location.Y, lbl7.Width, lbl7.Height);
            Label8 = new Rectangle(lbl8.Location.X, lbl8.Location.Y, lbl8.Width, lbl8.Height);
            Label9 = new Rectangle(lbl9.Location.X, lbl9.Location.Y, lbl9.Width, lbl9.Height);
            Label10 = new Rectangle(lbl10.Location.X, lbl10.Location.Y, lbl10.Width, lbl10.Height);
            Label11 = new Rectangle(lbl11.Location.X, lbl11.Location.Y, lbl11.Width, lbl11.Height);
            Label12 = new Rectangle(lbl12.Location.X, lbl12.Location.Y, lbl12.Width, lbl12.Height);
            Label13 = new Rectangle(lbl13.Location.X, lbl13.Location.Y, lbl13.Width, lbl13.Height);
            Label15 = new Rectangle(lbl15.Location.X, lbl15.Location.Y, lbl15.Width, lbl15.Height);
            Label17 = new Rectangle(lbl17.Location.X, lbl17.Location.Y, lbl17.Width, lbl17.Height);
            Label18 = new Rectangle(lbl18.Location.X, lbl18.Location.Y, lbl18.Width, lbl18.Height);
            Label19 = new Rectangle(lbl19.Location.X, lbl19.Location.Y, lbl19.Width, lbl19.Height);
            LabelTotalProduct = new Rectangle(lbltotalprod.Location.X, lbltotalprod.Location.Y, lbltotalprod.Width, lbltotalprod.Height);
            LabelOut = new Rectangle(lblout.Location.X, lblout.Location.Y, lblout.Width, lblout.Height);
            LabelStock = new Rectangle(lblstock.Location.X, lblstock.Location.Y, lblstock.Width, lblstock.Height);
            LabelRaw = new Rectangle(lblraw.Location.X, lblraw.Location.Y, lblraw.Width, lblraw.Height);

            //chart//
            Chart1 = new Rectangle(chart1.Location.X, chart1.Location.Y, chart1.Width, chart1.Height);

            //datagrid//
            Datagrid = new Rectangle(dgvproduct.Location.X, dgvproduct.Location.Y, dgvproduct.Width, dgvproduct.Height);
        }

        private void resizeChildrenControl()
        {
            //chart//
            resizeControl(Chart1, chart1);

            //datagrid//
            resizeControl(Datagrid, dgvproduct);

            //panel//
            resizeControl(pn1, pN1);
            resizeControl(pn2, pN2);
            resizeControl(pn3, pN3);
            resizeControl(pn4, pN4);
            resizeControl(pn5, pN5);
            resizeControl(pn6, pN6);
            resizeControl(pn7, pN7);
            resizeControl(pn8, pN8);
            resizeControl(pn9, pN9);
            resizeControl(pn10, pN10);
            resizeControl(pn11, pN11);
            resizeControl(pn12, pN12);
            resizeControl(pn13, pN13);

            //button//
            resizeControl(btn1, btnProduct);
            resizeControl(btn2, btnRawMaterial);

            //panel//
            resizeControl(Label1, lbl1);
            resizeControl(Label2, lbl2);
            resizeControl(Label3, lbl3);
            resizeControl(Label4, lbl4);
            resizeControl(Label5, lbl5);
            resizeControl(Label7, lbl7);
            resizeControl(Label8, lbl8);
            resizeControl(Label9, lbl9);
            resizeControl(Label10, lbl10);
            resizeControl(Label11, lbl11);
            resizeControl(Label12, lbl12);
            resizeControl(Label13, lbl13);
            resizeControl(Label15, lbl15);
            resizeControl(Label17, lbl17);
            resizeControl(Label18, lbl18);
            resizeControl(Label19, lbl19);
            resizeControl(LabelTotalProduct, lbltotalprod);
            resizeControl(LabelOut, lblout);
            resizeControl(LabelStock, lblstock);
            resizeControl(LabelRaw, lblraw);
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
        Dashboard ds;

        string username, usertype;
        public InventoryManagement(Dashboard ds, string username, string usertype)
        {
            InitializeComponent();
            con = new MySqlConnection();
            con.ConnectionString = data.getConnection();
            this.ds = ds;
            this.username = username;
            this.usertype = usertype;
        }
        private void InventoryManagement_Load(object sender, EventArgs e)
        {
            timer1.Start();
            productLoad();
            Instock();
            OutStock();
            alcoholCount();
            perfumeCount();
            TotalProduct();
            RawMaterialCount();
            productLoad();
            chartTotal();
            autosize();
            userControl();
        }

        public void userControl()
        {
            if(usertype == "Staff")
            {
                btnRawMaterial.Enabled = false;
            }
            if (usertype == "Manager")
            {
                btnRawMaterial.Enabled = false;
            }
            if (usertype == "Owner")
            {
                btnRawMaterial.Enabled = true;
            }
        }
        public void productLoad()
        {
            try
            {
                dt = new DataTable();
                adpt = new MySqlDataAdapter("Select ProductName, Quantity From tblproduct ORDER BY Quantity DESC", con);
                adpt.Fill(dt);
                dgvproduct.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on loading datagridview", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void Instock()
        {
            string query = "SELECT COALESCE(COUNT(*),0) FROM tblproduct WHERE Quantity < 50 && Quantity > 0";

            try
            {
                con.Open();
                cmd = new MySqlCommand(query, con);
                Int32 row_count = Convert.ToInt32(cmd.ExecuteScalar());
                
                cmd.Dispose();
                con.Close();

                lblstock.Text = row_count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Counting Stock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void OutStock()
        {
            string query = "SELECT COALESCE(COUNT(*),0) FROM tblproduct WHERE Quantity <=0";

            try
            {
                con.Open();
                cmd = new MySqlCommand(query, con);
                Int32 row_count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                con.Close();

                lblout.Text = row_count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Counting Out Stock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void RawMaterialCount()
        {
            string query = "SELECT COALESCE(COUNT(*),0) FROM tblmaterial ";

            try
            {
                con.Open();
                cmd = new MySqlCommand(query, con);
                Int32 row_count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                con.Close();

                lblraw.Text = row_count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Counting Raw Material", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void TotalProduct()
        {
            string query = "SELECT COALESCE(COUNT(*),0) FROM tblproduct ";

            try
            {
                con.Open();
                cmd = new MySqlCommand(query, con);
                Int32 row_count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                con.Close();

                lbltotalprod.Text = row_count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Counting Product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void perfumeCount()
        {
            string query = "SELECT COALESCE(COUNT(*),0) FROM tblproduct WHERE Category= 'Perfume'";

            try
            {
                con.Open();
                cmd = new MySqlCommand(query, con);
                Int32 row_count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                con.Close();

                lbl2.Text = row_count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Counting Perfume", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void alcoholCount()
        {
            string query = "SELECT COALESCE(COUNT(*),0) FROM tblproduct WHERE Category= 'Alcohol'";

            try
            {
                con.Open();
                cmd = new MySqlCommand(query, con);
                Int32 row_count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                con.Close();

                lbl4.Text = row_count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Counting Alcohol", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void chartTotal()
        {
            MySqlDataAdapter adpt = new MySqlDataAdapter("SELECT COUNT(Quantity), Category FROM tblproduct GROUP BY Category", con);
            DataSet ds = new DataSet();

            adpt.Fill(ds, "Count");
            chart1.DataSource = ds.Tables["Count"];

            chart1.Series["Count"].XValueMember = "Category";
            chart1.Series["Count"].YValueMembers = "COUNT(Quantity)";

            chart1.Series[0].LegendText = "#VALX (#PERCENT)";
        }
        private void btnProduct_Click(object sender, EventArgs e)
        {
            Inventory_Related.ViewProducts view = new Inventory_Related.ViewProducts(username, usertype) { TopLevel = false, TopMost = true, Dock = DockStyle.Fill }; 
            ds.pContainer.Controls.Add(view);
            view.BringToFront();
            view.Show();
        }

        private void btnRawMaterial_Click(object sender, EventArgs e)
        {
            ViewRawMaterials raw = new ViewRawMaterials(username) { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
            ds.pContainer.Controls.Add(raw);
            raw.BringToFront();
            raw.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToString("dddd, MMMM, dd, yyyy");
            lbltime.Text = DateTime.Now.ToString("hh:mm:ss:tt");
        }

        private void InventoryManagement_Resize(object sender, EventArgs e)
        {
            resizeChildrenControl();
        }
    }
}
