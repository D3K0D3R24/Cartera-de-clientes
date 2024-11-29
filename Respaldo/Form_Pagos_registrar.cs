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
    public partial class Form_Pagos_registrar : Form
    {
        private int id_log;
        public Form_Pagos_registrar(int id_log)
        {
            InitializeComponent();
            this.id_log = id_log;

        }
        string Conexion = "server=localhost; port=3306; uid=root; pwd='' ;database=cartera_clientes;";
        int? id_cliente;
        int? id_credito;
        int? id_empleado;
        int id_pago;
        
        
        private void Form_Pagos_registrar_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            dateTimePickerFecha.CustomFormat = fecha.ToString("yyy-MM-dd");
            
        }

        private void ComboBox_Cliente_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
        Class_Funciones_DB pagar = new Class_Funciones_DB();
        float? saldo_restante;
        private void Button_Pagar_Click(object sender, EventArgs e)
        {
            if (saldo_restante > 0)
            {
                DateTime Fecha = dateTimePickerFecha.Value;
                float Cantidad = Convert.ToSingle(TextBox_cantidad_pago.Text);
                saldo_restante = Convert.ToSingle(TextBox_Saldo_Restante.Text) - Convert.ToInt32(TextBox_cantidad_pago.Text);
                pagar.SQL_Query("UPDATE creditos SET SALDO_RESTANTE = " + saldo_restante + " WHERE ID_CREDITOS=" + id_credito + ";");

                //pagar.SQL_Query("INSERT INTO pagos (ID_PAGO, FECHA_PAGO, CANTIDAD_PAGO,	FK_ID_CLIENTE,	FK_ID_EMPLEADO,	FK_ID_CREDITO) \r\n" +
                //   "values (" + id_pago + ",'" + TextBox_Fecha_pago.Text + "'," + TextBox_cantidad_pago.Text + "," + id_cliente + "," + id_empleado + "," + id_credito + ");");
                AgregarPago(id_pago, Fecha, Cantidad, id_cliente, id_empleado, id_credito, saldo_restante);
                update_valor();
            }
            else
            {
                MessageBox.Show("Crédito pagado");
            }
        }
        public void AgregarPago(int id_pago, DateTime Fecha, float Cantidad, int? id_cliente, int? empleado, int? id_credito, float? SaldoRestante)
        {
            try
            {

                MySqlConnection sqlConnection = new MySqlConnection(Conexion);

                sqlConnection.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO pagos (`ID_PAGO`, `FECHA_PAGO`, `CANTIDAD_PAGO`, `FK_ID_CLIENTE`, `FK_ID_EMPLEADO`, `FK_ID_CREDITO`) values (@ID_PAGO, @FECHA_PAGO, @CANTIDAD_PAGO, @FK_ID_CLIENTE, @FK_ID_EMPLEADO, @FK_ID_CREDITO);", sqlConnection);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(command);

                command.Parameters.AddWithValue("@ID_PAGO", id_pago);
                command.Parameters.AddWithValue("@FECHA_PAGO", Fecha);
                command.Parameters.AddWithValue("@CANTIDAD_PAGO", Cantidad);
                command.Parameters.AddWithValue("@FK_ID_CLIENTE", id_cliente);
                command.Parameters.AddWithValue("@FK_ID_EMPLEADO", empleado);
                command.Parameters.AddWithValue("@FK_ID_CREDITO", id_credito);

                MySqlDataReader gconsulta = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al insertar los registros");
            }
        }
        private void update_valor() 
        {
            try
            {
                DataTable nombre = pagar.SQL_Query("SELECT ID_CLIENTE FROM cliente WHERE NOMBRE_CLIENTE = '"+TextBox_Nombre_Cliente.Text+"';");
                id_cliente = Convert.ToInt32(nombre.Rows[0][0].ToString());

                DataTable info = pagar.SQL_Query("SELECT * FROM creditos WHERE FK_ID_CLIENTE = " + id_cliente + " AND SALDO_RESTANTE>0;");
                
                
                if (info.Rows.Count >= 0)
                {   
                    TextBox_ID_Credito.Text = info.Rows[0][0].ToString();
                    TextBox_Cant_Credito.Text = info.Rows[0][2].ToString();
                    TextBox_Saldo_Restante.Text = info.Rows[0][4].ToString();
                    TextBox_Vigencia.Text = info.Rows[0][3].ToString();
                    TextBox_Fecha_otorgamiento.Text = info.Rows[0][1].ToString();

                    id_credito = Convert.ToInt32(info.Rows[0][0].ToString());
                    id_cliente = Convert.ToInt32(info.Rows[0][6].ToString());
                    id_empleado = id_log;
                    saldo_restante = Convert.ToSingle(info.Rows[0][4].ToString());
                }
                else
                {
                    TextBox_Nombre_Cliente.Clear();
                    TextBox_Cant_Credito.Clear();
                    TextBox_Saldo_Restante.Clear();
                    TextBox_Vigencia.Clear();
                    TextBox_Fecha_otorgamiento.Clear();

                    id_credito = null;
                    id_cliente = null;
                    //id_empleado = null;
                    saldo_restante = null;
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void TextBox_Nombre_Cliente_TextChanged(object sender, EventArgs e)
        {
            update_valor();
        }
    }
}
