namespace SBC_Maker.Interfaz_grafica
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 49);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonPintar
            // 
            this.buttonPintar.BackColor = System.Drawing.Color.Red;
            this.buttonPintar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonPintar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPintar.FlatAppearance.BorderSize = 0;
            this.buttonPintar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPintar.Image = ((System.Drawing.Image)(resources.GetObject("buttonPintar.Image")));
            this.buttonPintar.Location = new System.Drawing.Point(425, 12);
            this.buttonPintar.Name = "buttonPintar";
            this.buttonPintar.Size = new System.Drawing.Size(31, 23);
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
            this.eliminarButton.Location = new System.Drawing.Point(462, 11);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(31, 24);
            this.eliminarButton.TabIndex = 40;
            this.eliminarButton.UseVisualStyleBackColor = false;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click_1);
            // 
            // textBoxNombreFuncionPertenencia
            // 
            this.textBoxNombreFuncionPertenencia.Location = new System.Drawing.Point(64, 12);
            this.textBoxNombreFuncionPertenencia.Name = "textBoxNombreFuncionPertenencia";
            this.textBoxNombreFuncionPertenencia.Size = new System.Drawing.Size(164, 23);
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
            this.buttonConfiguracion.Location = new System.Drawing.Point(379, 4);
            this.buttonConfiguracion.Name = "buttonConfiguracion";
            this.buttonConfiguracion.Size = new System.Drawing.Size(31, 38);
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
            this.comboBoxFuncionesPertenencia.Location = new System.Drawing.Point(238, 12);
            this.comboBoxFuncionesPertenencia.Name = "comboBoxFuncionesPertenencia";
            this.comboBoxFuncionesPertenencia.Size = new System.Drawing.Size(135, 23);
            this.comboBoxFuncionesPertenencia.TabIndex = 37;
            this.comboBoxFuncionesPertenencia.Text = "Triangular";
            this.comboBoxFuncionesPertenencia.SelectedIndexChanged += new System.EventHandler(this.comboBoxFuncionesPertenencia_SelectedIndexChanged);
            // 
            // labelNombreFuncion
            // 
            this.labelNombreFuncion.AutoSize = true;
            this.labelNombreFuncion.Location = new System.Drawing.Point(6, 16);
            this.labelNombreFuncion.Name = "labelNombreFuncion";
            this.labelNombreFuncion.Size = new System.Drawing.Size(51, 15);
            this.labelNombreFuncion.TabIndex = 36;
            this.labelNombreFuncion.Text = "Nombre";
            // 
            // FuncionPertenenciaUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FuncionPertenenciaUserControl";
            this.Size = new System.Drawing.Size(499, 53);
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
