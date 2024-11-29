namespace Respaldo
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.Label_Welcome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_IMG = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Button_Login = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox1Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.ComboBox_Users = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ButtonPasswd = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Button_Cerrar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_IMG)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPasswd)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Welcome
            // 
            this.Label_Welcome.AutoSize = true;
            this.Label_Welcome.Font = new System.Drawing.Font("Agency FB", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Welcome.ForeColor = System.Drawing.Color.White;
            this.Label_Welcome.Location = new System.Drawing.Point(45, 156);
            this.Label_Welcome.Name = "Label_Welcome";
            this.Label_Welcome.Size = new System.Drawing.Size(494, 79);
            this.Label_Welcome.TabIndex = 26;
            this.Label_Welcome.Text = "CARTERA DE CLIENTES";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Label_Welcome);
            this.panel1.Controls.Add(this.pictureBox_IMG);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 390);
            this.panel1.TabIndex = 27;
            // 
            // pictureBox_IMG
            // 
            this.pictureBox_IMG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_IMG.Image = global::Respaldo.Properties.Resources.notebook_natural_laptop_macbook;
            this.pictureBox_IMG.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_IMG.Name = "pictureBox_IMG";
            this.pictureBox_IMG.Size = new System.Drawing.Size(585, 390);
            this.pictureBox_IMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_IMG.TabIndex = 28;
            this.pictureBox_IMG.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(912, 390);
            this.panel2.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Button_Login);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.TextBox1Password);
            this.panel3.Controls.Add(this.ComboBox_Users);
            this.panel3.Controls.Add(this.ButtonPasswd);
            this.panel3.Controls.Add(this.Button_Cerrar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(584, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(328, 390);
            this.panel3.TabIndex = 31;
            // 
            // Button_Login
            // 
            this.Button_Login.BorderRadius = 20;
            this.Button_Login.CheckedState.Parent = this.Button_Login;
            this.Button_Login.CustomImages.Parent = this.Button_Login;
            this.Button_Login.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_Login.ForeColor = System.Drawing.Color.White;
            this.Button_Login.HoverState.Parent = this.Button_Login;
            this.Button_Login.Location = new System.Drawing.Point(78, 301);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.ShadowDecoration.Parent = this.Button_Login;
            this.Button_Login.Size = new System.Drawing.Size(168, 45);
            this.Button_Login.TabIndex = 37;
            this.Button_Login.Text = "Login";
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(114, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 35;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(114, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 36;
            this.label1.Text = "Username";
            // 
            // TextBox1Password
            // 
            this.TextBox1Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox1Password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(119)))), ((int)(((byte)(219)))));
            this.TextBox1Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox1Password.DefaultText = "";
            this.TextBox1Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox1Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox1Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox1Password.DisabledState.Parent = this.TextBox1Password;
            this.TextBox1Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox1Password.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.TextBox1Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox1Password.FocusedState.Parent = this.TextBox1Password;
            this.TextBox1Password.ForeColor = System.Drawing.Color.White;
            this.TextBox1Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox1Password.HoverState.Parent = this.TextBox1Password;
            this.TextBox1Password.Location = new System.Drawing.Point(46, 219);
            this.TextBox1Password.Name = "TextBox1Password";
            this.TextBox1Password.PasswordChar = '•';
            this.TextBox1Password.PlaceholderText = "Password";
            this.TextBox1Password.SelectedText = "";
            this.TextBox1Password.ShadowDecoration.Parent = this.TextBox1Password;
            this.TextBox1Password.Size = new System.Drawing.Size(200, 36);
            this.TextBox1Password.TabIndex = 34;
            this.TextBox1Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1Password_KeyDown);
            // 
            // ComboBox_Users
            // 
            this.ComboBox_Users.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboBox_Users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.ComboBox_Users.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(119)))), ((int)(((byte)(219)))));
            this.ComboBox_Users.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_Users.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Users.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.ComboBox_Users.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBox_Users.FocusedState.Parent = this.ComboBox_Users;
            this.ComboBox_Users.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBox_Users.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(119)))), ((int)(((byte)(219)))));
            this.ComboBox_Users.FormattingEnabled = true;
            this.ComboBox_Users.HoverState.Parent = this.ComboBox_Users;
            this.ComboBox_Users.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ComboBox_Users.ItemHeight = 30;
            this.ComboBox_Users.ItemsAppearance.Parent = this.ComboBox_Users;
            this.ComboBox_Users.Location = new System.Drawing.Point(46, 96);
            this.ComboBox_Users.Name = "ComboBox_Users";
            this.ComboBox_Users.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.ComboBox_Users.ShadowDecoration.Parent = this.ComboBox_Users;
            this.ComboBox_Users.Size = new System.Drawing.Size(236, 36);
            this.ComboBox_Users.TabIndex = 33;
            this.ComboBox_Users.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Users_SelectedIndexChanged);
            // 
            // ButtonPasswd
            // 
            this.ButtonPasswd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonPasswd.BackColor = System.Drawing.Color.Transparent;
            this.ButtonPasswd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ButtonPasswd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPasswd.FillColor = System.Drawing.Color.Transparent;
            this.ButtonPasswd.Image = ((System.Drawing.Image)(resources.GetObject("ButtonPasswd.Image")));
            this.ButtonPasswd.Location = new System.Drawing.Point(246, 219);
            this.ButtonPasswd.Name = "ButtonPasswd";
            this.ButtonPasswd.ShadowDecoration.Parent = this.ButtonPasswd;
            this.ButtonPasswd.Size = new System.Drawing.Size(36, 36);
            this.ButtonPasswd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ButtonPasswd.TabIndex = 32;
            this.ButtonPasswd.TabStop = false;
            this.ButtonPasswd.UseTransparentBackground = true;
            this.ButtonPasswd.Click += new System.EventHandler(this.ButtonPasswd_Click_1);
            // 
            // Button_Cerrar
            // 
            this.Button_Cerrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Cerrar.CheckedState.Parent = this.Button_Cerrar;
            this.Button_Cerrar.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.Button_Cerrar.HoverState.Parent = this.Button_Cerrar;
            this.Button_Cerrar.Image = global::Respaldo.Properties.Resources.icons8_cerrar_ventana_50;
            this.Button_Cerrar.ImageSize = new System.Drawing.Size(30, 30);
            this.Button_Cerrar.Location = new System.Drawing.Point(298, 0);
            this.Button_Cerrar.Name = "Button_Cerrar";
            this.Button_Cerrar.PressedState.Parent = this.Button_Cerrar;
            this.Button_Cerrar.Size = new System.Drawing.Size(30, 30);
            this.Button_Cerrar.TabIndex = 31;
            this.Button_Cerrar.Click += new System.EventHandler(this.Button_Cerrar_Click_1);
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(912, 390);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Login";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_IMG)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonPasswd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Label_Welcome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_IMG;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2GradientButton Button_Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox TextBox1Password;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox_Users;
        private Guna.UI2.WinForms.Guna2PictureBox ButtonPasswd;
        private Guna.UI2.WinForms.Guna2ImageButton Button_Cerrar;
    }
}