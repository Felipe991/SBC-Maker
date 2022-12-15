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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelExplicación = new System.Windows.Forms.Label();
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
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(4, 43);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(449, 72);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // labelExplicación
            // 
            this.labelExplicación.AutoSize = true;
            this.labelExplicación.Font = new System.Drawing.Font("Segoe UI Historic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelExplicación.Location = new System.Drawing.Point(4, 23);
            this.labelExplicación.Name = "labelExplicación";
            this.labelExplicación.Size = new System.Drawing.Size(72, 17);
            this.labelExplicación.TabIndex = 2;
            this.labelExplicación.Text = "Explicación";
            // 
            // ConclusionUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelExplicación);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.nombreConclusionLabel);
            this.Name = "ConclusionUserControl";
            this.Size = new System.Drawing.Size(458, 135);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nombreConclusionLabel;
        private RichTextBox richTextBox1;
        private Label labelExplicación;
    }
}
