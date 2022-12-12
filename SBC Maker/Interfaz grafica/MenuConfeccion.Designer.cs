namespace SBC_Maker
{
    partial class MenuConfeccion
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conjuntoDifusoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proyectoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.conjuntoDifusoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejecutarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAgregarRegla = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAgregarRelacion = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonVerRelaciones = new System.Windows.Forms.ToolStripButton();
            this.panelLienzo = new System.Windows.Forms.Panel();
            this.treeViewRelaciones = new System.Windows.Forms.TreeView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panelLienzo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ejecutarToolStripMenuItem,
            this.configuracionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1019, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proyectoToolStripMenuItem,
            this.conjuntoDifusoToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // proyectoToolStripMenuItem
            // 
            this.proyectoToolStripMenuItem.Name = "proyectoToolStripMenuItem";
            this.proyectoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.proyectoToolStripMenuItem.Text = "Proyecto";
            // 
            // conjuntoDifusoToolStripMenuItem
            // 
            this.conjuntoDifusoToolStripMenuItem.Name = "conjuntoDifusoToolStripMenuItem";
            this.conjuntoDifusoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.conjuntoDifusoToolStripMenuItem.Text = "Conjunto difuso";
            this.conjuntoDifusoToolStripMenuItem.Click += new System.EventHandler(this.conjuntoDifusoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proyectoToolStripMenuItem1,
            this.conjuntoDifusoToolStripMenuItem1});
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // proyectoToolStripMenuItem1
            // 
            this.proyectoToolStripMenuItem1.Name = "proyectoToolStripMenuItem1";
            this.proyectoToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.proyectoToolStripMenuItem1.Text = "Proyecto";
            // 
            // conjuntoDifusoToolStripMenuItem1
            // 
            this.conjuntoDifusoToolStripMenuItem1.Name = "conjuntoDifusoToolStripMenuItem1";
            this.conjuntoDifusoToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.conjuntoDifusoToolStripMenuItem1.Text = "Conjunto Difuso";
            this.conjuntoDifusoToolStripMenuItem1.Click += new System.EventHandler(this.conjuntoDifusoToolStripMenuItem1_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar como...";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // ejecutarToolStripMenuItem
            // 
            this.ejecutarToolStripMenuItem.Name = "ejecutarToolStripMenuItem";
            this.ejecutarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ejecutarToolStripMenuItem.Text = "Ejecutar";
            this.ejecutarToolStripMenuItem.Click += new System.EventHandler(this.ejecutarToolStripMenuItem_Click);
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            this.configuracionToolStripMenuItem.Click += new System.EventHandler(this.configuracionToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 26);
            this.panel2.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAgregarRegla,
            this.toolStripButtonAgregarRelacion,
            this.toolStripButtonVerRelaciones});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1014, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAgregarRegla
            // 
            this.toolStripButtonAgregarRegla.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAgregarRegla.Image = global::SBC_Maker.Properties.Resources._1491254405_plusaddmoredetail_82972;
            this.toolStripButtonAgregarRegla.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAgregarRegla.Name = "toolStripButtonAgregarRegla";
            this.toolStripButtonAgregarRegla.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonAgregarRegla.Text = "toolStripButtonAgregarRegla";
            this.toolStripButtonAgregarRegla.Click += new System.EventHandler(this.toolStripButtonAgregarRegla_Click);
            // 
            // toolStripButtonAgregarRelacion
            // 
            this.toolStripButtonAgregarRelacion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAgregarRelacion.Image = global::SBC_Maker.Properties.Resources.arrow_arrows_back_direction_left_navigation_right_icon_123236;
            this.toolStripButtonAgregarRelacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAgregarRelacion.Name = "toolStripButtonAgregarRelacion";
            this.toolStripButtonAgregarRelacion.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonAgregarRelacion.Text = "toolStripButtonAgregarRelacion";
            this.toolStripButtonAgregarRelacion.Click += new System.EventHandler(this.toolStripButtonAgregarRelacion_Click);
            // 
            // toolStripButtonVerRelaciones
            // 
            this.toolStripButtonVerRelaciones.BackgroundImage = global::SBC_Maker.Properties.Resources.Imagen1tree2;
            this.toolStripButtonVerRelaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButtonVerRelaciones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonVerRelaciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonVerRelaciones.Name = "toolStripButtonVerRelaciones";
            this.toolStripButtonVerRelaciones.Size = new System.Drawing.Size(23, 24);
            this.toolStripButtonVerRelaciones.Text = "toolStripButton1";
            this.toolStripButtonVerRelaciones.Click += new System.EventHandler(this.toolStripButtonVerRelaciones_Click);
            // 
            // panelLienzo
            // 
            this.panelLienzo.AllowDrop = true;
            this.panelLienzo.AutoScroll = true;
            this.panelLienzo.AutoSize = true;
            this.panelLienzo.BackColor = System.Drawing.SystemColors.Window;
            this.panelLienzo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLienzo.Controls.Add(this.treeViewRelaciones);
            this.panelLienzo.Location = new System.Drawing.Point(0, 57);
            this.panelLienzo.Name = "panelLienzo";
            this.panelLienzo.Size = new System.Drawing.Size(1020, 509);
            this.panelLienzo.TabIndex = 3;
            this.panelLienzo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLienzo_Paint);
            this.panelLienzo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLienzo_MouseDown);
            this.panelLienzo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelLienzo_MouseMove);
            this.panelLienzo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelLienzo_MouseUp);
            // 
            // treeViewRelaciones
            // 
            this.treeViewRelaciones.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.treeViewRelaciones.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.treeViewRelaciones.Location = new System.Drawing.Point(-2, -2);
            this.treeViewRelaciones.Name = "treeViewRelaciones";
            this.treeViewRelaciones.Size = new System.Drawing.Size(131, 504);
            this.treeViewRelaciones.TabIndex = 0;
            this.treeViewRelaciones.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "C:\\Users\\R_B_G\\Documents\\Conjuntos Difusos";
            // 
            // MenuConfeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 559);
            this.Controls.Add(this.panelLienzo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuConfeccion";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuConfeccion_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelLienzo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private SaveFileDialog saveFileDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem proyectoToolStripMenuItem;
        private ToolStripMenuItem conjuntoDifusoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem proyectoToolStripMenuItem1;
        private ToolStripMenuItem conjuntoDifusoToolStripMenuItem1;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem guardarComoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem ejecutarToolStripMenuItem;
        private Panel panel2;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonAgregarRegla;
        private ToolStripButton toolStripButtonAgregarRelacion;
        private Panel panelLienzo;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem configuracionToolStripMenuItem;
        private ToolStripButton toolStripButtonVerRelaciones;
        private TreeView treeViewRelaciones;
    }
}