﻿namespace SBC_Maker.Interfaz_grafica
{
    partial class NodoUserControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NodoUserControl));
            this.richTextBoxNombreRegla = new System.Windows.Forms.RichTextBox();
            this.buttonRelacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxNombreRegla
            // 
            this.richTextBoxNombreRegla.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBoxNombreRegla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxNombreRegla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.richTextBoxNombreRegla.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxNombreRegla.Location = new System.Drawing.Point(4, 4);
            this.richTextBoxNombreRegla.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBoxNombreRegla.Name = "richTextBoxNombreRegla";
            this.richTextBoxNombreRegla.ReadOnly = true;
            this.richTextBoxNombreRegla.Size = new System.Drawing.Size(81, 81);
            this.richTextBoxNombreRegla.TabIndex = 0;
            this.richTextBoxNombreRegla.Text = "";
            this.richTextBoxNombreRegla.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.richTextBoxNombreRegla_MouseDoubleClick);
            this.richTextBoxNombreRegla.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTextBoxNombreRegla_MouseDown);
            this.richTextBoxNombreRegla.MouseMove += new System.Windows.Forms.MouseEventHandler(this.richTextBoxNombreRegla_MouseMove);
            this.richTextBoxNombreRegla.MouseUp += new System.Windows.Forms.MouseEventHandler(this.richTextBoxNombreRegla_MouseUp);
            // 
            // buttonRelacion
            // 
            this.buttonRelacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRelacion.Image = ((System.Drawing.Image)(resources.GetObject("buttonRelacion.Image")));
            this.buttonRelacion.Location = new System.Drawing.Point(24, 86);
            this.buttonRelacion.Name = "buttonRelacion";
            this.buttonRelacion.Size = new System.Drawing.Size(40, 32);
            this.buttonRelacion.TabIndex = 1;
            this.buttonRelacion.UseVisualStyleBackColor = true;
            this.buttonRelacion.Click += new System.EventHandler(this.button1_Click);
            // 
            // NodoUserControl
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.buttonRelacion);
            this.Controls.Add(this.richTextBoxNombreRegla);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NodoUserControl";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(90, 120);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox richTextBoxNombreRegla;
        private Button buttonRelacion;
    }
}
