
namespace Phosclay.Inventory_Related
{
    partial class ViewProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProducts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dateFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnsearch = new Guna.UI2.WinForms.Guna2Button();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearchID = new Guna.UI2.WinForms.Guna2TextBox();
            this.pn1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.lbl3 = new Guna.UI.WinForms.GunaLabel();
            this.lbl1 = new Guna.UI.WinForms.GunaLabel();
            this.cmbsearch = new Guna.UI.WinForms.GunaComboBox();
            this.txtsearchName = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltime = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnrefresh = new Guna.UI2.WinForms.Guna2Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pn1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dateTo
            // 
            this.dateTo.BorderRadius = 5;
            this.dateTo.CheckedState.Parent = this.dateTo;
            this.dateTo.FillColor = System.Drawing.Color.White;
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTo.HoverState.Parent = this.dateTo;
            this.dateTo.Location = new System.Drawing.Point(319, 116);
            this.dateTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTo.Name = "dateTo";
            this.dateTo.ShadowDecoration.Parent = this.dateTo;
            this.dateTo.Size = new System.Drawing.Size(200, 36);
            this.dateTo.TabIndex = 4;
            this.dateTo.Value = new System.DateTime(2021, 8, 21, 9, 40, 59, 769);
            // 
            // dateFrom
            // 
            this.dateFrom.BorderRadius = 5;
            this.dateFrom.CheckedState.Parent = this.dateFrom;
            this.dateFrom.FillColor = System.Drawing.Color.White;
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateFrom.HoverState.Parent = this.dateFrom;
            this.dateFrom.Location = new System.Drawing.Point(68, 116);
            this.dateFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.ShadowDecoration.Parent = this.dateFrom;
            this.dateFrom.Size = new System.Drawing.Size(200, 36);
            this.dateFrom.TabIndex = 2;
            this.dateFrom.Value = new System.DateTime(2021, 8, 21, 9, 40, 59, 769);
            // 
            // btnsearch
            // 
            this.btnsearch.BorderRadius = 5;
            this.btnsearch.CheckedState.Parent = this.btnsearch;
            this.btnsearch.CustomImages.Parent = this.btnsearch;
            this.btnsearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btnsearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.Black;
            this.btnsearch.HoverState.Parent = this.btnsearch;
            this.btnsearch.Image = ((System.Drawing.Image)(resources.GetObject("btnsearch.Image")));
            this.btnsearch.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnsearch.ImageSize = new System.Drawing.Size(30, 30);
            this.btnsearch.Location = new System.Drawing.Point(634, 113);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.ShadowDecoration.Parent = this.btnsearch;
            this.btnsearch.Size = new System.Drawing.Size(152, 38);
            this.btnsearch.TabIndex = 6;
            this.btnsearch.Text = "Search";
            this.btnsearch.TextOffset = new System.Drawing.Point(4, 0);
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.ForeColor = System.Drawing.Color.Gray;
            this.lbl4.Location = new System.Drawing.Point(285, 124);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(28, 18);
            this.lbl4.TabIndex = 76;
            this.lbl4.Text = "To:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.Gray;
            this.lbl2.Location = new System.Drawing.Point(13, 124);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(49, 18);
            this.lbl2.TabIndex = 75;
            this.lbl2.Text = "From:";
            // 
            // btnPrint
            // 
            this.btnPrint.BorderRadius = 5;
            this.btnPrint.CheckedState.Parent = this.btnPrint;
            this.btnPrint.CustomImages.Parent = this.btnPrint;
            this.btnPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btnPrint.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.HoverState.Parent = this.btnPrint;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnPrint.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPrint.Location = new System.Drawing.Point(792, 113);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ShadowDecoration.Parent = this.btnPrint;
            this.btnPrint.Size = new System.Drawing.Size(152, 38);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextOffset = new System.Drawing.Point(4, 0);
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtSearchID
            // 
            this.txtSearchID.BorderRadius = 5;
            this.txtSearchID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchID.DefaultText = "";
            this.txtSearchID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchID.DisabledState.Parent = this.txtSearchID;
            this.txtSearchID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchID.FocusedState.Parent = this.txtSearchID;
            this.txtSearchID.Font = new System.Drawing.Font("Arial", 12.25F);
            this.txtSearchID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchID.HoverState.Parent = this.txtSearchID;
            this.txtSearchID.Location = new System.Drawing.Point(68, 78);
            this.txtSearchID.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.PasswordChar = '\0';
            this.txtSearchID.PlaceholderText = "Search for Product ID.....";
            this.txtSearchID.SelectedText = "";
            this.txtSearchID.ShadowDecoration.Parent = this.txtSearchID;
            this.txtSearchID.Size = new System.Drawing.Size(200, 30);
            this.txtSearchID.TabIndex = 1;
            this.txtSearchID.TextChanged += new System.EventHandler(this.txtSearchID_TextChanged);
            // 
            // pn1
            // 
            this.pn1.BackColor = System.Drawing.Color.Gainsboro;
            this.pn1.Controls.Add(this.btnUpdate);
            this.pn1.Controls.Add(this.btnDelete);
            this.pn1.Controls.Add(this.btnAdd);
            this.pn1.Location = new System.Drawing.Point(13, 551);
            this.pn1.Name = "pn1";
            this.pn1.ShadowDecoration.Parent = this.pn1;
            this.pn1.Size = new System.Drawing.Size(931, 63);
            this.pn1.TabIndex = 72;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 5;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnUpdate.Location = new System.Drawing.Point(341, 13);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(246, 38);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update Product";
            this.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdate.TextOffset = new System.Drawing.Point(4, 0);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 5;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btnDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDelete.Location = new System.Drawing.Point(654, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(246, 38);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete Product";
            this.btnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDelete.TextOffset = new System.Drawing.Point(4, 0);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAdd.Location = new System.Drawing.Point(20, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(246, 38);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Product";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdd.TextOffset = new System.Drawing.Point(4, 0);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduct.ColumnHeadersHeight = 35;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column9,
            this.Column6,
            this.Column4,
            this.Column7,
            this.Column3,
            this.Column8});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProduct.Location = new System.Drawing.Point(10, 158);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProduct.RowTemplate.Height = 55;
            this.dgvProduct.RowTemplate.ReadOnly = true;
            this.dgvProduct.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(934, 387);
            this.dgvProduct.TabIndex = 82;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl3.ForeColor = System.Drawing.Color.Gray;
            this.lbl3.Location = new System.Drawing.Point(283, 81);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(30, 21);
            this.lbl3.TabIndex = 88;
            this.lbl3.Text = "By:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl1.ForeColor = System.Drawing.Color.Gray;
            this.lbl1.Location = new System.Drawing.Point(13, 81);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(51, 21);
            this.lbl1.TabIndex = 89;
            this.lbl1.Text = "Value:";
            // 
            // cmbsearch
            // 
            this.cmbsearch.BackColor = System.Drawing.Color.Transparent;
            this.cmbsearch.BaseColor = System.Drawing.Color.White;
            this.cmbsearch.BorderColor = System.Drawing.Color.Silver;
            this.cmbsearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbsearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsearch.FocusedColor = System.Drawing.Color.Empty;
            this.cmbsearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbsearch.ForeColor = System.Drawing.Color.Black;
            this.cmbsearch.FormattingEnabled = true;
            this.cmbsearch.Items.AddRange(new object[] {
            "Product ID",
            "Product Name"});
            this.cmbsearch.Location = new System.Drawing.Point(319, 78);
            this.cmbsearch.Name = "cmbsearch";
            this.cmbsearch.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbsearch.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbsearch.Radius = 5;
            this.cmbsearch.Size = new System.Drawing.Size(200, 30);
            this.cmbsearch.TabIndex = 3;
            this.cmbsearch.SelectedIndexChanged += new System.EventHandler(this.cmbsearch_SelectedIndexChanged);
            // 
            // txtsearchName
            // 
            this.txtsearchName.BorderRadius = 5;
            this.txtsearchName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsearchName.DefaultText = "";
            this.txtsearchName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsearchName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsearchName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearchName.DisabledState.Parent = this.txtsearchName;
            this.txtsearchName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearchName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearchName.FocusedState.Parent = this.txtsearchName;
            this.txtsearchName.Font = new System.Drawing.Font("Arial", 12.25F);
            this.txtsearchName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearchName.HoverState.Parent = this.txtsearchName;
            this.txtsearchName.Location = new System.Drawing.Point(68, 78);
            this.txtsearchName.Margin = new System.Windows.Forms.Padding(5);
            this.txtsearchName.Name = "txtsearchName";
            this.txtsearchName.PasswordChar = '\0';
            this.txtsearchName.PlaceholderText = "Search Product Name";
            this.txtsearchName.SelectedText = "";
            this.txtsearchName.ShadowDecoration.Parent = this.txtsearchName;
            this.txtsearchName.Size = new System.Drawing.Size(200, 30);
            this.txtsearchName.TabIndex = 91;
            this.txtsearchName.TextChanged += new System.EventHandler(this.txtsearchName_TextChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel6.Location = new System.Drawing.Point(0, 629);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(959, 3);
            this.panel6.TabIndex = 87;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(14, 7);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(24, 26);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 7;
            this.guna2PictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lbltime);
            this.panel1.Controls.Add(this.lbldate);
            this.panel1.Controls.Add(this.guna2PictureBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 48);
            this.panel1.TabIndex = 10;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // lbltime
            // 
            this.lbltime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.Black;
            this.lbltime.Location = new System.Drawing.Point(742, 29);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(76, 18);
            this.lbltime.TabIndex = 16;
            this.lbltime.Text = "10:00 PM";
            // 
            // lbldate
            // 
            this.lbldate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.Black;
            this.lbldate.Location = new System.Drawing.Point(742, 7);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(165, 18);
            this.lbldate.TabIndex = 15;
            this.lbldate.Text = "Tuesday, July 13, 2021";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.Location = new System.Drawing.Point(704, 11);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(32, 32);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 14;
            this.guna2PictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label5.Location = new System.Drawing.Point(44, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Inventory Management";
            // 
            // btnrefresh
            // 
            this.btnrefresh.BorderRadius = 3;
            this.btnrefresh.CheckedState.Parent = this.btnrefresh;
            this.btnrefresh.CustomImages.Parent = this.btnrefresh;
            this.btnrefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btnrefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnrefresh.ForeColor = System.Drawing.Color.White;
            this.btnrefresh.HoverState.Parent = this.btnrefresh;
            this.btnrefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnrefresh.Image")));
            this.btnrefresh.ImageSize = new System.Drawing.Size(30, 30);
            this.btnrefresh.Location = new System.Drawing.Point(575, 114);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.ShadowDecoration.Parent = this.btnrefresh;
            this.btnrefresh.Size = new System.Drawing.Size(53, 38);
            this.btnrefresh.TabIndex = 92;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "ProductID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "ProductID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column1.Width = 93;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.DataPropertyName = "ProductName";
            this.Column2.HeaderText = "ProductName";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column2.Width = 115;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.DataPropertyName = "Measurement";
            this.Column5.HeaderText = "Unit";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column5.Width = 57;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column9.DataPropertyName = "Price";
            this.Column9.HeaderText = "Price";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column9.Width = 61;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.DataPropertyName = "Date";
            this.Column6.HeaderText = "Date";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column6.Width = 60;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Description";
            this.Column4.HeaderText = "Description";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.DataPropertyName = "Quantity";
            this.Column7.HeaderText = "Qty";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column7.Width = 53;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.DataPropertyName = "Status";
            this.Column3.HeaderText = "Status";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 69;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.DataPropertyName = "Image";
            this.Column8.HeaderText = "Image";
            this.Column8.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column8.Width = 69;
            // 
            // ViewProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 632);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbsearch);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtSearchID);
            this.Controls.Add(this.pn1);
            this.Controls.Add(this.txtsearchName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewProducts";
            this.Load += new System.EventHandler(this.ViewProducts_Load);
            this.Resize += new System.EventHandler(this.ViewProducts_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pn1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTo;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateFrom;
        private Guna.UI2.WinForms.Guna2Button btnsearch;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl2;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchID;
        private Guna.UI2.WinForms.Guna2Panel pn1;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.DataGridView dgvProduct;
        private Guna.UI.WinForms.GunaLabel lbl3;
        private Guna.UI.WinForms.GunaComboBox cmbsearch;
        private Guna.UI.WinForms.GunaLabel lbl1;
        private Guna.UI2.WinForms.Guna2TextBox txtsearchName;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnrefresh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lbldate;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Column8;
    }
}