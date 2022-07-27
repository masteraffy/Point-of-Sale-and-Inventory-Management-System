using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Phosclay.Inventory_Related
{
    public partial class UpdateProduct : Form
    {
        MainConnection data = new MainConnection();
        MySqlConnection con;
        MySqlCommand cmd;
        ViewProducts v;
        private string action;
        string username;
        DateTime date = DateTime.Now;
        public UpdateProduct(ViewProducts v, string action, string username)
        {
            InitializeComponent();
            con = new MySqlConnection();
            con.ConnectionString = data.getConnection();
            this.v = v;
            this.action = action;
            this.username = username;
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

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            txtProductID.Enabled = false;
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //insert logs//
        public void logs()
        {
            string action = "Updated Existing Item ID:" + txtProductID.Text + " by: " + username.ToString();
            con.Open();
            cmd = new MySqlCommand("Insert into tbllogs (datelog, timelog, full_name, action, module)" +
                "Values('" + date.ToString("yyyy-MM-dd") + "', '" + date.ToString("HH:mm:ss") + "', '" + username.ToString() + "', '" + action.ToString() + "', 'Inventory')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "0")
            {
                try
                {
                    con.Open();
                    cmd = new MySqlCommand("UPDATE tblproduct SET ProductName = '" + txtProductName.Text + "', Measurement = '" + cmbunit.Text + "', Price = '"+txtPrice.Text+"', " +
                        "Description ='" + txtProductDesc.Text + "', Quantity= '" + txtQuantity.Text + "', Status = 'Out of Stock', Image= @Image WHERE ProductID = '" + txtProductID.Text + "'", con);

                    MemoryStream stream = new MemoryStream();
                    pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] pic = stream.ToArray();
                    cmd.Parameters.AddWithValue("@Image", pic);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    //insert logs//
                    logs();
                    MessageBox.Show("Product Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    ViewProducts update = (ViewProducts)Application.OpenForms["ViewProducts"];
                    update.DatagridviewLoad();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error on updating product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new MySqlCommand("UPDATE tblproduct SET ProductName = '" + txtProductName.Text + "', Measurement = '" + cmbunit.Text + "', Price = '" + txtPrice.Text + "', " +
                        "Description ='" + txtProductDesc.Text + "', Quantity= '" + txtQuantity.Text + "', Status = 'In-Stock', Image= @Image WHERE ProductID = '" + txtProductID.Text + "'", con);

                    MemoryStream stream = new MemoryStream();
                    pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] pic = stream.ToArray();
                    cmd.Parameters.AddWithValue("@Image", pic);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    //insert logs//
                    logs();
                    MessageBox.Show("Product Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    ViewProducts update = (ViewProducts)Application.OpenForms["ViewProducts"];
                    update.DatagridviewLoad();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error on updating product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public Point mouseLocation;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - mouseLocation.X;
                this.Top += e.Y - mouseLocation.Y;
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new MySqlCommand("SELECT * From tblproduct WHERE ProductID LIKE '%" + txtsearch.Text + "%' ", con);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtProductID.Text = dr["ProductID"].ToString();
                    txtProductName.Text = dr["Productname"].ToString();
                    txtProductDesc.Text = dr["Description"].ToString();
                    txtQuantity.Text = dr["Quantity"].ToString();
                    txtPrice.Text = dr["Price"].ToString();
                    gunaDateTimePicker1.Value = DateTime.Parse(dr["Date"].ToString());
                    byte[] imgData = (byte[])dr["Image"];
                    MemoryStream ms = new MemoryStream(imgData);
                    pictureBox1.Image = Image.FromStream(ms);
                }
                else
                {
                    MessageBox.Show("No data found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on searching", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
