using Parcial1_JonathanMaria.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial1_JonathanMaria.Entidades;
using Parcial1_JonathanMaria.BLL;
using ProyectoParcial1.Entidades;

namespace Parcial1_JonathanMaria.UI.Consultas
{
    public partial class CValorTotalInventario : Form
    {
        public CValorTotalInventario()
        {
            InitializeComponent();
        }

        private ValorTotalDeInventario LlenaClase()
        {
            ValorTotalInventario valortotalinventario = new ValorTotalInventario();
            //producto.IdProducto = Convert.ToInt32(IdProductoNumericUpDown.Value);
            return valortotalinventario;
        }
        private void ActualizarButton_Click(object sender, EventArgs e)
        {
            ValorTotalDeInventario valortotaldeinventario;

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
