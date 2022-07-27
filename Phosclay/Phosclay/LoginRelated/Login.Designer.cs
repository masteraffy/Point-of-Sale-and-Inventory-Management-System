
namespace Phosclay
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtusername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnlogin = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkConnection = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnSettings = new Guna.UI2.WinForms.Guna2ImageButton();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(181)))), ((int)(((byte)(59)))));
            this.cb1.Location = new System.Drawing.Point(693, 343);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(102, 17);
            this.cb1.TabIndex = 130;
            this.cb1.Text = "Show Password";
            this.cb1.UseVisualStyleBackColor = true;
            this.cb1.CheckedChanged += new System.EventHandler(this.cb1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(811, 551);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 127;
            this.pictureBox1.TabStop = false;
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.White;
            this.txtusername.BorderRadius = 20;
            this.txtusername.BorderThickness = 0;
            this.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtusername.DefaultText = "";
            this.txtusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtusername.DisabledState.Parent = this.txtusername;
            this.txtusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtusername.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtusername.FocusedState.Parent = this.txtusername;
            this.txtusername.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.Color.Black;
            this.txtusername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtusername.HoverState.Parent = this.txtusername;
            this.txtusername.Location = new System.Drawing.Point(487, 225);
            this.txtusername.Margin = new System.Windows.Forms.Padding(5);
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtusername.PlaceholderText = "Username";
            this.txtusername.SelectedText = "";
            this.txtusername.ShadowDecoration.Parent = this.txtusername;
            this.txtusername.Size = new System.Drawing.Size(308, 43);
            this.txtusername.TabIndex = 136;
            this.txtusername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusername_KeyPress);
            // 
            // txtpassword
            // 
            this.txtpassword.BorderRadius = 20;
            this.txtpassword.BorderThickness = 0;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.DefaultText = "";
            this.txtpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpassword.DisabledState.Parent = this.txtpassword;
            this.txtpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpassword.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword.FocusedState.Parent = this.txtpassword;
            this.txtpassword.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.Color.Black;
            this.txtpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword.HoverState.Parent = this.txtpassword;
            this.txtpassword.Location = new System.Drawing.Point(487, 278);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '\0';
            this.txtpassword.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtpassword.PlaceholderText = "Password";
            this.txtpassword.SelectedText = "";
            this.txtpassword.ShadowDecoration.Parent = this.txtpassword;
            this.txtpassword.Size = new System.Drawing.Size(308, 43);
            this.txtpassword.TabIndex = 137;
            this.txtpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpassword_KeyPress);
            // 
            // btnlogin
            // 
            this.btnlogin.BorderRadius = 10;
            this.btnlogin.CheckedState.Parent = this.btnlogin;
            this.btnlogin.CustomImages.Parent = this.btnlogin;
            this.btnlogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(181)))), ((int)(((byte)(59)))));
            this.btnlogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.Black;
            this.btnlogin.HoverState.Parent = this.btnlogin;
            this.btnlogin.Image = ((System.Drawing.Image)(resources.GetObject("btnlogin.Image")));
            this.btnlogin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnlogin.ImageOffset = new System.Drawing.Point(15, 0);
            this.btnlogin.ImageSize = new System.Drawing.Size(30, 30);
            this.btnlogin.Location = new System.Drawing.Point(487, 396);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.ShadowDecoration.Parent = this.btnlogin;
            this.btnlogin.Size = new System.Drawing.Size(249, 43);
            this.btnlogin.TabIndex = 138;
            this.btnlogin.Text = "Login";
            this.btnlogin.TextOffset = new System.Drawing.Point(4, 0);
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(439, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(358, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 139;
            this.pictureBox2.TabStop = false;
            // 
            // checkConnection
            // 
            this.checkConnection.BorderRadius = 10;
            this.checkConnection.CheckedState.Parent = this.checkConnection;
            this.checkConnection.CustomImages.Parent = this.checkConnection;
            this.checkConnection.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(181)))), ((int)(((byte)(59)))));
            this.checkConnection.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkConnection.ForeColor = System.Drawing.Color.Black;
            this.checkConnection.HoverState.Parent = this.checkConnection;
            this.checkConnection.Image = ((System.Drawing.Image)(resources.GetObject("checkConnection.Image")));
            this.checkConnection.Location = new System.Drawing.Point(742, 396);
            this.checkConnection.Name = "checkConnection";
            this.checkConnection.ShadowDecoration.Parent = this.checkConnection;
            this.checkConnection.Size = new System.Drawing.Size(49, 43);
            this.checkConnection.TabIndex = 140;
            this.checkConnection.Click += new System.EventHandler(this.checkConnection_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(771, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(26, 23);
            this.btnClose.TabIndex = 141;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.CheckedState.Parent = this.btnSettings;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.HoverState.Parent = this.btnSettings;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(729, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.PressedState.Parent = this.btnSettings;
            this.btnSettings.Size = new System.Drawing.Size(26, 23);
            this.btnSettings.TabIndex = 142;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(187)))), ((int)(((byte)(130)))));
            this.label1.Location = new System.Drawing.Point(109, 513);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 143;
            this.label1.Text = "Student Of Arellano University";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(187)))), ((int)(((byte)(130)))));
            this.label2.Location = new System.Drawing.Point(118, 529);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 144;
            this.label2.Text = "Computer Science 2022";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(809, 551);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.checkConnection);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtusername;
        private Guna.UI2.WinForms.Guna2TextBox txtpassword;
        private Guna.UI2.WinForms.Guna2Button btnlogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Button checkConnection;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private Guna.UI2.WinForms.Guna2ImageButton btnSettings;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}