using Parcial1_JonathanMaria.BLL;
using Parcial1_JonathanMaria.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoParcial1.UI.Registros
{
    public partial class RUbicaciones : Form
    {
        public RUbicaciones()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IdUbicacionNumericUpDown.Value = 0;
            DescripcionTextBox.Text = string.Empty;
        }

        private Ubicaciones LlenaClase()
        {
            Ubicaciones ubicacion = new Ubicaciones();
            ubicacion.IdUbicacion = Convert.ToInt32(IdUbicacionNumericUpDown.Value);
            return ubicacion;
        }

        private void LlenaCampos(Ubicaciones ubicacion)
        {
            IdUbicacionNumericUpDown.Value = ubicacion.IdUbicacion;
            DescripcionTextBox.Text = ubicacion.Descripcion;
        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();
            if (DescripcionTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(DescripcionTextBox, "El campo \"Descripcion\" no puede estar vacio");
                DescripcionTextBox.Focus();
                paso = false;
            }
            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Ubicaciones ubicacion = UbicacionesBLL.Buscar((int)IdUbicacionNumericUpDown.Value);
            return ubicacion != null;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            int id;
            Ubicaciones ubicacion = new Ubicaciones();
            int.TryParse(IdUbicacionNumericUpDown.Text, out id);
            ubicacion = UbicacionesBLL.Buscar(id);
            if (ubicacion != null)
            {
                MessageBox.Show("Ubicacion encontrada");
                LlenaCampos(ubicacion);
                EliminarButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Producto no encontrado");
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
            MyErrorProvider.Clear();
            EliminarButton.Enabled = false;
            DescripcionTextBox.Focus();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Ubicaciones ubicacion;
            bool paso = false;
            if (!Validar())
                return;
            ubicacion = LlenaClase();
            if (IdUbicacionNumericUpDown.Value == 0)
            {
                paso = UbicacionesBLL.Guardar(ubicacion);
                MessageBox.Show("Guardado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una ubicacion que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("Esta seguro que desea modificar esta ubicacion?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    paso = UbicacionesBLL.Modificar(ubicacion);
                    MessageBox.Show("Modificada!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                    return;
            }
            if (!paso)
                MessageBox.Show("Error al guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar esta ubicacion?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                MyErrorProvider.Clear();
                int id;
                int.TryParse(IdUbicacionNumericUpDown.Text, out id);
                Limpiar();
                if (ProductosBLL.Eliminar(id))
                {
                    MessageBox.Show("El ubicacion fue eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    IdUbicacionNumericUpDown.Enabled = true;
                    EliminarButton.Enabled = false;
                }
                else
                    MessageBox.Show("El producto no pudo ser eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                return;
        }

    }
}
