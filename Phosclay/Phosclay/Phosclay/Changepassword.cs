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
    public partial class Changepassword : Form
    {
        MainConnection data = new MainConnection();
        string empno, password;
        MySqlConnection cn;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public Changepassword(string empno)
        {
            InitializeComponent();
            this.empno = empno;
            cn = new MySqlConnection();
            cn.ConnectionString = data.getConnection();
            checkPassword();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void logoutFunction()
        {
            Dashboard ds = new Dashboard(empno);
            ds.deleteLoggedIn();
            ds.status();
            Application.Restart();
            
            
        }
        public void validation()
        {
            

            if (string.IsNullOrEmpty(txtConfirmPass.Text) && string.IsNullOrEmpty(txtCurrentPass.Text) && string.IsNullOrEmpty(txtNewPass.Text))
            {
                MessageBox.Show("Please Fill All Fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtCurrentPass.Text != password)
            {
                MessageBox.Show("Current Password is Incorrect, Please Input Again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtNewPass.Text != txtConfirmPass.Text)
            {
                MessageBox.Show("New and Confirm Password dont Match, Please Input Again!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult result = new DialogResult();
                result = MessageBox.Show("Are you sure you want to Change your Password?\n You wull be Automatically Logged Out After You Change Your Password", "Change Password", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (result == DialogResult.Yes)
                {
                    cn.Open();
                    cmd = new MySqlCommand("UPDATE tblaccount set password = '" + txtNewPass.Text + "' where employee_number ='" + empno + "'", cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("Password Successfully Changed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logoutFunction();
                }   
                else
                {

                }    
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            validation();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCurrentPass.Clear();
            txtNewPass.Clear();
            txtConfirmPass.Clear();
        }

        private void chkshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkshowpassword.Checked == true)
            {
                txtNewPass.UseSystemPasswordChar = false;
                txtConfirmPass.UseSystemPasswordChar = false;
                txtCurrentPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtNewPass.UseSystemPasswordChar = true;
                txtConfirmPass.UseSystemPasswordChar = true;
                txtCurrentPass.UseSystemPasswordChar = true;
            }
        }

        public void checkPassword()
        {
            try
            {
                cn.Open();
                cmd = new MySqlCommand("select password from tblaccount where employee_number = '" + empno + "'", cn);
                dr = cmd.ExecuteReader();
                
                while(dr.Read())
                {
                    password = dr["Password"].ToString();
                }
                cn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Change password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
