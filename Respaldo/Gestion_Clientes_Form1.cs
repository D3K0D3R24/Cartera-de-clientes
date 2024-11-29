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
using Guna.UI2.WinForms;

namespace Respaldo
{
    public partial class Gestion_Clientes_Form1 : Form
    {
        string Conexion = "server=localhost; port=3306; uid=root; pwd='' ;database=cartera_clientes;";
        public Gestion_Clientes_Form1()
        {
            InitializeComponent();
        }
        int ID;
        public void eliminar(int id)
        {
            Class_Funciones_DB delete = new Class_Funciones_DB();
            delete.SQL_Query("DELETE FROM cliente WHERE ID_CLIENTE = " + id + ";");
            listar_registros();

            foreach (Control controles in this.Controls)
            {
                if (controles is Guna2TextBox)
                {
                    Guna2TextBox textbox = controles as Guna2TextBox;
                    textbox.Clear();
                    textbox.Enabled = false;
                    ComboBox_Rago.Enabled = false;
                }
            }
        }
        private void DataGridView_Clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7 & e.RowIndex >= 0)
            {
                string id = DataGridView_Clientes.Rows[e.RowIndex].Cells[0].Value.ToString();
                string nombre = DataGridView_Clientes.Rows[e.RowIndex].Cells[1].Value.ToString();
                Mensaje_eliminar abrir = new Mensaje_eliminar(id,nombre);
                abrir.ShowDialog();
            }
            else
            {
                habilitarControls();
                int indice = e.RowIndex;
                ID = Convert.ToInt32(DataGridView_Clientes.Rows[indice].Cells[0].Value);
                TextBox_Nom_Cliente.Text = DataGridView_Clientes.Rows[indice].Cells[1].Value.ToString();
                TextBox_Correo.Text = DataGridView_Clientes.Rows[indice].Cells[2].Value.ToString();
                TextBox_Telefono.Text = DataGridView_Clientes.Rows[indice].Cells[3].Value.ToString();
                TextBox_Direccion.Text = DataGridView_Clientes.Rows[indice].Cells[4].Value.ToString();
                TextBox_Edad.Text = DataGridView_Clientes.Rows[indice].Cells[5].Value.ToString();
                ComboBox_Rago.SelectedItem = DataGridView_Clientes.Rows[indice].Cells[6].Value.ToString();
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

        private void Gestion_Clientes_Form1_Load(object sender, EventArgs e)
        {
            TextBox_Correo.Enabled = false;
            TextBox_Direccion.Enabled = false;
            TextBox_Edad.Enabled = false;
            TextBox_Nom_Cliente.Enabled = false;
            TextBox_Telefono.Enabled = false;
            ComboBox_Rago.Enabled = false;

            listar_registros();
            DataGridView_Clientes.Select();
            Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper scroll = new Guna.UI.Lib.ScrollBar.DataGridViewScrollHelper(DataGridView_Clientes, VScrollBar_Datagrid, true);
        }

        private void Button_update_client_Click(object sender, EventArgs e)
        {
            Actualizar();
            listar_registros();
        }
        public void Actualizar()
        {
            MySqlConnection sqlConnection = new MySqlConnection(Conexion);

            sqlConnection.Open();

            string ComandoSQL = "UPDATE `cliente` SET `NOMBRE_CLIENTE`=@VALOR1, `CORREO`=@VALOR2, `TELEFONO`=@VALOR3, `DIRECCION`=@VALOR4, `EDAD`=@VALOR5, `RANGO`=@VALOR6 WHERE ID_CLIENTE=@ID";

            MySqlCommand command = new MySqlCommand(ComandoSQL, sqlConnection);

            command.Parameters.AddWithValue("@VALOR1", TextBox_Nom_Cliente.Text);
            command.Parameters.AddWithValue("@VALOR2", TextBox_Correo.Text);
            command.Parameters.AddWithValue("@VALOR3", TextBox_Telefono.Text);
            command.Parameters.AddWithValue("@VALOR4", TextBox_Direccion.Text);
            command.Parameters.AddWithValue("@VALOR5", Convert.ToInt32(TextBox_Edad.Text));
            command.Parameters.AddWithValue("@VALOR6", ComboBox_Rago.Text);
            command.Parameters.AddWithValue("@ID", Convert.ToInt32(ID));

            command.ExecuteNonQuery();
            sqlConnection.Close();
        

        }

        private void DataGridView_Clientes_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                habilitarControls();
                int indice = DataGridView_Clientes.CurrentRow.Index;
                ID = Convert.ToInt32(DataGridView_Clientes.Rows[indice].Cells[0].Value);
                TextBox_Nom_Cliente.Text = DataGridView_Clientes.Rows[indice].Cells[1].Value.ToString();
                TextBox_Correo.Text = DataGridView_Clientes.Rows[indice].Cells[2].Value.ToString();
                TextBox_Telefono.Text = DataGridView_Clientes.Rows[indice].Cells[3].Value.ToString();
                TextBox_Direccion.Text = DataGridView_Clientes.Rows[indice].Cells[4].Value.ToString();
                TextBox_Edad.Text = DataGridView_Clientes.Rows[indice].Cells[5].Value.ToString();
                ComboBox_Rago.SelectedItem = DataGridView_Clientes.Rows[indice].Cells[6].Value.ToString();
            }
        }

        private void Gestion_Clientes_Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                DataGridView_Clientes.Rows[0].Selected = true;
                habilitarControls();
            }
            
        }
        private void habilitarControls()
        {
            TextBox_Correo.Enabled = true;
            TextBox_Direccion.Enabled = true;
            TextBox_Edad.Enabled = true;
            TextBox_Nom_Cliente.Enabled = true;
            TextBox_Telefono.Enabled = true;
            ComboBox_Rago.Enabled = true;
        }
    }
}
