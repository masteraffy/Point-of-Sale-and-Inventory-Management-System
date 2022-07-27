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
    public partial class Dashboard : Form
    {
        string username, usertype, empNo;
        MySqlConnection cn;
        MySqlDataReader dr;
        MySqlCommand cmd;
        MainConnection data = new MainConnection();
        public Point mouseLocation;
        public Dashboard(string empno)
        {
            InitializeComponent();
            this.empNo = empno;
            cn = new MySqlConnection();
            cn.ConnectionString = data.getConnection();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Overview over = new Overview() { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
            this.pContainer.Controls.Add(over);
            over.BringToFront();
            over.Show();

            panelDropdown.Height = 66;
            loadResource();
            userControl();
        }

        private void btninventory_Click(object sender, EventArgs e)
        {
            InventoryManagement im = new InventoryManagement(this, lblUsername.Text, lblUserType.Text) { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
            this.pContainer.Controls.Add(im);
            im.BringToFront();
            im.Show();
            
        }

        private void btnpos_Click(object sender, EventArgs e)
        {
            Point_of_Sale pos = new Point_of_Sale(this, lblUsername.Text) { TopLevel = false, TopMost = true, Dock = DockStyle.Fill } ;
            this.pContainer.Controls.Add(pos);
            pos.BringToFront();
            pos.Show();
            btnsalesofreport.Enabled = false;
            btnadministratormenu.Enabled = false;
            btnpos.Enabled = false;
            btninventory.Enabled = false;
            btndashboard.Enabled = false;
        }

        private void btnsalesofreport_Click(object sender, EventArgs e)
        {
            SalesReport sr = new SalesReport() { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
            this.pContainer.Controls.Add(sr);
            sr.BringToFront();
            sr.Show();
        }

        private void btnadministratormenu_Click(object sender, EventArgs e)
        {
            Administrator admin = new Administrator(this,lblUsername.Text ,lblUserType.Text) { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
            this.pContainer.Controls.Add(admin);
            admin.BringToFront();
            admin.Show();
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            Overview over = new Overview() { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
            this.pContainer.Controls.Add(over);
            over.BringToFront();
            over.Show();
        }

        public void openPos()
        {
            Point_of_Sale pos = new Point_of_Sale(this, username);
            pos.MdiParent = this;
            pos.Show();         
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {

                Changepassword cp = new Changepassword(empNo) { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
                this.pContainer.Controls.Add(cp);
                cp.BringToFront();
                cp.Show();      

                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Button Change password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        internal void deleteLoggedIn()
        {
            //this section is to delete the data in tblloggedIn when a user logs out on his account

            cn.Open();
            cmd = new MySqlCommand("delete from tblloggedin where Employee_Number ='" + empNo + "'", cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void status()
        {
            try
            {
                cn.Open();
                cmd = new MySqlCommand("update tblaccount set Status ='Off-Duty' where Employee_Number='" + empNo + "'", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = new DialogResult();
                result = MessageBox.Show("Are you sure you want to Logout?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //delete from tblLoggedIn
                    deleteLoggedIn();
                    status();
                    Application.Restart();
                }
                else
                {

                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on button logout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            if (panelDropdown.Height == 147)
            {
                panelDropdown.Height = 66;
            }
            else
            {
                panelDropdown.Height = 147;
            }
        }

        private void btnmax_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            controls.DoMaximize(this, btn);
        }

        private void btnmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            try
            {
                deleteLoggedIn();
                status();
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Exit button", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(e.X, e.Y);
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - mouseLocation.X;
                this.Top += e.Y - mouseLocation.Y;

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/1_23EiUG2mOdEHEkrJElHbqB6pIC2QyHl/view?usp=sharing");
        }

        private void loadResource()
        {
            try
            {
                cn.Open();
                cmd = new MySqlCommand("Select * from tblaccount where Employee_Number ='" + empNo + "'", cn);
                dr = cmd.ExecuteReader();
                dr.Read();
                username = dr["Full_Name"].ToString();
                usertype = dr["Usertype"].ToString();
                lblUsername.Text = username;
                lblUserType.Text = usertype;
                cn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Load Resource", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        public void userControl()
        {
            if(usertype == "Staff")
            {
                btndashboard.Visible = true;
                btninventory.Visible = true;
                btnpos.Visible = false;
                btnsalesofreport.Visible = false;
                btnadministratormenu.Visible = false;
            }

            if(usertype == "Manager")
            {
                btndashboard.Visible = true;
                btninventory.Visible = true;
                btnpos.Visible = true;
                btnsalesofreport.Visible = false;
                btnadministratormenu.Visible = false;
            }

            if (usertype == "Owner")
            {
                btndashboard.Visible = true;
                btninventory.Visible = true;
                btnpos.Visible = true;
                btnsalesofreport.Visible = true;
                btnadministratormenu.Visible = true;
            }
        }

        
    }
}
