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
    public partial class Pos_Manage_Void : Form
    {
        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;
        MainConnection data = new MainConnection();
        MySqlDataAdapter adpt;
        string transactionNumber, username, action;

        public Pos_Manage_Void(string Username)
        {
            InitializeComponent();
            cn = new MySqlConnection();
            cn.ConnectionString = data.getConnection();
            this.username = Username;
        }

        //display grid
        public void load()
        {
            try
            {
                DataTable dt = new DataTable();
                cn.Open();
                adpt = new MySqlDataAdapter("select * from tblvoided ORDER BY DateVoided AND TimeVoided DESC",cn);
                adpt.Fill(dt);
                dgv1.DataSource = dt;
                cn.Close();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Pos_Manage_Void_Load(object sender, EventArgs e)
        {
            load();
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToString("dddd, MMMM, dd, yyyy");
            lbltime.Text = DateTime.Now.ToString("hh:mm:ss:tt:");
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void searchbyDate()
        {
            try
            {
                DataTable dt = new DataTable();
                adpt = new MySqlDataAdapter(" select * from tblvoided WHERE DateVoided BETWEEN '" +
                    dateFrom.Value.ToString("MMM. dd, yyyy") + "' AND '" + dateTo.Value.ToString("MMM. dd, yyyy") + "' ORDER BY DateVoided DESC", cn);
                dt = new DataTable();
                adpt.Fill(dt);
                dgv1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on searching date", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void searchByCustomerName()
        {
            //da = new MySqlDataAdapter("SELECT FullName from tblposcustomerinfo where FullName Like '%" + txtCustomer.Text + "%'", cn);
            try
            {
                DataTable dt = new DataTable();
                cn.Open();
                adpt = new MySqlDataAdapter("Select * from tblvoided where (CustomerName Like '%" + txtSearch.Text + "%' OR TransactionNumber Like '%" + txtSearch.Text + "%'" +
                    "OR Amount Like '%" + txtSearch.Text + "%' OR TransactionType Like '%" + txtSearch.Text + "%' OR PaymentOption Like '%" + txtSearch.Text + "%')", cn);
                adpt.Fill(dt);
                dgv1.DataSource = dt;
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchByCustomerName();
        }

        private void btnCheckDate_Click(object sender, EventArgs e)
        {
            searchbyDate();
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                action = "void";
                if (dgv1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgv1.CurrentRow.Selected = true;
                    transactionNumber = dgv1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    Pos_Related.Pos_Transaction_History_Records posh = new Pos_Related.Pos_Transaction_History_Records(transactionNumber, username, action);
                    posh.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
