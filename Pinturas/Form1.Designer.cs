﻿namespace Pinturas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tinteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.presentacionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presentacionesTerminadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presentacionesNoTerminadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faltanDetallesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtaño = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdescr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboAutos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBusqueda2 = new System.Windows.Forms.TextBox();
            this.TxtTipoBusqueda = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.coloresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1470, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.tinteToolStripMenuItem1,
            this.presentacionToolStripMenuItem1,
            this.vehiculosToolStripMenuItem,
            this.coloresToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.opcionesToolStripMenuItem.Text = "Datos";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = global::Pinturas.Properties.Resources.tick;
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.nuevoToolStripMenuItem.Text = "Actualizar";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // tinteToolStripMenuItem1
            // 
            this.tinteToolStripMenuItem1.Image = global::Pinturas.Properties.Resources.select_by_color;
            this.tinteToolStripMenuItem1.Name = "tinteToolStripMenuItem1";
            this.tinteToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.tinteToolStripMenuItem1.Text = "Tinte";
            this.tinteToolStripMenuItem1.Click += new System.EventHandler(this.tinteToolStripMenuItem1_Click);
            // 
            // presentacionToolStripMenuItem1
            // 
            this.presentacionToolStripMenuItem1.Image = global::Pinturas.Properties.Resources.Graphicloads_Medical_Health_Equation;
            this.presentacionToolStripMenuItem1.Name = "presentacionToolStripMenuItem1";
            this.presentacionToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.presentacionToolStripMenuItem1.Text = "Formula";
            this.presentacionToolStripMenuItem1.Click += new System.EventHandler(this.presentacionToolStripMenuItem1_Click);
            // 
            // vehiculosToolStripMenuItem
            // 
            this.vehiculosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarVehiculoToolStripMenuItem,
            this.buscarVehiculoToolStripMenuItem});
            this.vehiculosToolStripMenuItem.Image = global::Pinturas.Properties.Resources.vehiculo1;
            this.vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";
            this.vehiculosToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.vehiculosToolStripMenuItem.Text = "Vehiculos ";
            this.vehiculosToolStripMenuItem.Click += new System.EventHandler(this.vehiculosToolStripMenuItem_Click);
            // 
            // registrarVehiculoToolStripMenuItem
            // 
            this.registrarVehiculoToolStripMenuItem.Name = "registrarVehiculoToolStripMenuItem";
            this.registrarVehiculoToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.registrarVehiculoToolStripMenuItem.Text = "Registrar Vehiculo";
            this.registrarVehiculoToolStripMenuItem.Click += new System.EventHandler(this.registrarVehiculoToolStripMenuItem_Click);
            // 
            // buscarVehiculoToolStripMenuItem
            // 
            this.buscarVehiculoToolStripMenuItem.Name = "buscarVehiculoToolStripMenuItem";
            this.buscarVehiculoToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.buscarVehiculoToolStripMenuItem.Text = "Buscar Vehiculo";
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
            this.presentacionesTerminadasToolStripMenuItem.Image = global::Pinturas.Properties.Resources.tick;
            this.presentacionesTerminadasToolStripMenuItem.Name = "presentacionesTerminadasToolStripMenuItem";
            this.presentacionesTerminadasToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.presentacionesTerminadasToolStripMenuItem.Text = "Formulas Completas";
            this.presentacionesTerminadasToolStripMenuItem.Click += new System.EventHandler(this.presentacionesTerminadasToolStripMenuItem_Click);
            // 
            // presentacionesNoTerminadasToolStripMenuItem
            // 
            this.presentacionesNoTerminadasToolStripMenuItem.Image = global::Pinturas.Properties.Resources.delete2;
            this.presentacionesNoTerminadasToolStripMenuItem.Name = "presentacionesNoTerminadasToolStripMenuItem";
            this.presentacionesNoTerminadasToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.presentacionesNoTerminadasToolStripMenuItem.Text = "Formulas Incompletas";
            this.presentacionesNoTerminadasToolStripMenuItem.Click += new System.EventHandler(this.presentacionesNoTerminadasToolStripMenuItem_Click);
            // 
            // faltanDetallesToolStripMenuItem
            // 
            this.faltanDetallesToolStripMenuItem.Image = global::Pinturas.Properties.Resources.Icojam_Blue_Bits_Warning;
            this.faltanDetallesToolStripMenuItem.Name = "faltanDetallesToolStripMenuItem";
            this.faltanDetallesToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.faltanDetallesToolStripMenuItem.Text = "Formulas con Falta de detalles";
            this.faltanDetallesToolStripMenuItem.Click += new System.EventHandler(this.faltanDetallesToolStripMenuItem_Click);
            // 
            // sinDatosToolStripMenuItem
            // 
            this.sinDatosToolStripMenuItem.Image = global::Pinturas.Properties.Resources.Oxygen_Icons_org_Oxygen_Status_dialog_warning;
            this.sinDatosToolStripMenuItem.Name = "sinDatosToolStripMenuItem";
            this.sinDatosToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.sinDatosToolStripMenuItem.Text = "Formulas Sin datos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(294, 77);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1148, 623);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseMove);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(23, 77);
            this.TxtBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(251, 22);
            this.TxtBusqueda.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 271);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ensambladora";
            // 
            // txtaño
            // 
            this.txtaño.Location = new System.Drawing.Point(19, 227);
            this.txtaño.Margin = new System.Windows.Forms.Padding(4);
            this.txtaño.Name = "txtaño";
            this.txtaño.Size = new System.Drawing.Size(251, 22);
            this.txtaño.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Año Inicial";
            // 
            // txtdescr
            // 
            this.txtdescr.Location = new System.Drawing.Point(23, 155);
            this.txtdescr.Margin = new System.Windows.Forms.Padding(4);
            this.txtdescr.Name = "txtdescr";
            this.txtdescr.Size = new System.Drawing.Size(251, 22);
            this.txtdescr.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Descripción";
            // 
            // ComboAutos
            // 
            this.ComboAutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboAutos.FormattingEnabled = true;
            this.ComboAutos.Location = new System.Drawing.Point(19, 306);
            this.ComboAutos.Margin = new System.Windows.Forms.Padding(4);
            this.ComboAutos.Name = "ComboAutos";
            this.ComboAutos.Size = new System.Drawing.Size(251, 24);
            this.ComboAutos.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Codigo";
            // 
            // TxtBusqueda2
            // 
            this.TxtBusqueda2.Location = new System.Drawing.Point(1029, 34);
            this.TxtBusqueda2.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBusqueda2.Name = "TxtBusqueda2";
            this.TxtBusqueda2.Size = new System.Drawing.Size(255, 22);
            this.TxtBusqueda2.TabIndex = 27;
            // 
            // TxtTipoBusqueda
            // 
            this.TxtTipoBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtTipoBusqueda.FormattingEnabled = true;
            this.TxtTipoBusqueda.Items.AddRange(new object[] {
            "Tipo de Auto",
            "Codigo de Color",
            "Descripcion"});
            this.TxtTipoBusqueda.Location = new System.Drawing.Point(384, 32);
            this.TxtTipoBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTipoBusqueda.Name = "TxtTipoBusqueda";
            this.TxtTipoBusqueda.Size = new System.Drawing.Size(160, 24);
            this.TxtTipoBusqueda.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.Image = global::Pinturas.Properties.Resources.delete1;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(147, 361);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 44);
            this.button2.TabIndex = 24;
            this.button2.Text = "      Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Pinturas.Properties.Resources.search_plus;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(27, 361);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 44);
            this.button1.TabIndex = 23;
            this.button1.Text = "   Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // coloresToolStripMenuItem
            // 
            this.coloresToolStripMenuItem.Name = "coloresToolStripMenuItem";
            this.coloresToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.coloresToolStripMenuItem.Text = "Colores";
            this.coloresToolStripMenuItem.Click += new System.EventHandler(this.coloresToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 753);
            this.Controls.Add(this.TxtBusqueda2);
            this.Controls.Add(this.TxtTipoBusqueda);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtaño);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdescr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboAutos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtaño;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdescr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboAutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBusqueda2;
        private System.Windows.Forms.ComboBox TxtTipoBusqueda;
        private System.Windows.Forms.ToolStripMenuItem vehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coloresToolStripMenuItem;
    }
}

