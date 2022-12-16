namespace SBC_Maker.Interfaz_grafica
{
    partial class ConclusionUserControl
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
            this.nombreConclusionLabel = new System.Windows.Forms.Label();
            this.richTextBoxExplicacion = new System.Windows.Forms.RichTextBox();
            this.labelExplicación = new System.Windows.Forms.Label();
            this.labelIndicacion = new System.Windows.Forms.Label();
            this.richTextBoxIndicacion = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // nombreConclusionLabel
            // 
            this.nombreConclusionLabel.AutoSize = true;
            this.nombreConclusionLabel.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nombreConclusionLabel.Location = new System.Drawing.Point(0, 0);
            this.nombreConclusionLabel.Name = "nombreConclusionLabel";
            this.nombreConclusionLabel.Size = new System.Drawing.Size(173, 23);
            this.nombreConclusionLabel.TabIndex = 0;
            this.nombreConclusionLabel.Text = "NombreConclusion";
            // 
            // richTextBoxExplicacion
            // 
            this.richTextBoxExplicacion.Location = new System.Drawing.Point(3, 127);
            this.richTextBoxExplicacion.Name = "richTextBoxExplicacion";
            this.richTextBoxExplicacion.Size = new System.Drawing.Size(449, 76);
            this.richTextBoxExplicacion.TabIndex = 1;
            this.richTextBoxExplicacion.Text = "";
            this.richTextBoxExplicacion.WordWrap = false;
            // 
            // labelExplicación
            // 
            this.labelExplicación.AutoSize = true;
            this.labelExplicación.Font = new System.Drawing.Font("Segoe UI Historic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelExplicación.Location = new System.Drawing.Point(3, 107);
            this.labelExplicación.Name = "labelExplicación";
            this.labelExplicación.Size = new System.Drawing.Size(72, 17);
            this.labelExplicación.TabIndex = 2;
            this.labelExplicación.Text = "Explicación";
            // 
            // labelIndicacion
            // 
            this.labelIndicacion.AutoSize = true;
            this.labelIndicacion.Font = new System.Drawing.Font("Segoe UI Historic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelIndicacion.Location = new System.Drawing.Point(3, 29);
            this.labelIndicacion.Name = "labelIndicacion";
            this.labelIndicacion.Size = new System.Drawing.Size(88, 23);
            this.labelIndicacion.TabIndex = 3;
            this.labelIndicacion.Text = "Indicación";
            // 
            // richTextBoxIndicacion
            // 
            this.richTextBoxIndicacion.Location = new System.Drawing.Point(3, 55);
            this.richTextBoxIndicacion.Name = "richTextBoxIndicacion";
            this.richTextBoxIndicacion.Size = new System.Drawing.Size(449, 49);
            this.richTextBoxIndicacion.TabIndex = 4;
            this.richTextBoxIndicacion.Text = "";
            this.richTextBoxIndicacion.WordWrap = false;
            // 
            // ConclusionUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBoxIndicacion);
            this.Controls.Add(this.labelIndicacion);
            this.Controls.Add(this.labelExplicación);
            this.Controls.Add(this.richTextBoxExplicacion);
            this.Controls.Add(this.nombreConclusionLabel);
            this.Name = "ConclusionUserControl";
            this.Size = new System.Drawing.Size(458, 216);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nombreConclusionLabel;
        private RichTextBox richTextBoxExplicacion;
        private Label labelExplicación;
        private Label labelIndicacion;
        private RichTextBox richTextBoxIndicacion;
    }
}
