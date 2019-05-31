namespace Parcial1_JonathanMaria.UI.Consultas
{
    partial class CValorTotalInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CValorTotalInventario));
            this.Valortotal = new System.Windows.Forms.Label();
            this.ValorTotalDeInventarioTextBox = new System.Windows.Forms.TextBox();
            this.deInventario = new System.Windows.Forms.Label();
            this.ActualizarButton = new System.Windows.Forms.Button();
            this.ConsultaDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Valortotal
            // 
            this.Valortotal.AutoSize = true;
            this.Valortotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valortotal.Location = new System.Drawing.Point(21, 26);
            this.Valortotal.Name = "Valortotal";
            this.Valortotal.Size = new System.Drawing.Size(79, 16);
            this.Valortotal.TabIndex = 1;
            this.Valortotal.Text = "Valor total";
            this.Valortotal.UseWaitCursor = true;
            // 
            // ValorTotalDeInventarioTextBox
            // 
            this.ValorTotalDeInventarioTextBox.Enabled = false;
            this.ValorTotalDeInventarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorTotalDeInventarioTextBox.Location = new System.Drawing.Point(24, 82);
            this.ValorTotalDeInventarioTextBox.Name = "ValorTotalDeInventarioTextBox";
            this.ValorTotalDeInventarioTextBox.Size = new System.Drawing.Size(162, 22);
            this.ValorTotalDeInventarioTextBox.TabIndex = 2;
            // 
            // deInventario
            // 
            this.deInventario.AutoSize = true;
            this.deInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deInventario.Location = new System.Drawing.Point(21, 48);
            this.deInventario.Name = "deInventario";
            this.deInventario.Size = new System.Drawing.Size(102, 16);
            this.deInventario.TabIndex = 3;
            this.deInventario.Text = "de inventario:";
            this.deInventario.UseWaitCursor = true;
            // 
            // ActualizarButton
            // 
            this.ActualizarButton.Image = global::ProyectoParcial1.Properties.Resources.BotonActualizar;
            this.ActualizarButton.Location = new System.Drawing.Point(146, 26);
            this.ActualizarButton.Name = "ActualizarButton";
            this.ActualizarButton.Size = new System.Drawing.Size(40, 40);
            this.ActualizarButton.TabIndex = 0;
            this.ActualizarButton.UseVisualStyleBackColor = true;
            this.ActualizarButton.Click += new System.EventHandler(this.ActualizarButton_Click);
            // 
            // ConsultaDataGridView
            // 
            this.ConsultaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaDataGridView.Location = new System.Drawing.Point(24, 6);
            this.ConsultaDataGridView.Name = "ConsultaDataGridView";
            this.ConsultaDataGridView.Size = new System.Drawing.Size(21, 17);
            this.ConsultaDataGridView.TabIndex = 4;
            this.ConsultaDataGridView.Visible = false;
            // 
            // CValorTotalInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 120);
            this.Controls.Add(this.ConsultaDataGridView);
            this.Controls.Add(this.deInventario);
            this.Controls.Add(this.ValorTotalDeInventarioTextBox);
            this.Controls.Add(this.Valortotal);
            this.Controls.Add(this.ActualizarButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CValorTotalInventario";
            this.Text = "Valor total de Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ActualizarButton;
        private System.Windows.Forms.Label Valortotal;
        private System.Windows.Forms.TextBox ValorTotalDeInventarioTextBox;
        private System.Windows.Forms.Label deInventario;
        private System.Windows.Forms.DataGridView ConsultaDataGridView;
    }
}