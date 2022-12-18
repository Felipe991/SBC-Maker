namespace SBC_Maker
{
    [Serializable]
    partial class MenuConjuntoDifuso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuConjuntoDifuso));
            this.CancelarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.addFuncionButton = new System.Windows.Forms.Button();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanelFuncionesPertenencia = new System.Windows.Forms.FlowLayoutPanel();
            this.labelNombreUnidad = new System.Windows.Forms.Label();
            this.textBoxNombreUnidad = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.comboBoxMetodosResolucion = new System.Windows.Forms.ComboBox();
            this.labelMetodoResolucion = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(391, 507);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 23;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(472, 507);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 22;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // addFuncionButton
            // 
            this.addFuncionButton.BackColor = System.Drawing.Color.Transparent;
            this.addFuncionButton.FlatAppearance.BorderSize = 0;
            this.addFuncionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFuncionButton.Image = ((System.Drawing.Image)(resources.GetObject("addFuncionButton.Image")));
            this.addFuncionButton.Location = new System.Drawing.Point(516, 296);
            this.addFuncionButton.Name = "addFuncionButton";
            this.addFuncionButton.Size = new System.Drawing.Size(31, 24);
            this.addFuncionButton.TabIndex = 29;
            this.addFuncionButton.UseVisualStyleBackColor = false;
            this.addFuncionButton.Click += new System.EventHandler(this.addFuncionButton_Click);
            // 
            // formsPlot1
            // 
            this.formsPlot1.Enabled = false;
            this.formsPlot1.Location = new System.Drawing.Point(12, 83);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(535, 213);
            this.formsPlot1.TabIndex = 30;
            this.formsPlot1.Load += new System.EventHandler(this.formsPlot1_Load);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(134, 16);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(170, 23);
            this.textBoxNombre.TabIndex = 33;
            this.textBoxNombre.Text = "Conjunto Difuso";
            this.textBoxNombre.Leave += new System.EventHandler(this.textBoxNombre_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "Funciones de pertenencia";
            // 
            // flowLayoutPanelFuncionesPertenencia
            // 
            this.flowLayoutPanelFuncionesPertenencia.AutoScroll = true;
            this.flowLayoutPanelFuncionesPertenencia.Location = new System.Drawing.Point(13, 322);
            this.flowLayoutPanelFuncionesPertenencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelFuncionesPertenencia.Name = "flowLayoutPanelFuncionesPertenencia";
            this.flowLayoutPanelFuncionesPertenencia.Size = new System.Drawing.Size(534, 170);
            this.flowLayoutPanelFuncionesPertenencia.TabIndex = 35;
            this.flowLayoutPanelFuncionesPertenencia.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.flowLayoutPanelFuncionesPertenencia_ControlAdded);
            this.flowLayoutPanelFuncionesPertenencia.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.flowLayoutPanelFuncionesPertenencia_ControlRemoved);
            // 
            // labelNombreUnidad
            // 
            this.labelNombreUnidad.AutoSize = true;
            this.labelNombreUnidad.Location = new System.Drawing.Point(27, 61);
            this.labelNombreUnidad.Name = "labelNombreUnidad";
            this.labelNombreUnidad.Size = new System.Drawing.Size(92, 15);
            this.labelNombreUnidad.TabIndex = 36;
            this.labelNombreUnidad.Text = "Nombre Unidad";
            // 
            // textBoxNombreUnidad
            // 
            this.textBoxNombreUnidad.Location = new System.Drawing.Point(134, 56);
            this.textBoxNombreUnidad.Name = "textBoxNombreUnidad";
            this.textBoxNombreUnidad.Size = new System.Drawing.Size(170, 23);
            this.textBoxNombreUnidad.TabIndex = 37;
            this.textBoxNombreUnidad.Text = "Unidades";
            this.textBoxNombreUnidad.Leave += new System.EventHandler(this.textBoxNombreUnidad_Leave);
            // 
            // comboBoxMetodosResolucion
            // 
            this.comboBoxMetodosResolucion.FormattingEnabled = true;
            this.comboBoxMetodosResolucion.Items.AddRange(new object[] {
            "Hacia arriba",
            "Hacia abajo",
            "Caso sensible"});
            this.comboBoxMetodosResolucion.Location = new System.Drawing.Point(360, 39);
            this.comboBoxMetodosResolucion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMetodosResolucion.Name = "comboBoxMetodosResolucion";
            this.comboBoxMetodosResolucion.Size = new System.Drawing.Size(170, 23);
            this.comboBoxMetodosResolucion.TabIndex = 38;
            this.comboBoxMetodosResolucion.Text = "Hacia arriba";
            this.comboBoxMetodosResolucion.SelectedIndexChanged += new System.EventHandler(this.comboBoxMetodosResolucion_SelectedIndexChanged);
            // 
            // labelMetodoResolucion
            // 
            this.labelMetodoResolucion.AutoSize = true;
            this.labelMetodoResolucion.Location = new System.Drawing.Point(360, 22);
            this.labelMetodoResolucion.Name = "labelMetodoResolucion";
            this.labelMetodoResolucion.Size = new System.Drawing.Size(126, 15);
            this.labelMetodoResolucion.TabIndex = 39;
            this.labelMetodoResolucion.Text = "Metodo de Resolucion";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.AddExtension = false;
            this.saveFileDialog1.InitialDirectory = "C:\\Users\\PIPEX\\Documents\\Conjuntos Difusos";
            // 
            // MenuConjuntoDifuso
            // 
            this.AcceptButton = this.GuardarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarButton;
            this.ClientSize = new System.Drawing.Size(559, 553);
            this.Controls.Add(this.labelMetodoResolucion);
            this.Controls.Add(this.comboBoxMetodosResolucion);
            this.Controls.Add(this.textBoxNombreUnidad);
            this.Controls.Add(this.labelNombreUnidad);
            this.Controls.Add(this.flowLayoutPanelFuncionesPertenencia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addFuncionButton);
            this.Controls.Add(this.formsPlot1);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.GuardarButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuConjuntoDifuso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuConjuntoDifuso";
            this.Load += new System.EventHandler(this.MenuConjuntoDifuso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CancelarButton;
        private Button GuardarButton;
        private Button addFuncionButton;
        private ScottPlot.FormsPlot formsPlot1;
        private TextBox textBoxNombre;
        private Label label1;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanelFuncionesPertenencia;
        private Label labelNombreUnidad;
        private TextBox textBoxNombreUnidad;
        private ColorDialog colorDialog1;
        private ComboBox comboBoxMetodosResolucion;
        private Label labelMetodoResolucion;
        private SaveFileDialog saveFileDialog1;
    }
}