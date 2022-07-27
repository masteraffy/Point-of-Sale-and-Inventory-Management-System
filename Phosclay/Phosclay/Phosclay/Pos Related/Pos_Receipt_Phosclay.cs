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

namespace Phosclay
{
    public partial class Pos_Receipt_Phosclay : Form
    {
        private string title, customername, address, contactnumber, date, change, no;
        Pos_Checkout pc;
        string username;
        Dashboard ds;
        public Pos_Receipt_Phosclay(string title, string customername, string address, string contactnumber, string date, Pos_Checkout pc, string change, string no, string username, Dashboard ds)
        {
            InitializeComponent();
            this.title = title;
            this.customername = customername;
            this.address = address;
            this.contactnumber = contactnumber;
            this.date = date;
            this.pc = pc;
            this.change = change;
            this.ds = ds;
            this.no = no;
            getData();
        }
        public void getData()
        {
            labelTitle.Text = title.ToString();
            lblname.Text = customername;
            lbladdress.Text = address;
            lblcontactno.Text = contactnumber;
            lbldatetime.Text = date;
            lblChange.Text = change;
            lblno.Text = no;
        }
        private void btnokay_Click(object sender, EventArgs e)
        {
            Point_of_Sale pos = new Point_of_Sale(ds, username) { TopLevel = false, TopMost = true, Dock = DockStyle.Fill };
            ds.pContainer.Controls.Add(pos);
            pos.BringToFront();
            pos.Show();
            this.Close();
           
        }
        private void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panelPrint = pnl;
            getprintarea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 730, 670);
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

        private void btnprint_Click_1(object sender, EventArgs e)
        {
            Print(this.panelPrint);
        }
        public void compute()
        {
            dgv4.Refresh();
            for (int i = 0; i < dgv4.Rows.Count; i++)
            {

                lbltotal1.Text = (from DataGridViewRow row in dgv4.Rows
                                  where row.Cells[0].FormattedValue.ToString() != string.Empty
                                  select Convert.ToInt32(row.Cells[3].FormattedValue)).Sum().ToString("#,##0.00");
            }


        }
        private void Pos_Receipt_Phosclay_Load(object sender, EventArgs e)
        {
            compute();
        }
        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
