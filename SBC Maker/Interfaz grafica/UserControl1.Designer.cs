namespace SBC_Maker.Interfaz_grafica
{
    partial class UserControl1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxNombreFuncionPertenencia = new System.Windows.Forms.TextBox();
            this.buttonConfiguracion = new System.Windows.Forms.Button();
            this.comboBoxFuncionesPertenencia = new System.Windows.Forms.ComboBox();
            this.labelNombreFuncion = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxNombreFuncionPertenencia);
            this.panel1.Controls.Add(this.buttonConfiguracion);
            this.panel1.Controls.Add(this.comboBoxFuncionesPertenencia);
            this.panel1.Controls.Add(this.labelNombreFuncion);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 44);
            this.panel1.TabIndex = 0;
            // 
            // textBoxNombreFuncionPertenencia
            // 
            this.textBoxNombreFuncionPertenencia.Location = new System.Drawing.Point(73, 9);
            this.textBoxNombreFuncionPertenencia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNombreFuncionPertenencia.Name = "textBoxNombreFuncionPertenencia";
            this.textBoxNombreFuncionPertenencia.Size = new System.Drawing.Size(260, 27);
            this.textBoxNombreFuncionPertenencia.TabIndex = 38;
            // 
            // buttonConfiguracion
            // 
            this.buttonConfiguracion.BackColor = System.Drawing.Color.Transparent;
            this.buttonConfiguracion.BackgroundImage = global::SBC_Maker.Properties.Resources.iconoConfiguracion;
            this.buttonConfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConfiguracion.FlatAppearance.BorderSize = 0;
            this.buttonConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfiguracion.Image = global::SBC_Maker.Properties.Resources.iconoConfiguracion;
            this.buttonConfiguracion.Location = new System.Drawing.Point(513, 9);
            this.buttonConfiguracion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonConfiguracion.Name = "buttonConfiguracion";
            this.buttonConfiguracion.Size = new System.Drawing.Size(35, 32);
            this.buttonConfiguracion.TabIndex = 39;
            this.buttonConfiguracion.UseVisualStyleBackColor = false;
            this.buttonConfiguracion.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxFuncionesPertenencia
            // 
            this.comboBoxFuncionesPertenencia.FormattingEnabled = true;
            this.comboBoxFuncionesPertenencia.Items.AddRange(new object[] {
            "Triangular",
            "Trapezoidal",
            "Gausiana"});
            this.comboBoxFuncionesPertenencia.Location = new System.Drawing.Point(339, 9);
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
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(570, 49);
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
    }
}
