using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Respaldo
{
    public partial class Form_Principal_Ventana : Form
    {
        public string logged_user;
        public Form_Principal_Ventana(string logged_user)
        {
            InitializeComponent();
            this.logged_user = logged_user;
        }

        private void Form_Principal_Ventana_Load(object sender, EventArgs e)
        {
            abrirforms(new Form_Home());

            Class_Funciones_DB objeto = new Class_Funciones_DB();
            
            objeto.vServidor = "Localhost";
            objeto.vPassword = "";
            objeto.vUsuario = "root";
            objeto.vBaseDeDatos = "cartera_clientes";
           
            int vResultado = objeto.ABRIR_CONEXION_DB_MYSQL(objeto);
            switch (vResultado)
            {
                case 0:
                    DataTable vDatos = objeto.ListarRegistros("select * from cliente;");
                    //guna2DataGridView1.DataSource = vDatos;
                    break;
                case 1:
                    return;
                    break;
            }

            if (logged_user == "Administrador")
            {
                Button_Add_User.Visible = true;
            }
            else
            {
                Button_Add_User.Visible = false;
            }

        }

        private void Button_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Respaldo_Click(object sender, EventArgs e)
        {
            abrirforms(new Form_Backup());
            
        }
        public void abrirforms(Form nameForm)
        {
            while (panel_principal.Controls.Count > 0)
            {
                panel_principal.Controls.RemoveAt(0);
            }
            Form formHijo = nameForm;
            formHijo.TopLevel = false;
            formHijo.Dock = DockStyle.Fill;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            panel_principal.Controls.Add(formHijo);
            formHijo.Show();
        }

        private void Button_Home_Click(object sender, EventArgs e)
        {
            abrirforms(new Form_Home());
        }

        private void Button_Clientes_Click(object sender, EventArgs e)
        {
            abrirforms(new Ventana_Clientes_Form());
        }

        private void Button_Creditos_Click(object sender, EventArgs e)
        {
            Class_Funciones_DB id_empleado = new Class_Funciones_DB();
            DataTable id = id_empleado.SQL_Query("SELECT ID_USUARIO FROM usuarios WHERE USUARIO = '" + logged_user+"';");
            int ID_EMPLEADO = Convert.ToInt32(id.Rows[0][0].ToString());
            
            abrirforms(new Form_Gestionar_Creditos(ID_EMPLEADO));
        }

        private void Button_pagos_Click(object sender, EventArgs e)
        {
            Class_Funciones_DB consulta = new Class_Funciones_DB();
            //MessageBox.Show(logged_user);
            DataTable id = consulta.SQL_Query("SELECT ID_USUARIO FROM usuarios WHERE USUARIO ='" + logged_user + "';");
            int id_empleado = Convert.ToInt32(id.Rows[0][0].ToString());
            
            abrirforms(new Form_Pagos(id_empleado)); 
        }

        private void Button_Notificaciones_Click(object sender, EventArgs e)
        {
            abrirforms(new Ventana_Notificaciones_Form());
        }

        private void Button_Add_User_Click(object sender, EventArgs e)
        {
            Form_Creacion_Usuarios abrir = new Form_Creacion_Usuarios();
            abrir.ShowDialog();
        }
    }
}
