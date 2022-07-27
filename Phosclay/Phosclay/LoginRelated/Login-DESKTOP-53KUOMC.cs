using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlphaTesting
{
    public partial class Login : Form
    {
        string randomNumber;
        public Login()
        {
            InitializeComponent();
            this.ActiveControl = txtusername;
            txtusername.Focus();
        }
        Class1 login = new Class1("127.0.0.1", "ojt_management", "sevgonzales", "123456");
        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = login.GetData("select * from tblaccount where Username = '" + txtusername.Text + "' and Password '" 
                    + txtpassword.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    //OTP otp = new OTP();
                    //otp.Show();
                    Dashboard db = new Dashboard();
                    db.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("You have entered an invalid username or password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Login Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
