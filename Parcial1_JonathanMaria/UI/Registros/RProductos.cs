using Parcial1_JonathanMaria.BLL;
using Parcial1_JonathanMaria.Entidades;
using System;
using System.Windows.Forms;

namespace Parcial1_JonathanMaria.UI.Registros
{
    public partial class RProductos : Form
    {
        public RProductos()
        {
            InitializeComponent();
            AdvertenciaErrorProvider.SetError(IdProductoNumericUpDown, "Si desea guardar un producto nuevo, procure que el Id Producto sea 0");
        }

        private void Limpiar()
        {
            IdProductoNumericUpDown.Value = 0;
            DescripcionTextBox.Text = string.Empty;
            ExistenciaNumericUpDown.Value = 0;
            CostoNumericUpDown.Value = 0;
            ValorInventarioTextBox.Text = string.Empty;
        }

        private Productos LlenaClase()
        {
            Productos producto = new Productos();
            producto.IdProducto = Convert.ToInt32(IdProductoNumericUpDown.Value);
            producto.Descripcion = DescripcionTextBox.Text;
            producto.Existencia = Convert.ToInt32(ExistenciaNumericUpDown.Value);
            producto.Costo = Convert.ToSingle(CostoNumericUpDown.Value);
            producto.ValorEnInventario = Convert.ToSingle(ValorInventarioTextBox.Text);
            return producto;
        }
        private void LlenaCampos(Productos producto)
        {
            IdProductoNumericUpDown.Value = producto.IdProducto;
            DescripcionTextBox.Text = producto.Descripcion;
            ExistenciaNumericUpDown.Value = producto.Existencia;
            CostoNumericUpDown.Value = Convert.ToDecimal(producto.Costo);
            ValorInventarioTextBox.Text = Convert.ToString(producto.ValorEnInventario);
        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();
            if(DescripcionTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(DescripcionTextBox, "El campo \"Descripcion\" no puede estar vacio");
                DescripcionTextBox.Focus();
                paso = false;
            }

            if(ExistenciaNumericUpDown.Value < 1 )
            {
                MyErrorProvider.SetError(ExistenciaNumericUpDown, "La cantidad en existencia no puede ser negativo o 0");
                ExistenciaNumericUpDown.Focus();
                paso = false;
            }

            if (ExistenciaNumericUpDown.Value > 999999999)
            {
                MyErrorProvider.SetError(ExistenciaNumericUpDown, "La cantidad en existencia no puede ser mayor a 999,999,999");
                ExistenciaNumericUpDown.Focus();
                paso = false;
            }

            if (CostoNumericUpDown.Value <= 0)
            {
                MyErrorProvider.SetError(CostoNumericUpDown, "El costo del producto no puede ser menor que 0");
                CostoNumericUpDown.Focus();
                paso = false;
            }

            if (CostoNumericUpDown.Value > 999999999)
            {
                MyErrorProvider.SetError(CostoNumericUpDown, "El precio del producto no puede ser mayor que 999,999,999");
                CostoNumericUpDown.Focus();
                paso = false;
            }
            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Productos producto = ProductosBLL.Buscar((int)IdProductoNumericUpDown.Value);
            return producto != null;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            AdvertenciaErrorProvider.Clear();
            MyErrorProvider.Clear();
            int id;
            Productos producto = new Productos();
            int.TryParse(IdProductoNumericUpDown.Text, out id);
            producto = ProductosBLL.Buscar(id);
            if (producto != null)
            {
                MessageBox.Show("Producto encontrado");
                LlenaCampos(producto);
                EliminarButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Producto no encontrado");
                AdvertenciaErrorProvider.SetError(IdProductoNumericUpDown, "Si desea guardar un producto nuevo, procure que el Id Producto sea 0");
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
            MyErrorProvider.Clear();
            AdvertenciaErrorProvider.SetError(IdProductoNumericUpDown, "Si desea guardar un producto nuevo, procure que el Id Producto sea 0");
            EliminarButton.Enabled = false;
            DescripcionTextBox.Focus();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Productos producto;
            bool paso = false;
            if (!Validar())
                return;
            producto = LlenaClase();
            if (IdProductoNumericUpDown.Value == 0)
            {
                paso = ProductosBLL.Guardar(producto);
                MessageBox.Show("Guardado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else 
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un producto que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("Esta seguro que desea modificar este producto?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    paso = ProductosBLL.Modificar(producto);
                    MessageBox.Show("Modificado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                    return;
            }                
            if(!paso)
                MessageBox.Show("Error al guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            AdvertenciaErrorProvider.SetError(IdProductoNumericUpDown, "Si desea guardar un producto nuevo, procure que el Id Producto sea 0");
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar este producto?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                MyErrorProvider.Clear();
                int id;
                int.TryParse(IdProductoNumericUpDown.Text, out id);
                Limpiar();
                if (ProductosBLL.Eliminar(id))
                {
                    MessageBox.Show("El producto fue eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    IdProductoNumericUpDown.Enabled = true;
                    EliminarButton.Enabled = false;
                }
                else
                    MessageBox.Show("El producto no pudo ser eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AdvertenciaErrorProvider.SetError(IdProductoNumericUpDown, "Si desea guardar un producto nuevo, procure que el Id Producto sea 0");
            }
            else
                return;
        }

        private void ExistenciaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ValorInventarioTextBox.Text = Convert.ToString(ExistenciaNumericUpDown.Value * CostoNumericUpDown.Value);
        }

        private void CostoNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ValorInventarioTextBox.Text = Convert.ToString(ExistenciaNumericUpDown.Value * CostoNumericUpDown.Value);
        }
    }
}
