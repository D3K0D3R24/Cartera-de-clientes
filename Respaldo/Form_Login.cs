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
    public partial class Form_Login : Form
    {
        int clic = 0;
        public Form_Login()
        {
            InitializeComponent();
        }


        MySqlConnection conexion = new MySqlConnection("server=localhost; port=3306; uid=root; pwd='';database=cartera_clientes;");
        private void Form_Login_Load(object sender, EventArgs e)
        {
            Label_Welcome.Parent = pictureBox_IMG;
            Label_Welcome.BackColor = Color.Transparent;

            DataTable tabla = new DataTable();
            MySqlCommand comando = new MySqlCommand("SELECT USUARIO from usuarios", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            adaptador.Fill(tabla);
            ComboBox_Users.DataSource = tabla;
            ComboBox_Users.DisplayMember = "usuarios";
            ComboBox_Users.ValueMember = "USUARIO";
            conexion.Close();
            TextBox1Password.Select();
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            if (TextBox1Password.Text.Trim().Equals(""))
            {
                MessageBox.Show("Faltan campos por llenar");
            }
            else
            {
                validar();
            }
            
        }
        string user, pass;
        private void ComboBox_Users_SelectedIndexChanged(object sender, EventArgs e)
        {
            user = ComboBox_Users.Text;
        }

        public void validar()
        {
            conexion.Open();
            pass = TextBox1Password.Text;
            MySqlCommand comand = new MySqlCommand("Select USUARIO, PASSWORD from usuarios where USUARIO=@USER and PASSWORD=@PASSWD", conexion);
            comand.Parameters.AddWithValue("@USER", user);
            comand.Parameters.AddWithValue("@PASSWD", pass);
            MySqlDataReader gconsulta = comand.ExecuteReader();
            if (gconsulta.Read())
            {
                Form_Principal_Ventana V_Principal = new Form_Principal_Ventana(ComboBox_Users.Text.Trim()); 
                V_Principal.Show();
                conexion.Close();
                this.Hide();
                Class_Funciones_DB instance = Class_Funciones_DB.obtener_instancia();
                instance.logged_user = ComboBox_Users.Text;
            }
            else
            {
                conexion.Close();
            }
        }

        private void Button_Cerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TextBox1Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                validar();
            }
        }

        private void ButtonPasswd_Click_1(object sender, EventArgs e)
        {
            clic++;
            if (clic != 1)
            {
                TextBox1Password.PasswordChar = '•';
                clic = 0;
            }
            else
            {
                TextBox1Password.PasswordChar = '\0';
            }
        }
    }
}
