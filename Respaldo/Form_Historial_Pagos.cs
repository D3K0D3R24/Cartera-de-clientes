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
using Guna.UI.Lib;

namespace Respaldo
{
    public partial class Form_Historial_Pagos : Form
    {
        string Conexion = "server=localhost; port=3306; uid=root; pwd='' ;database=cartera_clientes;";
        public Form_Historial_Pagos()
        {
            InitializeComponent();
        }

        private void Form_Historial_Pagos_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper scroll = new Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(DtgHistorialPagos, VScrollBar_Datagrid, true);
            EjecutarConsulta();
        }
        public void EjecutarConsulta()
        {
            /*SELECT FK_ID_CLIENTE, cliente.NOMBRE_CLIENTE, ID_PAGO, FECHA_PAGO, CANTIDAD_PAGO, usuarios.USUARIO 
FROM pagos
JOIN usuarios ON pagos.FK_ID_EMPLEADO = usuarios.ID_USUARIO
JOIN cliente ON pagos.FK_ID_CLIENTE = cliente.ID_CLIENTE;*/
            MySqlConnection sqlConnection = new MySqlConnection(Conexion);

            sqlConnection.Open();
            string consultaSQL = "SELECT FK_ID_CLIENTE AS ID_CLIENTE, cliente.NOMBRE_CLIENTE, ID_PAGO, FECHA_PAGO, CANTIDAD_PAGO, usuarios.USUARIO FROM pagos JOIN usuarios ON pagos.FK_ID_EMPLEADO = usuarios.ID_USUARIO JOIN cliente ON pagos.FK_ID_CLIENTE = cliente.ID_CLIENTE;";
            
            MySqlCommand command = new MySqlCommand(consultaSQL, sqlConnection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            DtgHistorialPagos.DataSource = dataTable;

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection sqlConnection = new MySqlConnection(Conexion);

                sqlConnection.Open();
                string consultaSQL = "SELECT FK_ID_CLIENTE AS ID_CLIENTE, cliente.NOMBRE_CLIENTE, ID_PAGO, FECHA_PAGO, CANTIDAD_PAGO, usuarios.USUARIO FROM pagos JOIN usuarios ON pagos.FK_ID_EMPLEADO = usuarios.ID_USUARIO JOIN cliente ON pagos.FK_ID_CLIENTE = cliente.ID_CLIENTE WHERE cliente.NOMBRE_CLIENTE ='" + TextBBuscar.Text+"';";
                MySqlCommand command = new MySqlCommand(consultaSQL, sqlConnection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                DtgHistorialPagos.DataSource = null;

                DataTable dataTable = new DataTable();

                DtgHistorialPagos.Columns.Clear();
                DtgHistorialPagos.Rows.Clear();

                adapter.Fill(dataTable);

                DtgHistorialPagos.DataSource = dataTable;
            }
            catch (Exception ex)
            {

            }
        }

        private void TextBBuscar_TextChanged(object sender, EventArgs e)
        {
            EjecutarConsulta();
        }
    }
}
