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
    public partial class Login : Form
    {
        //string randomNumber;

        MySqlConnection cn;
        MySqlDataReader dr;
        MySqlCommand cmd;
        MainConnection data = new MainConnection();
        int errorCount = 0;
        string fullname, employeenum;

        DateTime date = DateTime.Now;
        public Login()
        {
            InitializeComponent();
            this.ActiveControl = txtusername;
            cn = new MySqlConnection();
            cn.ConnectionString = data.getConnection();
            txtusername.Focus();
        }
        
        public void logs()
        {
            try
            {
                string action = "Logged In Today:" + date.ToString("yyyy-MM-dd") + " Username: " + fullname.ToString();

                cmd = new MySqlCommand("Insert into tbllogs (datelog, timelog, full_name, action, module)" +
                    "Values('" + date.ToString("yyyy-MM-dd") + "', '" + date.ToString("hh:mm:tt") + "', '" + fullname.ToString() + "', '" + action.ToString() + "', 'Login')", cn);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on login Form Logs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
      
        }

        public void loggedIn()
        {
            try
            {
                cmd = new MySqlCommand("insert into tblloggedin (employee_number, full_name, date, time)" +
                "Values('" + txtusername.Text + "', '" + fullname + "', '" + date.ToString("yyyy-MM-dd") + "', '" + date.ToString("hh:mm:tt") + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Login Form LoggedIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
           try
            {
                validation();
                if (errorCount == 0)
                {
                    cn.Open();
                    cmd = new MySqlCommand("select * from tblaccount where Employee_Number = '" + txtusername.Text + "' OR Full_Name ='"
                        + txtusername.Text + "'  AND Password = '" + txtpassword.Text + "'", cn);
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            fullname = dr["full_name"].ToString();
                            employeenum = dr["Employee_Number"].ToString();
                            Dashboard ds = new Dashboard(employeenum);
                            ds.Show();
                            this.Hide();
                        }
                        dr.Close();

                        //insert logs//
                        logs();

                        //insert data to tbl loggedIn//
                        loggedIn();

                        //update tblaccount status
                        status();

                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username and Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    cn.Close();
                }
                else
                {
                    MessageBox.Show("Please Enter Your Credentials", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Logging In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void status()
        {
            try
            {
                cmd = new MySqlCommand("update tblaccount set Status ='On-Duty' where Employee_Number='" + employeenum + "'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cb1_CheckedChanged(object sender, EventArgs e)
        {
            if(cb1.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = true;
        }

        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToChar(e.KeyChar) == 13)
            {
                btnlogin_Click(sender, e);
            }
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToChar(e.KeyChar) == 13)
            {
                btnlogin_Click(sender, e);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult message = new DialogResult();
            message = MessageBox.Show("Are you sure you want to Exit the Application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(message == DialogResult.Yes)
            {
                cn.Close();
                Application.Exit();
            }
        }

        private void checkConnection_Click(object sender, EventArgs e)
        {
            string con = data.getConnection();
            bool result = data.checkConnection(con);

            if (result == false)
            {
                MessageBox.Show("Connection is Not yet Established Properly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Connected!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            try
            {
                Connection cn = new Connection();
                cn.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



     

        public void validation()
        {
            errorCount = 0;
            if (string.IsNullOrEmpty(txtusername.Text))
            {
           
                errorCount += 1;
            }
            if(string.IsNullOrEmpty(txtpassword.Text))
            {
                
                errorCount += 1;
            }
        }
    }
}
