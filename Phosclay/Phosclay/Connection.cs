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
using System.Configuration;
using System.Xml;

namespace Phosclay
{
    public partial class Connection : Form
    {
        MainConnection data = new MainConnection();
        int errorCount = 0;
        public Connection()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        public void validate()
        {
            try
            {
                errorCount = 0;
                String message = "This field is Required!";
                if(string.IsNullOrEmpty(txtServer.Text))
                {
                    MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    errorCount += 1;
                }
                if (string.IsNullOrEmpty(txtDBName.Text))
                {
                    MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    errorCount += 1;
                }
                if (string.IsNullOrEmpty(txtUsername.Text))
                {
                    MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    errorCount += 1;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDBName.Clear();
            txtPassword.Clear();
            txtServer.Clear();
            txtUsername.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            validate();

            if(errorCount == 0)
            {
                try
                {
                    //connectionString = @"datasource=localhost;username=root;password=;database=ojt;SSL Mode=None";
                    //connectionString = "Server=localhost;Database=ojt;Uid=root;Password=;SSL Mode=None"
                    /*StringBuilder a = new StringBuilder("@");
                    a.Append("datasource=");
                    a.Append(txtServer.Text);
                    a.Append(";username=");
                    a.Append(txtUsername.Text);
                    a.Append(";password=");
                    a.Append(txtPassword.Text);
                    a.Append(";database=");
                    a.Append(txtDBName.Text);
                    a.Append(";SSL Mode=None");
                    */

                    string stringcon = "Server=" + txtServer.Text + ";username=" + txtUsername.Text + ";password=" + txtPassword.Text + ";database=" + txtDBName.Text + ";SSLMode=None";
                    updateConfigFile(stringcon);

                    MySqlConnection db = new MySqlConnection();
                    ConfigurationManager.RefreshSection("connectionStrings");
                    db.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ToString();
                    MessageBox.Show("Connection is Saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void updateConfigFile(string con)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            foreach (XmlElement xElement in xmlDoc.DocumentElement)
            {
                if (xElement.Name == "connectionStrings")
                {
                    xElement.FirstChild.Attributes[2].Value = con;
                }
            }

            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
        }

        private void btnTestCon_Click(object sender, EventArgs e)
        {
           
            string con = data.getConnection();
            bool result = data.checkConnection(con);

            if (result == false)
            {
                MessageBox.Show("Connection is Not yet Established Properly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Connected!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            MessageBox.Show(data.getConnection(), "Connection Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
