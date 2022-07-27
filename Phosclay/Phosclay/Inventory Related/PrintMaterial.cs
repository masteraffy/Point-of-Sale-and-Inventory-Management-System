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
using DGVPrinterHelper;
namespace Phosclay.Inventory_Related
{
    public partial class PrintMaterial : Form
    {
        MainConnection data = new MainConnection();
        MySqlConnection con;
        MySqlDataAdapter adpt;
        DataTable dt;
        public PrintMaterial()
        {
            InitializeComponent();
            con = new MySqlConnection();
            con.ConnectionString = data.getConnection();
            dateFrom.Value = DateTime.Now;
            dateTo.Value = DateTime.Now;
        }

        private void PrintMaterial_Load(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                adpt = new MySqlDataAdapter("SELECT TransactionReceipt, Material_ID, Material_Name, Date, Description, CompanyName, Contact, Measurement, Quantity, Amount, Status FROM tblmaterial ORDER BY Material_ID", con);
                adpt.Fill(dt);
                dgvRawMaterial.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on loading datagridview", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                adpt = new MySqlDataAdapter("SELECT TransactionReceipt, Material_ID, Material_Name, Date, Description, CompanyName, Contact, Measurement, Quantity, Amount, Status FROM tblmaterial WHERE Date BETWEEN '" + dateFrom.Value.ToString("yyyy-MM-dd") + "' AND '" +
                    dateTo.Value.ToString("yyyy-MM-dd") + "'", con);
                dt = new DataTable();
                adpt.Fill(dt);
                dgvRawMaterial.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on searching date", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Phosclay";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.ToString("MM/dd/yyyy"));
            printer.SubTitleAlignment = StringAlignment.Center;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = false;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Center;
            printer.Footer = "Raw Material Management";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintPreviewDataGridView(dgvRawMaterial);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
