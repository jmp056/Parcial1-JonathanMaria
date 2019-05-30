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

namespace ProyectoParcial1.UI.Consultas
{
    public partial class CValorTotalInventario : Form
    {
        public CValorTotalInventario()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            SqlCommand VTI = new SqlCommand("select sum(ValorEnInventario) from Productos");
            ValorTotalDeInventarioTextBox.Text = Convert.ToString(VTI);
        }
    }
}
