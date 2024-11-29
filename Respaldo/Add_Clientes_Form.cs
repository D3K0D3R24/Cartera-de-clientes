using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Guna.UI2.WinForms;

namespace Respaldo
{
    public partial class Add_Clientes_Form : Form
    {
        string Conexion = "server=localhost; port=3306; uid=root; pwd='' ;database=cartera_clientes;";
        public Add_Clientes_Form()
        {
            InitializeComponent();
        }

        private void Add_Clientes_Form_Load(object sender, EventArgs e)
        {
            listar_registros();
        }

        private void Button_add_client_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TextBox_Edad.Text) <= 17)
            {
                MessageBox.Show("No cumple con la edad requerida");
            }
            else
            {
                string nombre = TextBox_Nom_Cliente.Text;
                string correo = TextBox_Correo.Text;
                string telefono = TextBox_Telefono.Text;
                string direccion = TextBox_Direccion.Text;
                int edad = Convert.ToInt32(TextBox_Edad.Text);
                string rango = ComboBox_Rago.Text;
                AgregarClientes(nombre, correo, telefono, direccion, edad, rango);
                listar_registros();
            }
        }
        public void listar_registros()
        {
            Class_Funciones_DB listar = new Class_Funciones_DB();
            DataTable registros = listar.ListarRegistros("SELECT ID_CLIENTE, NOMBRE_CLIENTE, CORREO, TELEFONO, DIRECCION, EDAD, RANGO FROM cliente");

            DataGridView_Clientes.Rows.Clear();
            for (int filas = 0; filas < registros.Rows.Count; filas++)
            {
                DataGridView_Clientes.Rows.Add();
                DataRow fila = registros.Rows[filas];
                for (int colum = 0; colum < registros.Columns.Count; colum++)
                {
                    DataColumn columna = registros.Columns[colum];
                    string valor = fila[columna].ToString();
                    DataGridView_Clientes.Rows[filas].Cells[colum].Value = valor;
                }
            }
        }
        public void AgregarClientes(string nombre, string correo, string telefono, string direccion, int edad, string rango)
        {
            MySqlConnection sqlConnection = new MySqlConnection(Conexion);

            sqlConnection.Open();
            MySqlCommand command = new MySqlCommand("INSERT INTO cliente (`ID_CLIENTE`, `NOMBRE_CLIENTE`, `CORREO`, `TELEFONO`, `DIRECCION`, `EDAD`, `RANGO`) values (0,@NOMBRE, @CORREO, @TELEFONO,@DIRECCION,@EDAD,@RANGO);", sqlConnection);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(command);
            
            command.Parameters.AddWithValue("@NOMBRE", nombre);
            command.Parameters.AddWithValue("@CORREO", correo);
            command.Parameters.AddWithValue("@TELEFONO", telefono);
            command.Parameters.AddWithValue("@DIRECCION", direccion);
            command.Parameters.AddWithValue("@EDAD", edad);
            command.Parameters.AddWithValue("@RANGO", rango);

            MySqlDataReader gconsulta = command.ExecuteReader();
        }
    }
}
