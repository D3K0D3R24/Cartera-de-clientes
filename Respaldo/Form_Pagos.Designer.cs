namespace Respaldo
{
    partial class Form_Pagos
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
            this.Button_Registrar_Pago = new Guna.UI2.WinForms.Guna2TileButton();
            this.Button_Pagos = new Guna.UI2.WinForms.Guna2TileButton();
            this.SuspendLayout();
            // 
            // Button_Registrar_Pago
            // 
            this.Button_Registrar_Pago.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Registrar_Pago.CheckedState.Parent = this.Button_Registrar_Pago;
            this.Button_Registrar_Pago.CustomImages.Parent = this.Button_Registrar_Pago;
            this.Button_Registrar_Pago.FillColor = System.Drawing.Color.Transparent;
            this.Button_Registrar_Pago.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.Button_Registrar_Pago.ForeColor = System.Drawing.Color.White;
            this.Button_Registrar_Pago.HoverState.Parent = this.Button_Registrar_Pago;
            this.Button_Registrar_Pago.Image = global::Respaldo.Properties.Resources.icons8_añadir_usuario_masculino_50;
            this.Button_Registrar_Pago.ImageSize = new System.Drawing.Size(65, 65);
            this.Button_Registrar_Pago.Location = new System.Drawing.Point(228, 177);
            this.Button_Registrar_Pago.Name = "Button_Registrar_Pago";
            this.Button_Registrar_Pago.ShadowDecoration.Parent = this.Button_Registrar_Pago;
            this.Button_Registrar_Pago.Size = new System.Drawing.Size(225, 225);
            this.Button_Registrar_Pago.TabIndex = 10;
            this.Button_Registrar_Pago.Text = "Registrar pago";
            this.Button_Registrar_Pago.Click += new System.EventHandler(this.Button_Registrar_Pago_Click);
            // 
            // Button_Pagos
            // 
            this.Button_Pagos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Pagos.CheckedState.Parent = this.Button_Pagos;
            this.Button_Pagos.CustomImages.Parent = this.Button_Pagos;
            this.Button_Pagos.FillColor = System.Drawing.Color.Transparent;
            this.Button_Pagos.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.Button_Pagos.ForeColor = System.Drawing.Color.White;
            this.Button_Pagos.HoverState.Parent = this.Button_Pagos;
            this.Button_Pagos.Image = global::Respaldo.Properties.Resources.icons8_añadir_usuario_masculino_50;
            this.Button_Pagos.ImageSize = new System.Drawing.Size(65, 65);
            this.Button_Pagos.Location = new System.Drawing.Point(523, 177);
            this.Button_Pagos.Name = "Button_Pagos";
            this.Button_Pagos.ShadowDecoration.Parent = this.Button_Pagos;
            this.Button_Pagos.Size = new System.Drawing.Size(225, 225);
            this.Button_Pagos.TabIndex = 11;
            this.Button_Pagos.Text = "Historial de pagos";
            this.Button_Pagos.Click += new System.EventHandler(this.Button_Pagos_Click);
            // 
            // Form_Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(976, 579);
            this.Controls.Add(this.Button_Pagos);
            this.Controls.Add(this.Button_Registrar_Pago);
            this.Name = "Form_Pagos";
            this.Text = "Form_Pagos";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TileButton Button_Registrar_Pago;
        private Guna.UI2.WinForms.Guna2TileButton Button_Pagos;
    }
}