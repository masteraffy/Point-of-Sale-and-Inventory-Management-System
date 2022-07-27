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
namespace Phosclay.Administration_Related
{
    public partial class SystemLogs : Form
    {
        private Size formOriginalSize;

        //label
        private Rectangle Label1;
        private Rectangle Label2;
        private Rectangle Label3;
        private Rectangle Label4;

        //panel
        private Rectangle pN1;
        private Rectangle pN2;
        private Rectangle pN3;

        //textbox, combobox, datetimepicker
        private Rectangle textboxsearch;
        private Rectangle comboboxLogsFilter;
        private Rectangle dt1;
        private Rectangle dt2;

        //button
        private Rectangle btn1;

        //datagrid
        private Rectangle datagrid;

        public void autosize()
        {
            formOriginalSize = this.Size;
            //panel//
            pN1 = new Rectangle(pn1.Location.X, pn1.Location.Y, pn1.Width, pn1.Height);
            pN2 = new Rectangle(pn2.Location.X, pn2.Location.Y, pn2.Width, pn2.Height);
            pN3 = new Rectangle(pn3.Location.X, pn3.Location.Y, pn3.Width, pn3.Height);

            //label//
            Label1 = new Rectangle(lbl1.Location.X, lbl1.Location.Y, lbl1.Width, lbl1.Height);
            Label2 = new Rectangle(lbl2.Location.X, lbl2.Location.Y, lbl2.Width, lbl2.Height);
            Label3 = new Rectangle(lbl3.Location.X, lbl3.Location.Y, lbl3.Width, lbl3.Height);
            Label4 = new Rectangle(lbl4.Location.X, lbl4.Location.Y, lbl4.Width, lbl4.Height);

            //textbox, combobox, datetimepicker//
            textboxsearch = new Rectangle(txtSearch.Location.X, txtSearch.Location.Y, txtSearch.Width, txtSearch.Height);
            comboboxLogsFilter = new Rectangle(cmbLogsFilter.Location.X, cmbLogsFilter.Location.Y, cmbLogsFilter.Width, cmbLogsFilter.Height);
            dt1 = new Rectangle(dtpFrom.Location.X, dtpFrom.Location.Y, dtpFrom.Width, dtpFrom.Height);
            dt2 = new Rectangle(dtpTo.Location.X, dtpTo.Location.Y, dtpTo.Width, dtpTo.Height);

            //button//
            btn1 = new Rectangle(btnView.Location.X, btnView.Location.Y, btnView.Width, btnView.Height);

            //datagrid//
            datagrid = new Rectangle(dgvLogs.Location.X, dgvLogs.Location.Y, dgvLogs.Width, dgvLogs.Height);
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

        private void resizeChildrenControl()
        {
            
            //panel//
            resizeControl(pN1, pn1);
            resizeControl(pN2, pn2);
            resizeControl(pN3, pn3);
            
            //label//
            resizeControl(Label1, lbl1);
            resizeControl(Label2, lbl2);
            resizeControl(Label3, lbl3);
            resizeControl(Label4, lbl4);

            //button//
            resizeControl(btn1, btnView);

            //datagrid//
            resizeControl(datagrid, dgvLogs);

            //textbox, combobox, datetimepicker//
            resizeControl(textboxsearch, txtSearch);
            resizeControl(comboboxLogsFilter, cmbLogsFilter);
            resizeControl(dt1, dtpFrom);
            resizeControl(dt2, dtpTo);
            
        }

        MainConnection data = new MainConnection();
        MySqlConnection con;
        MySqlDataAdapter adpt;
        DataTable dt;
        public SystemLogs()
        {
            InitializeComponent();
            con = new MySqlConnection();
            con.ConnectionString = data.getConnection();
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                adpt = new MySqlDataAdapter("SELECT * FROM tbllogs where datelog BETWEEN '" + dtpFrom.Value.ToString("yyyy-MM-dd") + "' AND '" + 
                    dtpTo.Value.ToString("yyyy-MM-dd") + "'", con);
                adpt.Fill(dt);
                dgvLogs.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error button View", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cmbLogsFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                adpt = new MySqlDataAdapter("SELECT * FROM tbllogs where datelog BETWEEN '" + dtpFrom.Value.ToString("yyyy-MM-dd") + "' AND '" + 
                    dtpTo.Value.ToString("yyyy-MM-dd") + "' AND  Module ='" + cmbLogsFilter.SelectedItem + "'", con);
                adpt.Fill(dt);
                dgvLogs.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error cmbLogs Filter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void loadLogs()
        {
            try
            {
                con.Open();
                dt = new DataTable();
                adpt = new MySqlDataAdapter("select * from tbllogs ORDER BY datelog DESC", con);
                adpt.Fill(dt);
                dgvLogs.DataSource = dt;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on loading Logs (System Logs Form)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                dt = new DataTable();
                adpt = new MySqlDataAdapter("SELECT * FROM tbllogs WHERE full_name LIKE '%" + txtSearch.Text + "%'",con);
                adpt.Fill(dt);
                dgvLogs.DataSource = dt;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on Text search", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }
        private void SystemLogs_Load(object sender, EventArgs e)
        {
            loadLogs();
            autosize();
        }
        private void SystemLogs_Resize(object sender, EventArgs e)
        {
           resizeChildrenControl();
        }
    }
}
