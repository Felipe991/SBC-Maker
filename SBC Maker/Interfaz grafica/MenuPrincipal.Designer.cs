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
            this.buttonEjecucion.Location = new System.Drawing.Point(53, 151);
            this.buttonEjecucion.Name = "buttonEjecucion";
            this.buttonEjecucion.Size = new System.Drawing.Size(113, 23);
            this.buttonEjecucion.TabIndex = 5;
            this.buttonEjecucion.Text = "Ejecutar";
            this.buttonEjecucion.UseVisualStyleBackColor = true;
            this.buttonEjecucion.Click += new System.EventHandler(this.buttonEjecucion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "SBC Maker";
            // 
            // buttonConfeccion
            // 
            this.buttonConfeccion.Location = new System.Drawing.Point(53, 90);
            this.buttonConfeccion.Name = "buttonConfeccion";
            this.buttonConfeccion.Size = new System.Drawing.Size(113, 23);
            this.buttonConfeccion.TabIndex = 3;
            this.buttonConfeccion.Text = "Confeccionar";
            this.buttonConfeccion.UseVisualStyleBackColor = true;
            this.buttonConfeccion.Click += new System.EventHandler(this.buttonConfeccion_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 240);
            this.Controls.Add(this.buttonEjecucion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConfeccion);
            this.Name = "MenuPrincipal";
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