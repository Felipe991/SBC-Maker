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
            this.groupBoxAlternativas.AutoSize = true;
            this.groupBoxAlternativas.Location = new System.Drawing.Point(14, 11);
            this.groupBoxAlternativas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxAlternativas.Name = "groupBoxAlternativas";
            this.groupBoxAlternativas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxAlternativas.Size = new System.Drawing.Size(342, 100);
            this.groupBoxAlternativas.TabIndex = 0;
            this.groupBoxAlternativas.TabStop = false;
            // 
            // EjecucionRespuestaCerradaUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxAlternativas);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EjecucionRespuestaCerradaUserControl";
            this.Size = new System.Drawing.Size(368, 123);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBoxAlternativas;
    }
}
