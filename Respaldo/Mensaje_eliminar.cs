using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Respaldo
{
    public partial class Mensaje_eliminar : Form
    {
        private string id;
        private string nombre;
        public Mensaje_eliminar(string id,string nombre)
        {
            InitializeComponent();
            this.id = id;
            this.nombre = nombre;
        }

        private void Button_Aceptar_Click(object sender, EventArgs e)
        {
            Gestion_Clientes_Form1 ejecutar = Application.OpenForms.OfType<Gestion_Clientes_Form1>().FirstOrDefault();
            ejecutar.eliminar(Convert.ToInt32(id));
            this.Close();
            this.Dispose();
        }

        private void Button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void Mensaje_eliminar_Load(object sender, EventArgs e)
        {
            Label_Name.Text = nombre;
        }
    }
}
