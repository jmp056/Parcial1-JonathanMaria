using Parcial1_JonathanMaria.UI.Consultas;
using Parcial1_JonathanMaria.UI.Registros;
using System;
using System.Windows.Forms;

namespace Parcial1_JonathanMaria
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RegistroDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RProductos Rp = new RProductos();
            Rp.Show();
        }

        private void ValorDelInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CValorTotalInventario Cv = new CValorTotalInventario();
            Cv.Show();
        }

        private void RegistroDeUbicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RUbicaciones Ru = new RUbicaciones();
            Ru.Show();
        }
    }
}
