﻿namespace Respaldo
{
    partial class Gestion_Clientes_Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_Clientes_Form1));
            this.DataGridView_Clientes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Button_update_client = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ComboBox_Rago = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TextBox_Edad = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_Direccion = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_Telefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_Correo = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_Nom_Cliente = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.VScrollBar_Datagrid = new Guna.UI.WinForms.GunaVScrollBar();
            this.Column_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_NombreC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Rango = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView_Clientes
            // 
            this.DataGridView_Clientes.AllowUserToAddRows = false;
            this.DataGridView_Clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_Clientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.DataGridView_Clientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_Clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_Clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(209)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_Clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_Clientes.ColumnHeadersHeight = 35;
            this.DataGridView_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_ID,
            this.Column_NombreC,
            this.Column_Correo,
            this.Column_Telefono,
            this.Column_Direccion,
            this.Column_Edad,
            this.Column_Rango,
            this.Column_Eliminar});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(134)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_Clientes.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView_Clientes.EnableHeadersVisualStyles = false;
            this.DataGridView_Clientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.DataGridView_Clientes.Location = new System.Drawing.Point(74, 93);
            this.DataGridView_Clientes.MultiSelect = false;
            this.DataGridView_Clientes.Name = "DataGridView_Clientes";
            this.DataGridView_Clientes.RowHeadersVisible = false;
            this.DataGridView_Clientes.RowTemplate.Height = 35;
            this.DataGridView_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_Clientes.Size = new System.Drawing.Size(845, 218);
            this.DataGridView_Clientes.TabIndex = 29;
            this.DataGridView_Clientes.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGridView_Clientes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Empty;
            this.DataGridView_Clientes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_Clientes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_Clientes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_Clientes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_Clientes.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.DataGridView_Clientes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.DataGridView_Clientes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(209)))));
            this.DataGridView_Clientes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_Clientes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_Clientes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_Clientes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_Clientes.ThemeStyle.HeaderStyle.Height = 35;
            this.DataGridView_Clientes.ThemeStyle.ReadOnly = false;
            this.DataGridView_Clientes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.DataGridView_Clientes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_Clientes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView_Clientes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_Clientes.ThemeStyle.RowsStyle.Height = 35;
            this.DataGridView_Clientes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.DataGridView_Clientes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(134)))), ((int)(((byte)(224)))));
            this.DataGridView_Clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Clientes_CellClick);
            this.DataGridView_Clientes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DataGridView_Clientes_KeyUp);
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(74, 25);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(167, 26);
            this.guna2HtmlLabel7.TabIndex = 28;
            this.guna2HtmlLabel7.Text = "Gestionar clientes";
            // 
            // Button_update_client
            // 
            this.Button_update_client.Animated = true;
            this.Button_update_client.AutoRoundedCorners = true;
            this.Button_update_client.BorderRadius = 21;
            this.Button_update_client.CheckedState.Parent = this.Button_update_client;
            this.Button_update_client.CustomImages.Parent = this.Button_update_client;
            this.Button_update_client.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(134)))), ((int)(((byte)(224)))));
            this.Button_update_client.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_update_client.ForeColor = System.Drawing.Color.White;
            this.Button_update_client.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(209)))));
            this.Button_update_client.HoverState.Parent = this.Button_update_client;
            this.Button_update_client.Location = new System.Drawing.Point(396, 506);
            this.Button_update_client.Name = "Button_update_client";
            this.Button_update_client.ShadowDecoration.Parent = this.Button_update_client;
            this.Button_update_client.Size = new System.Drawing.Size(200, 45);
            this.Button_update_client.TabIndex = 27;
            this.Button_update_client.Text = "Actualizar";
            this.Button_update_client.Click += new System.EventHandler(this.Button_update_client_Click);
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(719, 412);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(45, 20);
            this.guna2HtmlLabel6.TabIndex = 26;
            this.guna2HtmlLabel6.Text = "Rango";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(396, 412);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(36, 20);
            this.guna2HtmlLabel5.TabIndex = 25;
            this.guna2HtmlLabel5.Text = "Edad";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(74, 412);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(65, 20);
            this.guna2HtmlLabel4.TabIndex = 24;
            this.guna2HtmlLabel4.Text = "Dirección";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(719, 334);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(59, 20);
            this.guna2HtmlLabel3.TabIndex = 23;
            this.guna2HtmlLabel3.Text = "Teléfono";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(396, 334);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(125, 20);
            this.guna2HtmlLabel2.TabIndex = 22;
            this.guna2HtmlLabel2.Text = "Correo electronico";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(74, 334);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(129, 20);
            this.guna2HtmlLabel1.TabIndex = 21;
            this.guna2HtmlLabel1.Text = "Nombre del cliente";
            // 
            // ComboBox_Rago
            // 
            this.ComboBox_Rago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.ComboBox_Rago.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(209)))));
            this.ComboBox_Rago.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_Rago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Rago.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.ComboBox_Rago.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBox_Rago.FocusedState.Parent = this.ComboBox_Rago;
            this.ComboBox_Rago.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBox_Rago.ForeColor = System.Drawing.Color.White;
            this.ComboBox_Rago.FormattingEnabled = true;
            this.ComboBox_Rago.HoverState.Parent = this.ComboBox_Rago;
            this.ComboBox_Rago.ItemHeight = 30;
            this.ComboBox_Rago.Items.AddRange(new object[] {
            "Inicial",
            "Activo",
            "Moroso"});
            this.ComboBox_Rago.ItemsAppearance.Parent = this.ComboBox_Rago;
            this.ComboBox_Rago.Location = new System.Drawing.Point(719, 438);
            this.ComboBox_Rago.Name = "ComboBox_Rago";
            this.ComboBox_Rago.ShadowDecoration.Parent = this.ComboBox_Rago;
            this.ComboBox_Rago.Size = new System.Drawing.Size(200, 36);
            this.ComboBox_Rago.StartIndex = 0;
            this.ComboBox_Rago.TabIndex = 20;
            // 
            // TextBox_Edad
            // 
            this.TextBox_Edad.Animated = true;
            this.TextBox_Edad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.TextBox_Edad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(209)))));
            this.TextBox_Edad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Edad.DefaultText = "";
            this.TextBox_Edad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.TextBox_Edad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.TextBox_Edad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Edad.DisabledState.Parent = this.TextBox_Edad;
            this.TextBox_Edad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Edad.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.TextBox_Edad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Edad.FocusedState.Parent = this.TextBox_Edad;
            this.TextBox_Edad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Edad.HoverState.Parent = this.TextBox_Edad;
            this.TextBox_Edad.Location = new System.Drawing.Point(396, 438);
            this.TextBox_Edad.Name = "TextBox_Edad";
            this.TextBox_Edad.PasswordChar = '\0';
            this.TextBox_Edad.PlaceholderText = "";
            this.TextBox_Edad.SelectedText = "";
            this.TextBox_Edad.ShadowDecoration.Parent = this.TextBox_Edad;
            this.TextBox_Edad.Size = new System.Drawing.Size(200, 36);
            this.TextBox_Edad.TabIndex = 19;
            // 
            // TextBox_Direccion
            // 
            this.TextBox_Direccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.TextBox_Direccion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(209)))));
            this.TextBox_Direccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Direccion.DefaultText = "";
            this.TextBox_Direccion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.TextBox_Direccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.TextBox_Direccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Direccion.DisabledState.Parent = this.TextBox_Direccion;
            this.TextBox_Direccion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Direccion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.TextBox_Direccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Direccion.FocusedState.Parent = this.TextBox_Direccion;
            this.TextBox_Direccion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Direccion.HoverState.Parent = this.TextBox_Direccion;
            this.TextBox_Direccion.Location = new System.Drawing.Point(74, 438);
            this.TextBox_Direccion.Name = "TextBox_Direccion";
            this.TextBox_Direccion.PasswordChar = '\0';
            this.TextBox_Direccion.PlaceholderText = "";
            this.TextBox_Direccion.SelectedText = "";
            this.TextBox_Direccion.ShadowDecoration.Parent = this.TextBox_Direccion;
            this.TextBox_Direccion.Size = new System.Drawing.Size(200, 36);
            this.TextBox_Direccion.TabIndex = 18;
            // 
            // TextBox_Telefono
            // 
            this.TextBox_Telefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.TextBox_Telefono.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(209)))));
            this.TextBox_Telefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Telefono.DefaultText = "";
            this.TextBox_Telefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.TextBox_Telefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.TextBox_Telefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Telefono.DisabledState.Parent = this.TextBox_Telefono;
            this.TextBox_Telefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Telefono.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.TextBox_Telefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Telefono.FocusedState.Parent = this.TextBox_Telefono;
            this.TextBox_Telefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Telefono.HoverState.Parent = this.TextBox_Telefono;
            this.TextBox_Telefono.Location = new System.Drawing.Point(719, 360);
            this.TextBox_Telefono.Name = "TextBox_Telefono";
            this.TextBox_Telefono.PasswordChar = '\0';
            this.TextBox_Telefono.PlaceholderText = "";
            this.TextBox_Telefono.SelectedText = "";
            this.TextBox_Telefono.ShadowDecoration.Parent = this.TextBox_Telefono;
            this.TextBox_Telefono.Size = new System.Drawing.Size(200, 36);
            this.TextBox_Telefono.TabIndex = 17;
            // 
            // TextBox_Correo
            // 
            this.TextBox_Correo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.TextBox_Correo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(209)))));
            this.TextBox_Correo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Correo.DefaultText = "";
            this.TextBox_Correo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.TextBox_Correo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.TextBox_Correo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Correo.DisabledState.Parent = this.TextBox_Correo;
            this.TextBox_Correo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Correo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.TextBox_Correo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Correo.FocusedState.Parent = this.TextBox_Correo;
            this.TextBox_Correo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Correo.HoverState.Parent = this.TextBox_Correo;
            this.TextBox_Correo.Location = new System.Drawing.Point(396, 360);
            this.TextBox_Correo.Name = "TextBox_Correo";
            this.TextBox_Correo.PasswordChar = '\0';
            this.TextBox_Correo.PlaceholderText = "";
            this.TextBox_Correo.SelectedText = "";
            this.TextBox_Correo.ShadowDecoration.Parent = this.TextBox_Correo;
            this.TextBox_Correo.Size = new System.Drawing.Size(200, 36);
            this.TextBox_Correo.TabIndex = 16;
            // 
            // TextBox_Nom_Cliente
            // 
            this.TextBox_Nom_Cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.TextBox_Nom_Cliente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(209)))));
            this.TextBox_Nom_Cliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Nom_Cliente.DefaultText = "";
            this.TextBox_Nom_Cliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.TextBox_Nom_Cliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.TextBox_Nom_Cliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Nom_Cliente.DisabledState.Parent = this.TextBox_Nom_Cliente;
            this.TextBox_Nom_Cliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_Nom_Cliente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.TextBox_Nom_Cliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Nom_Cliente.FocusedState.Parent = this.TextBox_Nom_Cliente;
            this.TextBox_Nom_Cliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_Nom_Cliente.HoverState.Parent = this.TextBox_Nom_Cliente;
            this.TextBox_Nom_Cliente.Location = new System.Drawing.Point(74, 360);
            this.TextBox_Nom_Cliente.Name = "TextBox_Nom_Cliente";
            this.TextBox_Nom_Cliente.PasswordChar = '\0';
            this.TextBox_Nom_Cliente.PlaceholderText = "";
            this.TextBox_Nom_Cliente.SelectedText = "";
            this.TextBox_Nom_Cliente.ShadowDecoration.Parent = this.TextBox_Nom_Cliente;
            this.TextBox_Nom_Cliente.Size = new System.Drawing.Size(200, 36);
            this.TextBox_Nom_Cliente.TabIndex = 15;
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Bahnschrift", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.DimGray;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(74, 67);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(487, 20);
            this.guna2HtmlLabel8.TabIndex = 30;
            this.guna2HtmlLabel8.Text = "De clic sobre un cliente para editar o mueva las flechas de arriba o abajo";
            // 
            // VScrollBar_Datagrid
            // 
            this.VScrollBar_Datagrid.LargeChange = 10;
            this.VScrollBar_Datagrid.Location = new System.Drawing.Point(925, 93);
            this.VScrollBar_Datagrid.Maximum = 100;
            this.VScrollBar_Datagrid.Name = "VScrollBar_Datagrid";
            this.VScrollBar_Datagrid.ScrollIdleColor = System.Drawing.Color.Silver;
            this.VScrollBar_Datagrid.Size = new System.Drawing.Size(11, 218);
            this.VScrollBar_Datagrid.TabIndex = 31;
            this.VScrollBar_Datagrid.ThumbColor = System.Drawing.Color.DimGray;
            this.VScrollBar_Datagrid.ThumbHoverColor = System.Drawing.Color.Gray;
            this.VScrollBar_Datagrid.ThumbPressedColor = System.Drawing.Color.DarkGray;
            // 
            // Column_ID
            // 
            this.Column_ID.FillWeight = 42.6396F;
            this.Column_ID.HeaderText = "ID";
            this.Column_ID.Name = "Column_ID";
            // 
            // Column_NombreC
            // 
            this.Column_NombreC.FillWeight = 109.5601F;
            this.Column_NombreC.HeaderText = "Nombre cliente";
            this.Column_NombreC.Name = "Column_NombreC";
            // 
            // Column_Correo
            // 
            this.Column_Correo.FillWeight = 109.5601F;
            this.Column_Correo.HeaderText = "Correo";
            this.Column_Correo.Name = "Column_Correo";
            // 
            // Column_Telefono
            // 
            this.Column_Telefono.FillWeight = 109.5601F;
            this.Column_Telefono.HeaderText = "Teléfono";
            this.Column_Telefono.Name = "Column_Telefono";
            // 
            // Column_Direccion
            // 
            this.Column_Direccion.FillWeight = 109.5601F;
            this.Column_Direccion.HeaderText = "Dirección";
            this.Column_Direccion.Name = "Column_Direccion";
            // 
            // Column_Edad
            // 
            this.Column_Edad.FillWeight = 109.5601F;
            this.Column_Edad.HeaderText = "Edad";
            this.Column_Edad.Name = "Column_Edad";
            // 
            // Column_Rango
            // 
            this.Column_Rango.FillWeight = 109.5601F;
            this.Column_Rango.HeaderText = "Rango";
            this.Column_Rango.Name = "Column_Rango";
            // 
            // Column_Eliminar
            // 
            this.Column_Eliminar.Description = "Dar de baja por fallecimiento";
            this.Column_Eliminar.HeaderText = "Eliminar";
            this.Column_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Column_Eliminar.Image")));
            this.Column_Eliminar.Name = "Column_Eliminar";
            // 
            // Gestion_Clientes_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(992, 568);
            this.Controls.Add(this.VScrollBar_Datagrid);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.DataGridView_Clientes);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.Button_update_client);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.ComboBox_Rago);
            this.Controls.Add(this.TextBox_Edad);
            this.Controls.Add(this.TextBox_Direccion);
            this.Controls.Add(this.TextBox_Telefono);
            this.Controls.Add(this.TextBox_Correo);
            this.Controls.Add(this.TextBox_Nom_Cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gestion_Clientes_Form1";
            this.Text = "Gestion_Clientes_Form1";
            this.Load += new System.EventHandler(this.Gestion_Clientes_Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Gestion_Clientes_Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_Clientes;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2Button Button_update_client;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox_Rago;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Edad;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Direccion;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Telefono;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Correo;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_Nom_Cliente;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI.WinForms.GunaVScrollBar VScrollBar_Datagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_NombreC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Rango;
        private System.Windows.Forms.DataGridViewImageColumn Column_Eliminar;
    }
}