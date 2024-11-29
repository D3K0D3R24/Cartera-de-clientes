namespace Respaldo
{
    partial class Form_Principal_Ventana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Principal_Ventana));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Button_Add_User = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Button_Notificaciones = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Button_Clientes = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Button_Respaldo = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Button_pagos = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Button_Creditos = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton7 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Button_Home = new Guna.UI2.WinForms.Guna2ImageButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Button_Cerrar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_principal = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.Button_Add_User);
            this.panel1.Controls.Add(this.Button_Notificaciones);
            this.panel1.Controls.Add(this.Button_Clientes);
            this.panel1.Controls.Add(this.Button_Respaldo);
            this.panel1.Controls.Add(this.Button_pagos);
            this.panel1.Controls.Add(this.Button_Creditos);
            this.panel1.Controls.Add(this.guna2ImageButton7);
            this.panel1.Controls.Add(this.Button_Home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 618);
            this.panel1.TabIndex = 2;
            // 
            // Button_Add_User
            // 
            this.Button_Add_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.Button_Add_User.CheckedState.Parent = this.Button_Add_User;
            this.Button_Add_User.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Add_User.HoverState.Parent = this.Button_Add_User;
            this.Button_Add_User.Image = ((System.Drawing.Image)(resources.GetObject("Button_Add_User.Image")));
            this.Button_Add_User.ImageSize = new System.Drawing.Size(30, 30);
            this.Button_Add_User.Location = new System.Drawing.Point(0, 382);
            this.Button_Add_User.Name = "Button_Add_User";
            this.Button_Add_User.PressedState.Parent = this.Button_Add_User;
            this.Button_Add_User.Size = new System.Drawing.Size(50, 50);
            this.Button_Add_User.TabIndex = 2;
            this.toolTip1.SetToolTip(this.Button_Add_User, "Gestión de usuarios");
            this.Button_Add_User.Click += new System.EventHandler(this.Button_Add_User_Click);
            // 
            // Button_Notificaciones
            // 
            this.Button_Notificaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.Button_Notificaciones.CheckedState.Parent = this.Button_Notificaciones;
            this.Button_Notificaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Notificaciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Button_Notificaciones.HoverState.Parent = this.Button_Notificaciones;
            this.Button_Notificaciones.Image = global::Respaldo.Properties.Resources.icons8_campana_100;
            this.Button_Notificaciones.ImageSize = new System.Drawing.Size(30, 30);
            this.Button_Notificaciones.Location = new System.Drawing.Point(0, 568);
            this.Button_Notificaciones.Name = "Button_Notificaciones";
            this.Button_Notificaciones.PressedState.Parent = this.Button_Notificaciones;
            this.Button_Notificaciones.Size = new System.Drawing.Size(50, 50);
            this.Button_Notificaciones.TabIndex = 2;
            this.toolTip1.SetToolTip(this.Button_Notificaciones, "Notificaciones");
            this.Button_Notificaciones.Click += new System.EventHandler(this.Button_Notificaciones_Click);
            // 
            // Button_Clientes
            // 
            this.Button_Clientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.Button_Clientes.CheckedState.Parent = this.Button_Clientes;
            this.Button_Clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Clientes.HoverState.Parent = this.Button_Clientes;
            this.Button_Clientes.Image = global::Respaldo.Properties.Resources.icons8_gestión_de_clientes_50;
            this.Button_Clientes.ImageSize = new System.Drawing.Size(35, 35);
            this.Button_Clientes.Location = new System.Drawing.Point(0, 158);
            this.Button_Clientes.Name = "Button_Clientes";
            this.Button_Clientes.PressedState.Parent = this.Button_Clientes;
            this.Button_Clientes.Size = new System.Drawing.Size(50, 50);
            this.Button_Clientes.TabIndex = 1;
            this.toolTip1.SetToolTip(this.Button_Clientes, "Clientes");
            this.Button_Clientes.Click += new System.EventHandler(this.Button_Clientes_Click);
            // 
            // Button_Respaldo
            // 
            this.Button_Respaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.Button_Respaldo.CheckedState.Parent = this.Button_Respaldo;
            this.Button_Respaldo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Respaldo.HoverState.Parent = this.Button_Respaldo;
            this.Button_Respaldo.Image = global::Respaldo.Properties.Resources.icons8_reestablecer_las_bases_de_datos_50;
            this.Button_Respaldo.ImageSize = new System.Drawing.Size(30, 30);
            this.Button_Respaldo.Location = new System.Drawing.Point(0, 326);
            this.Button_Respaldo.Name = "Button_Respaldo";
            this.Button_Respaldo.PressedState.Parent = this.Button_Respaldo;
            this.Button_Respaldo.Size = new System.Drawing.Size(50, 50);
            this.Button_Respaldo.TabIndex = 1;
            this.toolTip1.SetToolTip(this.Button_Respaldo, "Copia de seguridad");
            this.Button_Respaldo.Click += new System.EventHandler(this.Button_Respaldo_Click);
            // 
            // Button_pagos
            // 
            this.Button_pagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.Button_pagos.CheckedState.Parent = this.Button_pagos;
            this.Button_pagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_pagos.HoverState.Parent = this.Button_pagos;
            this.Button_pagos.Image = global::Respaldo.Properties.Resources.icons8_pago_100;
            this.Button_pagos.ImageSize = new System.Drawing.Size(30, 30);
            this.Button_pagos.Location = new System.Drawing.Point(0, 270);
            this.Button_pagos.Name = "Button_pagos";
            this.Button_pagos.PressedState.Parent = this.Button_pagos;
            this.Button_pagos.Size = new System.Drawing.Size(50, 50);
            this.Button_pagos.TabIndex = 1;
            this.toolTip1.SetToolTip(this.Button_pagos, "Pagos");
            this.Button_pagos.Click += new System.EventHandler(this.Button_pagos_Click);
            // 
            // Button_Creditos
            // 
            this.Button_Creditos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.Button_Creditos.CheckedState.Parent = this.Button_Creditos;
            this.Button_Creditos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Creditos.HoverState.Parent = this.Button_Creditos;
            this.Button_Creditos.Image = global::Respaldo.Properties.Resources.icons8_moneda_100__1_;
            this.Button_Creditos.ImageSize = new System.Drawing.Size(30, 30);
            this.Button_Creditos.Location = new System.Drawing.Point(0, 214);
            this.Button_Creditos.Name = "Button_Creditos";
            this.Button_Creditos.PressedState.Parent = this.Button_Creditos;
            this.Button_Creditos.Size = new System.Drawing.Size(50, 50);
            this.Button_Creditos.TabIndex = 1;
            this.toolTip1.SetToolTip(this.Button_Creditos, "Créditos");
            this.Button_Creditos.Click += new System.EventHandler(this.Button_Creditos_Click);
            // 
            // guna2ImageButton7
            // 
            this.guna2ImageButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.guna2ImageButton7.CheckedState.Parent = this.guna2ImageButton7;
            this.guna2ImageButton7.HoverState.Parent = this.guna2ImageButton7;
            this.guna2ImageButton7.Image = global::Respaldo.Properties.Resources.icons8_menú_redondeado_30;
            this.guna2ImageButton7.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton7.Location = new System.Drawing.Point(0, 0);
            this.guna2ImageButton7.Name = "guna2ImageButton7";
            this.guna2ImageButton7.PressedState.Parent = this.guna2ImageButton7;
            this.guna2ImageButton7.Size = new System.Drawing.Size(50, 50);
            this.guna2ImageButton7.TabIndex = 1;
            // 
            // Button_Home
            // 
            this.Button_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.Button_Home.CheckedState.Parent = this.Button_Home;
            this.Button_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Home.HoverState.Parent = this.Button_Home;
            this.Button_Home.Image = global::Respaldo.Properties.Resources.icons8_casa_50;
            this.Button_Home.ImageSize = new System.Drawing.Size(30, 30);
            this.Button_Home.Location = new System.Drawing.Point(0, 102);
            this.Button_Home.Name = "Button_Home";
            this.Button_Home.PressedState.Parent = this.Button_Home;
            this.Button_Home.Size = new System.Drawing.Size(50, 50);
            this.Button_Home.TabIndex = 1;
            this.toolTip1.SetToolTip(this.Button_Home, "Home");
            this.Button_Home.Click += new System.EventHandler(this.Button_Home_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 50;
            this.toolTip1.AutoPopDelay = 1000;
            this.toolTip1.InitialDelay = 50;
            this.toolTip1.ReshowDelay = 10;
            // 
            // Button_Cerrar
            // 
            this.Button_Cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.Button_Cerrar.CheckedState.Parent = this.Button_Cerrar;
            this.Button_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Cerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Button_Cerrar.HoverState.Parent = this.Button_Cerrar;
            this.Button_Cerrar.Image = global::Respaldo.Properties.Resources.icons8_apagar_48;
            this.Button_Cerrar.ImageSize = new System.Drawing.Size(30, 30);
            this.Button_Cerrar.Location = new System.Drawing.Point(942, 0);
            this.Button_Cerrar.Name = "Button_Cerrar";
            this.Button_Cerrar.PressedState.Parent = this.Button_Cerrar;
            this.Button_Cerrar.Size = new System.Drawing.Size(50, 50);
            this.Button_Cerrar.TabIndex = 1;
            this.toolTip1.SetToolTip(this.Button_Cerrar, "Exit");
            this.Button_Cerrar.Click += new System.EventHandler(this.Button_Cerrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.panel2.Controls.Add(this.Button_Cerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(50, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(992, 50);
            this.panel2.TabIndex = 4;
            // 
            // panel_principal
            // 
            this.panel_principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.panel_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_principal.Location = new System.Drawing.Point(50, 50);
            this.panel_principal.Name = "panel_principal";
            this.panel_principal.Size = new System.Drawing.Size(992, 568);
            this.panel_principal.TabIndex = 5;
            // 
            // Form_Principal_Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 618);
            this.Controls.Add(this.panel_principal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Principal_Ventana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Principal_Ventana";
            this.Load += new System.EventHandler(this.Form_Principal_Ventana_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton Button_Home;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ImageButton Button_Clientes;
        private Guna.UI2.WinForms.Guna2ImageButton Button_Creditos;
        private Guna.UI2.WinForms.Guna2ImageButton Button_pagos;
        private Guna.UI2.WinForms.Guna2ImageButton Button_Respaldo;
        private Guna.UI2.WinForms.Guna2ImageButton Button_Cerrar;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton7;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2ImageButton Button_Notificaciones;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_principal;
        private Guna.UI2.WinForms.Guna2ImageButton Button_Add_User;
    }
}