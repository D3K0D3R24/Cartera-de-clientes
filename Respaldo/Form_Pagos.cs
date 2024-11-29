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
    public partial class Form_Pagos : Form
    {
        private int id;
        public Form_Pagos(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Button_Registrar_Pago_Click(object sender, EventArgs e)
        {
            Form_Pagos_registrar abrir = new Form_Pagos_registrar(id);

            Form_Principal_Ventana padre = this.Parent.Parent as Form_Principal_Ventana;
            padre.abrirforms(new Form_Pagos_registrar(id));
        }

        private void Button_Pagos_Click(object sender, EventArgs e)
        {
            Form_Principal_Ventana padre = Application.OpenForms.OfType<Form_Principal_Ventana>().FirstOrDefault();

            padre.abrirforms(new Form_Historial_Pagos());
        }
    }
}
