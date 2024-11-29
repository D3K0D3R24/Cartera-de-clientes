namespace Respaldo
{
    partial class Ventana_Creditos_Form
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
            this.Button_Contratos = new Guna.UI2.WinForms.Guna2TileButton();
            this.Button_Equipos = new Guna.UI2.WinForms.Guna2TileButton();
            this.Button_Gestion_Credito = new Guna.UI2.WinForms.Guna2TileButton();
            this.SuspendLayout();
            // 
            // Button_Contratos
            // 
            this.Button_Contratos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Contratos.CheckedState.Parent = this.Button_Contratos;
            this.Button_Contratos.CustomImages.Parent = this.Button_Contratos;
            this.Button_Contratos.FillColor = System.Drawing.Color.Transparent;
            this.Button_Contratos.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.Button_Contratos.ForeColor = System.Drawing.Color.White;
            this.Button_Contratos.HoverState.Parent = this.Button_Contratos;
            this.Button_Contratos.Image = global::Respaldo.Properties.Resources.icons8_por_nueva_copia_96;
            this.Button_Contratos.ImageSize = new System.Drawing.Size(60, 60);
            this.Button_Contratos.Location = new System.Drawing.Point(648, 177);
            this.Button_Contratos.Name = "Button_Contratos";
            this.Button_Contratos.ShadowDecoration.Parent = this.Button_Contratos;
            this.Button_Contratos.Size = new System.Drawing.Size(225, 225);
            this.Button_Contratos.TabIndex = 7;
            this.Button_Contratos.Text = "Crédito a favor";
            // 
            // Button_Equipos
            // 
            this.Button_Equipos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Equipos.CheckedState.Parent = this.Button_Equipos;
            this.Button_Equipos.CustomImages.Parent = this.Button_Equipos;
            this.Button_Equipos.FillColor = System.Drawing.Color.Transparent;
            this.Button_Equipos.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.Button_Equipos.ForeColor = System.Drawing.Color.White;
            this.Button_Equipos.HoverState.Parent = this.Button_Equipos;
            this.Button_Equipos.Image = global::Respaldo.Properties.Resources.icons8_iniciar_la_transferencia_de_dinero_50;
            this.Button_Equipos.ImageSize = new System.Drawing.Size(60, 60);
            this.Button_Equipos.Location = new System.Drawing.Point(376, 177);
            this.Button_Equipos.Name = "Button_Equipos";
            this.Button_Equipos.ShadowDecoration.Parent = this.Button_Equipos;
            this.Button_Equipos.Size = new System.Drawing.Size(225, 225);
            this.Button_Equipos.TabIndex = 8;
            this.Button_Equipos.Text = "Aumento de crédito";
            // 
            // Button_Gestion_Credito
            // 
            this.Button_Gestion_Credito.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Gestion_Credito.CheckedState.Parent = this.Button_Gestion_Credito;
            this.Button_Gestion_Credito.CustomImages.Parent = this.Button_Gestion_Credito;
            this.Button_Gestion_Credito.FillColor = System.Drawing.Color.Transparent;
            this.Button_Gestion_Credito.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.Button_Gestion_Credito.ForeColor = System.Drawing.Color.White;
            this.Button_Gestion_Credito.HoverState.Parent = this.Button_Gestion_Credito;
            this.Button_Gestion_Credito.Image = global::Respaldo.Properties.Resources.icons8_bolsa_de_dinero_50;
            this.Button_Gestion_Credito.ImageSize = new System.Drawing.Size(65, 65);
            this.Button_Gestion_Credito.Location = new System.Drawing.Point(104, 177);
            this.Button_Gestion_Credito.Name = "Button_Gestion_Credito";
            this.Button_Gestion_Credito.ShadowDecoration.Parent = this.Button_Gestion_Credito;
            this.Button_Gestion_Credito.Size = new System.Drawing.Size(225, 225);
            this.Button_Gestion_Credito.TabIndex = 9;
            this.Button_Gestion_Credito.Text = "Gestionar crédito";
            this.Button_Gestion_Credito.Click += new System.EventHandler(this.Button_Gestion_Credito_Click);
            // 
            // Ventana_Creditos_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(976, 579);
            this.Controls.Add(this.Button_Contratos);
            this.Controls.Add(this.Button_Equipos);
            this.Controls.Add(this.Button_Gestion_Credito);
            this.Name = "Ventana_Creditos_Form";
            this.Text = "Ventana_Creditos_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TileButton Button_Contratos;
        private Guna.UI2.WinForms.Guna2TileButton Button_Equipos;
        private Guna.UI2.WinForms.Guna2TileButton Button_Gestion_Credito;
    }
}