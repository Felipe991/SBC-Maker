namespace SBC_Maker.Interfaz_grafica
{
    partial class RespusestaCerradaUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RespusestaCerradaUserControl));
            this.textBoxRespuesta1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxRespuesta1
            // 
            this.textBoxRespuesta1.Location = new System.Drawing.Point(87, 12);
            this.textBoxRespuesta1.Name = "textBoxRespuesta1";
            this.textBoxRespuesta1.Size = new System.Drawing.Size(314, 23);
            this.textBoxRespuesta1.TabIndex = 11;
            this.textBoxRespuesta1.Leave += new System.EventHandler(this.textBoxRespuesta1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Respuesta";
            // 
            // eliminarButton
            // 
            this.eliminarButton.BackColor = System.Drawing.Color.Transparent;
            this.eliminarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.eliminarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminarButton.FlatAppearance.BorderSize = 0;
            this.eliminarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("eliminarButton.Image")));
            this.eliminarButton.Location = new System.Drawing.Point(407, 12);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(31, 24);
            this.eliminarButton.TabIndex = 41;
            this.eliminarButton.UseVisualStyleBackColor = false;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // RespusestaCerradaUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.textBoxRespuesta1);
            this.Controls.Add(this.label1);
            this.Name = "RespusestaCerradaUserControl";
            this.Size = new System.Drawing.Size(453, 46);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxRespuesta1;
        private Label label1;
        private Button eliminarButton;
    }
}
