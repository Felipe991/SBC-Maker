namespace SBC_Maker
{
    partial class MenuConjuntoDifuso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuConjuntoDifuso));
            this.CancelarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.verGraficoButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.addFuncionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(351, 440);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 23;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(432, 440);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 22;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(108, 42);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(172, 23);
            this.Nombre.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Funcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Conjunto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre";
            // 
            // verGraficoButton
            // 
            this.verGraficoButton.Image = ((System.Drawing.Image)(resources.GetObject("verGraficoButton.Image")));
            this.verGraficoButton.Location = new System.Drawing.Point(472, 22);
            this.verGraficoButton.Name = "verGraficoButton";
            this.verGraficoButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.verGraficoButton.Size = new System.Drawing.Size(35, 35);
            this.verGraficoButton.TabIndex = 24;
            this.verGraficoButton.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Triangular",
            "Trapezoidal",
            "Gausiana"});
            this.comboBox1.Location = new System.Drawing.Point(200, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 23);
            this.comboBox1.TabIndex = 25;
            // 
            // addFuncionButton
            // 
            this.addFuncionButton.BackColor = System.Drawing.Color.Transparent;
            this.addFuncionButton.FlatAppearance.BorderSize = 0;
            this.addFuncionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFuncionButton.Image = ((System.Drawing.Image)(resources.GetObject("addFuncionButton.Image")));
            this.addFuncionButton.Location = new System.Drawing.Point(78, 118);
            this.addFuncionButton.Name = "addFuncionButton";
            this.addFuncionButton.Size = new System.Drawing.Size(31, 24);
            this.addFuncionButton.TabIndex = 26;
            this.addFuncionButton.UseVisualStyleBackColor = false;
            // 
            // MenuConjuntoDifuso
            // 
            this.AcceptButton = this.GuardarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarButton;
            this.ClientSize = new System.Drawing.Size(559, 506);
            this.Controls.Add(this.addFuncionButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.verGraficoButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuConjuntoDifuso";
            this.Text = "MenuConjuntoDifuso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CancelarButton;
        private Button GuardarButton;
        private TextBox Nombre;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button verGraficoButton;
        private ComboBox comboBox1;
        private Button addFuncionButton;
    }
}