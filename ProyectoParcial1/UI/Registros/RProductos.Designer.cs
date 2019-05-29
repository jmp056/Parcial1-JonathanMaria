namespace ProyectoParcial1.UI.Registros
{
    partial class RProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.IdProducto = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.Label();
            this.Existencia = new System.Windows.Forms.Label();
            this.Costo = new System.Windows.Forms.Label();
            this.ValorInventario = new System.Windows.Forms.Label();
            this.IdProductoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.ExistenciaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CostoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ValorInventarioTextBox = new System.Windows.Forms.TextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IdProductoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExistenciaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // IdProducto
            // 
            this.IdProducto.AutoSize = true;
            this.IdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdProducto.Location = new System.Drawing.Point(38, 42);
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.Size = new System.Drawing.Size(93, 16);
            this.IdProducto.TabIndex = 0;
            this.IdProducto.Text = "ID Producto:";
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion.Location = new System.Drawing.Point(38, 72);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(91, 16);
            this.Descripcion.TabIndex = 1;
            this.Descripcion.Text = "Descripcion";
            // 
            // Existencia
            // 
            this.Existencia.AutoSize = true;
            this.Existencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Existencia.Location = new System.Drawing.Point(38, 103);
            this.Existencia.Name = "Existencia";
            this.Existencia.Size = new System.Drawing.Size(79, 16);
            this.Existencia.TabIndex = 2;
            this.Existencia.Text = "Existencia";
            // 
            // Costo
            // 
            this.Costo.AutoSize = true;
            this.Costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Costo.Location = new System.Drawing.Point(38, 136);
            this.Costo.Name = "Costo";
            this.Costo.Size = new System.Drawing.Size(48, 16);
            this.Costo.TabIndex = 3;
            this.Costo.Text = "Costo";
            // 
            // ValorInventario
            // 
            this.ValorInventario.AutoSize = true;
            this.ValorInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorInventario.Location = new System.Drawing.Point(38, 168);
            this.ValorInventario.Name = "ValorInventario";
            this.ValorInventario.Size = new System.Drawing.Size(117, 16);
            this.ValorInventario.TabIndex = 4;
            this.ValorInventario.Text = "Valor Inventario";
            // 
            // IdProductoNumericUpDown
            // 
            this.IdProductoNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdProductoNumericUpDown.Location = new System.Drawing.Point(155, 37);
            this.IdProductoNumericUpDown.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.IdProductoNumericUpDown.Name = "IdProductoNumericUpDown";
            this.IdProductoNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.IdProductoNumericUpDown.TabIndex = 5;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionTextBox.Location = new System.Drawing.Point(155, 72);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(100, 22);
            this.DescripcionTextBox.TabIndex = 6;
            // 
            // ExistenciaNumericUpDown
            // 
            this.ExistenciaNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExistenciaNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ExistenciaNumericUpDown.Location = new System.Drawing.Point(155, 99);
            this.ExistenciaNumericUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.ExistenciaNumericUpDown.Name = "ExistenciaNumericUpDown";
            this.ExistenciaNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.ExistenciaNumericUpDown.TabIndex = 7;
            this.ExistenciaNumericUpDown.Tag = "";
            // 
            // CostoNumericUpDown
            // 
            this.CostoNumericUpDown.DecimalPlaces = 2;
            this.CostoNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostoNumericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.CostoNumericUpDown.Location = new System.Drawing.Point(155, 136);
            this.CostoNumericUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.CostoNumericUpDown.Name = "CostoNumericUpDown";
            this.CostoNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.CostoNumericUpDown.TabIndex = 8;
            // 
            // ValorInventarioTextBox
            // 
            this.ValorInventarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorInventarioTextBox.Location = new System.Drawing.Point(161, 168);
            this.ValorInventarioTextBox.Name = "ValorInventarioTextBox";
            this.ValorInventarioTextBox.Size = new System.Drawing.Size(100, 22);
            this.ValorInventarioTextBox.TabIndex = 9;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.Location = new System.Drawing.Point(307, 34);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarButton.TabIndex = 10;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoButton.Location = new System.Drawing.Point(42, 205);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 23);
            this.NuevoButton.TabIndex = 11;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Location = new System.Drawing.Point(161, 205);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 12;
            this.GuardarButton.Text = "GuardarButton";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Location = new System.Drawing.Point(307, 205);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 23);
            this.EliminarButton.TabIndex = 13;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // RProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.ValorInventarioTextBox);
            this.Controls.Add(this.CostoNumericUpDown);
            this.Controls.Add(this.ExistenciaNumericUpDown);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.IdProductoNumericUpDown);
            this.Controls.Add(this.ValorInventario);
            this.Controls.Add(this.Costo);
            this.Controls.Add(this.Existencia);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.IdProducto);
            this.Name = "RProductos";
            this.Text = "RProductos";
            ((System.ComponentModel.ISupportInitialize)(this.IdProductoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExistenciaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdProducto;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.Label Existencia;
        private System.Windows.Forms.Label Costo;
        private System.Windows.Forms.Label ValorInventario;
        private System.Windows.Forms.NumericUpDown IdProductoNumericUpDown;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.NumericUpDown ExistenciaNumericUpDown;
        private System.Windows.Forms.NumericUpDown CostoNumericUpDown;
        private System.Windows.Forms.TextBox ValorInventarioTextBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}