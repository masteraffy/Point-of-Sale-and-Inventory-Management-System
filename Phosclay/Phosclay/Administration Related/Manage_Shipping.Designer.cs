namespace Phosclay
{
    partial class Manage_Shipping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Shipping));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCheckDate = new Guna.UI2.WinForms.Guna2Button();
            this.dateFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dateTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbl5 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnok = new Guna.UI2.WinForms.Guna2Button();
            this.btnprint = new Guna.UI2.WinForms.Guna2Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lbltime = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalShipping = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPending = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCanceled = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCompleted = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.cmbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnrefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnexcel = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheckDate
            // 
            this.btnCheckDate.CheckedState.Parent = this.btnCheckDate;
            this.btnCheckDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckDate.CustomImages.Parent = this.btnCheckDate;
            this.btnCheckDate.FillColor = System.Drawing.Color.Transparent;
            this.btnCheckDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCheckDate.ForeColor = System.Drawing.Color.White;
            this.btnCheckDate.HoverState.Parent = this.btnCheckDate;
            this.btnCheckDate.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckDate.Image")));
            this.btnCheckDate.ImageSize = new System.Drawing.Size(35, 35);
            this.btnCheckDate.Location = new System.Drawing.Point(1079, 77);
            this.btnCheckDate.Name = "btnCheckDate";
            this.btnCheckDate.ShadowDecoration.Parent = this.btnCheckDate;
            this.btnCheckDate.Size = new System.Drawing.Size(50, 36);
            this.btnCheckDate.TabIndex = 63;
            this.btnCheckDate.Click += new System.EventHandler(this.btnCheckDate_Click);
            // 
            // dateFrom
            // 
            this.dateFrom.CheckedState.Parent = this.dateFrom;
            this.dateFrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateFrom.CustomFormat = "MMM. dd, yyyy";
            this.dateFrom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.dateFrom.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFrom.HoverState.Parent = this.dateFrom;
            this.dateFrom.Location = new System.Drawing.Point(711, 77);
            this.dateFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.ShadowDecoration.Parent = this.dateFrom;
            this.dateFrom.Size = new System.Drawing.Size(159, 36);
            this.dateFrom.TabIndex = 59;
            this.dateFrom.Value = new System.DateTime(2022, 2, 5, 0, 0, 0, 0);
            // 
            // dateTo
            // 
            this.dateTo.CheckedState.Parent = this.dateTo;
            this.dateTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTo.CustomFormat = "MMM. dd, yyyy";
            this.dateTo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.dateTo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTo.HoverState.Parent = this.dateTo;
            this.dateTo.Location = new System.Drawing.Point(910, 77);
            this.dateTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTo.Name = "dateTo";
            this.dateTo.ShadowDecoration.Parent = this.dateTo;
            this.dateTo.Size = new System.Drawing.Size(159, 36);
            this.dateTo.TabIndex = 60;
            this.dateTo.Value = new System.DateTime(2022, 2, 5, 0, 0, 0, 0);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.ForeColor = System.Drawing.Color.Gray;
            this.lbl5.Location = new System.Drawing.Point(876, 88);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(28, 18);
            this.lbl5.TabIndex = 62;
            this.lbl5.Text = "To:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.Location = new System.Drawing.Point(28, 77);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Customer Name, Transaction Number, Amount";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(567, 36);
            this.txtSearch.TabIndex = 58;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnok
            // 
            this.btnok.BorderRadius = 5;
            this.btnok.CheckedState.Parent = this.btnok;
            this.btnok.CustomImages.Parent = this.btnok;
            this.btnok.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btnok.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.ForeColor = System.Drawing.Color.Black;
            this.btnok.HoverState.Parent = this.btnok;
            this.btnok.Image = ((System.Drawing.Image)(resources.GetObject("btnok.Image")));
            this.btnok.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnok.Location = new System.Drawing.Point(703, 728);
            this.btnok.Name = "btnok";
            this.btnok.ShadowDecoration.Parent = this.btnok;
            this.btnok.Size = new System.Drawing.Size(263, 38);
            this.btnok.TabIndex = 56;
            this.btnok.Text = "Ok";
            this.btnok.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnok.TextOffset = new System.Drawing.Point(4, 0);
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btnprint
            // 
            this.btnprint.BorderRadius = 5;
            this.btnprint.CheckedState.Parent = this.btnprint;
            this.btnprint.CustomImages.Parent = this.btnprint;
            this.btnprint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btnprint.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.Color.Black;
            this.btnprint.HoverState.Parent = this.btnprint;
            this.btnprint.Image = ((System.Drawing.Image)(resources.GetObject("btnprint.Image")));
            this.btnprint.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnprint.Location = new System.Drawing.Point(434, 728);
            this.btnprint.Name = "btnprint";
            this.btnprint.ShadowDecoration.Parent = this.btnprint;
            this.btnprint.Size = new System.Drawing.Size(263, 38);
            this.btnprint.TabIndex = 55;
            this.btnprint.Text = "Print";
            this.btnprint.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnprint.TextOffset = new System.Drawing.Point(4, 0);
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1098, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(26, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbltime
            // 
            this.lbltime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.Black;
            this.lbltime.Location = new System.Drawing.Point(859, 30);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(76, 18);
            this.lbltime.TabIndex = 11;
            this.lbltime.Text = "10:00 PM";
            // 
            // lbldate
            // 
            this.lbldate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.Black;
            this.lbldate.Location = new System.Drawing.Point(859, 12);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(165, 18);
            this.lbldate.TabIndex = 10;
            this.lbldate.Text = "Tuesday, July 13, 2021";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(24, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(43, 43);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.Location = new System.Drawing.Point(817, 16);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(36, 30);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 8;
            this.guna2PictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(73, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Manage Shipping";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.ForeColor = System.Drawing.Color.Gray;
            this.lbl4.Location = new System.Drawing.Point(656, 88);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(49, 18);
            this.lbl4.TabIndex = 61;
            this.lbl4.Text = "From:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.lbltime);
            this.panel3.Controls.Add(this.lbldate);
            this.panel3.Controls.Add(this.guna2PictureBox1);
            this.panel3.Controls.Add(this.guna2PictureBox2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1137, 64);
            this.panel3.TabIndex = 54;
            // 
            // lblTotalShipping
            // 
            this.lblTotalShipping.AutoSize = true;
            this.lblTotalShipping.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalShipping.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalShipping.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalShipping.Location = new System.Drawing.Point(170, 129);
            this.lblTotalShipping.Name = "lblTotalShipping";
            this.lblTotalShipping.Size = new System.Drawing.Size(31, 33);
            this.lblTotalShipping.TabIndex = 65;
            this.lblTotalShipping.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 22);
            this.label1.TabIndex = 64;
            this.label1.Text = "Total Shippings:";
            // 
            // lblPending
            // 
            this.lblPending.AutoSize = true;
            this.lblPending.BackColor = System.Drawing.Color.Transparent;
            this.lblPending.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPending.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblPending.Location = new System.Drawing.Point(564, 129);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(31, 33);
            this.lblPending.TabIndex = 67;
            this.lblPending.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(446, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.TabIndex = 66;
            this.label4.Text = "Pendings:";
            // 
            // lblCanceled
            // 
            this.lblCanceled.AutoSize = true;
            this.lblCanceled.BackColor = System.Drawing.Color.Transparent;
            this.lblCanceled.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanceled.ForeColor = System.Drawing.Color.Red;
            this.lblCanceled.Location = new System.Drawing.Point(755, 129);
            this.lblCanceled.Name = "lblCanceled";
            this.lblCanceled.Size = new System.Drawing.Size(31, 33);
            this.lblCanceled.TabIndex = 69;
            this.lblCanceled.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(655, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 22);
            this.label6.TabIndex = 68;
            this.label6.Text = "Canceled:";
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.BackgroundColor = System.Drawing.Color.White;
            this.dgv1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv1.ColumnHeadersHeight = 40;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv1.EnableHeadersVisualStyles = false;
            this.dgv1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv1.Location = new System.Drawing.Point(12, 178);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv1.RowTemplate.Height = 30;
            this.dgv1.RowTemplate.ReadOnly = true;
            this.dgv1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(1112, 544);
            this.dgv1.TabIndex = 70;
            this.dgv1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.dgv1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv1.ThemeStyle.HeaderStyle.Height = 40;
            this.dgv1.ThemeStyle.ReadOnly = true;
            this.dgv1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv1.ThemeStyle.RowsStyle.Height = 30;
            this.dgv1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TransactionNumber";
            this.Column1.HeaderText = "Transaction#";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Customer_Name";
            this.Column2.HeaderText = "CustomerName";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.DataPropertyName = "Quantity";
            this.Column3.HeaderText = "Qty";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column3.Width = 55;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.DataPropertyName = "Amount";
            this.Column4.HeaderText = "Amount";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column4.Width = 82;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.DataPropertyName = "Shipping_Method";
            this.Column5.HeaderText = "Method";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column5.Width = 81;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.DataPropertyName = "PaymentOption";
            this.Column6.HeaderText = "PaymentOption";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column6.Width = 129;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.DataPropertyName = "ShippingTerms";
            this.Column7.HeaderText = "ShippingTerms";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column7.Width = 121;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column8.DataPropertyName = "Shipping_Date";
            this.Column8.HeaderText = "ShippingDate";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column8.Width = 114;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column9.DataPropertyName = "Status";
            this.Column9.HeaderText = "Status";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column9.Width = 70;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column10.DataPropertyName = "TransacDate";
            this.Column10.HeaderText = "TransacDate";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column10.Width = 106;
            // 
            // lblCompleted
            // 
            this.lblCompleted.AutoSize = true;
            this.lblCompleted.BackColor = System.Drawing.Color.Transparent;
            this.lblCompleted.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompleted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblCompleted.Location = new System.Drawing.Point(376, 129);
            this.lblCompleted.Name = "lblCompleted";
            this.lblCompleted.Size = new System.Drawing.Size(31, 33);
            this.lblCompleted.TabIndex = 72;
            this.lblCompleted.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(258, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 22);
            this.label8.TabIndex = 71;
            this.label8.Text = "Completed";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7.ForeColor = System.Drawing.Color.Black;
            this.lbl7.Location = new System.Drawing.Point(874, 138);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(58, 22);
            this.lbl7.TabIndex = 74;
            this.lbl7.Text = "Days:";
            // 
            // cmbFilter
            // 
            this.cmbFilter.BackColor = System.Drawing.Color.Transparent;
            this.cmbFilter.BorderThickness = 0;
            this.cmbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.FocusedColor = System.Drawing.Color.Empty;
            this.cmbFilter.FocusedState.Parent = this.cmbFilter;
            this.cmbFilter.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.HoverState.Parent = this.cmbFilter;
            this.cmbFilter.IntegralHeight = false;
            this.cmbFilter.ItemHeight = 30;
            this.cmbFilter.Items.AddRange(new object[] {
            "7",
            "15",
            "30"});
            this.cmbFilter.ItemsAppearance.Parent = this.cmbFilter;
            this.cmbFilter.Location = new System.Drawing.Point(937, 129);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.ShadowDecoration.Parent = this.cmbFilter;
            this.cmbFilter.Size = new System.Drawing.Size(174, 36);
            this.cmbFilter.TabIndex = 73;
            this.cmbFilter.TextOffset = new System.Drawing.Point(0, 1);
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
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
            this.btnrefresh.Location = new System.Drawing.Point(815, 127);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.ShadowDecoration.Parent = this.btnrefresh;
            this.btnrefresh.Size = new System.Drawing.Size(53, 38);
            this.btnrefresh.TabIndex = 93;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnexcel
            // 
            this.btnexcel.BorderRadius = 5;
            this.btnexcel.CheckedState.Parent = this.btnexcel;
            this.btnexcel.CustomImages.Parent = this.btnexcel;
            this.btnexcel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btnexcel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcel.ForeColor = System.Drawing.Color.Black;
            this.btnexcel.HoverState.Parent = this.btnexcel;
            this.btnexcel.Image = ((System.Drawing.Image)(resources.GetObject("btnexcel.Image")));
            this.btnexcel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnexcel.ImageSize = new System.Drawing.Size(28, 28);
            this.btnexcel.Location = new System.Drawing.Point(165, 728);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.ShadowDecoration.Parent = this.btnexcel;
            this.btnexcel.Size = new System.Drawing.Size(263, 38);
            this.btnexcel.TabIndex = 94;
            this.btnexcel.Text = "Export Excel";
            this.btnexcel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnexcel.TextOffset = new System.Drawing.Point(4, 0);
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // Manage_Shipping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 778);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.lblCompleted);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.lblCanceled);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPending);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotalShipping);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheckDate);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manage_Shipping";
            this.Text = "Manage_Shipping";
            this.Load += new System.EventHandler(this.Manage_Shipping_Load);
            this.Resize += new System.EventHandler(this.Manage_Shipping_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnCheckDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateFrom;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTo;
        private System.Windows.Forms.Label lbl5;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnok;
        private Guna.UI2.WinForms.Guna2Button btnprint;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lbldate;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalShipping;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPending;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCanceled;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DataGridView dgv1;
        private System.Windows.Forms.Label lblCompleted;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl7;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFilter;
        private Guna.UI2.WinForms.Guna2Button btnrefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private Guna.UI2.WinForms.Guna2Button btnexcel;
    }
}