namespace SBC_Maker.Interfaz_grafica
{
    partial class PreguntaDicotomicaUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRespuesta1 = new System.Windows.Forms.TextBox();
            this.textBoxRespuesta2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Respuesta 1";
            // 
            // textBoxRespuesta1
            // 
            this.textBoxRespuesta1.Location = new System.Drawing.Point(99, 9);
            this.textBoxRespuesta1.Name = "textBoxRespuesta1";
            this.textBoxRespuesta1.Size = new System.Drawing.Size(377, 23);
            this.textBoxRespuesta1.TabIndex = 1;
            this.textBoxRespuesta1.Text = "Respuesta 1";
            this.textBoxRespuesta1.TextChanged += new System.EventHandler(this.textBoxRespuesta1_TextChanged);
            this.textBoxRespuesta1.Leave += new System.EventHandler(this.textBoxRespuesta1_Leave);
            // 
            // textBoxRespuesta2
            // 
            this.textBoxRespuesta2.Location = new System.Drawing.Point(99, 38);
            this.textBoxRespuesta2.Name = "textBoxRespuesta2";
            this.textBoxRespuesta2.Size = new System.Drawing.Size(377, 23);
            this.textBoxRespuesta2.TabIndex = 3;
            this.textBoxRespuesta2.Text = "Respuesta 2";
            this.textBoxRespuesta2.Leave += new System.EventHandler(this.textBoxRespuesta2_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Respuesta 2";
            // 
            // PreguntaDicotomicaUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxRespuesta2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRespuesta1);
            this.Controls.Add(this.label1);
            this.Name = "PreguntaDicotomicaUserControl";
            this.Size = new System.Drawing.Size(479, 90);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxRespuesta1;
        private TextBox textBoxRespuesta2;
        private Label label2;
    }
}
