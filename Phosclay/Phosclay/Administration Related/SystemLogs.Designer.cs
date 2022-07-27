
namespace Phosclay.Administration_Related
{
    partial class SystemLogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemLogs));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvLogs = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn2 = new System.Windows.Forms.Panel();
            this.btnView = new Guna.UI2.WinForms.Guna2Button();
            this.dtpTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.dtpFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.pn1 = new System.Windows.Forms.Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbLogsFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.pn3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            this.pn2.SuspendLayout();
            this.pn1.SuspendLayout();
            this.pn3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(854, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.PressedState.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(26, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(49, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "System Logs";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // dgvLogs
            // 
            this.dgvLogs.AllowUserToAddRows = false;
            this.dgvLogs.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvLogs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLogs.BackgroundColor = System.Drawing.Color.White;
            this.dgvLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLogs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLogs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLogs.ColumnHeadersHeight = 30;
            this.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLogs.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvLogs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLogs.EnableHeadersVisualStyles = false;
            this.dgvLogs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLogs.Location = new System.Drawing.Point(0, 172);
            this.dgvLogs.Name = "dgvLogs";
            this.dgvLogs.ReadOnly = true;
            this.dgvLogs.RowHeadersVisible = false;
            this.dgvLogs.RowHeadersWidth = 51;
            this.dgvLogs.RowTemplate.Height = 25;
            this.dgvLogs.RowTemplate.ReadOnly = true;
            this.dgvLogs.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLogs.Size = new System.Drawing.Size(894, 527);
            this.dgvLogs.TabIndex = 24;
            this.dgvLogs.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvLogs.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLogs.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvLogs.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvLogs.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvLogs.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvLogs.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvLogs.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLogs.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.dgvLogs.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLogs.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvLogs.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLogs.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLogs.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvLogs.ThemeStyle.ReadOnly = true;
            this.dgvLogs.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLogs.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLogs.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvLogs.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvLogs.ThemeStyle.RowsStyle.Height = 25;
            this.dgvLogs.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLogs.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "datelog";
            this.Column1.HeaderText = "DateLog";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column1.Width = 84;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.DataPropertyName = "timelog";
            this.Column2.HeaderText = "TimeLog";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column2.Width = 84;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "full_name";
            this.Column3.HeaderText = "Full Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "action";
            this.Column4.HeaderText = "Action";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.DataPropertyName = "module";
            this.Column5.HeaderText = "Module";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column5.Width = 79;
            // 
            // pn2
            // 
            this.pn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.pn2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn2.Controls.Add(this.btnView);
            this.pn2.Controls.Add(this.dtpTo);
            this.pn2.Controls.Add(this.lbl3);
            this.pn2.Controls.Add(this.lbl1);
            this.pn2.Controls.Add(this.lbl2);
            this.pn2.Controls.Add(this.dtpFrom);
            this.pn2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn2.Location = new System.Drawing.Point(0, 111);
            this.pn2.Name = "pn2";
            this.pn2.Size = new System.Drawing.Size(894, 61);
            this.pn2.TabIndex = 26;
            // 
            // btnView
            // 
            this.btnView.BorderRadius = 25;
            this.btnView.CheckedState.Parent = this.btnView;
            this.btnView.CustomImages.Parent = this.btnView;
            this.btnView.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btnView.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.Black;
            this.btnView.HoverState.Parent = this.btnView;
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnView.ImageSize = new System.Drawing.Size(30, 30);
            this.btnView.Location = new System.Drawing.Point(809, 8);
            this.btnView.Name = "btnView";
            this.btnView.ShadowDecoration.Parent = this.btnView;
            this.btnView.Size = new System.Drawing.Size(46, 45);
            this.btnView.TabIndex = 5;
            this.btnView.TextOffset = new System.Drawing.Point(-15, 0);
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.CheckedState.Parent = this.dtpTo;
            this.dtpTo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.dtpTo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpTo.HoverState.Parent = this.dtpTo;
            this.dtpTo.Location = new System.Drawing.Point(582, 14);
            this.dtpTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.ShadowDecoration.Parent = this.dtpTo;
            this.dtpTo.Size = new System.Drawing.Size(214, 36);
            this.dtpTo.TabIndex = 4;
            this.dtpTo.Value = new System.DateTime(2021, 10, 14, 0, 0, 0, 0);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.Black;
            this.lbl3.Location = new System.Drawing.Point(548, 24);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(28, 18);
            this.lbl3.TabIndex = 39;
            this.lbl3.Text = "To:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.Black;
            this.lbl1.Location = new System.Drawing.Point(15, 18);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(223, 27);
            this.lbl1.TabIndex = 10;
            this.lbl1.Text = "Today\'s Latest Logs";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.Black;
            this.lbl2.Location = new System.Drawing.Point(257, 24);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(49, 18);
            this.lbl2.TabIndex = 38;
            this.lbl2.Text = "From:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CheckedState.Parent = this.dtpFrom;
            this.dtpFrom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.dtpFrom.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFrom.HoverState.Parent = this.dtpFrom;
            this.dtpFrom.Location = new System.Drawing.Point(312, 14);
            this.dtpFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.ShadowDecoration.Parent = this.dtpFrom;
            this.dtpFrom.Size = new System.Drawing.Size(230, 36);
            this.dtpFrom.TabIndex = 3;
            this.dtpFrom.Value = new System.DateTime(2021, 10, 14, 0, 0, 0, 0);
            // 
            // pn1
            // 
            this.pn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.pn1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn1.Controls.Add(this.txtSearch);
            this.pn1.Controls.Add(this.cmbLogsFilter);
            this.pn1.Controls.Add(this.lbl4);
            this.pn1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn1.Location = new System.Drawing.Point(0, 50);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(894, 61);
            this.pn1.TabIndex = 25;
            // 
            // txtSearch
            // 
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
            this.txtSearch.Location = new System.Drawing.Point(9, 9);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search Full Name";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(509, 42);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbLogsFilter
            // 
            this.cmbLogsFilter.BackColor = System.Drawing.Color.Transparent;
            this.cmbLogsFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLogsFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLogsFilter.FocusedColor = System.Drawing.Color.Empty;
            this.cmbLogsFilter.FocusedState.Parent = this.cmbLogsFilter;
            this.cmbLogsFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbLogsFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbLogsFilter.FormattingEnabled = true;
            this.cmbLogsFilter.HoverState.Parent = this.cmbLogsFilter;
            this.cmbLogsFilter.ItemHeight = 30;
            this.cmbLogsFilter.Items.AddRange(new object[] {
            "Account",
            "Inventory",
            "POS",
            "Void Transactions",
            "Login"});
            this.cmbLogsFilter.ItemsAppearance.Parent = this.cmbLogsFilter;
            this.cmbLogsFilter.Location = new System.Drawing.Point(599, 13);
            this.cmbLogsFilter.Name = "cmbLogsFilter";
            this.cmbLogsFilter.ShadowDecoration.Parent = this.cmbLogsFilter;
            this.cmbLogsFilter.Size = new System.Drawing.Size(197, 36);
            this.cmbLogsFilter.TabIndex = 2;
            this.cmbLogsFilter.SelectedIndexChanged += new System.EventHandler(this.cmbLogsFilter_SelectedIndexChanged);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.ForeColor = System.Drawing.Color.Black;
            this.lbl4.Location = new System.Drawing.Point(526, 23);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(67, 18);
            this.lbl4.TabIndex = 35;
            this.lbl4.Text = "Filter by:";
            // 
            // pn3
            // 
            this.pn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.pn3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn3.Controls.Add(this.btnExit);
            this.pn3.Controls.Add(this.label3);
            this.pn3.Controls.Add(this.pictureBox1);
            this.pn3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn3.Location = new System.Drawing.Point(0, 0);
            this.pn3.Name = "pn3";
            this.pn3.Size = new System.Drawing.Size(894, 50);
            this.pn3.TabIndex = 27;
            // 
            // SystemLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 700);
            this.Controls.Add(this.dgvLogs);
            this.Controls.Add(this.pn2);
            this.Controls.Add(this.pn1);
            this.Controls.Add(this.pn3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SystemLogs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SystemLogs";
            this.Load += new System.EventHandler(this.SystemLogs_Load);
            this.Resize += new System.EventHandler(this.SystemLogs_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            this.pn2.ResumeLayout(false);
            this.pn2.PerformLayout();
            this.pn1.ResumeLayout(false);
            this.pn1.PerformLayout();
            this.pn3.ResumeLayout(false);
            this.pn3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvLogs;
        private System.Windows.Forms.Panel pn2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTo;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFrom;
        private System.Windows.Forms.Panel pn1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cmbLogsFilter;
        private System.Windows.Forms.Label lbl4;
        private Guna.UI2.WinForms.Guna2Button btnView;
        private System.Windows.Forms.Panel pn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}