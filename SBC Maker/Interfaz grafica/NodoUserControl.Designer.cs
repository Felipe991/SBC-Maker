namespace SBC_Maker.Interfaz_grafica
{
    partial class NodoUserControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richTextBoxNombreRegla = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarReglaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarRelacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarReglaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxNombreRegla
            // 
            this.richTextBoxNombreRegla.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBoxNombreRegla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxNombreRegla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.richTextBoxNombreRegla.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxNombreRegla.Location = new System.Drawing.Point(5, 5);
            this.richTextBoxNombreRegla.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBoxNombreRegla.Name = "richTextBoxNombreRegla";
            this.richTextBoxNombreRegla.ReadOnly = true;
            this.richTextBoxNombreRegla.Size = new System.Drawing.Size(80, 80);
            this.richTextBoxNombreRegla.TabIndex = 0;
            this.richTextBoxNombreRegla.Text = "";
            this.richTextBoxNombreRegla.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.richTextBoxNombreRegla_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarReglaToolStripMenuItem,
            this.editarRelacionesToolStripMenuItem,
            this.eliminarReglaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(189, 76);
            // 
            // editarReglaToolStripMenuItem
            // 
            this.editarReglaToolStripMenuItem.Name = "editarReglaToolStripMenuItem";
            this.editarReglaToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.editarReglaToolStripMenuItem.Text = "Editar regla";
            this.editarReglaToolStripMenuItem.Click += new System.EventHandler(this.editarReglaToolStripMenuItem_Click);
            // 
            // editarRelacionesToolStripMenuItem
            // 
            this.editarRelacionesToolStripMenuItem.Name = "editarRelacionesToolStripMenuItem";
            this.editarRelacionesToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.editarRelacionesToolStripMenuItem.Text = "Editar relaciones";
            this.editarRelacionesToolStripMenuItem.Click += new System.EventHandler(this.editarRelacionesToolStripMenuItem_Click);
            // 
            // eliminarReglaToolStripMenuItem
            // 
            this.eliminarReglaToolStripMenuItem.Name = "eliminarReglaToolStripMenuItem";
            this.eliminarReglaToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.eliminarReglaToolStripMenuItem.Text = "Eliminar regla";
            this.eliminarReglaToolStripMenuItem.Click += new System.EventHandler(this.eliminarReglaToolStripMenuItem_Click);
            // 
            // NodoUserControl
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.richTextBoxNombreRegla);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NodoUserControl";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(90, 90);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NodoUserControl_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NodoUserControl_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NodoUserControl_MouseUp);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public RichTextBox richTextBoxNombreRegla;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editarReglaToolStripMenuItem;
        private ToolStripMenuItem editarRelacionesToolStripMenuItem;
        private ToolStripMenuItem eliminarReglaToolStripMenuItem;
    }
}
