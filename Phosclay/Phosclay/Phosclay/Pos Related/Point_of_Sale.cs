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
using System.IO;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace Phosclay
{
    public partial class Point_of_Sale : Form
    {
        double tot, price, price1;
        string filter = "";
        int count;
        int sum = 0;
        string transtype, action;
        string username;
        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;
        MySqlDataAdapter adp;
        DateTime date = DateTime.Now;
        private PictureBox pic;
        private Label pname;
        private Button del;
        Dashboard ds;
        MainConnection data = new MainConnection();
        public Point_of_Sale(Dashboard ds, String username)
        {
            InitializeComponent();
            cn = new MySqlConnection();
            cn.ConnectionString = data.getConnection();
            this.ds = ds;
            this.username = username;
        }

        private void GetData()
        {                
            try
            {
                flowLayoutPanel1.Controls.Clear();
                cn.Open();
                cm = new MySqlCommand("Select Image, description, productid, productname, measurement from tblproduct order by ProductName", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    long len = dr.GetBytes(0, 0, null, 0, 0);
                    byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                    dr.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));
                    pic = new PictureBox();
                    pic.Width = 163;
                    pic.Height = 163;
                    pic.BackgroundImageLayout = ImageLayout.Zoom;
                    pic.Tag = dr["ProductID"].ToString();

                    del = new Button();
                    del.Text = "X";

                    pname = new Label();
                    pname.Text = dr["productname"].ToString() +" ("+ dr["measurement"].ToString() + ")";
                    pname.BackColor = Color.FromArgb(255, 220, 115);
                    pname.TextAlign = ContentAlignment.MiddleCenter;
                    pname.Dock = DockStyle.Bottom;
                    pname.ForeColor = Color.FromArgb(39, 55, 70);

                    MemoryStream ms = new MemoryStream(array);
                    Bitmap bitmap = new Bitmap(ms);
                    pic.BackgroundImage = bitmap;

                    pic.Controls.Add(pname);
                    flowLayoutPanel1.Controls.Add(pic);

                    pic.Click += new EventHandler(onClick);
                }
                dr.Close();
                cn.Close(); 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                          
        }
        public void Search()
        {
            flowLayoutPanel1.Controls.Clear();
            cn.Open();
            cm = new MySqlCommand("Select Image, description, productid, productname from tblproduct where ProductName like  '%" + txtSearch.Text + "%' OR ProductID like '%" + txtSearch.Text + "%' order by ProductName", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                long len = dr.GetBytes(0, 0, null, 0, 0);
                byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                dr.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));
                pic = new PictureBox();
                pic.Width = 163;
                pic.Height = 163;
                pic.BackgroundImageLayout = ImageLayout.Zoom;
                pic.Tag = dr["ProductID"].ToString();

                del = new Button();
                del.Text = "X";

                pname = new Label();
                pname.Text = dr["productname"].ToString();
                pname.BackColor = Color.FromArgb(255, 220, 115);
                pname.TextAlign = ContentAlignment.MiddleCenter;
                pname.Dock = DockStyle.Bottom;
                pname.ForeColor = Color.FromArgb(39, 55, 70);

                MemoryStream ms = new MemoryStream(array);
                Bitmap bitmap = new Bitmap(ms);
                pic.BackgroundImage = bitmap;

                pic.Controls.Add(pname);
                flowLayoutPanel1.Controls.Add(pic);

                pic.Click += new EventHandler(onClick);
            }
            dr.Close();
            cn.Close();
        }

        private void onClick(object sender, EventArgs e)
        {
            if(cmbTranscationType.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select Transaction Type First!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    int input1 = new int();
                    String quantity = Interaction.InputBox("Quantity", "Input Quantity", "", -1, -1);
                    Boolean validInput = new Boolean();
                    validInput = int.TryParse(quantity, out input1);

                    if(string.IsNullOrEmpty(quantity))
                    {

                    }
                    else if(validInput == false)
                    {
                        MessageBox.Show("Please Input Numbers only!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if(Convert.ToInt32(quantity) <= 0)
                    {
                        MessageBox.Show("Selected Item is Out of Stock","Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        String tag = ((PictureBox)sender).Tag.ToString();
                        cn.Open();
                        cm = new MySqlCommand("select * from tblproduct where productid like '" + tag + "'", cn);
                        dr = cm.ExecuteReader();
                        dr.Read();
                        if (dr.HasRows)
                        {
                            int quantity1 = Convert.ToInt32(quantity);
                            int currentQuantity = Convert.ToInt32(dr["Quantity"].ToString());
                            String pid = dr["ProductID"].ToString();

                            if (currentQuantity >= quantity1)
                            {
                                price = quantity1 * double.Parse(dr["Price"].ToString());
                                count += 1;

                                dataGridView1.Rows.Add(dr["ProductID"].ToString(), dr["ProductName"].ToString(), quantity.ToString(), price.ToString());

                                currentQuantity = currentQuantity - quantity1;
                                
                                data.executeSQL("UPDATE tblproduct SET Quantity = '" + currentQuantity + "' WHERE ProductID = '" + pid + "'");
                                currentQuantity = 0;
                                lbltotal.Text = (from DataGridViewRow row in dataGridView1.Rows
                                                 where row.Cells[0].FormattedValue.ToString() != string.Empty
                                                 select Convert.ToInt32(row.Cells[3].FormattedValue)).Sum().ToString();
                                txtTotalCost.Text = lbltotal.Text;
                                //total quantity
                                int[] qty = new int[dataGridView1.Rows.Count];
                                qty = (from DataGridViewRow row in dataGridView1.Rows
                                       where row.Cells[0].FormattedValue.ToString() != string.Empty
                                       select Convert.ToInt32(row.Cells[2].FormattedValue)).ToArray();
                                lblcount.Text = qty.Sum().ToString();
                            }
                            else
                            {
                                MessageBox.Show("The Current Quantity of the Product is Only " + currentQuantity + " \n Please Try Again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        dr.Close();
                        cn.Close();
                        lbltotal.Text = (from DataGridViewRow row in dataGridView1.Rows
                                         where row.Cells[0].FormattedValue.ToString() != string.Empty
                                         select Convert.ToInt32(row.Cells[3].FormattedValue)).Sum().ToString();
                        txtTotalCost.Text = lbltotal.Text;
                    }                        
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error on On-Click",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }                
            }            
        }

        public void cmbCategoryData()
        {
            try
            {
                DataTable dt = new DataTable();
                cn.Open();
                adp = new MySqlDataAdapter("Select Category from tblsettings where form = 'PosCategory'",cn);
                adp.Fill(dt);
                
                foreach (DataRow da in dt.Rows)
                {
                    cmbCategory.Items.Add(da[0].ToString());
                }
                cn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on cmb Category Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Point_of_Sale_Load(object sender, EventArgs e)
        {
            GetData();
            cmbCategoryData();            
            timer1.Start();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            try
            {
                //////////// payment validation
                
                if (Convert.ToDouble(lbltotal.Text) <= 0)
                {
                    MessageBox.Show("No Items has been found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrEmpty(txtdiscount.Text))
                {
                    txtdiscount.Text = "0";
                }
                else
                {
                    ////////////////////////////////////////// - Transaction Type
                    if (cmbTranscationType.SelectedIndex == 0)
                    {
                        transtype = "WI";
                    }
                    else if (cmbTranscationType.SelectedIndex == 1)
                    {
                        transtype = "DEL";
                    }
                    //////////////////////////////////////////////////////////////////
                    cn.Open();
                    cm = new MySqlCommand("select * from tblproduct  ", cn);
                    dr = cm.ExecuteReader();
                    dr.Read();

                    Pos_Checkout pc = new Pos_Checkout(lblcount.Text, txtdiscount.Text, txtTotalCost.Text, transtype, this, cmbTranscationType.Text, username, ds, action) { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };

                    for (int a = 0; a < dataGridView1.Rows.Count; a++)
                    {
                        int n = pc.dgv2.Rows.Add();
                        a = n;
                        pc.dgv2.Rows[n].Cells[0].Value = dataGridView1.Rows[n].Cells[0].Value.ToString();
                        pc.dgv2.Rows[n].Cells[1].Value = dataGridView1.Rows[n].Cells[1].Value.ToString();
                        pc.dgv2.Rows[n].Cells[2].Value = dataGridView1.Rows[n].Cells[2].Value.ToString();
                        pc.dgv2.Rows[n].Cells[3].Value = dataGridView1.Rows[n].Cells[3].Value.ToString();
                    }

                    if(cmbTranscationType.SelectedIndex == 0)
                    {
                        action = "walk-in";
                    }
                    else if(cmbTranscationType.SelectedIndex ==0)
                    {
                        action = "shipping";
                    }
                    ds.pContainer.Controls.Add(pc);
                    pc.BringToFront();
                    pc.Show();
                    cn.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult cancel = MessageBox.Show("Are you sure you want to cancel this current transcation?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cancel == DialogResult.Yes)
            {

                try
                {

                    for(int i = 0; i < dataGridView1.Rows.Count; i ++)
                    {
                        string pid = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        string quantity = dataGridView1.Rows[i].Cells[2].Value.ToString();

                        cn.Open();
                        cm = new MySqlCommand("select * from tblproduct where productid ='" + pid + "'", cn);
                        dr = cm.ExecuteReader();
                        dr.Read();

                        int currentQuantity = Convert.ToInt32(dr["Quantity"].ToString());
                        dr.Close();
                        cn.Close();

                        currentQuantity = currentQuantity + Convert.ToInt32(quantity.ToString());

                        cn.Open();
                        cm = new MySqlCommand("UPDATE tblproduct SET Quantity = '" + currentQuantity + "' WHERE ProductID = '" + pid + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();

                        currentQuantity = 0;

                    }
                    
                    for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
                    {
                        dataGridView1.Rows.RemoveAt(i);
                    }
   
                    lblcount.Text = "0";
                    lbltotal.Text = "0.00";
                    txtTotalCost.Text = "0.00";
                    cmbTranscationType.SelectedIndex = -1;
                    txtdiscount.Text = "0";
                    txtSearch.Clear();
                    dataGridView1.Refresh();
                    cmbCategory.SelectedIndex = -1;

                    ds.btnsalesofreport.Enabled = true;
                    ds.btnadministratormenu.Enabled = true;
                    ds.btnpos.Enabled = true;
                    ds.btninventory.Enabled = true;
                    ds.btndashboard.Enabled = true;
                    this.Close();
                    Overview view = new Overview() { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
                    ds.pContainer.Controls.Add(view);
                    view.BringToFront();
                    view.Show();

                    MessageBox.Show("Transaction is Canceled!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error on button cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {

            }
        }
        
        private void txtdiscount_MouseClick(object sender, MouseEventArgs e)
        {
            txtdiscount.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToString("dddd, MMMM, dd, yyyy");
            lbltime.Text = DateTime.Now.ToString("hh:mm:ss:tt");
        }
        private void txtdiscount_KeyPress(object sender, KeyPressEventArgs e)
        {            
               if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
               {
                    e.Handled = true;
               }

             Regex re = new Regex("^\\d{1,2}([.]\\d{1})$");
            if(char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {
                if (Regex.IsMatch(txtdiscount.Text, "^\\d*\\.\\d{1}$")) e.Handled = true;
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }                            
        }
     
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cmbCategory.SelectedIndex < 1000)
                {
                    filter = "PERFUME";
                    flowLayoutPanel1.Controls.Clear();
                    cn.Open();
                    cm = new MySqlCommand("Select Image, description, productid, productname from tblproduct where category = '"+cmbCategory.Text + "' order by ProductName", cn);
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        long len = dr.GetBytes(0, 0, null, 0, 0);
                        byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                        dr.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));
                        pic = new PictureBox();
                        pic.Width = 163;
                        pic.Height = 163;
                        pic.BackgroundImageLayout = ImageLayout.Zoom;
                        pic.Tag = dr["ProductID"].ToString();

                        del = new Button();
                        del.Text = "X";

                        pname = new Label();
                        pname.Text = dr["productname"].ToString();
                        pname.BackColor = Color.FromArgb(255, 220, 115);
                        pname.TextAlign = ContentAlignment.MiddleCenter;
                        pname.Dock = DockStyle.Bottom;
                        pname.ForeColor = Color.FromArgb(39, 55, 70);

                        MemoryStream ms = new MemoryStream(array);
                        Bitmap bitmap = new Bitmap(ms);
                        pic.BackgroundImage = bitmap;

                        pic.Controls.Add(pname);
                        flowLayoutPanel1.Controls.Add(pic);

                        pic.Click += new EventHandler(onClick);
                    }
                    dr.Close();
                    cn.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Selecting Category", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                string colName = dataGridView1.Columns[e.ColumnIndex].Name;

                if (colName == "Delete")
                {
                    string quantity1 = dataGridView1.Rows[0].Cells[2].Value.ToString();
                    string pid = dataGridView1.Rows[0].Cells[0].Value.ToString();


                    cn.Open();
                    cm = new MySqlCommand("select * from tblproduct where productid ='" + pid + "'", cn);
                    dr = cm.ExecuteReader();
                    dr.Read();

                    int quantity = Convert.ToInt32(quantity1);
                    int currentQuantity = Convert.ToInt32(dr["Quantity"].ToString());
                    dr.Close();

                    int mycell = dataGridView1.CurrentCell.RowIndex;
                    dataGridView1.Rows.RemoveAt(mycell);

                    currentQuantity = currentQuantity + Convert.ToInt32(quantity.ToString());

                    data.executeSQL("UPDATE tblproduct SET Quantity = '" + currentQuantity + "' WHERE ProductID = '" + pid + "'");
                    dataGridView1.Refresh();

                    cn.Close();
                    currentQuantity = 0;
                    quantity = 0;

                    lbltotal.Text = (from DataGridViewRow row in dataGridView1.Rows
                                     where row.Cells[0].FormattedValue.ToString() != string.Empty
                                     select Convert.ToInt32(row.Cells[3].FormattedValue)).Sum().ToString();
                    txtTotalCost.Text = lbltotal.Text;

                    //total quantity
                    int[] qty = new int[dataGridView1.Rows.Count];
                    qty = (from DataGridViewRow row in dataGridView1.Rows
                           where row.Cells[0].FormattedValue.ToString() != string.Empty
                           select Convert.ToInt32(row.Cells[2].FormattedValue)).ToArray();
                    lblcount.Text = qty.Sum().ToString();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void txtConfirm_Click_1(object sender, EventArgs e)
        {
            if (txtdiscount.Text == "0")
            {
                MessageBox.Show("Impossible Action!", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdiscount.Text = "0";
            }
            else if(txtdiscount.Text == ".")
            {
                MessageBox.Show("Impossible Action!", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdiscount.Text = "0";
            }
            else if(string.IsNullOrEmpty(txtdiscount.Text))
            {
                MessageBox.Show("Please Input Discount!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdiscount.Text = "0";
            }
            else
            {
                try
                {

                    double discounted, discounted1;
                    double total = double.Parse(lbltotal.Text);
                    double disc = double.Parse(txtdiscount.Text);
                    discounted = (disc / 100) * total;
                    discounted1 = (disc / 100) * total;
                    discounted = total - discounted;
                    txtTotalCost.Text = discounted.ToString();
                    txtdiscount1.Text = discounted1.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error on text confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
