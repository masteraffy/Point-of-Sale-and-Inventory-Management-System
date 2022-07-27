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
    public partial class ManageAccount : Form
    {
        private Size formOriginalSize;
        private Rectangle textboxsearch;
        private Rectangle datagrid;
        private Rectangle btn1;
        private Rectangle btn2;
        private Rectangle btn3;

        public void autosize()
        {
            formOriginalSize = this.Size;
            textboxsearch = new Rectangle(txtsearch.Location.X, txtsearch.Location.Y, txtsearch.Width, txtsearch.Height);
            datagrid = new Rectangle(dgvAccount.Location.X, dgvAccount.Location.Y, dgvAccount.Width, dgvAccount.Height);
            btn1 = new Rectangle(btnAdd.Location.X, btnAdd.Location.Y, btnAdd.Width, btnAdd.Height);
            btn2 = new Rectangle(btnUpdate.Location.X, btnUpdate.Location.Y, btnUpdate.Width, btnUpdate.Height);
            btn3 = new Rectangle(btnDelete.Location.X, btnDelete.Location.Y, btnDelete.Width, btnDelete.Height);
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
            //textbox//
            resizeControl(textboxsearch, txtsearch);

            //button//
            resizeControl(btn1, btnAdd);
            resizeControl(btn2, btnUpdate);
            resizeControl(btn3, btnDelete);

            //datagrid//
            resizeControl(datagrid, dgvAccount);
        }

        MainConnection data = new MainConnection();
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter adpt;
        DataTable dt;

        DateTime date = DateTime.Now;
        string username;
        string selectedEmployee;
        public ManageAccount(string username)
        {
            InitializeComponent();
            con = new MySqlConnection();
            con.ConnectionString = data.getConnection();
            this.username = username;
        }
        public int row = -1;

        private void ManageAccount_Load(object sender, EventArgs e)
        {
            autosize();
            try
            {
                dt = new DataTable();
                adpt = new MySqlDataAdapter("select Employee_Number, Full_Name, Usertype, Status, Cell_Number, Password from tblaccount",con);
                adpt.Fill(dt);
                dgvAccount.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Form Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void refresh()
        {
            dt = new DataTable();
            adpt = new MySqlDataAdapter("SELECT * FROM tblaccount",con);
            adpt.Fill(dt);
            dgvAccount.DataSource = dt;
        }
        public void incrementrefresh()
        {
            dt = new DataTable();
            adpt = new MySqlDataAdapter("SELECT * FROM tblaccount",con);
            adpt.Fill(dt);
            dgvAccount.DataSource = dt;
            AddAccount auto = (AddAccount)Application.OpenForms["AddAccount"];
            
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            errorProvider1.Clear();
            try
            {
                row = e.RowIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                adpt = new MySqlDataAdapter("select Employee_Number, Full_Name, Usertype, Status, Cell_Number, Password " +
                    "FROM tblaccount WHERE Employee_Number LIKE '%" + txtsearch.Text + "%' OR Full_Name LIKE '%" + txtsearch.Text + "%' ORDER BY Employee_Number",con);
                adpt.Fill(dt);
                dgvAccount.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on search by name or employee number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddAccount addacc = new AddAccount("", "", "", "", "", username);
            addacc.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string edit_empno, edit_fullname, edit_usertype, edit_cellnumber;
            try
            {
                edit_empno = dgvAccount.Rows[row].Cells[0].Value.ToString();
                edit_fullname = dgvAccount.Rows[row].Cells[1].Value.ToString();
                edit_usertype = dgvAccount.Rows[row].Cells[2].Value.ToString();
                edit_cellnumber = dgvAccount.Rows[row].Cells[4].Value.ToString();
                UpdateAccount updateacc = new UpdateAccount(edit_empno, edit_fullname, edit_usertype, "", edit_cellnumber, username);
                updateacc.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Update Button", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //insert logs//
        public void logs()
        {
            string action = "Updated Existing Account ID:" + selectedEmployee.ToString() + " by: " + username.ToString();
            con.Open();
            cmd = new MySqlCommand("Insert into tbllogs (datelog, timelog, full_name, action, module)" +
                "Values('" + date.ToString("yyyy-MM-dd") + "', '" + date.ToString("HH:mm:ss") + "', '" + username.ToString() + "', '" + action.ToString() + "', 'Account')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                selectedEmployee = dgvAccount.Rows[row].Cells[0].Value.ToString();
                string selectedName = dgvAccount.Rows[row].Cells[1].Value.ToString();
                if (DialogResult.Yes == MessageBox.Show("Do you want to delete this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    con.Open();
                    cmd = new MySqlCommand("DELETE FROM tblaccount WHERE Employee_Number = '" + selectedEmployee + "'",con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Account Deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //insertlogs//
                    logs();

                    ManageAccount delete = (ManageAccount)Application.OpenForms["ManageAccount"];
                    delete.refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ManageAccount_Resize(object sender, EventArgs e)
        {
            resizeChildrenControl();
        }
    }
}
