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
            this.buttonPintar = new System.Windows.Forms.Button();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.textBoxNombreFuncionPertenencia = new System.Windows.Forms.TextBox();
            this.buttonConfiguracion = new System.Windows.Forms.Button();
            this.comboBoxFuncionesPertenencia = new System.Windows.Forms.ComboBox();
            this.labelNombreFuncion = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonPintar);
            this.panel1.Controls.Add(this.eliminarButton);
            this.panel1.Controls.Add(this.textBoxNombreFuncionPertenencia);
            this.panel1.Controls.Add(this.buttonConfiguracion);
            this.panel1.Controls.Add(this.comboBoxFuncionesPertenencia);
            this.panel1.Controls.Add(this.labelNombreFuncion);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 55);
            this.panel1.TabIndex = 0;
            // 
            // buttonPintar
            // 
            this.buttonPintar.BackColor = System.Drawing.Color.Red;
            this.buttonPintar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonPintar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPintar.FlatAppearance.BorderSize = 0;
            this.buttonPintar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPintar.Image = ((System.Drawing.Image)(resources.GetObject("buttonPintar.Image")));
            this.buttonPintar.Location = new System.Drawing.Point(606, 8);
            this.buttonPintar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPintar.Name = "buttonPintar";
            this.buttonPintar.Size = new System.Drawing.Size(44, 40);
            this.buttonPintar.TabIndex = 41;
            this.buttonPintar.UseVisualStyleBackColor = false;
            this.buttonPintar.Click += new System.EventHandler(this.buttonPintar_Click);
            // 
            // eliminarButton
            // 
            this.eliminarButton.BackColor = System.Drawing.Color.Transparent;
            this.eliminarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.eliminarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminarButton.FlatAppearance.BorderSize = 0;
            this.eliminarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("eliminarButton.Image")));
            this.eliminarButton.Location = new System.Drawing.Point(660, 6);
            this.eliminarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(44, 40);
            this.eliminarButton.TabIndex = 40;
            this.eliminarButton.UseVisualStyleBackColor = false;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click_1);
            // 
            // textBoxNombreFuncionPertenencia
            // 
            this.textBoxNombreFuncionPertenencia.Location = new System.Drawing.Point(91, 11);
            this.textBoxNombreFuncionPertenencia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNombreFuncionPertenencia.Name = "textBoxNombreFuncionPertenencia";
            this.textBoxNombreFuncionPertenencia.Size = new System.Drawing.Size(233, 31);
            this.textBoxNombreFuncionPertenencia.TabIndex = 38;
            this.textBoxNombreFuncionPertenencia.Leave += new System.EventHandler(this.textBoxNombreFuncionPertenencia_Leave);
            // 
            // buttonConfiguracion
            // 
            this.buttonConfiguracion.BackColor = System.Drawing.Color.Transparent;
            this.buttonConfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConfiguracion.FlatAppearance.BorderSize = 0;
            this.buttonConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfiguracion.Image = ((System.Drawing.Image)(resources.GetObject("buttonConfiguracion.Image")));
            this.buttonConfiguracion.Location = new System.Drawing.Point(550, 6);
            this.buttonConfiguracion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonConfiguracion.Name = "buttonConfiguracion";
            this.buttonConfiguracion.Size = new System.Drawing.Size(44, 40);
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
            "Gaussiana"});
            this.comboBoxFuncionesPertenencia.Location = new System.Drawing.Point(340, 10);
            this.comboBoxFuncionesPertenencia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxFuncionesPertenencia.Name = "comboBoxFuncionesPertenencia";
            this.comboBoxFuncionesPertenencia.Size = new System.Drawing.Size(192, 33);
            this.comboBoxFuncionesPertenencia.TabIndex = 37;
            this.comboBoxFuncionesPertenencia.Text = "Triangular";
            // 
            // labelNombreFuncion
            // 
            this.labelNombreFuncion.AutoSize = true;
            this.labelNombreFuncion.Location = new System.Drawing.Point(9, 15);
            this.labelNombreFuncion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombreFuncion.Name = "labelNombreFuncion";
            this.labelNombreFuncion.Size = new System.Drawing.Size(78, 25);
            this.labelNombreFuncion.TabIndex = 36;
            this.labelNombreFuncion.Text = "Nombre";
            // 
            // FuncionPertenenciaUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FuncionPertenenciaUserControl";
            this.Size = new System.Drawing.Size(712, 62);
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
        private Button buttonPintar;
        private ColorDialog colorDialog1;
    }
}
