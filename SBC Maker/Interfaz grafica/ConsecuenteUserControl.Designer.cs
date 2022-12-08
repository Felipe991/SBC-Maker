namespace SBC_Maker.Interfaz_grafica
{
    partial class ConsecuenteUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsecuenteUserControl));
            this.labelAntecedente = new System.Windows.Forms.Label();
            this.labelConsecuente = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonConfiguracion = new System.Windows.Forms.Button();
            this.labelFlecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAntecedente
            // 
            this.labelAntecedente.AutoSize = true;
            this.labelAntecedente.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAntecedente.Location = new System.Drawing.Point(17, 11);
            this.labelAntecedente.Name = "labelAntecedente";
            this.labelAntecedente.Size = new System.Drawing.Size(107, 23);
            this.labelAntecedente.TabIndex = 0;
            this.labelAntecedente.Text = "Antecedente";
            // 
            // labelConsecuente
            // 
            this.labelConsecuente.AutoSize = true;
            this.labelConsecuente.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelConsecuente.Location = new System.Drawing.Point(178, 11);
            this.labelConsecuente.Name = "labelConsecuente";
            this.labelConsecuente.Size = new System.Drawing.Size(109, 23);
            this.labelConsecuente.TabIndex = 1;
            this.labelConsecuente.Text = "Consecuente";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.Transparent;
            this.buttonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminar.FlatAppearance.BorderSize = 0;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("buttonEliminar.Image")));
            this.buttonEliminar.Location = new System.Drawing.Point(350, 6);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(35, 32);
            this.buttonEliminar.TabIndex = 41;
            this.buttonEliminar.UseVisualStyleBackColor = false;
            // 
            // buttonConfiguracion
            // 
            this.buttonConfiguracion.BackColor = System.Drawing.Color.Transparent;
            this.buttonConfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConfiguracion.FlatAppearance.BorderSize = 0;
            this.buttonConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfiguracion.Image = ((System.Drawing.Image)(resources.GetObject("buttonConfiguracion.Image")));
            this.buttonConfiguracion.Location = new System.Drawing.Point(309, 6);
            this.buttonConfiguracion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonConfiguracion.Name = "buttonConfiguracion";
            this.buttonConfiguracion.Size = new System.Drawing.Size(35, 32);
            this.buttonConfiguracion.TabIndex = 42;
            this.buttonConfiguracion.UseVisualStyleBackColor = false;
            this.buttonConfiguracion.Click += new System.EventHandler(this.buttonConfiguracion_Click);
            // 
            // labelFlecha
            // 
            this.labelFlecha.AutoSize = true;
            this.labelFlecha.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFlecha.Location = new System.Drawing.Point(137, 11);
            this.labelFlecha.Name = "labelFlecha";
            this.labelFlecha.Size = new System.Drawing.Size(29, 23);
            this.labelFlecha.TabIndex = 43;
            this.labelFlecha.Text = "🡺";
            // 
            // ConsecuenteUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelFlecha);
            this.Controls.Add(this.buttonConfiguracion);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.labelConsecuente);
            this.Controls.Add(this.labelAntecedente);
            this.Name = "ConsecuenteUserControl";
            this.Size = new System.Drawing.Size(394, 45);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelAntecedente;
        private Label labelConsecuente;
        private Button buttonEliminar;
        private Button buttonConfiguracion;
        private Label labelFlecha;
    }
}
