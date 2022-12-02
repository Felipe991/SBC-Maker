namespace SBC_Maker.Interfaz_grafica
{
    partial class PreguntaCerradaUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreguntaCerradaUserControl));
            this.addFuncionButton = new System.Windows.Forms.Button();
            this.flowLayoutPanelRespuesta = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // addFuncionButton
            // 
            this.addFuncionButton.BackColor = System.Drawing.Color.Transparent;
            this.addFuncionButton.FlatAppearance.BorderSize = 0;
            this.addFuncionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFuncionButton.Image = ((System.Drawing.Image)(resources.GetObject("addFuncionButton.Image")));
            this.addFuncionButton.Location = new System.Drawing.Point(441, 3);
            this.addFuncionButton.Name = "addFuncionButton";
            this.addFuncionButton.Size = new System.Drawing.Size(31, 24);
            this.addFuncionButton.TabIndex = 30;
            this.addFuncionButton.UseVisualStyleBackColor = false;
            this.addFuncionButton.Click += new System.EventHandler(this.addFuncionButton_Click);
            // 
            // flowLayoutPanelRespuesta
            // 
            this.flowLayoutPanelRespuesta.AutoScroll = true;
            this.flowLayoutPanelRespuesta.Location = new System.Drawing.Point(3, 32);
            this.flowLayoutPanelRespuesta.Name = "flowLayoutPanelRespuesta";
            this.flowLayoutPanelRespuesta.Size = new System.Drawing.Size(472, 112);
            this.flowLayoutPanelRespuesta.TabIndex = 31;
            // 
            // PreguntaCerradaUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanelRespuesta);
            this.Controls.Add(this.addFuncionButton);
            this.Name = "PreguntaCerradaUserControl";
            this.Size = new System.Drawing.Size(478, 147);
            this.ResumeLayout(false);

        }

        #endregion
        private Button addFuncionButton;
        public FlowLayoutPanel flowLayoutPanelRespuesta;
    }
}
