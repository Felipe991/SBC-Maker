namespace SBC_Maker.Interfaz_grafica
{
    partial class MenuRelacion
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
            this.CancelarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAntecedente = new System.Windows.Forms.ComboBox();
            this.comboBoxConsecuente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxExplicacion = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxNRelacion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxRespuestaCerrada = new System.Windows.Forms.GroupBox();
            this.checkedListBoxRespuestaDifusa = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(312, 616);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(86, 31);
            this.CancelarButton.TabIndex = 23;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(405, 616);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(86, 31);
            this.GuardarButton.TabIndex = 22;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Antecedente";
            // 
            // comboBoxAntecedente
            // 
            this.comboBoxAntecedente.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBoxAntecedente.Enabled = false;
            this.comboBoxAntecedente.FormattingEnabled = true;
            this.comboBoxAntecedente.Location = new System.Drawing.Point(142, 44);
            this.comboBoxAntecedente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxAntecedente.Name = "comboBoxAntecedente";
            this.comboBoxAntecedente.Size = new System.Drawing.Size(348, 28);
            this.comboBoxAntecedente.TabIndex = 24;
            this.comboBoxAntecedente.SelectedIndexChanged += new System.EventHandler(this.comboBoxAntecedente_SelectedIndexChanged);
            // 
            // comboBoxConsecuente
            // 
            this.comboBoxConsecuente.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBoxConsecuente.Enabled = false;
            this.comboBoxConsecuente.FormattingEnabled = true;
            this.comboBoxConsecuente.Location = new System.Drawing.Point(142, 105);
            this.comboBoxConsecuente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxConsecuente.Name = "comboBoxConsecuente";
            this.comboBoxConsecuente.Size = new System.Drawing.Size(348, 28);
            this.comboBoxConsecuente.TabIndex = 26;
            this.comboBoxConsecuente.SelectedIndexChanged += new System.EventHandler(this.comboBoxConsecuente_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Consecuente";
            // 
            // textBoxExplicacion
            // 
            this.textBoxExplicacion.Location = new System.Drawing.Point(142, 245);
            this.textBoxExplicacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxExplicacion.Name = "textBoxExplicacion";
            this.textBoxExplicacion.Size = new System.Drawing.Size(348, 127);
            this.textBoxExplicacion.TabIndex = 28;
            this.textBoxExplicacion.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Explicacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Respuesta necesaria";
            // 
            // comboBoxNRelacion
            // 
            this.comboBoxNRelacion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBoxNRelacion.Enabled = false;
            this.comboBoxNRelacion.FormattingEnabled = true;
            this.comboBoxNRelacion.Location = new System.Drawing.Point(142, 165);
            this.comboBoxNRelacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxNRelacion.Name = "comboBoxNRelacion";
            this.comboBoxNRelacion.Size = new System.Drawing.Size(348, 28);
            this.comboBoxNRelacion.TabIndex = 32;
            this.comboBoxNRelacion.SelectedIndexChanged += new System.EventHandler(this.comboBoxNRelacion_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "N° Relacion";
            // 
            // groupBoxRespuestaCerrada
            // 
            this.groupBoxRespuestaCerrada.Location = new System.Drawing.Point(142, 400);
            this.groupBoxRespuestaCerrada.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxRespuestaCerrada.Name = "groupBoxRespuestaCerrada";
            this.groupBoxRespuestaCerrada.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxRespuestaCerrada.Size = new System.Drawing.Size(349, 197);
            this.groupBoxRespuestaCerrada.TabIndex = 0;
            this.groupBoxRespuestaCerrada.TabStop = false;
            this.groupBoxRespuestaCerrada.Visible = false;
            // 
            // checkedListBoxRespuestaDifusa
            // 
            this.checkedListBoxRespuestaDifusa.FormattingEnabled = true;
            this.checkedListBoxRespuestaDifusa.Location = new System.Drawing.Point(142, 400);
            this.checkedListBoxRespuestaDifusa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkedListBoxRespuestaDifusa.Name = "checkedListBoxRespuestaDifusa";
            this.checkedListBoxRespuestaDifusa.Size = new System.Drawing.Size(348, 180);
            this.checkedListBoxRespuestaDifusa.TabIndex = 1;
            this.checkedListBoxRespuestaDifusa.Visible = false;
            // 
            // MenuRelacion
            // 
            this.AcceptButton = this.GuardarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarButton;
            this.ClientSize = new System.Drawing.Size(511, 658);
            this.Controls.Add(this.checkedListBoxRespuestaDifusa);
            this.Controls.Add(this.groupBoxRespuestaCerrada);
            this.Controls.Add(this.comboBoxNRelacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxExplicacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxConsecuente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxAntecedente);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MenuRelacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuRelacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CancelarButton;
        private Button GuardarButton;
        private Label label1;
        private ComboBox comboBoxAntecedente;
        private ComboBox comboBoxConsecuente;
        private Label label2;
        public RichTextBox textBoxExplicacion;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxNRelacion;
        private Label label5;
        private GroupBox groupBoxRespuestaCerrada;
        private CheckedListBox checkedListBoxRespuestaDifusa;
    }
}