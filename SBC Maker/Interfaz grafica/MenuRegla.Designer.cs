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
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ConclusionButton = new System.Windows.Forms.RadioButton();
            this.InicioButton = new System.Windows.Forms.RadioButton();
            this.InformacionButton = new System.Windows.Forms.RadioButton();
            this.GroupTipoRegla = new System.Windows.Forms.GroupBox();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.panelPregunta = new System.Windows.Forms.Panel();
            this.textBoxIndicacion = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTipoPregunta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNivel = new System.Windows.Forms.TextBox();
            this.textBoxPregunta = new System.Windows.Forms.RichTextBox();
            this.GroupTipoRegla.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(117, 28);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxNombre.Size = new System.Drawing.Size(454, 27);
            this.textBoxNombre.TabIndex = 7;
            this.textBoxNombre.Text = "Regla";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Indicacion";
            // 
            // ConclusionButton
            // 
            this.ConclusionButton.AutoSize = true;
            this.ConclusionButton.Location = new System.Drawing.Point(190, 29);
            this.ConclusionButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConclusionButton.Name = "ConclusionButton";
            this.ConclusionButton.Size = new System.Drawing.Size(102, 24);
            this.ConclusionButton.TabIndex = 3;
            this.ConclusionButton.Text = "Conclusion";
            this.ConclusionButton.UseVisualStyleBackColor = true;
            this.ConclusionButton.Click += new System.EventHandler(this.ConclusionButton_Click);
            // 
            // InicioButton
            // 
            this.InicioButton.AutoSize = true;
            this.InicioButton.Checked = true;
            this.InicioButton.Location = new System.Drawing.Point(11, 29);
            this.InicioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InicioButton.Name = "InicioButton";
            this.InicioButton.Size = new System.Drawing.Size(66, 24);
            this.InicioButton.TabIndex = 2;
            this.InicioButton.TabStop = true;
            this.InicioButton.Text = "Inicio";
            this.InicioButton.UseVisualStyleBackColor = true;
            this.InicioButton.Click += new System.EventHandler(this.InicioButton_Click);
            // 
            // InformacionButton
            // 
            this.InformacionButton.AutoSize = true;
            this.InformacionButton.Location = new System.Drawing.Point(80, 29);
            this.InformacionButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InformacionButton.Name = "InformacionButton";
            this.InformacionButton.Size = new System.Drawing.Size(110, 24);
            this.InformacionButton.TabIndex = 4;
            this.InformacionButton.Text = "Informacion\r\n";
            this.InformacionButton.UseVisualStyleBackColor = true;
            this.InformacionButton.Click += new System.EventHandler(this.InformacionButton_Click);
            // 
            // GroupTipoRegla
            // 
            this.GroupTipoRegla.Controls.Add(this.InformacionButton);
            this.GroupTipoRegla.Controls.Add(this.InicioButton);
            this.GroupTipoRegla.Controls.Add(this.ConclusionButton);
            this.GroupTipoRegla.Location = new System.Drawing.Point(26, 255);
            this.GroupTipoRegla.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupTipoRegla.Name = "GroupTipoRegla";
            this.GroupTipoRegla.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupTipoRegla.Size = new System.Drawing.Size(546, 67);
            this.GroupTipoRegla.TabIndex = 6;
            this.GroupTipoRegla.TabStop = false;
            this.GroupTipoRegla.Text = "Tipo de regla";
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(487, 693);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(86, 31);
            this.GuardarButton.TabIndex = 11;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(395, 693);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(86, 31);
            this.CancelarButton.TabIndex = 12;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // panelPregunta
            // 
            this.panelPregunta.Location = new System.Drawing.Point(27, 485);
            this.panelPregunta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelPregunta.Name = "panelPregunta";
            this.panelPregunta.Size = new System.Drawing.Size(546, 197);
            this.panelPregunta.TabIndex = 13;
            // 
            // textBoxIndicacion
            // 
            this.textBoxIndicacion.BackColor = System.Drawing.Color.Silver;
            this.textBoxIndicacion.Enabled = false;
            this.textBoxIndicacion.Location = new System.Drawing.Point(117, 67);
            this.textBoxIndicacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxIndicacion.Name = "textBoxIndicacion";
            this.textBoxIndicacion.Size = new System.Drawing.Size(455, 127);
            this.textBoxIndicacion.TabIndex = 26;
            this.textBoxIndicacion.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Pregunta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Tipo de pregunta";
            // 
            // comboBoxTipoPregunta
            // 
            this.comboBoxTipoPregunta.FormattingEnabled = true;
            this.comboBoxTipoPregunta.Items.AddRange(new object[] {
            "Cerrada",
            "Difusa"});
            this.comboBoxTipoPregunta.Location = new System.Drawing.Point(155, 337);
            this.comboBoxTipoPregunta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxTipoPregunta.Name = "comboBoxTipoPregunta";
            this.comboBoxTipoPregunta.Size = new System.Drawing.Size(165, 28);
            this.comboBoxTipoPregunta.TabIndex = 30;
            this.comboBoxTipoPregunta.Text = "Cerrada";
            this.comboBoxTipoPregunta.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoPregunta_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nivel";
            // 
            // textBoxNivel
            // 
            this.textBoxNivel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNivel.Enabled = false;
            this.textBoxNivel.Location = new System.Drawing.Point(117, 212);
            this.textBoxNivel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNivel.Name = "textBoxNivel";
            this.textBoxNivel.Size = new System.Drawing.Size(114, 27);
            this.textBoxNivel.TabIndex = 32;
            this.textBoxNivel.Text = "0";
            // 
            // textBoxPregunta
            // 
            this.textBoxPregunta.Location = new System.Drawing.Point(117, 380);
            this.textBoxPregunta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPregunta.Name = "textBoxPregunta";
            this.textBoxPregunta.Size = new System.Drawing.Size(454, 96);
            this.textBoxPregunta.TabIndex = 33;
            this.textBoxPregunta.Text = "";
            // 
            // MenuRegla
            // 
            this.AcceptButton = this.GuardarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.CancelarButton;
            this.ClientSize = new System.Drawing.Size(597, 741);
            this.Controls.Add(this.textBoxPregunta);
            this.Controls.Add(this.textBoxNivel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTipoPregunta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxIndicacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelPregunta);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.GroupTipoRegla);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MenuRegla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuRegla";
            this.GroupTipoRegla.ResumeLayout(false);
            this.GroupTipoRegla.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxNombre;
        private Label label4;
        private RadioButton ConclusionButton;
        private RadioButton InicioButton;
        private RadioButton InformacionButton;
        private GroupBox GroupTipoRegla;
        private Button GuardarButton;
        private Button CancelarButton;
        private Panel panelPregunta;
        private RichTextBox textBoxIndicacion;
        private Label label3;
        private Label label5;
        private ComboBox comboBoxTipoPregunta;
        private Label label2;
        private TextBox textBoxNivel;
        private RichTextBox textBoxPregunta;
    }
}