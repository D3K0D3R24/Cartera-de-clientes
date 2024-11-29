namespace Respaldo
{
    partial class Form_Historial_Pagos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.VScrollBar_Datagrid = new Guna.UI.WinForms.GunaVScrollBar();
            this.DtgHistorialPagos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.BtnBuscar = new Guna.UI2.WinForms.Guna2Button();
            this.TextBBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgHistorialPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // VScrollBar_Datagrid
            // 
            this.VScrollBar_Datagrid.LargeChange = 10;
            this.VScrollBar_Datagrid.Location = new System.Drawing.Point(916, 175);
            this.VScrollBar_Datagrid.Maximum = 100;
            this.VScrollBar_Datagrid.Name = "VScrollBar_Datagrid";
            this.VScrollBar_Datagrid.ScrollIdleColor = System.Drawing.Color.Silver;
            this.VScrollBar_Datagrid.Size = new System.Drawing.Size(10, 311);
            this.VScrollBar_Datagrid.TabIndex = 33;
            this.VScrollBar_Datagrid.ThumbColor = System.Drawing.Color.DimGray;
            this.VScrollBar_Datagrid.ThumbHoverColor = System.Drawing.Color.Gray;
            this.VScrollBar_Datagrid.ThumbPressedColor = System.Drawing.Color.DarkGray;
            // 
            // DtgHistorialPagos
            // 
            this.DtgHistorialPagos.AllowUserToAddRows = false;
            this.DtgHistorialPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgHistorialPagos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.DtgHistorialPagos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtgHistorialPagos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DtgHistorialPagos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgHistorialPagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DtgHistorialPagos.ColumnHeadersHeight = 35;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(134)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgHistorialPagos.DefaultCellStyle = dataGridViewCellStyle4;
            this.DtgHistorialPagos.EnableHeadersVisualStyles = false;
            this.DtgHistorialPagos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.DtgHistorialPagos.Location = new System.Drawing.Point(65, 175);
            this.DtgHistorialPagos.MultiSelect = false;
            this.DtgHistorialPagos.Name = "DtgHistorialPagos";
            this.DtgHistorialPagos.RowHeadersVisible = false;
            this.DtgHistorialPagos.RowTemplate.Height = 35;
            this.DtgHistorialPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgHistorialPagos.Size = new System.Drawing.Size(845, 313);
            this.DtgHistorialPagos.TabIndex = 32;
            this.DtgHistorialPagos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DtgHistorialPagos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Empty;
            this.DtgHistorialPagos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DtgHistorialPagos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DtgHistorialPagos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DtgHistorialPagos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DtgHistorialPagos.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.DtgHistorialPagos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.DtgHistorialPagos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(209)))));
            this.DtgHistorialPagos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DtgHistorialPagos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtgHistorialPagos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DtgHistorialPagos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DtgHistorialPagos.ThemeStyle.HeaderStyle.Height = 35;
            this.DtgHistorialPagos.ThemeStyle.ReadOnly = false;
            this.DtgHistorialPagos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.DtgHistorialPagos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DtgHistorialPagos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DtgHistorialPagos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DtgHistorialPagos.ThemeStyle.RowsStyle.Height = 35;
            this.DtgHistorialPagos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.DtgHistorialPagos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(134)))), ((int)(((byte)(224)))));
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.CheckedState.Parent = this.BtnBuscar;
            this.BtnBuscar.CustomImages.Parent = this.BtnBuscar;
            this.BtnBuscar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(134)))), ((int)(((byte)(224)))));
            this.BtnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(209)))));
            this.BtnBuscar.HoverState.Parent = this.BtnBuscar;
            this.BtnBuscar.Location = new System.Drawing.Point(373, 104);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.ShadowDecoration.Parent = this.BtnBuscar;
            this.BtnBuscar.Size = new System.Drawing.Size(135, 36);
            this.BtnBuscar.TabIndex = 34;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TextBBuscar
            // 
            this.TextBBuscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(209)))));
            this.TextBBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBBuscar.DefaultText = "";
            this.TextBBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBBuscar.DisabledState.Parent = this.TextBBuscar;
            this.TextBBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBBuscar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.TextBBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBBuscar.FocusedState.Parent = this.TextBBuscar;
            this.TextBBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBBuscar.HoverState.Parent = this.TextBBuscar;
            this.TextBBuscar.Location = new System.Drawing.Point(65, 104);
            this.TextBBuscar.Name = "TextBBuscar";
            this.TextBBuscar.PasswordChar = '\0';
            this.TextBBuscar.PlaceholderText = "";
            this.TextBBuscar.SelectedText = "";
            this.TextBBuscar.ShadowDecoration.Parent = this.TextBBuscar;
            this.TextBBuscar.Size = new System.Drawing.Size(303, 36);
            this.TextBBuscar.TabIndex = 35;
            this.TextBBuscar.TextChanged += new System.EventHandler(this.TextBBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 19);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ingrese el nombre del cliente";
            // 
            // Form_Historial_Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(992, 568);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBBuscar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.VScrollBar_Datagrid);
            this.Controls.Add(this.DtgHistorialPagos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Historial_Pagos";
            this.Text = "Form_Historial_Pagos";
            this.Load += new System.EventHandler(this.Form_Historial_Pagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgHistorialPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaVScrollBar VScrollBar_Datagrid;
        private Guna.UI2.WinForms.Guna2DataGridView DtgHistorialPagos;
        private Guna.UI2.WinForms.Guna2Button BtnBuscar;
        private Guna.UI2.WinForms.Guna2TextBox TextBBuscar;
        private System.Windows.Forms.Label label1;
    }
}