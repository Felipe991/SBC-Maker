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
            this.richTextBoxExplicacionProposicional = new System.Windows.Forms.RichTextBox();
            this.labelExplicación = new System.Windows.Forms.Label();
            this.labelIndicacion = new System.Windows.Forms.Label();
            this.richTextBoxIndicacion = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxExplicacionNatural = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // nombreConclusionLabel
            // 
            this.nombreConclusionLabel.AutoSize = true;
            this.nombreConclusionLabel.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nombreConclusionLabel.Location = new System.Drawing.Point(23, 12);
            this.nombreConclusionLabel.Name = "nombreConclusionLabel";
            this.nombreConclusionLabel.Size = new System.Drawing.Size(173, 23);
            this.nombreConclusionLabel.TabIndex = 0;
            this.nombreConclusionLabel.Text = "NombreConclusion";
            // 
            // richTextBoxExplicacionProposicional
            // 
            this.richTextBoxExplicacionProposicional.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBoxExplicacionProposicional.Location = new System.Drawing.Point(24, 367);
            this.richTextBoxExplicacionProposicional.Name = "richTextBoxExplicacionProposicional";
            this.richTextBoxExplicacionProposicional.ReadOnly = true;
            this.richTextBoxExplicacionProposicional.Size = new System.Drawing.Size(900, 124);
            this.richTextBoxExplicacionProposicional.TabIndex = 1;
            this.richTextBoxExplicacionProposicional.Text = "";
            this.richTextBoxExplicacionProposicional.WordWrap = false;
            // 
            // labelExplicación
            // 
            this.labelExplicación.AutoSize = true;
            this.labelExplicación.Font = new System.Drawing.Font("Segoe UI Historic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelExplicación.Location = new System.Drawing.Point(24, 347);
            this.labelExplicación.Name = "labelExplicación";
            this.labelExplicación.Size = new System.Drawing.Size(156, 17);
            this.labelExplicación.TabIndex = 2;
            this.labelExplicación.Text = "Explicación proposicional";
            // 
            // labelIndicacion
            // 
            this.labelIndicacion.AutoSize = true;
            this.labelIndicacion.Font = new System.Drawing.Font("Segoe UI Historic", 10.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelIndicacion.Location = new System.Drawing.Point(23, 52);
            this.labelIndicacion.Name = "labelIndicacion";
            this.labelIndicacion.Size = new System.Drawing.Size(92, 25);
            this.labelIndicacion.TabIndex = 3;
            this.labelIndicacion.Text = "Indicación";
            // 
            // richTextBoxIndicacion
            // 
            this.richTextBoxIndicacion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBoxIndicacion.Location = new System.Drawing.Point(23, 80);
            this.richTextBoxIndicacion.Name = "richTextBoxIndicacion";
            this.richTextBoxIndicacion.ReadOnly = true;
            this.richTextBoxIndicacion.Size = new System.Drawing.Size(900, 96);
            this.richTextBoxIndicacion.TabIndex = 4;
            this.richTextBoxIndicacion.Text = "";
            this.richTextBoxIndicacion.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Explicación";
            // 
            // richTextBoxExplicacionNatural
            // 
            this.richTextBoxExplicacionNatural.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBoxExplicacionNatural.Location = new System.Drawing.Point(23, 209);
            this.richTextBoxExplicacionNatural.Name = "richTextBoxExplicacionNatural";
            this.richTextBoxExplicacionNatural.ReadOnly = true;
            this.richTextBoxExplicacionNatural.Size = new System.Drawing.Size(901, 124);
            this.richTextBoxExplicacionNatural.TabIndex = 5;
            this.richTextBoxExplicacionNatural.Text = "";
            this.richTextBoxExplicacionNatural.WordWrap = false;
            // 
            // ConclusionUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxExplicacionNatural);
            this.Controls.Add(this.richTextBoxIndicacion);
            this.Controls.Add(this.labelIndicacion);
            this.Controls.Add(this.labelExplicación);
            this.Controls.Add(this.richTextBoxExplicacionProposicional);
            this.Controls.Add(this.nombreConclusionLabel);
            this.Name = "ConclusionUserControl";
            this.Size = new System.Drawing.Size(944, 514);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nombreConclusionLabel;
        private RichTextBox richTextBoxExplicacionProposicional;
        private Label labelExplicación;
        private Label labelIndicacion;
        private RichTextBox richTextBoxIndicacion;
        private Label label1;
        private RichTextBox richTextBoxExplicacionNatural;
    }
}
