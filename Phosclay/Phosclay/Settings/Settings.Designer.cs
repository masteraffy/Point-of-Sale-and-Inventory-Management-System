
namespace Phosclay
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label22 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.Pn2 = new System.Windows.Forms.Panel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.cmbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Pn1 = new System.Windows.Forms.Panel();
            this.PN7 = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.PN8 = new System.Windows.Forms.Panel();
            this.addCategory = new Guna.UI2.WinForms.Guna2Button();
            this.deleteCategory = new Guna.UI2.WinForms.Guna2Button();
            this.datagridview1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnrefresh = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Pn2.SuspendLayout();
            this.PN7.SuspendLayout();
            this.PN8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 47);
            this.panel1.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1069, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.PressedState.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(26, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(50, 13);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 22);
            this.label22.TabIndex = 11;
            this.label22.Text = "Settings";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Gold;
            this.lbl2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.Black;
            this.lbl2.Location = new System.Drawing.Point(24, 63);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(143, 22);
            this.lbl2.TabIndex = 13;
            this.lbl2.Text = "Add Categories";
            // 
            // Pn2
            // 
            this.Pn2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pn2.Controls.Add(this.lbl1);
            this.Pn2.Controls.Add(this.cmbCategory);
            this.Pn2.Location = new System.Drawing.Point(12, 94);
            this.Pn2.Name = "Pn2";
            this.Pn2.Size = new System.Drawing.Size(1079, 115);
            this.Pn2.TabIndex = 14;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.SystemColors.Control;
            this.lbl1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.Black;
            this.lbl1.Location = new System.Drawing.Point(19, 14);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(146, 22);
            this.lbl1.TabIndex = 16;
            this.lbl1.Text = "Select Category";
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cmbCategory.BorderThickness = 0;
            this.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FocusedColor = System.Drawing.Color.Empty;
            this.cmbCategory.FocusedState.Parent = this.cmbCategory;
            this.cmbCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.HoverState.Parent = this.cmbCategory;
            this.cmbCategory.IntegralHeight = false;
            this.cmbCategory.ItemHeight = 30;
            this.cmbCategory.Items.AddRange(new object[] {
            "Inventory - Category Form",
            "Point of Sale - Category Form",
            "Inventory - Unit Form",
            "Point of Sale - Shipping Options Category"});
            this.cmbCategory.ItemsAppearance.Parent = this.cmbCategory;
            this.cmbCategory.Location = new System.Drawing.Point(16, 47);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.ShadowDecoration.Parent = this.cmbCategory;
            this.cmbCategory.Size = new System.Drawing.Size(1041, 36);
            this.cmbCategory.TabIndex = 2;
            this.cmbCategory.TextOffset = new System.Drawing.Point(0, 1);
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // Pn1
            // 
            this.Pn1.BackColor = System.Drawing.Color.Gold;
            this.Pn1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pn1.Location = new System.Drawing.Point(12, 53);
            this.Pn1.Name = "Pn1";
            this.Pn1.Size = new System.Drawing.Size(1079, 41);
            this.Pn1.TabIndex = 15;
            // 
            // PN7
            // 
            this.PN7.BackColor = System.Drawing.Color.Gold;
            this.PN7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PN7.Controls.Add(this.labelName);
            this.PN7.Location = new System.Drawing.Point(12, 215);
            this.PN7.Name = "PN7";
            this.PN7.Size = new System.Drawing.Size(1079, 41);
            this.PN7.TabIndex = 82;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Gold;
            this.labelName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Black;
            this.labelName.Location = new System.Drawing.Point(11, 10);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(113, 22);
            this.labelName.TabIndex = 19;
            this.labelName.Text = "Panel Name";
            // 
            // PN8
            // 
            this.PN8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PN8.Controls.Add(this.btnrefresh);
            this.PN8.Controls.Add(this.addCategory);
            this.PN8.Controls.Add(this.deleteCategory);
            this.PN8.Controls.Add(this.datagridview1);
            this.PN8.Location = new System.Drawing.Point(12, 256);
            this.PN8.Name = "PN8";
            this.PN8.Size = new System.Drawing.Size(1079, 274);
            this.PN8.TabIndex = 81;
            // 
            // addCategory
            // 
            this.addCategory.BorderRadius = 5;
            this.addCategory.CheckedState.Parent = this.addCategory;
            this.addCategory.CustomImages.Parent = this.addCategory;
            this.addCategory.FillColor = System.Drawing.Color.Gold;
            this.addCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategory.ForeColor = System.Drawing.Color.Black;
            this.addCategory.HoverState.Parent = this.addCategory;
            this.addCategory.Image = ((System.Drawing.Image)(resources.GetObject("addCategory.Image")));
            this.addCategory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.addCategory.ImageSize = new System.Drawing.Size(30, 30);
            this.addCategory.Location = new System.Drawing.Point(16, 223);
            this.addCategory.Name = "addCategory";
            this.addCategory.ShadowDecoration.Parent = this.addCategory;
            this.addCategory.Size = new System.Drawing.Size(475, 38);
            this.addCategory.TabIndex = 81;
            this.addCategory.Text = "Add Category";
            this.addCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addCategory.TextOffset = new System.Drawing.Point(4, 0);
            this.addCategory.Click += new System.EventHandler(this.addCategory_Click);
            // 
            // deleteCategory
            // 
            this.deleteCategory.BorderRadius = 5;
            this.deleteCategory.CheckedState.Parent = this.deleteCategory;
            this.deleteCategory.CustomImages.Parent = this.deleteCategory;
            this.deleteCategory.FillColor = System.Drawing.Color.Gold;
            this.deleteCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCategory.ForeColor = System.Drawing.Color.Black;
            this.deleteCategory.HoverState.Parent = this.deleteCategory;
            this.deleteCategory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.deleteCategory.ImageSize = new System.Drawing.Size(30, 30);
            this.deleteCategory.Location = new System.Drawing.Point(549, 223);
            this.deleteCategory.Name = "deleteCategory";
            this.deleteCategory.ShadowDecoration.Parent = this.deleteCategory;
            this.deleteCategory.Size = new System.Drawing.Size(508, 38);
            this.deleteCategory.TabIndex = 51;
            this.deleteCategory.Text = "Delete Category";
            this.deleteCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.deleteCategory.TextOffset = new System.Drawing.Point(4, 0);
            this.deleteCategory.Click += new System.EventHandler(this.deleteCategory_Click);
            // 
            // datagridview1
            // 
            this.datagridview1.AllowUserToAddRows = false;
            this.datagridview1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.datagridview1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridview1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridview1.BackgroundColor = System.Drawing.Color.White;
            this.datagridview1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridview1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridview1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridview1.ColumnHeadersHeight = 35;
            this.datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagridview1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridview1.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridview1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridview1.EnableHeadersVisualStyles = false;
            this.datagridview1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridview1.Location = new System.Drawing.Point(16, 19);
            this.datagridview1.Name = "datagridview1";
            this.datagridview1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridview1.RowHeadersVisible = false;
            this.datagridview1.RowHeadersWidth = 51;
            this.datagridview1.RowTemplate.Height = 35;
            this.datagridview1.RowTemplate.ReadOnly = true;
            this.datagridview1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridview1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridview1.Size = new System.Drawing.Size(1041, 187);
            this.datagridview1.TabIndex = 25;
            this.datagridview1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.datagridview1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridview1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagridview1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagridview1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagridview1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagridview1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.datagridview1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridview1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.datagridview1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridview1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.datagridview1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagridview1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagridview1.ThemeStyle.HeaderStyle.Height = 35;
            this.datagridview1.ThemeStyle.ReadOnly = true;
            this.datagridview1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridview1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridview1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.datagridview1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagridview1.ThemeStyle.RowsStyle.Height = 35;
            this.datagridview1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridview1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagridview1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview1_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Form";
            this.Column1.HeaderText = "Form";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Category";
            this.Column2.HeaderText = "Category";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // btnrefresh
            // 
            this.btnrefresh.BorderRadius = 5;
            this.btnrefresh.CheckedState.Parent = this.btnrefresh;
            this.btnrefresh.CustomImages.Parent = this.btnrefresh;
            this.btnrefresh.FillColor = System.Drawing.Color.Gold;
            this.btnrefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnrefresh.ForeColor = System.Drawing.Color.White;
            this.btnrefresh.HoverState.Parent = this.btnrefresh;
            this.btnrefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnrefresh.Image")));
            this.btnrefresh.ImageSize = new System.Drawing.Size(30, 30);
            this.btnrefresh.Location = new System.Drawing.Point(497, 223);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.ShadowDecoration.Parent = this.btnrefresh;
            this.btnrefresh.Size = new System.Drawing.Size(44, 38);
            this.btnrefresh.TabIndex = 83;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 558);
            this.Controls.Add(this.PN7);
            this.Controls.Add(this.PN8);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pn2);
            this.Controls.Add(this.Pn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.Resize += new System.EventHandler(this.Settings_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Pn2.ResumeLayout(false);
            this.Pn2.PerformLayout();
            this.PN7.ResumeLayout(false);
            this.PN7.PerformLayout();
            this.PN8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ImageButton btnExit;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Panel Pn2;
        private System.Windows.Forms.Panel Pn1;
        private System.Windows.Forms.Label lbl1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCategory;
        private System.Windows.Forms.Panel PN8;
        private Guna.UI2.WinForms.Guna2Button deleteCategory;
        private Guna.UI2.WinForms.Guna2DataGridView datagridview1;
        private System.Windows.Forms.Panel PN7;
        private System.Windows.Forms.Label labelName;
        private Guna.UI2.WinForms.Guna2Button addCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private Guna.UI2.WinForms.Guna2Button btnrefresh;
    }
}