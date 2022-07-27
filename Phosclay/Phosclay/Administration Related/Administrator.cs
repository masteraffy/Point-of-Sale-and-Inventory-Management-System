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
    public partial class Administrator : Form
    {
        private Size formOriginalSize;

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

        //button
        private Rectangle btn1;
        private Rectangle btn2;
        private Rectangle btn3;
        private Rectangle btn6;
        private Rectangle btn7;
        private Rectangle btn8;
        private Rectangle btn9;
        private Rectangle btn10;

        //combobox, datagrid
        private Rectangle comboLogs;
        private Rectangle datagrid1;
        private Rectangle datagrid2;
        private Rectangle datagrid3;
        private Rectangle datagrid4;

        public void autosize()
        {
            formOriginalSize = this.Size;
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
            pN18 = new Rectangle(pn18.Location.X, pn18.Location.Y, pn18.Width, pn18.Height);

            //label//
            Label1 = new Rectangle(lbl1.Location.X, lbl1.Location.Y, lbl1.Width, lbl1.Height);
            Label2 = new Rectangle(lbl2.Location.X, lbl2.Location.Y, lbl2.Width, lbl2.Height);
            Label3 = new Rectangle(lbl3.Location.X, lbl3.Location.Y, lbl3.Width, lbl3.Height);
            Label4 = new Rectangle(lbl4.Location.X, lbl4.Location.Y, lbl4.Width, lbl4.Height);
            Label5 = new Rectangle(lblastoday.Location.X, lblastoday.Location.Y, lblastoday.Width, lblastoday.Height);
            Label6 = new Rectangle(lbl6.Location.X, lbl6.Location.Y, lbl6.Width, lbl6.Height);
            Label7 = new Rectangle(lbl7.Location.X, lbl7.Location.Y, lbl7.Width, lbl7.Height);
            Label8 = new Rectangle(label10.Location.X, label10.Location.Y, label10.Width, label10.Height);

            //button//
            btn1 = new Rectangle(btnManageVoids.Location.X, btnManageVoids.Location.Y, btnManageVoids.Width, btnManageVoids.Height);
            btn2 = new Rectangle(btnProducts.Location.X, btnProducts.Location.Y, btnProducts.Width, btnProducts.Height);
            btn3 = new Rectangle(btnMaterial.Location.X, btnMaterial.Location.Y, btnMaterial.Width, btnMaterial.Height);
            btn6 = new Rectangle(btnTransaction.Location.X, btnTransaction.Location.Y, btnTransaction.Width, btnTransaction.Height);
            btn7 = new Rectangle(btnManage.Location.X, btnManage.Location.Y, btnManage.Width, btnManage.Height);
            btn8 = new Rectangle(btnSettings.Location.X, btnSettings.Location.Y, btnSettings.Width, btnSettings.Height);
            btn9 = new Rectangle(btnExpand.Location.X, btnExpand.Location.Y, btnExpand.Width, btnExpand.Height);
            btn10 = new Rectangle(btnExpandShip.Location.X, btnExpandShip.Location.Y, btnExpandShip.Width, btnExpandShip.Height);

            //datagrid//
            comboLogs = new Rectangle(cmbLogs.Location.X, cmbLogs.Location.Y, cmbLogs.Width, cmbLogs.Height);
            datagrid1 = new Rectangle(dgvShipped.Location.X, dgvShipped.Location.Y, dgvShipped.Width, dgvShipped.Height);
            datagrid2 = new Rectangle(dgvLoggedIn.Location.X, dgvLoggedIn.Location.Y, dgvLoggedIn.Width, dgvLoggedIn.Height);
            datagrid3 = new Rectangle(dgvLogs.Location.X, dgvLogs.Location.Y, dgvLogs.Width, dgvLogs.Height);
            datagrid4 = new Rectangle(dgv1.Location.X, dgv1.Location.Y, dgv1.Width, dgv1.Height);

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
            resizeControl(pN18, pn18);

            //label//
            resizeControl(Label1, lbl1);
            resizeControl(Label2, lbl2);
            resizeControl(Label3, lbl3);
            resizeControl(Label4, lbl4);
            resizeControl(Label5, lblastoday);
            resizeControl(Label6, lbl6);
            resizeControl(Label7, lbl7);
            resizeControl(Label8, label10);

            //button//
            resizeControl(btn1, btnManageVoids);
            resizeControl(btn2, btnProducts);
            resizeControl(btn3, btnMaterial);
            resizeControl(btn6, btnTransaction);
            resizeControl(btn7, btnManage);
            resizeControl(btn8, btnSettings);
            resizeControl(btn9, btnExpand);
            resizeControl(btn10, btnExpandShip);

            //datagrid, combobox//
            resizeControl(comboLogs, cmbLogs);
            resizeControl(datagrid1, dgvShipped);
            resizeControl(datagrid2, dgvLoggedIn);
            resizeControl(datagrid3, dgvLogs);
            resizeControl(datagrid4, dgv1);
        }

        MainConnection data = new MainConnection();
        MySqlConnection con;
        MySqlDataAdapter adpt;
        MySqlCommand cmd;
        DataTable dt;
        string username, usertype;
        Dashboard ds;
        public Administrator(Dashboard ds,string username, string usertype)
        {
            InitializeComponent();
            con = new MySqlConnection();
            con.ConnectionString = data.getConnection();
            this.username = username;
            this.ds = ds;
            this.usertype = usertype;

        }
        public void userControl()
        {
            if (usertype == "Staff")
            {
               btnMaterial.Enabled = false;
            }
            if (usertype == "Manager")
            {
                btnMaterial.Enabled = false;
            }
            if (usertype == "Owner")
            {
                btnMaterial.Enabled = true;
            }
        }
        //
        private void asToday()
        {
            string query = "SELECT COALESCE(COUNT(*),0) FROM tblshipped where Shipping_Date='" + DateTime.Now.ToString("MMM. dd, yyyy") + "' AND Status ='Pending'";

            try
            {
                con.Open();
                cmd = new MySqlCommand(query, con);
                Int32 row_count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                con.Close();

                lblastoday.Text = row_count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //Start of accountManagementLogs//
        public void AccountLogs()
        {
            try
            {
                DataTable dt = new DataTable();
                con.Open();
                adpt = new MySqlDataAdapter("select datelog, timelog, full_name, action from tblLogs where Module ='Account'", con);
                adpt.Fill(dt);
                dgvLogs.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Loading Account Logs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //End of accountManagementLogs//

        //Start of PosTransactionLogs // 
        public void PosTransactionLogs()
        {
            try
            {
                DataTable dt = new DataTable();
                con.Open();
                adpt = new MySqlDataAdapter("select datelog, timelog, full_name, action from tblLogs where Module ='POS'", con);
                adpt.Fill(dt);
                dgvLogs.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on PosTransaction Logs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // End of Pos TransactionLogs //

        // Start of Inventory Logs // 
        public void InventoryLogs()
        {
            try
            {
                DataTable dt = new DataTable();
                con.Open();
                adpt = new MySqlDataAdapter("select datelog, timelog, full_name, action from tblLogs where Module ='Inventory'", con);
                adpt.Fill(dt);
                dgvLogs.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Inventory Logs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void VoidedLogs()
        {
            try
            {
                DataTable dt = new DataTable();
                con.Open();
                adpt = new MySqlDataAdapter("select datelog, timelog, full_name, action from tblLogs where Module ='Void Transactions'", con);
                adpt.Fill(dt);
                dgvLogs.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on voided logs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoginLogs()
        {
            try
            {
                DataTable dt = new DataTable();
                con.Open();
                adpt = new MySqlDataAdapter("select datelog, timelog, full_name, action from tblLogs where Module ='Login'", con);
                adpt.Fill(dt);
                dgvLogs.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on login Logs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // End of Inventory Logs//

        private void Administrator_Load(object sender, EventArgs e)
        {
            cmbLogs.SelectedIndex = 0;
            timer1.Start();
            autosize();
            asToday();
            userControl();
            try
            {
                dt = new DataTable();
                adpt = new MySqlDataAdapter("select Employee_Number, Date, Time from tblloggedin",con);
                adpt.Fill(dt);
                dgvLoggedIn.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Administrator Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //---------------------------------End---------------------------//

            //-------------------------------Products to be Shipped---------------------//

            shipping();

           
        }

        public void shipping()
        {
            try
            {
                dt = new DataTable();
                adpt = new MySqlDataAdapter("select Customer_Name, Shipping_Date, Shipping_Method, Amount, Status from tblshipped where Status='Pending' ORDER BY Shipping_Date DESC", con);
                adpt.Fill(dt);
                dgvShipped.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Product to be shipped", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            Inventory_Related.ViewProducts vp = new Inventory_Related.ViewProducts(username,usertype) { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
            ds.pContainer.Controls.Add(vp);
            vp.BringToFront();
            vp.Show();
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            ViewRawMaterials vrw = new ViewRawMaterials("") { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
            ds.pContainer.Controls.Add(vrw);
            vrw.BringToFront();
            vrw.Show();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            Pos_Transaction_History pth = new Pos_Transaction_History(username) { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
            ds.pContainer.Controls.Add(pth);
            pth.BringToFront();
            pth.Show();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            Administration_Related.AccountManagement.ManageAccount manacc = new Administration_Related.AccountManagement.ManageAccount(username) { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
            ds.pContainer.Controls.Add(manacc);
            manacc.BringToFront();
            manacc.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToString("dddd, MMMM, dd, yyyy");
            lbltime.Text = DateTime.Now.ToString("hh:mm:ss:tt:");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {            
            Settings s = new Settings() { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
            ds.pContainer.Controls.Add(s);
            s.BringToFront();
            s.Show();
        }

        private void cmbLogs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLogs.SelectedIndex == 0)
            {
                AccountLogs();
            }
            else if (cmbLogs.SelectedIndex == 1)
            {
                InventoryLogs();
            }
            else if (cmbLogs.SelectedIndex == 2)
            {
                PosTransactionLogs();
            }
            else if (cmbLogs.SelectedIndex == 3)
            {
                VoidedLogs();
            }
            else if (cmbLogs.SelectedIndex == 4)
            {
                LoginLogs();
            }
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {                    
            Administration_Related.SystemLogs systemLogs = new Administration_Related.SystemLogs() { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
            ds.pContainer.Controls.Add(systemLogs);
            systemLogs.BringToFront();
            systemLogs.Show();
        }

        private void btnManageVoids_Click(object sender, EventArgs e)
        {
            Pos_Related.Pos_Manage_Void pmv = new Pos_Related.Pos_Manage_Void(username) { TopLevel = false, TopMost = true, Dock = DockStyle.Fill};
            ds.pContainer.Controls.Add(pmv);
            pmv.BringToFront();
            pmv.Show();
            

            
        }

        private void btnExpandShip_Click(object sender, EventArgs e)
        {
            /*
             * Pos_Related.Pos_Manage_Void pmv = new Pos_Related.Pos_Manage_Void(username) { TopLevel = false, TopMost = true, Dock = DockStyle.Fill};
            ds.pContainer.Controls.Add(pmv);
            pmv.BringToFront();
            pmv.Show();
            */

            Manage_Shipping ms = new Manage_Shipping(username) { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
            ds.pContainer.Controls.Add(ms);
            ms.BringToFront();
            ms.Show();

        }

        private void Administrator_Resize(object sender, EventArgs e)
        {
            resizeChildrenControl();
        }
    }
}
