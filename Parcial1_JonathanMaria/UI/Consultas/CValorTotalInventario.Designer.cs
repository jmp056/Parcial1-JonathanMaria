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
            this.ValorInventarioTextBox = new System.Windows.Forms.TextBox();
            this.ValorTotal = new System.Windows.Forms.Label();
            this.DeInventario = new System.Windows.Forms.Label();
            this.ActualizarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ValorInventarioTextBox
            // 
            this.ValorInventarioTextBox.Enabled = false;
            this.ValorInventarioTextBox.Location = new System.Drawing.Point(28, 87);
            this.ValorInventarioTextBox.Name = "ValorInventarioTextBox";
            this.ValorInventarioTextBox.Size = new System.Drawing.Size(169, 20);
            this.ValorInventarioTextBox.TabIndex = 1;
            // 
            // ValorTotal
            // 
            this.ValorTotal.AutoSize = true;
            this.ValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorTotal.Location = new System.Drawing.Point(25, 25);
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.Size = new System.Drawing.Size(79, 16);
            this.ValorTotal.TabIndex = 2;
            this.ValorTotal.Text = "Valor total";
            // 
            // DeInventario
            // 
            this.DeInventario.AutoSize = true;
            this.DeInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeInventario.Location = new System.Drawing.Point(25, 50);
            this.DeInventario.Name = "DeInventario";
            this.DeInventario.Size = new System.Drawing.Size(102, 16);
            this.DeInventario.TabIndex = 3;
            this.DeInventario.Text = "de inventario:";
            // 
            // ActualizarButton
            // 
            this.ActualizarButton.Image = global::ProyectoParcial1.Properties.Resources.BotonActualizar;
            this.ActualizarButton.Location = new System.Drawing.Point(147, 21);
            this.ActualizarButton.Name = "ActualizarButton";
            this.ActualizarButton.Size = new System.Drawing.Size(50, 50);
            this.ActualizarButton.TabIndex = 0;
            this.ActualizarButton.UseVisualStyleBackColor = true;
            this.ActualizarButton.Click += new System.EventHandler(this.ActualizarButton_Click);
            // 
            // CValorTotalInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 139);
            this.Controls.Add(this.DeInventario);
            this.Controls.Add(this.ValorTotal);
            this.Controls.Add(this.ValorInventarioTextBox);
            this.Controls.Add(this.ActualizarButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CValorTotalInventario";
            this.Text = "Consulta total de invetario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ActualizarButton;
        private System.Windows.Forms.TextBox ValorInventarioTextBox;
        private System.Windows.Forms.Label ValorTotal;
        private System.Windows.Forms.Label DeInventario;
    }
}