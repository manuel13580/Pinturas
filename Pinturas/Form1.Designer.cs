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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tinteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.presentacionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.presentacionesTerminadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presentacionesNoTerminadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faltanDetallesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.presentacionToolStripMenuItem1});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.opcionesToolStripMenuItem.Text = "Datos";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.nuevoToolStripMenuItem.Text = "Actualizar";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // tinteToolStripMenuItem1
            // 
            this.tinteToolStripMenuItem1.Name = "tinteToolStripMenuItem1";
            this.tinteToolStripMenuItem1.Size = new System.Drawing.Size(150, 26);
            this.tinteToolStripMenuItem1.Text = "Tinte";
            // 
            // presentacionToolStripMenuItem1
            // 
            this.presentacionToolStripMenuItem1.Name = "presentacionToolStripMenuItem1";
            this.presentacionToolStripMenuItem1.Size = new System.Drawing.Size(150, 26);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(295, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
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
            // 
            // presentacionesTerminadasToolStripMenuItem
            // 
            this.presentacionesTerminadasToolStripMenuItem.Image = global::Pinturas.Properties.Resources.tick;
            this.presentacionesTerminadasToolStripMenuItem.Name = "presentacionesTerminadasToolStripMenuItem";
            this.presentacionesTerminadasToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.presentacionesTerminadasToolStripMenuItem.Text = "Formulas Completas";
            // 
            // presentacionesNoTerminadasToolStripMenuItem
            // 
            this.presentacionesNoTerminadasToolStripMenuItem.Image = global::Pinturas.Properties.Resources.delete2;
            this.presentacionesNoTerminadasToolStripMenuItem.Name = "presentacionesNoTerminadasToolStripMenuItem";
            this.presentacionesNoTerminadasToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.presentacionesNoTerminadasToolStripMenuItem.Text = "Formulas Incompletas";
            // 
            // faltanDetallesToolStripMenuItem
            // 
            this.faltanDetallesToolStripMenuItem.Image = global::Pinturas.Properties.Resources.Icojam_Blue_Bits_Warning;
            this.faltanDetallesToolStripMenuItem.Name = "faltanDetallesToolStripMenuItem";
            this.faltanDetallesToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.faltanDetallesToolStripMenuItem.Text = "Formulas con Falta de detalles";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 753);
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
    }
}

