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
            this.CancelarButton.Location = new System.Drawing.Point(447, 676);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(86, 31);
            this.CancelarButton.TabIndex = 23;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(540, 676);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(86, 31);
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
            this.addFuncionButton.Location = new System.Drawing.Point(590, 395);
            this.addFuncionButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addFuncionButton.Name = "addFuncionButton";
            this.addFuncionButton.Size = new System.Drawing.Size(35, 32);
            this.addFuncionButton.TabIndex = 29;
            this.addFuncionButton.UseVisualStyleBackColor = false;
            this.addFuncionButton.Click += new System.EventHandler(this.addFuncionButton_Click);
            // 
            // formsPlot1
            // 
            this.formsPlot1.Enabled = false;
            this.formsPlot1.Location = new System.Drawing.Point(14, 111);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(611, 284);
            this.formsPlot1.TabIndex = 30;
            this.formsPlot1.Load += new System.EventHandler(this.formsPlot1_Load);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(153, 21);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(194, 27);
            this.textBoxNombre.TabIndex = 33;
            this.textBoxNombre.Text = "Conjunto Difuso";
            this.textBoxNombre.Leave += new System.EventHandler(this.textBoxNombre_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Funciones de pertenencia";
            // 
            // flowLayoutPanelFuncionesPertenencia
            // 
            this.flowLayoutPanelFuncionesPertenencia.AutoScroll = true;
            this.flowLayoutPanelFuncionesPertenencia.Location = new System.Drawing.Point(33, 429);
            this.flowLayoutPanelFuncionesPertenencia.Name = "flowLayoutPanelFuncionesPertenencia";
            this.flowLayoutPanelFuncionesPertenencia.Size = new System.Drawing.Size(592, 227);
            this.flowLayoutPanelFuncionesPertenencia.TabIndex = 35;
            this.flowLayoutPanelFuncionesPertenencia.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.flowLayoutPanelFuncionesPertenencia_ControlAdded);
            this.flowLayoutPanelFuncionesPertenencia.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.flowLayoutPanelFuncionesPertenencia_ControlRemoved);
            // 
            // labelNombreUnidad
            // 
            this.labelNombreUnidad.AutoSize = true;
            this.labelNombreUnidad.Location = new System.Drawing.Point(31, 81);
            this.labelNombreUnidad.Name = "labelNombreUnidad";
            this.labelNombreUnidad.Size = new System.Drawing.Size(116, 20);
            this.labelNombreUnidad.TabIndex = 36;
            this.labelNombreUnidad.Text = "Nombre Unidad";
            // 
            // textBoxNombreUnidad
            // 
            this.textBoxNombreUnidad.Location = new System.Drawing.Point(153, 74);
            this.textBoxNombreUnidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNombreUnidad.Name = "textBoxNombreUnidad";
            this.textBoxNombreUnidad.Size = new System.Drawing.Size(194, 27);
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
            this.comboBoxMetodosResolucion.Location = new System.Drawing.Point(411, 52);
            this.comboBoxMetodosResolucion.Name = "comboBoxMetodosResolucion";
            this.comboBoxMetodosResolucion.Size = new System.Drawing.Size(194, 28);
            this.comboBoxMetodosResolucion.TabIndex = 38;
            this.comboBoxMetodosResolucion.Text = "Hacia arriba";
            this.comboBoxMetodosResolucion.SelectedIndexChanged += new System.EventHandler(this.comboBoxMetodosResolucion_SelectedIndexChanged);
            // 
            // labelMetodoResolucion
            // 
            this.labelMetodoResolucion.AutoSize = true;
            this.labelMetodoResolucion.Location = new System.Drawing.Point(411, 29);
            this.labelMetodoResolucion.Name = "labelMetodoResolucion";
            this.labelMetodoResolucion.Size = new System.Drawing.Size(159, 20);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarButton;
            this.ClientSize = new System.Drawing.Size(639, 737);
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