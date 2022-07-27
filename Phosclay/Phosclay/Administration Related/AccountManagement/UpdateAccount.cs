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
    public partial class UpdateAccount : Form
    {
        MainConnection data = new MainConnection();
        MySqlConnection con;
        MySqlCommand cmd;
        private string Empno, Full_Name, Usertype, Status, Cell_Number;
        string username;
        private int errorCount;

        DateTime date = DateTime.Now;
        public UpdateAccount(string Empno, string Full_Name, string Usertype, string Status, string Cell_Number, string username)
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
        private void UpdateAccount_Load(object sender, EventArgs e)
        {
            txtEmpNo.Text = Empno;
            txtFullName.Text = Full_Name;
            txtCellNum.Text = Cell_Number;
            if (Usertype == "Staff")
            {
                cmbusertype.SelectedIndex = 0;
            }
            else if (Usertype == "Manager")
            {
                cmbusertype.SelectedIndex = 1;
            }
            else
            {
                cmbusertype.SelectedIndex = 2;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCellNum.Clear();
            txtFullName.Clear();
            cmbusertype.SelectedIndex = -1;
        }

        private void txtCellNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        //insert logs//
        public void logs()
        {
            string action = "Updated Existing Account ID:" + txtEmpNo.Text + " by: " + username.ToString();
            con.Open();
            cmd = new MySqlCommand("Insert into tbllogs (datelog, timelog, full_name, action, module)" +
                "Values('" + date.ToString("yyyy-MM-dd") + "', '" + date.ToString("HH:mm:ss") + "', '" + username.ToString() + "', '" + action.ToString() + "', 'Account')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                validateForm();
                if (errorCount == 0)
                {
                    con.Open();
                    cmd = new MySqlCommand("UPDATE tblaccount SET Full_Name = '" + txtFullName.Text + "', Usertype = '" + cmbusertype.Text + "'," +
                        "Cell_Number = '" + txtCellNum.Text + "' WHERE Employee_Number = '" + txtEmpNo.Text + "'",con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Account Updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //insert logs//
                    logs();
                    
                    this.Hide();
                    ManageAccount updateacc = (ManageAccount)Application.OpenForms["ManageAccount"];
                    updateacc.refresh();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void validateForm()
        {
            errorProvider1.Clear();
            errorCount = 0;
            if (string.IsNullOrEmpty(txtFullName.Text))
            {
                errorProvider1.SetError(txtFullName, "This field cannot be empty");
                errorCount++;
            }
            if (string.IsNullOrEmpty(txtCellNum.Text))
            {
                errorProvider1.SetError(txtCellNum, "This field cannot be empty");
                errorCount++;
            }
            if (cmbusertype.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbusertype, "Please select a position");
                errorCount++;
            }
        }       
    }
}
