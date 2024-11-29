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
    public partial class Form_Creacion_Usuarios : Form
    {
        string Conexion = "server=localhost; port=3306; uid=root; pwd='' ;database=cartera_clientes;";
        public Form_Creacion_Usuarios()
        {
            InitializeComponent();
        }

        private void Button_create_Click(object sender, EventArgs e)
        {
            int id = 0;
            MySqlConnection sqlConnection = new MySqlConnection(Conexion);

            sqlConnection.Open();
            MySqlCommand command = new MySqlCommand("INSERT INTO usuarios (`ID_USUARIO`, `USUARIO`, `PASSWORD`) values (0,@USUARIO, @PASSWORD);", sqlConnection);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(command);

            command.Parameters.AddWithValue("@ID_USUARIO", id);
            command.Parameters.AddWithValue("@USUARIO", TextBox_Nom_usuario.Text);
            command.Parameters.AddWithValue("@PASSWORD", TextBox_passoword.Text);

            MySqlDataReader gconsulta = command.ExecuteReader();
            this.Close();
            this.Dispose();
        }
    }
}
