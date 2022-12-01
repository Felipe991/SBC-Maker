namespace SBC_Maker.Interfaz_grafica
{
    partial class PreguntaDifusaUserControl
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
            this.buttonExaminar = new System.Windows.Forms.Button();
            this.textBoxRuta = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // buttonExaminar
            // 
            this.buttonExaminar.Location = new System.Drawing.Point(380, 27);
            this.buttonExaminar.Name = "buttonExaminar";
            this.buttonExaminar.Size = new System.Drawing.Size(75, 23);
            this.buttonExaminar.TabIndex = 0;
            this.buttonExaminar.Text = "Examinar";
            this.buttonExaminar.UseVisualStyleBackColor = true;
            this.buttonExaminar.Click += new System.EventHandler(this.buttonExaminar_Click);
            // 
            // textBoxRuta
            // 
            this.textBoxRuta.Enabled = false;
            this.textBoxRuta.Location = new System.Drawing.Point(48, 28);
            this.textBoxRuta.Name = "textBoxRuta";
            this.textBoxRuta.Size = new System.Drawing.Size(304, 23);
            this.textBoxRuta.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PreguntaDIfusaUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxRuta);
            this.Controls.Add(this.buttonExaminar);
            this.Name = "PreguntaDIfusaUserControl";
            this.Size = new System.Drawing.Size(484, 86);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonExaminar;
        private TextBox textBoxRuta;
        private OpenFileDialog openFileDialog1;
    }
}
