using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Phosclay
{
    public partial class Pos_Receipt_Fragranza : Form
    {
        private string title, customername, companyname, address, city, contactnumber, shipping, paymentmethod, shippingdate, date, transnumber, change;
        MainConnection data = new MainConnection();
        Dashboard ds;
        string username;
        public Pos_Receipt_Fragranza(string title, string customername, string companyname, string address, string city, string contactnumber, string shipping, string paymentmethod, string shippingdate, Pos_Checkout pc, string date, string transnumber, string change, Point_of_Sale ps, string username, Dashboard ds)
        {
            InitializeComponent();
            this.title = title;
            this.customername = customername;
            this.companyname = companyname;
            this.address = address;
            this.city = city;
            this.contactnumber = contactnumber;
            this.shipping = shipping;
            this.paymentmethod = paymentmethod;
            this.shippingdate = shippingdate;
            this.pc = pc;
            this.date = date;
            this.transnumber = transnumber;
            this.change = change;
            this.ps = ps;
            this.username = username;
            this.ds = ds;
            getData();
        }
        public void getData()
        {
            labelTitle.Text = title.ToString();
            lblCustomerName.Text = customername;
            lblCompanyName.Text = companyname;
            lblAddress.Text = address;
            lblCity.Text = city;
            lblContactNumber.Text = contactnumber;
            lblShippingMethod.Text = shipping;
            lblPaymentMethod.Text = paymentmethod;
            lblShippingDate.Text = shippingdate.ToString();
            lbldate.Text = date;
            lblChange.Text = change;
            lblno.Text = transnumber;
        }
        private void btnprint_Click(object sender, EventArgs e)
        {
            Print(this.panelPrint);
        }
        private void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panelPrint = pnl;
            getprintarea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 730, 630);
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }
        private Bitmap memorying;

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memorying, (pagearea.Width / 2) - (this.panelPrint.Width / 2), this.panelPrint.Location.Y);
        }

        private void getprintarea(Panel pnl)
        {
            memorying = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memorying, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }
        private void btnok_Click(object sender, EventArgs e)
        {
            Point_of_Sale pos = new Point_of_Sale(ds, username) { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
            ds.pContainer.Controls.Add(pos);
            pos.BringToFront();
            pos.Show();
            this.Close();
        }
        Pos_Checkout pc;
        Point_of_Sale ps;
        public void compute()
        {
            dgv3.Refresh();
            for(int i = 0; i < dgv3.Rows.Count; i ++)
            {
                
                lbltotal1.Text = (from DataGridViewRow row in dgv3.Rows
                                  where row.Cells[0].FormattedValue.ToString() != string.Empty
                                  select Convert.ToInt32(row.Cells[3].FormattedValue)).Sum().ToString("#,##0.00");
            }        
        }
        private void Pos_Receipt_Fragranza_Load(object sender, EventArgs e)
        {
            compute();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
