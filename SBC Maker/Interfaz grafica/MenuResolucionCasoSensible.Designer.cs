﻿namespace SBC_Maker.Interfaz_grafica
{
    partial class MenuResolucionCasoSensible
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.enviarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(409, 28);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "RESPUESTA EN CONFLICTO";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(7, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 158);
            this.panel1.TabIndex = 2;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Enabled = false;
            this.richTextBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox2.Location = new System.Drawing.Point(12, 58);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(409, 55);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "¿Cual de las siguientes alternativas se ajusta más a su respuesta?";
            // 
            // enviarButton
            // 
            this.enviarButton.Location = new System.Drawing.Point(319, 304);
            this.enviarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.enviarButton.Name = "enviarButton";
            this.enviarButton.Size = new System.Drawing.Size(102, 31);
            this.enviarButton.TabIndex = 28;
            this.enviarButton.Text = "Responder";
            this.enviarButton.UseVisualStyleBackColor = true;
            this.enviarButton.Click += new System.EventHandler(this.enviarButton_Click);
            // 
            // MenuResolucionCasoSensible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 348);
            this.Controls.Add(this.enviarButton);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "MenuResolucionCasoSensible";
            this.Text = "MenuResolucionCasoSensible";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuResolucionCasoSensible_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox richTextBox1;
        private Panel panel1;
        private RichTextBox richTextBox2;
        private Button enviarButton;
    }
}