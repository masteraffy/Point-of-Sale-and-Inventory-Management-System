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

namespace Phosclay.Administration_Related.AccountManagement
{
    public partial class AddAccount : Form
    {
        private string Empno, Full_Name, Usertype, Status, Cell_Number;
        string username;
        MainConnection data = new MainConnection();
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter adpt;
        DataTable dt;
        string sql;

        DateTime date = DateTime.Now;
        public AddAccount(string Empno, string Full_Name, string Usertype, string Status, string Cell_Number, string username)
        {
            InitializeComponent();
            con = new MySqlConnection();
            con.ConnectionString = data.getConnection();
            this.Empno = Empno;
            this.Full_Name = Full_Name;
            this.Usertype = Usertype;
            this.Status = Status;
            this.Cell_Number = Cell_Number;
            this.username = username;
        }
        private void AddAccount_Load(object sender, EventArgs e)
        {
            
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtNumber.Text = "+639";
            cmbUsertype.SelectedIndex = -1;

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private int errorCount;

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            txtNumber.MaxLength = 10;
        }

 

        public void validateForm()
        {
            errorProvider1.Clear();
            errorCount = 0;
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errorProvider1.SetError(txtName, "Please input your full name");
                errorCount++;
            }
            if (string.IsNullOrEmpty(txtNumber.Text))
            {
                errorProvider1.SetError(txtNumber, "Please input your contact number");
                errorCount++;
            }
            if (cmbUsertype.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbUsertype, "Please select a position");
                errorCount++;
            }
            try
            {
                dt = new DataTable();
                adpt = new MySqlDataAdapter("select * from tblaccount where Employee_Number = '" + txtEmpNo.Text + "'",con);
                adpt.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    errorProvider1.SetError(txtEmpNo, "Employee Number is already existing");
                    errorCount++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on search existing employee number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        

        //insert logs//
        public void logs()
        {
            string action = "Added New Account ID:" + txtEmpNo.Text + " by: " + username.ToString();
            con.Open();
            cmd = new MySqlCommand("Insert into tbllogs (datelog, timelog, full_name, action, module)" +
                "Values('" + date.ToString("yyyy-MM-dd") + "', '" + date.ToString("HH:mm:ss") + "', '" + username.ToString() + "', '" + action.ToString() + "', 'Account')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                validateForm();
                if (errorCount == 0)
                {
                    string addon = "+63";
                    con.Open();
                    cmd = new MySqlCommand("INSERT INTO tblaccount (Employee_Number, Full_Name, Usertype, Status, Cell_Number, Password) VALUES " +
                        "('" + txtEmpNo.Text + "', '" + txtName.Text + "', '" + cmbUsertype.Text + "', 'On-duty', '" + (addon + txtNumber.Text) + "', '123456')",con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Account Added!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    //insert logs//
                    logs();
                    
                    this.Hide();
                    ManageAccount add = (ManageAccount)Application.OpenForms["ManageAccount"];
                    add.incrementrefresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on adding an account", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
