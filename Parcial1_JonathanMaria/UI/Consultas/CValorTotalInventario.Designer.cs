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
            this.ActualizarButton = new System.Windows.Forms.Button();
            this.ValorInventarioTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ActualizarButton
            // 
            this.ActualizarButton.Location = new System.Drawing.Point(272, 54);
            this.ActualizarButton.Name = "ActualizarButton";
            this.ActualizarButton.Size = new System.Drawing.Size(75, 23);
            this.ActualizarButton.TabIndex = 0;
            this.ActualizarButton.Text = "button1";
            this.ActualizarButton.UseVisualStyleBackColor = true;
            this.ActualizarButton.Click += new System.EventHandler(this.ActualizarButton_Click);
            // 
            // ValorInventarioTextBox
            // 
            this.ValorInventarioTextBox.Location = new System.Drawing.Point(151, 102);
            this.ValorInventarioTextBox.Name = "ValorInventarioTextBox";
            this.ValorInventarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.ValorInventarioTextBox.TabIndex = 1;
            // 
            // CValorTotalInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 158);
            this.Controls.Add(this.ValorInventarioTextBox);
            this.Controls.Add(this.ActualizarButton);
            this.Name = "CValorTotalInventario";
            this.Text = "CValorTotalInventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ActualizarButton;
        private System.Windows.Forms.TextBox ValorInventarioTextBox;
    }
}