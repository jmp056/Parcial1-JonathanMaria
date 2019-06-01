using Parcial1_JonathanMaria.BLL;
using Parcial1_JonathanMaria.Entidades;
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
            var listado = new List<Productos>();
            listado = ProductosBLL.GetList(p => true);
            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;
            double tot = 0;
            foreach (DataGridViewRow produ in ConsultaDataGridView.Rows)
            {
                tot += Convert.ToDouble(produ.Cells["ValorEnInventario"].Value);
            }
            ValorInventarioTextBox.Text = Convert.ToString(tot);
        }
    }
}
