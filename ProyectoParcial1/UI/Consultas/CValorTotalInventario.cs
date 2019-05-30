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

namespace ProyectoParcial1.UI.Consultas
{
    public partial class CValorTotalInventario : Form
    {
        public CValorTotalInventario()
        {
            InitializeComponent();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            Contexto db = new Contexto();
            //decimal vit = Convert.ToDecimal(db.Productos.Find(keyValues: "Select sum(ValorEnInventario) from Productos"));
            //= new SqlCommand("select sum(ValorEnInventario) from Productos");
            //ValorTotalDeInventarioTextBox.Text = Convert.ToString(VTI);
            ValorTotalDeInventarioTextBox.Text = Convert.ToString(db.Productos.Find(ValueType: "Select sum(ValorEnInventario) from Productos"));
        }
    }
}
