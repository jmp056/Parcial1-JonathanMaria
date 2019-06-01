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

        private Inventarios LlenaClase()
        {
            Inventarios inventario = new Inventarios();
            return inventario;
        }
        private void ActualizarButton_Click(object sender, EventArgs e)
        {
            int id = 1;
            Inventarios inventario = new Inventarios();
            inventario = InventariosBLL.Buscar(id);
            if(inventario != null)
            {
                ValorTotalDeInventarioTextBox.Text = Convert.ToString(0);
            }
            else
            {
                ValorTotalDeInventarioTextBox.Text = Convert.ToString(inventario.Valor);
            }

            /*var listado = new List<Productos>();
            listado = ProductosBLL.GetList(p => true);

            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;

            decimal tot = 0;
            foreach(DataGridViewRow produ in ConsultaDataGridView.Rows)
            {
                tot += Convert.ToDecimal(produ.Cells["ValorEnInventario"].Value);
            }
            ValorTotalDeInventarioTextBox.Text = Convert.ToString(tot);
            */
        }
    }
}
