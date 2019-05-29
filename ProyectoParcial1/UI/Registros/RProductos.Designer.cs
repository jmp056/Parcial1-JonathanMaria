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
            this.IdProducto = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.Label();
            this.Existencia = new System.Windows.Forms.Label();
            this.Costo = new System.Windows.Forms.Label();
            this.ValorInventario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IdProducto
            // 
            this.IdProducto.AutoSize = true;
            this.IdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdProducto.Location = new System.Drawing.Point(125, 125);
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.Size = new System.Drawing.Size(93, 16);
            this.IdProducto.TabIndex = 0;
            this.IdProducto.Text = "ID Producto:";
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion.Location = new System.Drawing.Point(125, 155);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(91, 16);
            this.Descripcion.TabIndex = 1;
            this.Descripcion.Text = "Descripcion";
            // 
            // Existencia
            // 
            this.Existencia.AutoSize = true;
            this.Existencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Existencia.Location = new System.Drawing.Point(125, 186);
            this.Existencia.Name = "Existencia";
            this.Existencia.Size = new System.Drawing.Size(79, 16);
            this.Existencia.TabIndex = 2;
            this.Existencia.Text = "Existencia";
            // 
            // Costo
            // 
            this.Costo.AutoSize = true;
            this.Costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Costo.Location = new System.Drawing.Point(125, 219);
            this.Costo.Name = "Costo";
            this.Costo.Size = new System.Drawing.Size(48, 16);
            this.Costo.TabIndex = 3;
            this.Costo.Text = "Costo";
            // 
            // ValorInventario
            // 
            this.ValorInventario.AutoSize = true;
            this.ValorInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorInventario.Location = new System.Drawing.Point(125, 251);
            this.ValorInventario.Name = "ValorInventario";
            this.ValorInventario.Size = new System.Drawing.Size(117, 16);
            this.ValorInventario.TabIndex = 4;
            this.ValorInventario.Text = "Valor Inventario";
            // 
            // RProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ValorInventario);
            this.Controls.Add(this.Costo);
            this.Controls.Add(this.Existencia);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.IdProducto);
            this.Name = "RProductos";
            this.Text = "RProductos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdProducto;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.Label Existencia;
        private System.Windows.Forms.Label Costo;
        private System.Windows.Forms.Label ValorInventario;
    }
}