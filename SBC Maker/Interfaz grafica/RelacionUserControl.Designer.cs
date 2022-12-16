namespace SBC_Maker.Interfaz_grafica
{
    partial class RelacionUserControl
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
            this.labelAntecedente = new System.Windows.Forms.Label();
            this.labelConsecuente = new System.Windows.Forms.Label();
            this.labelFlecha = new System.Windows.Forms.Label();
            this.labelRespuesta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAntecedente
            // 
            this.labelAntecedente.AutoSize = true;
            this.labelAntecedente.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAntecedente.Location = new System.Drawing.Point(45, 8);
            this.labelAntecedente.Name = "labelAntecedente";
            this.labelAntecedente.Size = new System.Drawing.Size(74, 15);
            this.labelAntecedente.TabIndex = 0;
            this.labelAntecedente.Text = "Antecedente";
            // 
            // labelConsecuente
            // 
            this.labelConsecuente.AutoSize = true;
            this.labelConsecuente.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelConsecuente.Location = new System.Drawing.Point(233, 11);
            this.labelConsecuente.Name = "labelConsecuente";
            this.labelConsecuente.Size = new System.Drawing.Size(109, 23);
            this.labelConsecuente.TabIndex = 1;
            this.labelConsecuente.Text = "Consecuente";
            // 
            // labelFlecha
            // 
            this.labelFlecha.AutoSize = true;
            this.labelFlecha.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFlecha.Location = new System.Drawing.Point(178, 11);
            this.labelFlecha.Name = "labelFlecha";
            this.labelFlecha.Size = new System.Drawing.Size(29, 23);
            this.labelFlecha.TabIndex = 43;
            this.labelFlecha.Text = "🡺";
            // 
            // labelRespuesta
            // 
            this.labelRespuesta.AutoSize = true;
            this.labelRespuesta.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRespuesta.Location = new System.Drawing.Point(45, 23);
            this.labelRespuesta.Name = "labelRespuesta";
            this.labelRespuesta.Size = new System.Drawing.Size(32, 15);
            this.labelRespuesta.TabIndex = 44;
            this.labelRespuesta.Text = "Resp";
            // 
            // RelacionUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelRespuesta);
            this.Controls.Add(this.labelFlecha);
            this.Controls.Add(this.labelConsecuente);
            this.Controls.Add(this.labelAntecedente);
            this.Name = "RelacionUserControl";
            this.Size = new System.Drawing.Size(394, 45);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelAntecedente;
        private Label labelConsecuente;
        private Label labelFlecha;
        private Label labelRespuesta;
    }
}
