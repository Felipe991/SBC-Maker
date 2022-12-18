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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelacionUserControl));
            this.labelFlecha = new System.Windows.Forms.Label();
            this.buttonConfiguracion = new System.Windows.Forms.Button();
            this.richTextBoxAntecedente = new System.Windows.Forms.RichTextBox();
            this.richTextBoxConsecuente = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labelFlecha
            // 
            this.labelFlecha.AutoSize = true;
            this.labelFlecha.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFlecha.Location = new System.Drawing.Point(230, 22);
            this.labelFlecha.Name = "labelFlecha";
            this.labelFlecha.Size = new System.Drawing.Size(25, 19);
            this.labelFlecha.TabIndex = 43;
            this.labelFlecha.Text = "🡺";
            // 
            // buttonConfiguracion
            // 
            this.buttonConfiguracion.BackColor = System.Drawing.Color.Transparent;
            this.buttonConfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConfiguracion.FlatAppearance.BorderSize = 0;
            this.buttonConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfiguracion.Image = ((System.Drawing.Image)(resources.GetObject("buttonConfiguracion.Image")));
            this.buttonConfiguracion.Location = new System.Drawing.Point(9, 10);
            this.buttonConfiguracion.Name = "buttonConfiguracion";
            this.buttonConfiguracion.Size = new System.Drawing.Size(42, 39);
            this.buttonConfiguracion.TabIndex = 45;
            this.buttonConfiguracion.UseVisualStyleBackColor = false;
            this.buttonConfiguracion.Click += new System.EventHandler(this.buttonConfiguracion_Click);
            // 
            // richTextBoxAntecedente
            // 
            this.richTextBoxAntecedente.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxAntecedente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxAntecedente.Location = new System.Drawing.Point(62, 11);
            this.richTextBoxAntecedente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxAntecedente.Name = "richTextBoxAntecedente";
            this.richTextBoxAntecedente.Size = new System.Drawing.Size(162, 39);
            this.richTextBoxAntecedente.TabIndex = 46;
            this.richTextBoxAntecedente.Text = "Antecedente\n(RESPUESTA)";
            // 
            // richTextBoxConsecuente
            // 
            this.richTextBoxConsecuente.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxConsecuente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxConsecuente.Location = new System.Drawing.Point(261, 22);
            this.richTextBoxConsecuente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxConsecuente.Name = "richTextBoxConsecuente";
            this.richTextBoxConsecuente.Size = new System.Drawing.Size(193, 28);
            this.richTextBoxConsecuente.TabIndex = 47;
            this.richTextBoxConsecuente.Text = "CONSECUENTE";
            // 
            // RelacionUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBoxConsecuente);
            this.Controls.Add(this.richTextBoxAntecedente);
            this.Controls.Add(this.buttonConfiguracion);
            this.Controls.Add(this.labelFlecha);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RelacionUserControl";
            this.Size = new System.Drawing.Size(468, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelFlecha;
        private Button buttonConfiguracion;
        private RichTextBox richTextBoxAntecedente;
        private RichTextBox richTextBoxConsecuente;
    }
}
