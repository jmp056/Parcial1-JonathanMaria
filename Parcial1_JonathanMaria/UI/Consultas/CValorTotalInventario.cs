using Parcial1_JonathanMaria.BLL;
using Parcial1_JonathanMaria.Entidades;
using System;
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
            if (inventario == null)
                ValorInventarioTextBox.Text = "0";
            else
                ValorInventarioTextBox.Text = Convert.ToString(inventario.Valor);
        }
    }
}
