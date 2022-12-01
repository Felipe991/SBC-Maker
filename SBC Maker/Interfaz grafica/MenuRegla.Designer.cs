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
            this.GroupTipoRegla = new System.Windows.Forms.GroupBox();
            this.InformacionButton = new System.Windows.Forms.RadioButton();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxExplicacion = new System.Windows.Forms.RichTextBox();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.panelPregunta = new System.Windows.Forms.Panel();
            this.textBoxIndicacion = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTipoPregunta = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPregunta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GroupTipoRegla.SuspendLayout();
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
            this.InicioButton.Checked = true;
            this.InicioButton.Location = new System.Drawing.Point(10, 22);
            this.InicioButton.Name = "InicioButton";
            this.InicioButton.Size = new System.Drawing.Size(54, 19);
            this.InicioButton.TabIndex = 2;
            this.InicioButton.TabStop = true;
            this.InicioButton.Text = "Inicio";
            this.InicioButton.UseVisualStyleBackColor = true;
            this.InicioButton.Click += new System.EventHandler(this.InicioButton_Click);
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
            this.ConclusionButton.Click += new System.EventHandler(this.ConclusionButton_Click);
            // 
            // GroupTipoRegla
            // 
            this.GroupTipoRegla.Controls.Add(this.InformacionButton);
            this.GroupTipoRegla.Controls.Add(this.InicioButton);
            this.GroupTipoRegla.Controls.Add(this.ConclusionButton);
            this.GroupTipoRegla.Location = new System.Drawing.Point(32, 308);
            this.GroupTipoRegla.Name = "GroupTipoRegla";
            this.GroupTipoRegla.Size = new System.Drawing.Size(478, 50);
            this.GroupTipoRegla.TabIndex = 6;
            this.GroupTipoRegla.TabStop = false;
            this.GroupTipoRegla.Text = "Tipo de regla";
            // 
            // InformacionButton
            // 
            this.InformacionButton.AutoSize = true;
            this.InformacionButton.Location = new System.Drawing.Point(70, 22);
            this.InformacionButton.Name = "InformacionButton";
            this.InformacionButton.Size = new System.Drawing.Size(90, 19);
            this.InformacionButton.TabIndex = 4;
            this.InformacionButton.Text = "Informacion\r\n";
            this.InformacionButton.UseVisualStyleBackColor = true;
            this.InformacionButton.Click += new System.EventHandler(this.InformacionButton_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(111, 40);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(398, 23);
            this.textBoxNombre.TabIndex = 7;
            // 
            // textBoxExplicacion
            // 
            this.textBoxExplicacion.Location = new System.Drawing.Point(111, 80);
            this.textBoxExplicacion.Name = "textBoxExplicacion";
            this.textBoxExplicacion.Size = new System.Drawing.Size(399, 96);
            this.textBoxExplicacion.TabIndex = 8;
            this.textBoxExplicacion.Text = "";
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(435, 610);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 11;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(354, 610);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 12;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // panelPregunta
            // 
            this.panelPregunta.Location = new System.Drawing.Point(32, 441);
            this.panelPregunta.Name = "panelPregunta";
            this.panelPregunta.Size = new System.Drawing.Size(478, 148);
            this.panelPregunta.TabIndex = 13;
            // 
            // textBoxIndicacion
            // 
            this.textBoxIndicacion.BackColor = System.Drawing.Color.Silver;
            this.textBoxIndicacion.Enabled = false;
            this.textBoxIndicacion.Location = new System.Drawing.Point(111, 191);
            this.textBoxIndicacion.Name = "textBoxIndicacion";
            this.textBoxIndicacion.Size = new System.Drawing.Size(399, 96);
            this.textBoxIndicacion.TabIndex = 26;
            this.textBoxIndicacion.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Indicacion";
            // 
            // comboBoxTipoPregunta
            // 
            this.comboBoxTipoPregunta.FormattingEnabled = true;
            this.comboBoxTipoPregunta.Items.AddRange(new object[] {
            "Cerrada",
            "Difusa"});
            this.comboBoxTipoPregunta.Location = new System.Drawing.Point(135, 370);
            this.comboBoxTipoPregunta.Name = "comboBoxTipoPregunta";
            this.comboBoxTipoPregunta.Size = new System.Drawing.Size(145, 23);
            this.comboBoxTipoPregunta.TabIndex = 30;
            this.comboBoxTipoPregunta.Text = "Cerrada";
            this.comboBoxTipoPregunta.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoPregunta_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Tipo de pregunta";
            // 
            // textBoxPregunta
            // 
            this.textBoxPregunta.Location = new System.Drawing.Point(110, 399);
            this.textBoxPregunta.Name = "textBoxPregunta";
            this.textBoxPregunta.Size = new System.Drawing.Size(399, 23);
            this.textBoxPregunta.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Pregunta";
            // 
            // MenuRegla
            // 
            this.AcceptButton = this.GuardarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.CancelarButton;
            this.ClientSize = new System.Drawing.Size(543, 645);
            this.Controls.Add(this.comboBoxTipoPregunta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPregunta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxIndicacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelPregunta);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.textBoxExplicacion);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.GroupTipoRegla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MenuRegla";
            this.Text = "MenuRegla";
            this.GroupTipoRegla.ResumeLayout(false);
            this.GroupTipoRegla.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private RadioButton InicioButton;
        private RadioButton ConclusionButton;
        private GroupBox GroupTipoRegla;
        private RadioButton InformacionButton;
        private TextBox textBoxNombre;
        private RichTextBox textBoxExplicacion;
        private Button GuardarButton;
        private Button CancelarButton;
        private Panel panelPregunta;
        private RichTextBox textBoxIndicacion;
        private Label label4;
        private ComboBox comboBoxTipoPregunta;
        private Label label5;
        private TextBox textBoxPregunta;
        private Label label3;
    }
}