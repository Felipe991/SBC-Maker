namespace SBC_Maker.Interfaz_grafica
{
    partial class EjecucionRespuestaDifusaUserControl
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
            this.trackBarRespuestaDifusa = new System.Windows.Forms.TrackBar();
            this.labelUnidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRespuestaDifusa)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarRespuestaDifusa
            // 
            this.trackBarRespuestaDifusa.Location = new System.Drawing.Point(27, 48);
            this.trackBarRespuestaDifusa.Name = "trackBarRespuestaDifusa";
            this.trackBarRespuestaDifusa.Size = new System.Drawing.Size(357, 56);
            this.trackBarRespuestaDifusa.TabIndex = 0;
            this.trackBarRespuestaDifusa.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarRespuestaDifusa.Scroll += new System.EventHandler(this.trackBarRespuestaDifusa_Scroll);
            // 
            // labelUnidad
            // 
            this.labelUnidad.AutoSize = true;
            this.labelUnidad.Location = new System.Drawing.Point(171, 126);
            this.labelUnidad.Name = "labelUnidad";
            this.labelUnidad.Size = new System.Drawing.Size(71, 20);
            this.labelUnidad.TabIndex = 1;
            this.labelUnidad.Text = "Unidades";
            // 
            // EjecucionRespuestaDifusaUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelUnidad);
            this.Controls.Add(this.trackBarRespuestaDifusa);
            this.Name = "EjecucionRespuestaDifusaUserControl";
            this.Size = new System.Drawing.Size(420, 164);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRespuestaDifusa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TrackBar trackBarRespuestaDifusa;
        private Label labelUnidad;
    }
}
