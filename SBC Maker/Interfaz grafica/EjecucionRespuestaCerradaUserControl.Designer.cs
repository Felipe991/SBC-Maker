namespace SBC_Maker.Interfaz_grafica
{
    partial class EjecucionRespuestaCerradaUserControl
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
            this.groupBoxAlternativas = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // groupBoxAlternativas
            // 
            this.groupBoxAlternativas.Location = new System.Drawing.Point(3, 3);
            this.groupBoxAlternativas.Name = "groupBoxAlternativas";
            this.groupBoxAlternativas.Size = new System.Drawing.Size(414, 158);
            this.groupBoxAlternativas.TabIndex = 0;
            this.groupBoxAlternativas.TabStop = false;
            // 
            // EjecucionRespuestaCerradaUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxAlternativas);
            this.Name = "EjecucionRespuestaCerradaUserControl";
            this.Size = new System.Drawing.Size(420, 164);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxAlternativas;
    }
}
