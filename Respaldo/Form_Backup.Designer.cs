namespace Respaldo
{
    partial class Form_Backup
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Label_Titulo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Button_Respaldar = new Guna.UI2.WinForms.Guna2Button();
            this.Button_Restaurar = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // Label_Titulo
            // 
            this.Label_Titulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Label_Titulo.Font = new System.Drawing.Font("Bahnschrift", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Titulo.ForeColor = System.Drawing.Color.White;
            this.Label_Titulo.Location = new System.Drawing.Point(315, 62);
            this.Label_Titulo.Name = "Label_Titulo";
            this.Label_Titulo.Size = new System.Drawing.Size(346, 50);
            this.Label_Titulo.TabIndex = 1;
            this.Label_Titulo.Text = "Copia de seguridad";
            // 
            // Button_Respaldar
            // 
            this.Button_Respaldar.CheckedState.Parent = this.Button_Respaldar;
            this.Button_Respaldar.CustomImages.Parent = this.Button_Respaldar;
            this.Button_Respaldar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(134)))), ((int)(((byte)(224)))));
            this.Button_Respaldar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_Respaldar.ForeColor = System.Drawing.Color.White;
            this.Button_Respaldar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(209)))));
            this.Button_Respaldar.HoverState.Parent = this.Button_Respaldar;
            this.Button_Respaldar.Location = new System.Drawing.Point(305, 251);
            this.Button_Respaldar.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Respaldar.Name = "Button_Respaldar";
            this.Button_Respaldar.ShadowDecoration.Parent = this.Button_Respaldar;
            this.Button_Respaldar.Size = new System.Drawing.Size(374, 40);
            this.Button_Respaldar.TabIndex = 35;
            this.Button_Respaldar.Text = "Respaldar DBS";
            this.Button_Respaldar.Click += new System.EventHandler(this.Button_Respaldar_Click);
            // 
            // Button_Restaurar
            // 
            this.Button_Restaurar.CheckedState.Parent = this.Button_Restaurar;
            this.Button_Restaurar.CustomImages.Parent = this.Button_Restaurar;
            this.Button_Restaurar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(134)))), ((int)(((byte)(224)))));
            this.Button_Restaurar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_Restaurar.ForeColor = System.Drawing.Color.White;
            this.Button_Restaurar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(209)))));
            this.Button_Restaurar.HoverState.Parent = this.Button_Restaurar;
            this.Button_Restaurar.Location = new System.Drawing.Point(305, 317);
            this.Button_Restaurar.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Restaurar.Name = "Button_Restaurar";
            this.Button_Restaurar.ShadowDecoration.Parent = this.Button_Restaurar;
            this.Button_Restaurar.Size = new System.Drawing.Size(374, 40);
            this.Button_Restaurar.TabIndex = 36;
            this.Button_Restaurar.Text = "Restaurar DBS";
            this.Button_Restaurar.Click += new System.EventHandler(this.Button_Restaurar_Click);
            // 
            // Form_Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(976, 579);
            this.Controls.Add(this.Button_Restaurar);
            this.Controls.Add(this.Button_Respaldar);
            this.Controls.Add(this.Label_Titulo);
            this.Name = "Form_Backup";
            this.Text = "Form_Backup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_Titulo;
        private Guna.UI2.WinForms.Guna2Button Button_Respaldar;
        private Guna.UI2.WinForms.Guna2Button Button_Restaurar;
    }
}

