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

namespace Respaldo
{
    public partial class Form_Gestionar_Creditos : Form
    {
        string Conexion = "server=localhost; port=3306; uid=root; pwd='' ;database=cartera_clientes;";
        bool TieneCredito = false;
        float Cantidadcredito = 0;
        double PorcentInteres = 0;
        private int id_empleado;

        int id_cliente;
        public Form_Gestionar_Creditos(int id_empleado)
        {
            InitializeComponent();
            this.id_empleado = id_empleado;
        }

        private void Form_Gestionar_Creditos_Load(object sender, EventArgs e)
        {
            listar_registros_Créditos();

            DateTime fecha_actual = DateTime.Now;
            dateTimePickerOtorgamiento.CustomFormat = fecha_actual.ToString("yyyy-MM-dd");
            dateTimePickerVigencia.CustomFormat = fecha_actual.ToString("yyyy-MM-dd");
        }
        public void listar_registros_Créditos()
        {
            Class_Funciones_DB listar = new Class_Funciones_DB();
            DataTable registros = listar.ListarRegistros("SELECT ID_CREDITOS, FECHA_OTORGAMIENTO, CANTIDAD_CREDITO,VIGENCIA,SALDO_RESTANTE,INTERES, cliente.NOMBRE_CLIENTE, usuarios.USUARIO FROM creditos JOIN cliente ON creditos.FK_ID_CLIENTE = cliente.ID_CLIENTE JOIN usuarios ON creditos.FK_ID_EMPLEADO = usuarios.ID_USUARIO;");
            
            DataGridView_Creditos.Rows.Clear();
            for (int filas = 0; filas < registros.Rows.Count; filas++)
            {
                DataGridView_Creditos.Rows.Add();
                DataRow fila = registros.Rows[filas];
                for (int colum = 0; colum < registros.Columns.Count; colum++)
                {
                    if (colum == 1 || colum == 3)
                    {
                        DataColumn columna = registros.Columns[colum];
                        string valor = fila[columna].ToString().Substring(0, 10);
                        DataGridView_Creditos.Rows[filas].Cells[colum].Value = valor;
                    }
                    else
                    {
                        DataColumn columna = registros.Columns[colum];
                        string valor = fila[columna].ToString();
                        DataGridView_Creditos.Rows[filas].Cells[colum].Value = valor;
                    }
                }
            }
        }
        public void AgregarCreditos(DateTime FechaOtorgamiento, float CantCredito, DateTime Vigencia, float SaldoRestante, double PorcenInteres, int FK_Cliente, int FKEmpleado)
        {
            MySqlConnection sqlConnection = new MySqlConnection(Conexion);

            sqlConnection.Open();
            MySqlCommand command = new MySqlCommand("INSERT INTO creditos (`ID_CREDITOS`, `FECHA_OTORGAMIENTO`, `CANTIDAD_CREDITO`, `VIGENCIA`, `SALDO_RESTANTE`, `INTERES`, `FK_ID_CLIENTE`, `FK_ID_EMPLEADO`) values (0,@ID_CREDITOS, @FECHA_OTORGAMIENTO, @VIGENCIA, @SALDO_RESTANTE, @INTERES, @FK_CLIENTE, @FK_EMPLEADO);", sqlConnection);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(command);

            command.Parameters.AddWithValue("@ID_CREDITOS", FechaOtorgamiento);
            command.Parameters.AddWithValue("@FECHA_OTORGAMIENTO", CantCredito);
            command.Parameters.AddWithValue("@VIGENCIA", Vigencia);
            command.Parameters.AddWithValue("@SALDO_RESTANTE", SaldoRestante);
            command.Parameters.AddWithValue("@INTERES", PorcenInteres);
            command.Parameters.AddWithValue("@FK_CLIENTE", FK_Cliente);
            command.Parameters.AddWithValue("@FK_EMPLEADO", FKEmpleado);

            MySqlDataReader gconsulta = command.ExecuteReader();
        }

        

        private void Button_AgregarCredito_Click(object sender, EventArgs e)
        {
            verificarClienteConcredito();

            if (TieneCredito)
            {

                MessageBox.Show("Imposible otorgar otro crédito, este cliente tiene un credito pendiente por pagar");
                return;
            }
            else
            {
                DateTime FechaOtorgamiento = dateTimePickerOtorgamiento.Value;
                Cantidadcredito = float.Parse(TextBox_CantCredito.Text);
                DateTime Vigencia = dateTimePickerVigencia.Value;
                float SaldoRestante = float.Parse(TextBox_SaldoRestante.Text);
                PorcentInteres = double.Parse(TextBox_PorcInteres.Text);
                //int FK_ID_Cliente = Convert.ToInt32(TextBox_Id_Cliente.Text);
                //int FK_ID_Empleado = Convert.ToInt32(ComboBox_EmpleadoFK.Text);

                AgregarCreditos(FechaOtorgamiento, Cantidadcredito, Vigencia, SaldoRestante, PorcentInteres, id_cliente, id_empleado);
                listar_registros_Créditos();
            }
        }
        private void verificarClienteConcredito()
        {
            Class_Funciones_DB listar = new Class_Funciones_DB();
            DataTable id = listar.ListarRegistros("SELECT ID_CLIENTE FROM cliente WHERE NOMBRE_CLIENTE ='" + TextBox_nombre_cliente.Text + "';");

            id_cliente = Convert.ToInt32(id.Rows[0][0].ToString());

            DataTable registros = listar.ListarRegistros("SELECT SALDO_RESTANTE FROM creditos WHERE FK_ID_CLIENTE = " + id_cliente + ";");
            if (registros.Rows.Count > 0)
            {
                foreach (DataRow fila in registros.Rows)
                {
                    string SaldoRestante1 = fila["SALDO_RESTANTE"].ToString();
                    float SaldoRestante = float.Parse(SaldoRestante1);

                    if (SaldoRestante > 0)
                    {
                        TieneCredito = true;
                        break; // Si encuentra un saldo mayor a cero, sale del bucle
                    }
                }
            }
            else
            {
                TieneCredito = false;
            }
        }

        private void TextBox_PorcInteres_TextChanged(object sender, EventArgs e)
        {
            if (TextBox_CantCredito.Text == "" || TextBox_PorcInteres.Text == "")
            {
                TextBox_SaldoRestante.Text = "0";
            }
            else
            {
                double Interes = (double.Parse(TextBox_CantCredito.Text) * (double.Parse(TextBox_PorcInteres.Text) / 100));

                TextBox_SaldoRestante.Text = (double.Parse(TextBox_CantCredito.Text) + Interes).ToString();
            }
        }
    }
}
