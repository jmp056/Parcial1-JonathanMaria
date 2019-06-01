using Parcial1_JonathanMaria.BLL;
using Parcial1_JonathanMaria.Entidades;
using ProyectoParcial1.BLL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Parcial1_JonathanMaria.UI.Consultas
{
    public partial class CValorTotalInventario : Form
    {
        public CValorTotalInventario()
        {
            InitializeComponent();
        }

        private void ActualizarButton_Click(object sender, EventArgs e)
        {
            Inventarios inventario = new Inventarios();
            inventario = InventariosBLL.Buscar(1);
            if (inventario == null/* || inventario.Valor == 0*/)
                ValorInventarioTextBox.Text = "0";
            else
                ValorInventarioTextBox.Text = Convert.ToString(inventario.Valor);
        }
    }
}
