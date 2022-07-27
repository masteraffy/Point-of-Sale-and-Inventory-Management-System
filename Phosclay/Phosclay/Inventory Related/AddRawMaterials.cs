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

namespace Phosclay
{
    public partial class AddRawMaterials : Form
    {
        private string action;
        MainConnection data = new MainConnection();
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter adpt;
        DataTable dt;
        int errorCount;

        DateTime date = DateTime.Now;
        string username;
        public AddRawMaterials(string action, string username)
        {
            InitializeComponent();
            con = new MySqlConnection();
            con.ConnectionString = data.getConnection();
            this.action = action;
            datepicker.Value = DateTime.Now;
            this.username = username;
        }
        public void validateForm()
        {
            errorProvider1.Clear();
            errorCount = 0;

            if (string.IsNullOrEmpty(txtItemID.Text))
            {
                errorProvider1.SetError(txtItemID, "Item ID is empty");
                errorCount++;
            }
            if (string.IsNullOrEmpty(txtMaterial.Text))
            {
                errorProvider1.SetError(txtMaterial, "Material name is empty");
                errorCount++;
            }
            if (string.IsNullOrEmpty(txtItemDesc.Text))
            {
                errorProvider1.SetError(txtItemDesc, "Description is empty");
                errorCount++;

            }
            if (string.IsNullOrEmpty(txtQuantity.Text))
            {
                errorProvider1.SetError(txtQuantity, "Quantity is empty");
                errorCount++;

            }
            if(string.IsNullOrEmpty(txttransacttion.Text))
            {
                errorProvider1.SetError(txttransacttion, "Transaction Receipt is empty");
                errorCount++;
            }
            if (string.IsNullOrEmpty(txtcompany.Text))
            {
                errorProvider1.SetError(txtcompany, "Company Name is empty");
                errorCount++;
            }
            if (string.IsNullOrEmpty(txttransacttion.Text))
            {
                errorProvider1.SetError(txttransacttion, "Transaction Receipt is empty");
                errorCount++;
            }
            if (string.IsNullOrEmpty(txtcontact.Text))
            {
                errorProvider1.SetError(txtcontact, "Contact is empty");
                errorCount++;
            }
            if (string.IsNullOrEmpty(txtCost.Text))
            {
                errorProvider1.SetError(txtCost, "Total Cost is empty");
                errorCount++;
            }
            if (string.IsNullOrEmpty(txtMeasurement.Text))
            {
                errorProvider1.SetError(txtMeasurement, "Measurement is empty");
                errorCount++;
            }
            if (action == "add")
            {
                try
                {
                    dt = new DataTable();
                    adpt = new MySqlDataAdapter("SELECT * FROM tblmaterial WHERE Material_ID = '" + txtItemID.Text + "'", con);
                    adpt.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        errorProvider1.SetError(txtItemID, "Item ID is already existed");
                        errorCount++;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error on searching existing item ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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

        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtClear_Click(object sender, EventArgs e)
        {
            txtItemID.Text = "";
            txtMaterial.Text = "";
            txtQuantity.Text = "";
            txtItemDesc.Text = "";
            txtCost.Text = "";
            txtMeasurement.Text = "";
            datepicker.Value = DateTime.Now;
            txtimagepath.Text = "";
        }

        private void txtUpload_Click(object sender, EventArgs e)
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
        //insert logs//
        public void logs()
        {
            string action = "Added New Raw Item ID:" + txtItemID.Text + " by: " + username.ToString();
            con.Open();
            cmd = new MySqlCommand("Insert into tbllogs (datelog, timelog, full_name, action, module)" +
                "Values('" + date.ToString("yyyy-MM-dd") + "', '" + date.ToString("HH:mm:ss") + "', '" + username.ToString() + "', '" + action.ToString() + "', 'Inventory')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void txtSave_Click(object sender, EventArgs e)
        {
            try
            {
                validateForm();
                if (errorCount == 0)
                {
                    con.Open();
                    cmd = new MySqlCommand("INSERT INTO tblmaterial VALUES ('" + txttransacttion.Text + "', '" + txtItemID.Text + "','" + txtMaterial.Text + "', '" + datepicker.Text + "', '"
                        + txtItemDesc.Text + "', '" + txtcompany.Text + "', '" + txtcontact.Text + "', '" + txtMeasurement.Text + "', '" + txtQuantity.Text + "', '" + txtCost.Text + "','In-Stock', @Image)", con);
                    MemoryStream stream = new MemoryStream();
                    pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] pic = stream.ToArray();
                    cmd.Parameters.AddWithValue("@Image", pic);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    //insert logs//
                    logs();
                    MessageBox.Show("New Material Added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    ViewRawMaterials view = (ViewRawMaterials)Application.OpenForms["ViewRawMaterials"];
                    view.refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on adding raw material", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public Point mouseLocation;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - mouseLocation.X;
                this.Top += e.Y - mouseLocation.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(e.X, e.Y);
        }
    }
}
