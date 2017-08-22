namespace Pinturas
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tinteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.presentacionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presentacionesTerminadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presentacionesNoTerminadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faltanDetallesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.mostrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(825, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.tinteToolStripMenuItem1,
            this.presentacionToolStripMenuItem1});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.opcionesToolStripMenuItem.Text = "Datos";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.nuevoToolStripMenuItem.Text = "Actualizar";
            // 
            // tinteToolStripMenuItem1
            // 
            this.tinteToolStripMenuItem1.Name = "tinteToolStripMenuItem1";
            this.tinteToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.tinteToolStripMenuItem1.Text = "Tinte";
            // 
            // presentacionToolStripMenuItem1
            // 
            this.presentacionToolStripMenuItem1.Name = "presentacionToolStripMenuItem1";
            this.presentacionToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.presentacionToolStripMenuItem1.Text = "Formula";
            this.presentacionToolStripMenuItem1.Click += new System.EventHandler(this.presentacionToolStripMenuItem1_Click);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.presentacionesTerminadasToolStripMenuItem,
            this.presentacionesNoTerminadasToolStripMenuItem,
            this.faltanDetallesToolStripMenuItem,
            this.sinDatosToolStripMenuItem});
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            // 
            // presentacionesTerminadasToolStripMenuItem
            // 
            this.presentacionesTerminadasToolStripMenuItem.Name = "presentacionesTerminadasToolStripMenuItem";
            this.presentacionesTerminadasToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.presentacionesTerminadasToolStripMenuItem.Text = "Formulas Completas";
            // 
            // presentacionesNoTerminadasToolStripMenuItem
            // 
            this.presentacionesNoTerminadasToolStripMenuItem.Name = "presentacionesNoTerminadasToolStripMenuItem";
            this.presentacionesNoTerminadasToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.presentacionesNoTerminadasToolStripMenuItem.Text = "Formulas Incompletas";
            // 
            // faltanDetallesToolStripMenuItem
            // 
            this.faltanDetallesToolStripMenuItem.Name = "faltanDetallesToolStripMenuItem";
            this.faltanDetallesToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.faltanDetallesToolStripMenuItem.Text = "Formulas con Falta de detalles";
            // 
            // sinDatosToolStripMenuItem
            // 
            this.sinDatosToolStripMenuItem.Name = "sinDatosToolStripMenuItem";
            this.sinDatosToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.sinDatosToolStripMenuItem.Text = "Formulas Sin datos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 437);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tinteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem presentacionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presentacionesTerminadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presentacionesNoTerminadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faltanDetallesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinDatosToolStripMenuItem;
    }
}

