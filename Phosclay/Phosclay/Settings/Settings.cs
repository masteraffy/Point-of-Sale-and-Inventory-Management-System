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

namespace Phosclay
{
    public partial class Settings : Form
    {
        private Size formOriginalSize;
        //panel
        private Rectangle pN1;
        private Rectangle pN2;
        private Rectangle pN3;
        private Rectangle pN4;
        private Rectangle pN5;
        private Rectangle pN6;
        private Rectangle pN7;
        private Rectangle pN8;
        private Rectangle pN9;
        private Rectangle pN10;
        private Rectangle pNPOS;
        private Rectangle pNPOSShipping;
        private Rectangle pNPOSCheckout;
        private Rectangle pNInventory;

        //label
        private Rectangle Label1;
        private Rectangle Label2;
        private Rectangle Label3;
        private Rectangle Label4;
        private Rectangle Label5;
        private Rectangle Label6;

        //combobox
        private Rectangle comboboxCategory;

        //datagrid
        private Rectangle datagrid1;
        private Rectangle datagrid2;
        private Rectangle datagrid3;
        private Rectangle datagrid4;

        //button
        private Rectangle btn1;
        private Rectangle btn2;
        private Rectangle btn3;
        private Rectangle btn4;
        private Rectangle btn5;
        private Rectangle btn6;
        private Rectangle btn7;
        private Rectangle btn8;
        private Rectangle btn9;
        private Rectangle btn10;
        private Rectangle btn11;
        private Rectangle btn12;

        public void autosize()
        {
            formOriginalSize = this.Size;
            //panel//
            pN1 = new Rectangle(Pn1.Location.X, Pn1.Location.Y, Pn1.Width, Pn1.Height);
            pN2 = new Rectangle(Pn2.Location.X, Pn2.Location.Y, Pn2.Width, Pn2.Height);
           
            pN7 = new Rectangle(PN7.Location.X, PN7.Location.Y, PN7.Width, PN7.Height);
            pN8 = new Rectangle(PN8.Location.X, PN8.Location.Y, PN8.Width, PN8.Height);
          

            //label//
            Label1 = new Rectangle(lbl1.Location.X, lbl1.Location.Y, lbl1.Width, lbl1.Height);
            Label2 = new Rectangle(lbl2.Location.X, lbl2.Location.Y, lbl2.Width, lbl2.Height);
            Label5 = new Rectangle(labelName.Location.X, labelName.Location.Y, labelName.Width, labelName.Height);


            //combobox//
            comboboxCategory = new Rectangle(cmbCategory.Location.X, cmbCategory.Location.Y, cmbCategory.Width, cmbCategory.Height);

            //datagrid//

            datagrid3 = new Rectangle(datagridview1.Location.X, datagridview1.Location.Y, datagridview1.Width, datagridview1.Height);


            //button//

            btn7 = new Rectangle(addCategory.Location.X, addCategory.Location.Y, addCategory.Width, addCategory.Height);
            btn8 = new Rectangle(deleteCategory.Location.X, deleteCategory.Location.Y, deleteCategory.Width, deleteCategory.Height);
            btn1 = new Rectangle(btnrefresh.Location.X, btnrefresh.Location.Y, btnrefresh.Width, btnrefresh.Height);
        }

        private void resizeChildrenControl()
        {
            //panel//
            resizeControl(pN1, Pn1);
            resizeControl(pN2, Pn2);

            resizeControl(pN7, PN7);
            resizeControl(pN8, PN8);

            //label//
            resizeControl(Label1, lbl1);
            resizeControl(Label2, lbl2);

            resizeControl(Label5, labelName);

            //combobox//
            resizeControl(comboboxCategory, cmbCategory);

            //datagrid//

            resizeControl(datagrid3, datagridview1);

            //button//

            resizeControl(btn7, addCategory);
            resizeControl(btn8, deleteCategory);
            resizeControl(btn1, btnrefresh);
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

        MainConnection data = new MainConnection();
        MySqlConnection cn;
        MySqlCommand cmd;
        MySqlDataAdapter adp;
        string action, category, form;
        string action1;
        DataTable dt;
        public Settings()
        {
            InitializeComponent();
            cn = new MySqlConnection();
            cn.ConnectionString = data.getConnection();
            
        }
        
        public void viewData()
        {

            try
            {
                if (action1 == "inventory")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        cn.Open();
                        adp = new MySqlDataAdapter("select * from tblsettings where form = 'InventoryCategory'", cn);
                        adp.Fill(dt);
                        datagridview1.DataSource = dt;
                        labelName.Text = "Inventory Category";
                        cn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                if(action1 == "poscategory")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        cn.Open();
                        adp = new MySqlDataAdapter("select * from tblsettings where form = 'POSCategory'", cn);
                        adp.Fill(dt);
                        datagridview1.DataSource = dt;
                        labelName.Text = "POS Category";
                        cn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                if(action1 == "InventoryUnit")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        cn.Open();
                        adp = new MySqlDataAdapter("select * from tblsettings where form = 'InventoryUnit'", cn);
                        adp.Fill(dt);
                        datagridview1.DataSource = dt;
                        labelName.Text = "InventoryUnit";
                        cn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                if(action1 == "posshipping")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        cn.Open();
                        adp = new MySqlDataAdapter("select * from tblsettings where form = 'PosShippingCategory'", cn);
                        adp.Fill(dt);
                        datagridview1.DataSource = dt;
                        labelName.Text = "POS Shipping Category";
                        cn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void datagridview1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                form = datagridview1.Rows[e.RowIndex].Cells[0].Value.ToString();
                category = datagridview1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            try
            {
                if (cmbCategory.SelectedIndex == 0)
                {
                    action1 = "inventory";
                    viewData();
                }
                else if (cmbCategory.SelectedIndex == 1)
                {
                    action1 = "poscategory";
                    viewData();
                }
                else if (cmbCategory.SelectedIndex == 2)
                {
                    action1 = "InventoryUnit";
                    viewData();
                }
                else if (cmbCategory.SelectedIndex == 3)
                {
                    action1 = "posshipping";
                    viewData();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on cmb Category Selection (Settings)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
       
        private void Settings_Load(object sender, EventArgs e)
        {
            autosize();
            cmbCategory.SelectedIndex = 0;
        }
        private void addCategory_Click(object sender, EventArgs e)
        {
            if(action1 == "inventory")
            {
                AddSettings add = new AddSettings("InventoryCategory");
                add.ShowDialog();
            }

            if (action1 == "poscategory")
            {
                AddSettings add = new AddSettings("POSCategory");
                add.ShowDialog();
            }
            if (action1 == "InventoryUnit")
            {
                AddSettings add = new AddSettings("InventoryUnit");
                add.ShowDialog();
            }
            if (action1 == "posshipping")
            {
                AddSettings add = new AddSettings("PosShippingCategory");
                add.ShowDialog();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void deleteCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (category == null && form == null)
                {
                    MessageBox.Show("Please Select Item to Delete!", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cn.Open();
                    cmd = new MySqlCommand("delete from tblsettings where Category ='" + category + "' AND Form ='" + form + "'", cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("Category Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Settings stg = (Settings)Application.OpenForms["Settings"];
                    stg.viewData();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnrefresh_Click(object sender, EventArgs e)
        {
            try
            {
                viewData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on button refresh", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Settings_Resize(object sender, EventArgs e)
        {
            resizeChildrenControl();
        }
        private void btnShippingCategory_Click(object sender, EventArgs e)
        {
            if(action == "PosShippingCategory")
            {
                AddSettings Ads = new AddSettings("PosShippingCategory");
                Ads.Show();
            }
        }

     
    }
}
