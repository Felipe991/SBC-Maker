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
            this.saveFileDialogSBC = new System.Windows.Forms.SaveFileDialog();
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
            this.panelLienzo = new System.Windows.Forms.Panel();
            this.treeViewRelaciones = new System.Windows.Forms.TreeView();
            this.openFileDialogConjuntoDifuso = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogSBC = new System.Windows.Forms.OpenFileDialog();
            this.toolStripButtonAgregarRegla = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAgregarRelacion = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonVerRelaciones = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panelLienzo.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ejecutarToolStripMenuItem,
            this.configuracionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
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
            this.proyectoToolStripMenuItem.Click += new System.EventHandler(this.proyectoToolStripMenuItem_Click);
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
            this.proyectoToolStripMenuItem1.Click += new System.EventHandler(this.proyectoToolStripMenuItem1_Click);
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
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar como...";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
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
            this.panel2.AutoSize = true;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1019, 0);
            this.panel2.TabIndex = 2;
            // 
            // panelLienzo
            // 
            this.panelLienzo.AllowDrop = true;
            this.panelLienzo.AutoScroll = true;
            this.panelLienzo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelLienzo.BackColor = System.Drawing.SystemColors.Window;
            this.panelLienzo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLienzo.Controls.Add(this.treeViewRelaciones);
            this.panelLienzo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLienzo.Location = new System.Drawing.Point(0, 0);
            this.panelLienzo.Name = "panelLienzo";
            this.panelLienzo.Size = new System.Drawing.Size(1014, 511);
            this.panelLienzo.TabIndex = 3;
            this.panelLienzo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLienzo_Paint);
            this.panelLienzo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLienzo_MouseDown);
            this.panelLienzo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelLienzo_MouseMove);
            this.panelLienzo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelLienzo_MouseUp);
            // 
            // treeViewRelaciones
            // 
            this.treeViewRelaciones.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.treeViewRelaciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewRelaciones.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.treeViewRelaciones.Location = new System.Drawing.Point(0, 0);
            this.treeViewRelaciones.Name = "treeViewRelaciones";
            this.treeViewRelaciones.Size = new System.Drawing.Size(131, 507);
            this.treeViewRelaciones.TabIndex = 0;
            this.treeViewRelaciones.Visible = false;
            // 
            // openFileDialogSBC
            // 
            this.openFileDialogSBC.FileName = "SBC";
            // 
            // toolStripButtonAgregarRegla
            // 
            this.toolStripButtonAgregarRegla.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAgregarRegla.Image = global::SBC_Maker.Properties.Resources._1491254405_plusaddmoredetail_82972;
            this.toolStripButtonAgregarRegla.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAgregarRegla.Name = "toolStripButtonAgregarRegla";
            this.toolStripButtonAgregarRegla.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonAgregarRegla.Text = "toolStripButtonAgregarRegla";
            this.toolStripButtonAgregarRegla.ToolTipText = "Agregar Regla";
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
            this.toolStripButtonAgregarRelacion.ToolTipText = "Agregar relación";
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
            this.toolStripButtonVerRelaciones.ToolTipText = "Mostrar arbol de relaciones";
            this.toolStripButtonVerRelaciones.Click += new System.EventHandler(this.toolStripButtonVerRelaciones_Click);
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
            this.toolStrip1.Size = new System.Drawing.Size(1019, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 535);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.panelLienzo);
            this.panel3.Location = new System.Drawing.Point(3, 22);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1014, 511);
            this.panel3.TabIndex = 4;
            // 
            // MenuConfeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1019, 559);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuConfeccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuConfeccion_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuConfeccion_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelLienzo.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private SaveFileDialog saveFileDialogSBC;
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
        private Panel panelLienzo;
        private OpenFileDialog openFileDialogConjuntoDifuso;
        private ToolStripMenuItem configuracionToolStripMenuItem;
        private TreeView treeViewRelaciones;
        private OpenFileDialog openFileDialogSBC;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonAgregarRegla;
        private ToolStripButton toolStripButtonAgregarRelacion;
        private ToolStripButton toolStripButtonVerRelaciones;
        private Panel panel1;
        private Panel panel3;
    }
}