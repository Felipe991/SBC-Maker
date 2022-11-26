﻿namespace SBC_Maker.Interfaz_grafica
{
    partial class FuncionPertenenciaUserControl
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FuncionPertenenciaUserControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.textBoxNombreFuncionPertenencia = new System.Windows.Forms.TextBox();
            this.buttonConfiguracion = new System.Windows.Forms.Button();
            this.comboBoxFuncionesPertenencia = new System.Windows.Forms.ComboBox();
            this.labelNombreFuncion = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.eliminarButton);
            this.panel1.Controls.Add(this.textBoxNombreFuncionPertenencia);
            this.panel1.Controls.Add(this.buttonConfiguracion);
            this.panel1.Controls.Add(this.comboBoxFuncionesPertenencia);
            this.panel1.Controls.Add(this.labelNombreFuncion);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 44);
            this.panel1.TabIndex = 0;
            // 
            // eliminarButton
            // 
            this.eliminarButton.BackColor = System.Drawing.Color.Transparent;
            this.eliminarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.eliminarButton.FlatAppearance.BorderSize = 0;
            this.eliminarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("eliminarButton.Image")));
            this.eliminarButton.Location = new System.Drawing.Point(475, 6);
            this.eliminarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(35, 32);
            this.eliminarButton.TabIndex = 40;
            this.eliminarButton.UseVisualStyleBackColor = false;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click_1);
            // 
            // textBoxNombreFuncionPertenencia
            // 
            this.textBoxNombreFuncionPertenencia.Location = new System.Drawing.Point(73, 9);
            this.textBoxNombreFuncionPertenencia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNombreFuncionPertenencia.Name = "textBoxNombreFuncionPertenencia";
            this.textBoxNombreFuncionPertenencia.Size = new System.Drawing.Size(216, 27);
            this.textBoxNombreFuncionPertenencia.TabIndex = 38;
            // 
            // buttonConfiguracion
            // 
            this.buttonConfiguracion.BackColor = System.Drawing.Color.Transparent;
            this.buttonConfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConfiguracion.FlatAppearance.BorderSize = 0;
            this.buttonConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfiguracion.Image = global::SBC_Maker.Properties.Resources.iconoConfiguracion.GetThumbnailImage(30, 30, null, IntPtr.Zero);
            this.buttonConfiguracion.Location = new System.Drawing.Point(525, 6);
            this.buttonConfiguracion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonConfiguracion.Name = "buttonConfiguracion";
            this.buttonConfiguracion.Size = new System.Drawing.Size(35, 32);
            this.buttonConfiguracion.TabIndex = 39;
            this.buttonConfiguracion.UseVisualStyleBackColor = false;
            this.buttonConfiguracion.Click += new System.EventHandler(this.buttonConfiguracion_Click);
            // 
            // comboBoxFuncionesPertenencia
            // 
            this.comboBoxFuncionesPertenencia.FormattingEnabled = true;
            this.comboBoxFuncionesPertenencia.Items.AddRange(new object[] {
            "Triangular",
            "Trapezoidal",
            "Gausiana"});
            this.comboBoxFuncionesPertenencia.Location = new System.Drawing.Point(295, 8);
            this.comboBoxFuncionesPertenencia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxFuncionesPertenencia.Name = "comboBoxFuncionesPertenencia";
            this.comboBoxFuncionesPertenencia.Size = new System.Drawing.Size(154, 28);
            this.comboBoxFuncionesPertenencia.TabIndex = 37;
            // 
            // labelNombreFuncion
            // 
            this.labelNombreFuncion.AutoSize = true;
            this.labelNombreFuncion.Location = new System.Drawing.Point(7, 12);
            this.labelNombreFuncion.Name = "labelNombreFuncion";
            this.labelNombreFuncion.Size = new System.Drawing.Size(64, 20);
            this.labelNombreFuncion.TabIndex = 36;
            this.labelNombreFuncion.Text = "Nombre";
            // 
            // FuncionPertenenciaUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "FuncionPertenenciaUserControl";
            this.Size = new System.Drawing.Size(570, 50);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox textBoxNombreFuncionPertenencia;
        private Button buttonConfiguracion;
        private ComboBox comboBoxFuncionesPertenencia;
        private Label labelNombreFuncion;
        private Button eliminarButton;
    }
}
