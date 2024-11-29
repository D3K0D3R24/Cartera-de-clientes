namespace Respaldo
{
    partial class Ventana_Clientes_Form
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
            this.Button_Gestion_C = new Guna.UI2.WinForms.Guna2TileButton();
            this.Button_Agregar_Cliente = new Guna.UI2.WinForms.Guna2TileButton();
            this.SuspendLayout();
            // 
            // Button_Gestion_C
            // 
            this.Button_Gestion_C.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Gestion_C.CheckedState.Parent = this.Button_Gestion_C;
            this.Button_Gestion_C.CustomImages.Parent = this.Button_Gestion_C;
            this.Button_Gestion_C.FillColor = System.Drawing.Color.Transparent;
            this.Button_Gestion_C.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.Button_Gestion_C.ForeColor = System.Drawing.Color.White;
            this.Button_Gestion_C.HoverState.Parent = this.Button_Gestion_C;
            this.Button_Gestion_C.Image = global::Respaldo.Properties.Resources.icons8_editar_50;
            this.Button_Gestion_C.ImageSize = new System.Drawing.Size(60, 60);
            this.Button_Gestion_C.Location = new System.Drawing.Point(523, 177);
            this.Button_Gestion_C.Name = "Button_Gestion_C";
            this.Button_Gestion_C.ShadowDecoration.Parent = this.Button_Gestion_C;
            this.Button_Gestion_C.Size = new System.Drawing.Size(225, 225);
            this.Button_Gestion_C.TabIndex = 8;
            this.Button_Gestion_C.Text = "Gestionar cliente";
            this.Button_Gestion_C.Click += new System.EventHandler(this.Button_Gestion_C_Click);
            // 
            // Button_Agregar_Cliente
            // 
            this.Button_Agregar_Cliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Agregar_Cliente.CheckedState.Parent = this.Button_Agregar_Cliente;
            this.Button_Agregar_Cliente.CustomImages.Parent = this.Button_Agregar_Cliente;
            this.Button_Agregar_Cliente.FillColor = System.Drawing.Color.Transparent;
            this.Button_Agregar_Cliente.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.Button_Agregar_Cliente.ForeColor = System.Drawing.Color.White;
            this.Button_Agregar_Cliente.HoverState.Parent = this.Button_Agregar_Cliente;
            this.Button_Agregar_Cliente.Image = global::Respaldo.Properties.Resources.icons8_añadir_usuario_masculino_50;
            this.Button_Agregar_Cliente.ImageSize = new System.Drawing.Size(65, 65);
            this.Button_Agregar_Cliente.Location = new System.Drawing.Point(228, 177);
            this.Button_Agregar_Cliente.Name = "Button_Agregar_Cliente";
            this.Button_Agregar_Cliente.ShadowDecoration.Parent = this.Button_Agregar_Cliente;
            this.Button_Agregar_Cliente.Size = new System.Drawing.Size(225, 225);
            this.Button_Agregar_Cliente.TabIndex = 9;
            this.Button_Agregar_Cliente.Text = "Agregar cliente";
            this.Button_Agregar_Cliente.Click += new System.EventHandler(this.Button_Agregar_Cliente_Click);
            // 
            // Ventana_Clientes_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(976, 579);
            this.Controls.Add(this.Button_Gestion_C);
            this.Controls.Add(this.Button_Agregar_Cliente);
            this.Name = "Ventana_Clientes_Form";
            this.Text = "Ventana_Clientes_Form";
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TileButton Button_Gestion_C;
        private Guna.UI2.WinForms.Guna2TileButton Button_Agregar_Cliente;
    }
}