namespace SBC_Maker.Interfaz_grafica
{
    partial class NodoUserControl
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
            this.richTextBoxNombreRegla = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxNombreRegla
            // 
            this.richTextBoxNombreRegla.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBoxNombreRegla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxNombreRegla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.richTextBoxNombreRegla.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxNombreRegla.Name = "richTextBoxNombreRegla";
            this.richTextBoxNombreRegla.ReadOnly = true;
            this.richTextBoxNombreRegla.Size = new System.Drawing.Size(134, 66);
            this.richTextBoxNombreRegla.TabIndex = 0;
            this.richTextBoxNombreRegla.Text = "";
            this.richTextBoxNombreRegla.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.richTextBoxNombreRegla_MouseDoubleClick);
            // 
            // NodoUserControl
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.richTextBoxNombreRegla);
            this.Name = "NodoUserControl";
            this.Size = new System.Drawing.Size(135, 67);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox richTextBoxNombreRegla;
    }
}
