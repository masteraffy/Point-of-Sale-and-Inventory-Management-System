
namespace Phosclay
{
    partial class Changepassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Changepassword));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.txtCurrentPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNewPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConfirmPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.chkshowpassword = new System.Windows.Forms.CheckBox();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1165, 41);
            this.panel4.TabIndex = 17;
            // 
            // btnClose
            // 
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1124, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(41, 41);
            this.btnClose.TabIndex = 21;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Change Password";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAdd.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAdd.Location = new System.Drawing.Point(662, 459);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(208, 38);
            this.btnAdd.TabIndex = 54;
            this.btnAdd.Text = "Change Password";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdd.TextOffset = new System.Drawing.Point(4, 0);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCurrentPass
            // 
            this.txtCurrentPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrentPass.BorderRadius = 3;
            this.txtCurrentPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurrentPass.DefaultText = "";
            this.txtCurrentPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCurrentPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCurrentPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrentPass.DisabledState.Parent = this.txtCurrentPass;
            this.txtCurrentPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrentPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCurrentPass.FocusedState.Parent = this.txtCurrentPass;
            this.txtCurrentPass.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCurrentPass.HoverState.Parent = this.txtCurrentPass;
            this.txtCurrentPass.Location = new System.Drawing.Point(396, 229);
            this.txtCurrentPass.Margin = new System.Windows.Forms.Padding(5);
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.PasswordChar = '\0';
            this.txtCurrentPass.PlaceholderText = "Enter Current Password";
            this.txtCurrentPass.SelectedText = "";
            this.txtCurrentPass.ShadowDecoration.Parent = this.txtCurrentPass;
            this.txtCurrentPass.Size = new System.Drawing.Size(474, 42);
            this.txtCurrentPass.TabIndex = 53;
            this.txtCurrentPass.UseSystemPasswordChar = true;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewPass.BorderRadius = 3;
            this.txtNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPass.DefaultText = "";
            this.txtNewPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPass.DisabledState.Parent = this.txtNewPass;
            this.txtNewPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPass.FocusedState.Parent = this.txtNewPass;
            this.txtNewPass.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPass.HoverState.Parent = this.txtNewPass;
            this.txtNewPass.Location = new System.Drawing.Point(396, 281);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(5);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '\0';
            this.txtNewPass.PlaceholderText = "Enter New Password";
            this.txtNewPass.SelectedText = "";
            this.txtNewPass.ShadowDecoration.Parent = this.txtNewPass;
            this.txtNewPass.Size = new System.Drawing.Size(472, 42);
            this.txtNewPass.TabIndex = 55;
            this.txtNewPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(180, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 22);
            this.label1.TabIndex = 56;
            this.label1.Text = "Input Current Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(205, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 22);
            this.label2.TabIndex = 57;
            this.label2.Text = "Input New Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(180, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 22);
            this.label4.TabIndex = 59;
            this.label4.Text = "Confirm New Password";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmPass.BorderRadius = 3;
            this.txtConfirmPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPass.DefaultText = "";
            this.txtConfirmPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfirmPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfirmPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPass.DisabledState.Parent = this.txtConfirmPass;
            this.txtConfirmPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPass.FocusedState.Parent = this.txtConfirmPass;
            this.txtConfirmPass.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConfirmPass.HoverState.Parent = this.txtConfirmPass;
            this.txtConfirmPass.Location = new System.Drawing.Point(396, 333);
            this.txtConfirmPass.Margin = new System.Windows.Forms.Padding(5);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '\0';
            this.txtConfirmPass.PlaceholderText = "Enter Password";
            this.txtConfirmPass.SelectedText = "";
            this.txtConfirmPass.ShadowDecoration.Parent = this.txtConfirmPass;
            this.txtConfirmPass.Size = new System.Drawing.Size(474, 42);
            this.txtConfirmPass.TabIndex = 58;
            this.txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BorderRadius = 5;
            this.btnClear.CheckedState.Parent = this.btnClear;
            this.btnClear.CustomImages.Parent = this.btnClear;
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.btnClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.HoverState.Parent = this.btnClear;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnClear.ImageSize = new System.Drawing.Size(25, 25);
            this.btnClear.Location = new System.Drawing.Point(660, 415);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Parent = this.btnClear;
            this.btnClear.Size = new System.Drawing.Size(208, 38);
            this.btnClear.TabIndex = 60;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClear.TextOffset = new System.Drawing.Point(4, 0);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chkshowpassword
            // 
            this.chkshowpassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkshowpassword.AutoSize = true;
            this.chkshowpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkshowpassword.Location = new System.Drawing.Point(732, 383);
            this.chkshowpassword.Name = "chkshowpassword";
            this.chkshowpassword.Size = new System.Drawing.Size(136, 20);
            this.chkshowpassword.TabIndex = 61;
            this.chkshowpassword.Text = "Show Password";
            this.chkshowpassword.UseVisualStyleBackColor = true;
            this.chkshowpassword.CheckedChanged += new System.EventHandler(this.chkshowpassword_CheckedChanged);
            // 
            // Changepassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 785);
            this.Controls.Add(this.chkshowpassword);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCurrentPass);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Changepassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Changepassword";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2TextBox txtCurrentPass;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPass;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private System.Windows.Forms.CheckBox chkshowpassword;
    }
}