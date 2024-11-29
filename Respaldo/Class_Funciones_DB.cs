using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Respaldo
{
    class Class_Funciones_DB
    {
        private static Class_Funciones_DB instance;
        public string logged_user { get; set; }
        //public static List<Class_Funciones_DB> Instancias_clases_Funciones = new List<Class_Funciones_DB>();
        public string vServidor { get; set; }
        public string vUsuario { get; set; }
        public string vPassword { get; set; }
        public string vBaseDeDatos { get; set; }

        public static MySqlConnection SQLConnection = new MySqlConnection();
        string vServerString = "";
        string vEstatus_Conexion = "";

        public static Class_Funciones_DB obtener_instancia()
        {
            if (instance == null)
            {
                instance = new Class_Funciones_DB();
            }
            return instance;
        }

        public int ABRIR_CONEXION_DB_MYSQL(Class_Funciones_DB vObjConexion)
        {
            int vResultado = 1;
            vServerString = ("Server="
                        + (vObjConexion.vServidor + (";" + ("user Id="
                        + (vObjConexion.vUsuario + (";" + ("Password="
                        + (vObjConexion.vPassword + (";" + ("Database=" + vObjConexion.vBaseDeDatos))))))))));
            SQLConnection.Close();
            SQLConnection.ConnectionString = vServerString;
            try
            {
                if ((SQLConnection.State == ConnectionState.Closed))
                {
                    SQLConnection.Open();
                    vResultado = 0;
                    vEstatus_Conexion = "OPEN";
                    return vResultado;
                }
                else
                {
                    SQLConnection.Close();
                    vResultado = 1;
                    vEstatus_Conexion = "CLOSE";
                    return vResultado;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

            return vResultado;
        }
        public DataTable ListarRegistros(string vSQL)
        {
            MySqlDataAdapter vAdaptador = new MySqlDataAdapter(vSQL, Class_Funciones_DB.SQLConnection);
            DataTable vTable = new DataTable();
            vAdaptador.Fill(vTable);
            Class_Funciones_DB.SQLConnection.Close();
            Class_Funciones_DB.SQLConnection.Dispose();
            return vTable;
        }

        public DataTable SQL_Query(string vSQL)
        {
            DataTable vTable = new DataTable();
            try
            {
                MySqlDataAdapter vAdaptador = new MySqlDataAdapter(vSQL, Class_Funciones_DB.SQLConnection);
                
                vAdaptador.Fill(vTable);
                Class_Funciones_DB.SQLConnection.Close();
                Class_Funciones_DB.SQLConnection.Dispose();
                
            }
            catch (Exception ex) 
            {

            }
            return vTable;
        }
    }
}
