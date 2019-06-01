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
            this.ActualizarButton = new System.Windows.Forms.Button();
            this.ValorInventarioTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ActualizarButton
            // 
            this.ActualizarButton.Image = global::ProyectoParcial1.Properties.Resources.BotonActualizar;
            this.ActualizarButton.Location = new System.Drawing.Point(148, 12);
            this.ActualizarButton.Name = "ActualizarButton";
            this.ActualizarButton.Size = new System.Drawing.Size(50, 50);
            this.ActualizarButton.TabIndex = 0;
            this.ActualizarButton.UseVisualStyleBackColor = true;
            this.ActualizarButton.Click += new System.EventHandler(this.ActualizarButton_Click);
            // 
            // ValorInventarioTextBox
            // 
            this.ValorInventarioTextBox.Enabled = false;
            this.ValorInventarioTextBox.Location = new System.Drawing.Point(12, 70);
            this.ValorInventarioTextBox.Name = "ValorInventarioTextBox";
            this.ValorInventarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.ValorInventarioTextBox.TabIndex = 1;
            // 
            // CValorTotalInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 111);
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
    }
}