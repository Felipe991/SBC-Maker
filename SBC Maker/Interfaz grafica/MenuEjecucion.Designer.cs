namespace SBC_Maker.Interfaz_grafica
{
    partial class MenuEjecucion
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonTerminar = new System.Windows.Forms.Button();
            this.buttonResponder = new System.Windows.Forms.Button();
            this.panelRespuesta = new System.Windows.Forms.Panel();
            this.labelRespuesta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(40, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(420, 327);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "¿ESTÁ O ESTUVO USTED EMBARAZADA EN LOS ULTIMOS 30 DIAS?";
            // 
            // buttonTerminar
            // 
            this.buttonTerminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTerminar.Location = new System.Drawing.Point(509, 296);
            this.buttonTerminar.Name = "buttonTerminar";
            this.buttonTerminar.Size = new System.Drawing.Size(127, 56);
            this.buttonTerminar.TabIndex = 8;
            this.buttonTerminar.Text = "Terminar";
            this.buttonTerminar.UseVisualStyleBackColor = true;
            this.buttonTerminar.Click += new System.EventHandler(this.buttonTerminar_Click);
            // 
            // buttonResponder
            // 
            this.buttonResponder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonResponder.Location = new System.Drawing.Point(802, 296);
            this.buttonResponder.Name = "buttonResponder";
            this.buttonResponder.Size = new System.Drawing.Size(127, 56);
            this.buttonResponder.TabIndex = 9;
            this.buttonResponder.Text = "Responder";
            this.buttonResponder.UseVisualStyleBackColor = true;
            this.buttonResponder.Click += new System.EventHandler(this.buttonResponder_Click);
            // 
            // panelRespuesta
            // 
            this.panelRespuesta.Location = new System.Drawing.Point(509, 92);
            this.panelRespuesta.Name = "panelRespuesta";
            this.panelRespuesta.Size = new System.Drawing.Size(420, 164);
            this.panelRespuesta.TabIndex = 10;
            // 
            // labelRespuesta
            // 
            this.labelRespuesta.AutoSize = true;
            this.labelRespuesta.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRespuesta.Location = new System.Drawing.Point(509, 25);
            this.labelRespuesta.Name = "labelRespuesta";
            this.labelRespuesta.Size = new System.Drawing.Size(157, 41);
            this.labelRespuesta.TabIndex = 11;
            this.labelRespuesta.Text = "Respuesta";
            // 
            // MenuEjecucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 378);
            this.Controls.Add(this.labelRespuesta);
            this.Controls.Add(this.panelRespuesta);
            this.Controls.Add(this.buttonResponder);
            this.Controls.Add(this.buttonTerminar);
            this.Controls.Add(this.richTextBox1);
            this.Name = "MenuEjecucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuEjecucion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuEjecucion_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox1;
        private Button buttonTerminar;
        private Button buttonResponder;
        private Panel panelRespuesta;
        private Label labelRespuesta;
    }
}