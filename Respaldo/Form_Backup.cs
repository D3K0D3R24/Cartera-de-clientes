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
    public partial class Form_Backup : Form
    {
        string DMA = System.DateTime.Now.ToLongDateString();
        string Hora = System.DateTime.Now.ToLongTimeString();
        MySqlConnection conexion = new MySqlConnection("server=localhost; port=3306; uid=root; pwd='';database=cartera_clientes;");
        public Form_Backup()
        {
            InitializeComponent();
        }
        

        private void Button_Respaldar_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Filter = "Archivos de respaldo de MySQL (*.sql)|*.sql";
                Hora = Hora.Replace(":", " ");
                string nombrearchivo = (DMA + " " + Hora);
                saveFileDialog1.FileName = nombrearchivo;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string ruta = saveFileDialog1.FileName;

                    MySqlCommand comando = new MySqlCommand();
                    MySqlBackup Backup = new MySqlBackup(comando);

                    comando.Connection = conexion;
                    conexion.Open();
                    Backup.ExportToFile(ruta);
                    conexion.Close();

                    MessageBox.Show("RESPALDO GUARDADO");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo: {ex.Message}");
            }
        }

        private void Button_Restaurar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            try
            {
                openFileDialog1.Filter = "Archivos de respaldo de MySQL (*.sql)|*.sql";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string ruta = openFileDialog1.FileName;

                    MySqlCommand comando = new MySqlCommand();
                    MySqlBackup Restore = new MySqlBackup(comando);

                    comando.Connection = conexion;
                    conexion.Open();
                    Restore.ImportFromFile(ruta);

                    conexion.Close();

                    MessageBox.Show("RESTAURACIÓN COMPLETADA");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al restaurar la base de datos: {ex.Message}");
            }
        }
    }
}
