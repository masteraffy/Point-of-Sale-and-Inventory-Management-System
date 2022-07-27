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
    public partial class UpdateRawMaterials : Form
    {
        MainConnection data = new MainConnection();
        MySqlConnection con;
        MySqlCommand cmd;
        ViewRawMaterials v;

        string username;

        DateTime date = DateTime.Now;

        public UpdateRawMaterials(ViewRawMaterials v, string username)
        {
            InitializeComponent();
            con = new MySqlConnection();
            con.ConnectionString = data.getConnection();
            this.v = v;
            this.username = username;
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
            string action = "Deleted a Raw Item ID:" + txtItemID.Text + " by: " + username.ToString();
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
                    cmd = new MySqlCommand("UPDATE tblmaterial SET TransactionReceipt = '" + txttransacttion.Text + "', Material_Name = '" + txtMaterials.Text + "', Date= '" + DateTimePicker1.Text + 
                        "', Description= '" + txtDescription.Text + "',CompanyName = '" + txtcompany.Text + "', Contact = '" + txtcontact.Text + "', Measurement = '" + txtMeasurement.Text + 
                        "', Quantity ='" + txtQuantity.Text + "', Amount = '" + txtCost.Text + "', Status= 'Out-Stock', Image = @Image WHERE Material_ID = '" + txtItemID.Text + "'", con);
                    MemoryStream stream = new MemoryStream();
                    pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] pic = stream.ToArray();
                    cmd.Parameters.AddWithValue("@Image", pic);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    //insert logs//
                    logs();
                    MessageBox.Show("Raw material updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    ViewRawMaterials view = (ViewRawMaterials)Application.OpenForms["ViewRawMaterials"];
                    view.refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error on saving material", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new MySqlCommand("UPDATE tblmaterial SET Material_Name = '" + txtMaterials.Text + "', Expiration= '" + DateTimePicker1.Text + "', Description= '" + txtDescription.Text + "'," +
                    "Quantity ='" + txtQuantity.Text + "',Status= 'In-Stock', Image = @Image WHERE Material_ID = '" + txtItemID.Text + "'", con);
                    MemoryStream stream = new MemoryStream();
                    pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] pic = stream.ToArray();
                    cmd.Parameters.AddWithValue("@Image", pic);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    //insert logs//
                    logs();
                    MessageBox.Show("Raw material updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    ViewRawMaterials view = (ViewRawMaterials)Application.OpenForms["ViewRawMaterials"];
                    view.refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error on saving material", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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
