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
    public partial class AddSettings : Form
    {
        private string category;
        MySqlConnection cn;
        MySqlCommand cmd;
        MySqlDataAdapter adp;
        MySqlDataReader dr;
        MainConnection data = new MainConnection();
        public AddSettings(string category)
        {
            InitializeComponent();
            cn = new MySqlConnection();
            cn.ConnectionString = data.getConnection();
            this.category = category;
        }

        public void AddCategory()
        {
            try
            {
                if (string.IsNullOrEmpty(txtCategory.Text))
                {
                    MessageBox.Show("Please Input Value into the Field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cn.Open();
                    cmd = new MySqlCommand("INSERT INTO tblsettings (Form, Category) VALUES ('" + category + "', '" + txtCategory.Text + "')", cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("Category Added Succesffuly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                    Settings stg = (Settings)Application.OpenForms["Settings"];
                    stg.viewData();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCategory();
        }
    }
}
