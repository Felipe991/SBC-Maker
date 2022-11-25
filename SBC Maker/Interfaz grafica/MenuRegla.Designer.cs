namespace SBC_Maker.Interfaz_grafica
{
    partial class MenuRegla
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InicioButton = new System.Windows.Forms.RadioButton();
            this.ConclusionButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TipoReglaGroup = new System.Windows.Forms.GroupBox();
            this.InformacionButton = new System.Windows.Forms.RadioButton();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Explicacion = new System.Windows.Forms.RichTextBox();
            this.Pregunta = new System.Windows.Forms.TextBox();
            this.Indicacion = new System.Windows.Forms.RichTextBox();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TipoReglaGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Explicacion";
            // 
            // InicioButton
            // 
            this.InicioButton.AutoSize = true;
            this.InicioButton.Location = new System.Drawing.Point(106, 22);
            this.InicioButton.Name = "InicioButton";
            this.InicioButton.Size = new System.Drawing.Size(54, 19);
            this.InicioButton.TabIndex = 2;
            this.InicioButton.Text = "Inicio";
            this.InicioButton.UseVisualStyleBackColor = true;
            // 
            // ConclusionButton
            // 
            this.ConclusionButton.AutoSize = true;
            this.ConclusionButton.Location = new System.Drawing.Point(166, 22);
            this.ConclusionButton.Name = "ConclusionButton";
            this.ConclusionButton.Size = new System.Drawing.Size(85, 19);
            this.ConclusionButton.TabIndex = 3;
            this.ConclusionButton.Text = "Conclusion";
            this.ConclusionButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pregunta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Indicacion";
            // 
            // TipoReglaGroup
            // 
            this.TipoReglaGroup.Controls.Add(this.InformacionButton);
            this.TipoReglaGroup.Controls.Add(this.InicioButton);
            this.TipoReglaGroup.Controls.Add(this.ConclusionButton);
            this.TipoReglaGroup.Location = new System.Drawing.Point(32, 191);
            this.TipoReglaGroup.Name = "TipoReglaGroup";
            this.TipoReglaGroup.Size = new System.Drawing.Size(478, 50);
            this.TipoReglaGroup.TabIndex = 6;
            this.TipoReglaGroup.TabStop = false;
            this.TipoReglaGroup.Text = "Tipo de regla";
            // 
            // InformacionButton
            // 
            this.InformacionButton.AutoSize = true;
            this.InformacionButton.Checked = true;
            this.InformacionButton.Location = new System.Drawing.Point(6, 22);
            this.InformacionButton.Name = "InformacionButton";
            this.InformacionButton.Size = new System.Drawing.Size(90, 19);
            this.InformacionButton.TabIndex = 4;
            this.InformacionButton.TabStop = true;
            this.InformacionButton.Text = "Informacion\r\n";
            this.InformacionButton.UseVisualStyleBackColor = true;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(111, 40);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(172, 23);
            this.Nombre.TabIndex = 7;
            // 
            // Explicacion
            // 
            this.Explicacion.Location = new System.Drawing.Point(111, 80);
            this.Explicacion.Name = "Explicacion";
            this.Explicacion.Size = new System.Drawing.Size(399, 96);
            this.Explicacion.TabIndex = 8;
            this.Explicacion.Text = "";
            // 
            // Pregunta
            // 
            this.Pregunta.Location = new System.Drawing.Point(111, 335);
            this.Pregunta.Name = "Pregunta";
            this.Pregunta.Size = new System.Drawing.Size(399, 23);
            this.Pregunta.TabIndex = 9;
            // 
            // Indicacion
            // 
            this.Indicacion.Location = new System.Drawing.Point(111, 377);
            this.Indicacion.Name = "Indicacion";
            this.Indicacion.Size = new System.Drawing.Size(399, 96);
            this.Indicacion.TabIndex = 10;
            this.Indicacion.Text = "";
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(435, 523);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 11;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(354, 523);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 12;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tipo de pregunta";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Dicotomica",
            "Politomica",
            "Difusa"});
            this.comboBox1.Location = new System.Drawing.Point(111, 281);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 23);
            this.comboBox1.TabIndex = 14;
            // 
            // MenuRegla
            // 
            this.AcceptButton = this.GuardarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.CancelarButton;
            this.ClientSize = new System.Drawing.Size(559, 581);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.Indicacion);
            this.Controls.Add(this.Pregunta);
            this.Controls.Add(this.Explicacion);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.TipoReglaGroup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MenuRegla";
            this.Text = "MenuRegla";
            this.TipoReglaGroup.ResumeLayout(false);
            this.TipoReglaGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private RadioButton InicioButton;
        private RadioButton ConclusionButton;
        private Label label3;
        private Label label4;
        private GroupBox TipoReglaGroup;
        private RadioButton InformacionButton;
        private TextBox Nombre;
        private RichTextBox Explicacion;
        private TextBox Pregunta;
        private RichTextBox Indicacion;
        private Button GuardarButton;
        private Button CancelarButton;
        private Label label5;
        private ComboBox comboBox1;
    }
}