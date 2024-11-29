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
    public partial class Ventana_Clientes_Form : Form
    {
        public Ventana_Clientes_Form()
        {
            InitializeComponent();
        }

        private void Button_Agregar_Cliente_Click(object sender, EventArgs e)
        {
            Form_Principal_Ventana padre = this.Parent.Parent as Form_Principal_Ventana;
            
            padre.abrirforms(new Add_Clientes_Form());
        }

        private void Button_Gestion_C_Click(object sender, EventArgs e)
        {
            Form_Principal_Ventana padre = this.Parent.Parent as Form_Principal_Ventana;
            padre.abrirforms(new Gestion_Clientes_Form1());
        }
    }
}
