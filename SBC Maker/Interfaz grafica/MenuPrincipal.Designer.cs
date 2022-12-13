namespace SBC_Maker.Interfaz_grafica
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonEjecucion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConfeccion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEjecucion
            // 
            this.buttonEjecucion.Location = new System.Drawing.Point(49, 127);
            this.buttonEjecucion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEjecucion.Name = "buttonEjecucion";
            this.buttonEjecucion.Size = new System.Drawing.Size(157, 60);
            this.buttonEjecucion.TabIndex = 5;
            this.buttonEjecucion.Text = "Ejecutar";
            this.buttonEjecucion.UseVisualStyleBackColor = true;
            this.buttonEjecucion.Click += new System.EventHandler(this.buttonEjecucion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "SBC Maker";
            // 
            // buttonConfeccion
            // 
            this.buttonConfeccion.Location = new System.Drawing.Point(49, 58);
            this.buttonConfeccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonConfeccion.Name = "buttonConfeccion";
            this.buttonConfeccion.Size = new System.Drawing.Size(157, 61);
            this.buttonConfeccion.TabIndex = 3;
            this.buttonConfeccion.Text = "Confeccionar";
            this.buttonConfeccion.UseVisualStyleBackColor = true;
            this.buttonConfeccion.Click += new System.EventHandler(this.buttonConfeccion_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 223);
            this.Controls.Add(this.buttonEjecucion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConfeccion);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonEjecucion;
        private Label label1;
        private Button buttonConfeccion;
    }
}