namespace SBC_Maker.Interfaz_grafica
{
    partial class MenuConfiguracionSBC
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
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownLimiteConclusiones = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonSi = new System.Windows.Forms.RadioButton();
            this.checkedListBoxMetodoResolucion = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimiteConclusiones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(160, 326);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 14;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(241, 326);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 13;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Limite de conclusiones";
            // 
            // numericUpDownLimiteConclusiones
            // 
            this.numericUpDownLimiteConclusiones.Location = new System.Drawing.Point(159, 173);
            this.numericUpDownLimiteConclusiones.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.numericUpDownLimiteConclusiones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLimiteConclusiones.Name = "numericUpDownLimiteConclusiones";
            this.numericUpDownLimiteConclusiones.Size = new System.Drawing.Size(157, 23);
            this.numericUpDownLimiteConclusiones.TabIndex = 16;
            this.numericUpDownLimiteConclusiones.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonNo);
            this.groupBox1.Controls.Add(this.radioButtonSi);
            this.groupBox1.Location = new System.Drawing.Point(30, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 45);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mostrar explicacion";
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(129, 17);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(41, 19);
            this.radioButtonNo.TabIndex = 1;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonSi
            // 
            this.radioButtonSi.AutoSize = true;
            this.radioButtonSi.Checked = true;
            this.radioButtonSi.Location = new System.Drawing.Point(6, 17);
            this.radioButtonSi.Name = "radioButtonSi";
            this.radioButtonSi.Size = new System.Drawing.Size(34, 19);
            this.radioButtonSi.TabIndex = 0;
            this.radioButtonSi.TabStop = true;
            this.radioButtonSi.Text = "Si";
            this.radioButtonSi.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxMetodoResolucion
            // 
            this.checkedListBoxMetodoResolucion.CheckOnClick = true;
            this.checkedListBoxMetodoResolucion.FormattingEnabled = true;
            this.checkedListBoxMetodoResolucion.Items.AddRange(new object[] {
            "Menor largo de camino",
            "Mayor  profundidad",
            "Mayor  informacion"});
            this.checkedListBoxMetodoResolucion.Location = new System.Drawing.Point(36, 71);
            this.checkedListBoxMetodoResolucion.Name = "checkedListBoxMetodoResolucion";
            this.checkedListBoxMetodoResolucion.Size = new System.Drawing.Size(280, 76);
            this.checkedListBoxMetodoResolucion.TabIndex = 22;
            this.checkedListBoxMetodoResolucion.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxMetodoResolucion_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Metodo de resolucion";
            // 
            // MenuConfiguracionSBC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 381);
            this.Controls.Add(this.checkedListBoxMetodoResolucion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericUpDownLimiteConclusiones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.label1);
            this.Name = "MenuConfiguracionSBC";
            this.Text = "MenuConfiguracionSBC";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimiteConclusiones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button CancelarButton;
        private Button GuardarButton;
        private Label label2;
        private NumericUpDown numericUpDownLimiteConclusiones;
        private GroupBox groupBox1;
        private RadioButton radioButtonNo;
        private RadioButton radioButtonSi;
        private CheckedListBox checkedListBoxMetodoResolucion;
        private Label label1;
    }
}