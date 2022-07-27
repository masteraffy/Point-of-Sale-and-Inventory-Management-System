using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace Phosclay.Inventory_Related
{
    public partial class AddProduct : Form
    {
        MainConnection data = new MainConnection();
        MySqlCommand cmd;
        MySqlConnection con;
        DataTable dt;
        MySqlDataAdapter adpt;
        private string action;
        int errorCount;
        public Point mouseLocation;
        string username = "";

        DateTime date = DateTime.Now;

        public AddProduct(string action, string username)
        {
            InitializeComponent();
            con = new MySqlConnection();
            con.ConnectionString = data.getConnection();
            this.action = action;
            this.username = username;
        }

        public void validateForm()
        {
            errorProvider1.Clear();
            errorCount = 0;

            if (string.IsNullOrEmpty(txtProductID.Text))
            {
                errorProvider1.SetError(txtProductID, "Product ID is empty");
                errorCount++;
            }
            if (string.IsNullOrEmpty(txtProductName.Text))
            {
                errorProvider1.SetError(txtProductName, "Product Name is empty");
                errorCount++;
            }
            if (cmbCategory.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbCategory, "Select Category");
                errorCount++;
            }
            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                errorProvider1.SetError(txtPrice, "Price is empty");
                errorCount++;
            }
            if (string.IsNullOrEmpty(txtProductDesc.Text))
            {
                errorProvider1.SetError(txtProductDesc, "Description is empty");
                errorCount++;
            }
            if (string.IsNullOrEmpty(txtQuantity.Text))
            {
                errorProvider1.SetError(txtQuantity, "Quantity is empty");
                errorCount++;
            }
            if (action == "add")
            {
                try
                {
                    dt = new DataTable();
                    adpt = new MySqlDataAdapter("SELECT * FROM tblproduct WHERE ProductID = '" + txtProductID.Text + "'", con);
                    adpt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        errorProvider1.SetError(txtProductID, "Product ID is already existing");
                        errorCount++;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error on searching exsiting Product ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    con.Close();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProductID.Text = "";
            txtProductName.Text = "";
            txtProductDesc.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            txtimagepath.Text = "";
            cmbCategory.SelectedIndex = -1;
            cmbunit.SelectedIndex = -1;
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        string FileName = openFileDialog.FileName;
                        txtimagepath.Text = FileName;
                        pictureBox1.Load(FileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void inventoryCategorySettings()
        {
            try
            {
                DataTable dt = new DataTable();
                con.Open();
                adpt = new MySqlDataAdapter("Select Category from tblsettings where form = 'InventoryCategory'", con);
                adpt.Fill(dt);

                foreach (DataRow da in dt.Rows)
                {
                    cmbCategory.Items.Add(da[0].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void inventoryUnit()
        {
            try
            {
                DataTable dt = new DataTable();
                con.Open();
                adpt = new MySqlDataAdapter("Select Category from tblsettings where form = 'InventoryUnit'", con);
                adpt.Fill(dt);

                foreach (DataRow da in dt.Rows)
                {
                    cmbunit.Items.Add(da[0].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Inventory Unit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                validateForm();
                if (errorCount == 0)
                {
                    con.Open();
                    cmd = new MySqlCommand("INSERT INTO tblproduct (ProductID, ProductName, Category, Measurement, Price, Date, Description, Quantity, Status, Image)VALUES " +
                        "('" + txtProductID.Text + "',  '" + txtProductName.Text + "', '" + cmbCategory.Text + "', '" + cmbunit.Text + "', '" + txtPrice.Text + "', '" 
                        + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + txtProductDesc.Text + "', '" + txtQuantity.Text + "', 'In-Stock', @Image)", con);

                    MemoryStream stream = new MemoryStream();
                    pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] pic = stream.ToArray();
                    cmd.Parameters.AddWithValue("@Image", pic);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    
                    //insert logs//
                    logs();

                    MessageBox.Show("Added new product", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    ViewProducts addP = (ViewProducts)Application.OpenForms["ViewProducts"];
                    addP.DatagridviewLoad();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on adding product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                con.Close();
            }
        }

        //insert logs//
        public void logs()
        {
            string action = "Added New Item ID:" + txtProductID.Text + " by: " + username.ToString();
            con.Open();
            cmd= new MySqlCommand("Insert into tbllogs (datelog, timelog, full_name, action, module)" +
                "Values('" + date.ToString("yyyy-MM-dd") + "', '" + date.ToString("HH:mm:ss") + "', '" + username.ToString() + "', '" + action.ToString() + "', 'Inventory')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
       
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - mouseLocation.X;
                this.Top += e.Y - mouseLocation.Y;

            }
        }
        private void AddProduct_Load(object sender, EventArgs e)
        {
            inventoryCategorySettings();
            inventoryUnit();
        }
    }
}
