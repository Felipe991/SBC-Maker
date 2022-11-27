namespace SBC_Maker.Interfaz_grafica
{
    partial class MenuConfigFuncionGaussiana
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
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelParametros = new System.Windows.Forms.Label();
            this.labelMedia = new System.Windows.Forms.Label();
            this.textBoxCentro = new System.Windows.Forms.TextBox();
            this.labelDesviacionEstandar = new System.Windows.Forms.Label();
            this.textBoxDesviacionEstandar = new System.Windows.Forms.TextBox();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // formsPlot1
            // 
            this.formsPlot1.Enabled = false;
            this.formsPlot1.Location = new System.Drawing.Point(5, 4);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(771, 262);
            this.formsPlot1.TabIndex = 0;
            this.formsPlot1.Load += new System.EventHandler(this.formsPlot1_Load);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.formsPlot1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 264);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelParametros);
            this.panel2.Controls.Add(this.labelMedia);
            this.panel2.Controls.Add(this.textBoxCentro);
            this.panel2.Controls.Add(this.labelDesviacionEstandar);
            this.panel2.Controls.Add(this.textBoxDesviacionEstandar);
            this.panel2.Location = new System.Drawing.Point(12, 282);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 117);
            this.panel2.TabIndex = 5;
            // 
            // labelParametros
            // 
            this.labelParametros.AutoSize = true;
            this.labelParametros.Location = new System.Drawing.Point(0, 0);
            this.labelParametros.Name = "labelParametros";
            this.labelParametros.Size = new System.Drawing.Size(83, 20);
            this.labelParametros.TabIndex = 9;
            this.labelParametros.Text = "Parametros";
            // 
            // labelMedia
            // 
            this.labelMedia.AutoSize = true;
            this.labelMedia.Location = new System.Drawing.Point(4, 78);
            this.labelMedia.Name = "labelMedia";
            this.labelMedia.Size = new System.Drawing.Size(51, 20);
            this.labelMedia.TabIndex = 8;
            this.labelMedia.Text = "Media";
            // 
            // textBoxCentro
            // 
            this.textBoxCentro.Location = new System.Drawing.Point(150, 75);
            this.textBoxCentro.Name = "textBoxCentro";
            this.textBoxCentro.Size = new System.Drawing.Size(150, 27);
            this.textBoxCentro.TabIndex = 7;
            this.textBoxCentro.Text = "5";
            this.textBoxCentro.Enter += new System.EventHandler(this.textBoxMedia_Enter);
            this.textBoxCentro.Leave += new System.EventHandler(this.textBoxMedia_Leave);
            // 
            // labelDesviacionEstandar
            // 
            this.labelDesviacionEstandar.AutoSize = true;
            this.labelDesviacionEstandar.Location = new System.Drawing.Point(2, 39);
            this.labelDesviacionEstandar.Name = "labelDesviacionEstandar";
            this.labelDesviacionEstandar.Size = new System.Drawing.Size(142, 20);
            this.labelDesviacionEstandar.TabIndex = 6;
            this.labelDesviacionEstandar.Text = "Desviacion Estandar";
            // 
            // textBoxDesviacionEstandar
            // 
            this.textBoxDesviacionEstandar.Location = new System.Drawing.Point(150, 36);
            this.textBoxDesviacionEstandar.Name = "textBoxDesviacionEstandar";
            this.textBoxDesviacionEstandar.Size = new System.Drawing.Size(150, 27);
            this.textBoxDesviacionEstandar.TabIndex = 5;
            this.textBoxDesviacionEstandar.Text = "0.5";
            this.textBoxDesviacionEstandar.Enter += new System.EventHandler(this.textBoxDesviacionEstandar_Enter);
            this.textBoxDesviacionEstandar.Leave += new System.EventHandler(this.textBoxDesviacionEstandar_Leave);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(702, 415);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(86, 31);
            this.GuardarButton.TabIndex = 24;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            // 
            // MenuConfigFuncionGaussiana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MenuConfigFuncionGaussiana";
            this.Text = "MenuConfigFuncionGaussiana";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ScottPlot.FormsPlot formsPlot1;
        private Panel panel1;
        private Panel panel2;
        private Label labelDesviacionEstandar;
        private TextBox textBoxDesviacionEstandar;
        private Label labelMedia;
        private TextBox textBoxCentro;
        private Label labelParametros;
        private Button GuardarButton;
        private Label labelFactorFuzzy;
        private TextBox textBoxFactorFuzzy;
    }
}