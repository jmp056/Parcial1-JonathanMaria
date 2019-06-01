namespace Parcial1_JonathanMaria
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MyMenuStrip = new System.Windows.Forms.MenuStrip();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulltasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valorDelInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MyMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MyMenuStrip
            // 
            this.MyMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.consulltasToolStripMenuItem});
            this.MyMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MyMenuStrip.Name = "MyMenuStrip";
            this.MyMenuStrip.Size = new System.Drawing.Size(313, 24);
            this.MyMenuStrip.TabIndex = 0;
            this.MyMenuStrip.Text = "MyMenuStrip";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeProductosToolStripMenuItem});
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registroToolStripMenuItem.Text = "Registros";
            // 
            // registroDeProductosToolStripMenuItem
            // 
            this.registroDeProductosToolStripMenuItem.Name = "registroDeProductosToolStripMenuItem";
            this.registroDeProductosToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.registroDeProductosToolStripMenuItem.Text = "Registro de productos";
            this.registroDeProductosToolStripMenuItem.Click += new System.EventHandler(this.RegistroDeProductosToolStripMenuItem_Click);
            // 
            // consulltasToolStripMenuItem
            // 
            this.consulltasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.valorDelInventarioToolStripMenuItem});
            this.consulltasToolStripMenuItem.Name = "consulltasToolStripMenuItem";
            this.consulltasToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.consulltasToolStripMenuItem.Text = "Consulltas";
            // 
            // valorDelInventarioToolStripMenuItem
            // 
            this.valorDelInventarioToolStripMenuItem.Name = "valorDelInventarioToolStripMenuItem";
            this.valorDelInventarioToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.valorDelInventarioToolStripMenuItem.Text = "Valor del inventario";
            this.valorDelInventarioToolStripMenuItem.Click += new System.EventHandler(this.ValorDelInventarioToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 220);
            this.Controls.Add(this.MyMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MyMenuStrip;
            this.Name = "MainForm";
            this.Text = "Menu Principal";
            this.MyMenuStrip.ResumeLayout(false);
            this.MyMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MyMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulltasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valorDelInventarioToolStripMenuItem;
    }
}

