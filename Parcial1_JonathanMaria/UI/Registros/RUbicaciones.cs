using Parcial1_JonathanMaria.BLL;
using Parcial1_JonathanMaria.Entidades;
using System;
using System.Windows.Forms;
using Parcial1_JonathanMaria.UI.Registros;

namespace Parcial1_JonathanMaria.UI.Registros
{
    public partial class RUbicaciones : Form
    {
        public RUbicaciones()
        {
            InitializeComponent();
            EliminarButton.Enabled = false;
        }

        private void Limpiar()
        {
            UbicacionIdNumericUpDown.Value = 0;
            DescripcionTextBox.Text = string.Empty;
        }

        private Ubicaciones LlenaClase()
        {
            Ubicaciones ubicacion = new Ubicaciones();
            ubicacion.UbicacionId = Convert.ToInt32(UbicacionIdNumericUpDown.Value);
            ubicacion.Descripcion = DescripcionTextBox.Text;
            return ubicacion;
        }

        private void LlenaCampos(Ubicaciones ubicacion)
        {
            UbicacionIdNumericUpDown.Value = ubicacion.UbicacionId;
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
            Ubicaciones ubicacion = UbicacionesBLL.Buscar((int)UbicacionIdNumericUpDown.Value);
            return ubicacion != null;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            int id;
            Ubicaciones ubicacion = new Ubicaciones();
            int.TryParse(UbicacionIdNumericUpDown.Text, out id);
            ubicacion = UbicacionesBLL.Buscar(id);
            if (ubicacion != null)
            {
                MessageBox.Show("Ubicacion encontrada");
                LlenaCampos(ubicacion);
                EliminarButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ubicacion no encontrada!");
            }
        }

        private void NuevoButton_Click_1(object sender, EventArgs e)
        {
            Limpiar();
            MyErrorProvider.Clear();
            EliminarButton.Enabled = false;
            DescripcionTextBox.Focus();
        }

        private void GuardarButton_Click_1(object sender, EventArgs e)
        {
            Ubicaciones ubicacion;
            bool paso = false;
            if (!Validar())
                return;
            ubicacion = LlenaClase();
            if (UbicacionesBLL.Existe(ubicacion.Descripcion) == true)
            {
                MessageBox.Show("Ya esta ubicacion existe, utilize otra descripcion!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (UbicacionIdNumericUpDown.Value == 0)
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
        }

        private void EliminarButton_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar esta ubicacion?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                MyErrorProvider.Clear();
                int id;
                int.TryParse(UbicacionIdNumericUpDown.Text, out id);
                Limpiar();
                if (UbicacionesBLL.Eliminar(id))
                {
                    MessageBox.Show("El ubicacion fue eliminada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    UbicacionIdNumericUpDown.Enabled = true;
                    EliminarButton.Enabled = false;
                }
                else
                {
                    MessageBox.Show("El producto no pudo ser eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }
    }
}
