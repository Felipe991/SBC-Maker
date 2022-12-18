namespace SBC_Maker.Interfaz_grafica
{
    partial class MenuConfigFuncionTrapezoidal
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
            this.GuardarButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelCentroIzq = new System.Windows.Forms.Label();
            this.textBoxCentroDer = new System.Windows.Forms.TextBox();
            this.labelLimDerecho = new System.Windows.Forms.Label();
            this.textBoxLimDerecho = new System.Windows.Forms.TextBox();
            this.labelParametros = new System.Windows.Forms.Label();
            this.labelCentroIzquierda = new System.Windows.Forms.Label();
            this.textBoxCentroIzq = new System.Windows.Forms.TextBox();
            this.labelLimiteIzquierdo = new System.Windows.Forms.Label();
            this.textBoxLimIzquierdo = new System.Windows.Forms.TextBox();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(706, 413);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(86, 31);
            this.GuardarButton.TabIndex = 30;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelCentroIzq);
            this.panel2.Controls.Add(this.textBoxCentroDer);
            this.panel2.Controls.Add(this.labelLimDerecho);
            this.panel2.Controls.Add(this.textBoxLimDerecho);
            this.panel2.Controls.Add(this.labelParametros);
            this.panel2.Controls.Add(this.labelCentroIzquierda);
            this.panel2.Controls.Add(this.textBoxCentroIzq);
            this.panel2.Controls.Add(this.labelLimiteIzquierdo);
            this.panel2.Controls.Add(this.textBoxLimIzquierdo);
            this.panel2.Location = new System.Drawing.Point(16, 280);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 117);
            this.panel2.TabIndex = 29;
            // 
            // labelCentroIzq
            // 
            this.labelCentroIzq.AutoSize = true;
            this.labelCentroIzq.Location = new System.Drawing.Point(422, 78);
            this.labelCentroIzq.Name = "labelCentroIzq";
            this.labelCentroIzq.Size = new System.Drawing.Size(112, 20);
            this.labelCentroIzq.TabIndex = 13;
            this.labelCentroIzq.Text = "Centro Derecha";
            // 
            // textBoxCentroDer
            // 
            this.textBoxCentroDer.Location = new System.Drawing.Point(570, 75);
            this.textBoxCentroDer.Name = "textBoxCentroDer";
            this.textBoxCentroDer.Size = new System.Drawing.Size(150, 27);
            this.textBoxCentroDer.TabIndex = 12;
            this.textBoxCentroDer.Text = "5";
            this.textBoxCentroDer.Enter += new System.EventHandler(this.textBoxCentroDer_Enter);
            this.textBoxCentroDer.Leave += new System.EventHandler(this.textBoxCentroDer_Leave);
            // 
            // labelLimDerecho
            // 
            this.labelLimDerecho.AutoSize = true;
            this.labelLimDerecho.Location = new System.Drawing.Point(422, 35);
            this.labelLimDerecho.Name = "labelLimDerecho";
            this.labelLimDerecho.Size = new System.Drawing.Size(110, 20);
            this.labelLimDerecho.TabIndex = 11;
            this.labelLimDerecho.Text = "Limite Derecho";
            // 
            // textBoxLimDerecho
            // 
            this.textBoxLimDerecho.Location = new System.Drawing.Point(570, 32);
            this.textBoxLimDerecho.Name = "textBoxLimDerecho";
            this.textBoxLimDerecho.Size = new System.Drawing.Size(150, 27);
            this.textBoxLimDerecho.TabIndex = 10;
            this.textBoxLimDerecho.Text = "10";
            this.textBoxLimDerecho.Enter += new System.EventHandler(this.textBoxLimDerecho_Enter);
            this.textBoxLimDerecho.Leave += new System.EventHandler(this.textBoxLimDerecho_Leave);
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
            // labelCentroIzquierda
            // 
            this.labelCentroIzquierda.AutoSize = true;
            this.labelCentroIzquierda.Location = new System.Drawing.Point(4, 78);
            this.labelCentroIzquierda.Name = "labelCentroIzquierda";
            this.labelCentroIzquierda.Size = new System.Drawing.Size(119, 20);
            this.labelCentroIzquierda.TabIndex = 8;
            this.labelCentroIzquierda.Text = "Centro Izquierda";
            // 
            // textBoxCentroIzq
            // 
            this.textBoxCentroIzq.Location = new System.Drawing.Point(150, 75);
            this.textBoxCentroIzq.Name = "textBoxCentroIzq";
            this.textBoxCentroIzq.Size = new System.Drawing.Size(150, 27);
            this.textBoxCentroIzq.TabIndex = 7;
            this.textBoxCentroIzq.Text = "-5";
            this.textBoxCentroIzq.TextChanged += new System.EventHandler(this.textBoxCentroIzq_TextChanged);
            this.textBoxCentroIzq.Enter += new System.EventHandler(this.textBoxCentroIzq_Enter);
            this.textBoxCentroIzq.Leave += new System.EventHandler(this.textBoxCentroIzq_Leave);
            // 
            // labelLimiteIzquierdo
            // 
            this.labelLimiteIzquierdo.AutoSize = true;
            this.labelLimiteIzquierdo.Location = new System.Drawing.Point(2, 39);
            this.labelLimiteIzquierdo.Name = "labelLimiteIzquierdo";
            this.labelLimiteIzquierdo.Size = new System.Drawing.Size(117, 20);
            this.labelLimiteIzquierdo.TabIndex = 6;
            this.labelLimiteIzquierdo.Text = "Limite Izquierdo";
            // 
            // textBoxLimIzquierdo
            // 
            this.textBoxLimIzquierdo.Location = new System.Drawing.Point(150, 36);
            this.textBoxLimIzquierdo.Name = "textBoxLimIzquierdo";
            this.textBoxLimIzquierdo.Size = new System.Drawing.Size(150, 27);
            this.textBoxLimIzquierdo.TabIndex = 5;
            this.textBoxLimIzquierdo.Text = "-10";
            this.textBoxLimIzquierdo.Enter += new System.EventHandler(this.textBoxLimIzquierdo_Enter);
            this.textBoxLimIzquierdo.Leave += new System.EventHandler(this.textBoxLimIzquierdo_Leave);
            // 
            // formsPlot1
            // 
            this.formsPlot1.Enabled = false;
            this.formsPlot1.Location = new System.Drawing.Point(20, 6);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(772, 270);
            this.formsPlot1.TabIndex = 28;
            this.formsPlot1.Load += new System.EventHandler(this.formsPlot1_Load);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(614, 413);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 31;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuConfigFuncionTrapezoidal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.formsPlot1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MenuConfigFuncionTrapezoidal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuConfigFuncionTrapezoidal";
            this.Load += new System.EventHandler(this.MenuConfigFuncionTrapezoidal_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button GuardarButton;
        private Panel panel2;
        private Label labelLimDerecho;
        private TextBox textBoxLimDerecho;
        private Label labelParametros;
        private Label labelCentroIzquierda;
        private TextBox textBoxCentroIzq;
        private Label labelLimiteIzquierdo;
        private TextBox textBoxLimIzquierdo;
        public ScottPlot.FormsPlot formsPlot1;
        private Label labelCentroIzq;
        private TextBox textBoxCentroDer;
        private Button button1;
    }
}