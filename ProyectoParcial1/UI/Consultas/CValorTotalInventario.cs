using ProyectoParcial1.DAL;
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
using ProyectoParcial1.Entidades;
using ProyectoParcial1.BLL;

namespace ProyectoParcial1.UI.Consultas
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
            foreach(DataGridViewRow produ in ConsultaDataGridView.Rows)
            {
                tot += Convert.ToDouble(produ.Cells["ValorEnInventario"].Value);
            }
        }
    }
}
