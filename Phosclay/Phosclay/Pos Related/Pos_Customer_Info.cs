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
    public partial class Pos_Customer_Info : Form
    {
        MySqlConnection cn;
        MySqlCommand cm;
        public Pos_Customer_Info()
        {
            InitializeComponent();
            cn = new MySqlConnection();
            cn.ConnectionString = data.getConnection();
        }
        MainConnection data = new MainConnection();
        int errorCount = 0;
        DateTime date = DateTime.Now;
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void clear()
        {
            txtFirstN.Clear();
            txtMiddleN.Clear();
            txtLastN.Clear();
            txtContactN.Clear();
            txtAddress.Clear();
            txtCity.Clear();
            txtCompany.Clear();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                string fullname = txtFirstN.Text + " " + txtMiddleN.Text + " " + txtLastN.Text;
                validation();
                if (errorCount == 0)
                {
                    cn.Open();
                    cm = new MySqlCommand("INSERT INTO tblposcustomerinfo VALUES " +
                           "('" + fullname + "', '" + txtCompany.Text + "', '" + txtAddress.Text +
                           "', '" + txtCity.Text + "', '" + txtContactN.Text + "', '" + date.ToString("MMM. dd, yyyy") + "')", cn);
                    cm.ExecuteNonQuery();
                    MessageBox.Show("New Customer Added!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    this.Hide();
                    Pos_Checkout ps = (Pos_Checkout)Application.OpenForms["Pos_Checkout"];
                    ps.search();
                    cn.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void validation()
        {
            try
            {
                errorProvider1.Clear();
                errorCount = 0;
                if (string.IsNullOrEmpty(txtFirstN.Text))
                {
                    errorProvider1.SetError(txtFirstN, "This field is Required");
                    errorCount++;
                }
                if (string.IsNullOrEmpty(txtLastN.Text))
                {
                    errorProvider1.SetError(txtLastN, "This field is Required");
                    errorCount++;
                }
                if (string.IsNullOrEmpty(txtCity.Text))
                {
                    errorProvider1.SetError(txtCity, "This field is Required");
                    errorCount++;
                }
                if (txtContactN.TextLength < 11)
                {
                    errorProvider1.SetError(txtContactN, "Must be 11 numbers");
                    errorCount++;
                }
                if (string.IsNullOrEmpty(txtContactN.Text))
                {
                    errorProvider1.SetError(txtContactN, "This field is Required");
                    errorCount++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void txtContactN_TextChanged(object sender, EventArgs e)
        {
            txtContactN.MaxLength = 11;
        }
        private void txtContactN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
    
}
