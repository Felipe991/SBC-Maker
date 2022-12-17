using Newtonsoft.Json;
using SBC_Maker.Interfaz_grafica;
using SBC_Maker.Logica;
using SBC_Maker.Logica.Configuracion;
using static SBC_Maker.Logica.Utiles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Xml.Serialization;
using static SBC_Maker.Logica.FormListener;

namespace SBC_Maker
{
    public partial class MenuConfeccion : Form
    {
        private SBC sbc;
        private bool mouseDown = false;
        private bool volverPrincipal = true;
        public MenuConfeccion()
        {
            InitializeComponent();
            setDirectorys();
            this.sbc = new SBC();
            this.SetStyle(ControlStyles.Opaque, true);
            DoubleBuffered = true;
        }
        
        public MenuConfeccion(SBC sbc)
        {
            InitializeComponent();
            setDirectorys();
            this.sbc = sbc;
            rebuildNodos(sbc.BaseConocimiento);
            this.Text += " (" + sbc.Nombre + ")";
            DoubleBuffered = true;
            this.panelLienzo.Refresh();
        }

        private void setDirectorys()
        {
            setDirectoryConjuntoDifuso();
            setDirectorySBC();
        }

        private void setDirectorySBC()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path = Path.Combine(path, "SBCs");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            this.openFileDialogSBC.InitialDirectory = path;
            this.saveFileDialogSBCs.InitialDirectory = path;
        }

        private void setDirectoryConjuntoDifuso()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path = Path.Combine(path, "Conjuntos Difusos");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            this.openFileDialogConjuntoDifuso.InitialDirectory = path;
        }

        private void conjuntoDifusoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialogConjuntoDifuso.Filter = "CDF Conjunto Difuso (*.cdf)|*.cdf|All files (*.*)|*.*";
            if (openFileDialogConjuntoDifuso.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Stream stream = File.Open(openFileDialogConjuntoDifuso.FileName, FileMode.Open);
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    ConjuntoDifuso conjuntoDifuso = (ConjuntoDifuso)bformatter.Deserialize(stream);
                    stream.Close();
                    MenuConjuntoDifuso mcd = new MenuConjuntoDifuso(conjuntoDifuso);
                    mcd.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("Archivo inválido");
                }
            }
        }

        private void conjuntoDifusoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuConjuntoDifuso menuConjuntoDifuso = new MenuConjuntoDifuso();
            menuConjuntoDifuso.ShowDialog();
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuConfiguracionSBC menuConfiguracionSBC = new MenuConfiguracionSBC(sbc.ConfiguracionMotor);
            menuConfiguracionSBC.ShowDialog();
        }

        private void toolStripButtonAgregarRegla_Click(object sender, EventArgs e)
        {
            MenuRegla menuRegla = new MenuRegla(sbc.BaseConocimiento);
            menuRegla.ShowDialog();
            if (menuRegla.DialogResult == DialogResult.OK)
            {
                addNUC(menuRegla.nodo, sbc.BaseConocimiento, panelLienzo);
            }
        }

        private void addNUC(Nodo nodo, List<Nodo> baseConocimiento, Panel panelLienzo)
        {
            NodoUserControl NUC = new NodoUserControl(nodo, sbc.BaseConocimiento, panelLienzo);
            NUC.flechas = this.sbc.datosFlecha;
            ExtendEvents(NUC);
            this.panelLienzo.Controls.Add(NUC);
            NUC.Left = nodo.Posicion.X;
            NUC.Top = nodo.Posicion.Y;
            AsignarNivelGlobal(sbc.BaseConocimiento);
            LoadTree(sbc.BaseConocimiento);
        }

        private void ExtendEvents(NodoUserControl NUC)
        {
            NUC.MouseMove += panelLienzo_MouseMove;
            NUC.richTextBoxNombreRegla.MouseMove += panelLienzo_MouseMove;
            foreach (Control c in NUC.Controls)
            {
                c.MouseMove += panelLienzo_MouseMove;
                c.MouseUp+= panelLienzo_MouseUp;
                c.MouseDown += panelLienzo_MouseDown;
            }
        }

        private void toolStripButtonAgregarRelacion_Click(object sender, EventArgs e)
        {
            MenuRelacion menuRelacion = new MenuRelacion(sbc.BaseConocimiento);
            if (menuRelacion.ShowDialog() == DialogResult.OK)
            {
                AddNewFlecha(menuRelacion);
                AsignarNivelGlobal(sbc.BaseConocimiento);
                LoadTree(sbc.BaseConocimiento);
                this.panelLienzo.Refresh();
            }
        }

        private void AddNewFlecha(MenuRelacion menuRelacion)
        {
            Nodo antecedente = menuRelacion.antecedente;
            Nodo consecuente = menuRelacion.consecuente;

            Posicion posAnt = antecedente.Posicion;
            Posicion posCon = consecuente.Posicion;

            string ID = antecedente.Regla.Nombre + consecuente.Regla.Nombre;
            
            this.sbc.datosFlecha.Add((ID,(posAnt,posCon)));
        }

        private void panelLienzo_Paint(object sender, PaintEventArgs e)
        {
            foreach((string,(Posicion,Posicion)) datos in sbc.datosFlecha)
            {
                DrawArrow(datos,e.Graphics);
            }
        }

        private void DrawArrow((string, (Posicion, Posicion)) datos,Graphics g)
        {
            Pen p = new Pen(Brushes.Black,5);
            p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(p,
                       datos.Item2.Item1.X+70,
                       datos.Item2.Item1.Y+30,
                       datos.Item2.Item2.X+70,
                       datos.Item2.Item2.Y-3);
        }

        private void panelLienzo_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Refresh();
            }
        }

        private void panelLienzo_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panelLienzo_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void LoadTree(List<Nodo> listaAdyacencia)
        {
            this.treeViewRelaciones.Nodes.Clear();
            int i = 0;
            foreach (Nodo nodo in listaAdyacencia)
            {
                this.treeViewRelaciones.Nodes.Add(nodo.Regla.Nombre);
                foreach (Nodo consecuente in nodo.Consecuentes)
                {
                    foreach (List<Relacion> antecedentes in consecuente.Antecedentes)
                    {
                        Relacion antecedente = antecedentes.Find(r => r.Nodo == nodo);
                        if (antecedente != null)
                        {
                            int numeroRelacion = antecedente.NumeroRelacion;
                            string label = "(" + numeroRelacion + ") " + consecuente.Regla.Nombre;

                            this.treeViewRelaciones.Nodes[i].Nodes.Add(label);
                        }
                    }
                }
                i++;
            }
        }

        private void toolStripButtonVerRelaciones_Click(object sender, EventArgs e)
        {
            bool visible = this.treeViewRelaciones.Visible;
            LoadTree(sbc.BaseConocimiento);
            this.treeViewRelaciones.Visible = !visible;
        }

        private void ejecutarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!VerifyStructure(sbc.BaseConocimiento)) MessageBox.Show("Base de conocimiento invalida", "Error");
            else 
            {
                CreateTemp(sbc);
                var MenuEjecucion = new MenuEjecucion(sbc, true);
                MenuEjecucion.ShowDialog();
                volverPrincipal = false;
                instanceNewForm(new MenuConfeccion(LoadTemp()));
                this.Close();
            }
        }

        private SBC LoadTemp()
        {
            Stream stream = File.Open("temp.sbc", FileMode.Open);
            var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            SBC sbcAux = (SBC)bformatter.Deserialize(stream);
            stream.Close();
            File.Delete("temp.sbc");
            return sbcAux;
        }

        private void CreateTemp(SBC sbc)
        {
            File.Create("temp.sbc").Close();
            Stream stream = File.Open("temp.sbc", FileMode.Create);
            var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            bformatter.Serialize(stream, sbc);
            stream.Close();
        }

        private void MenuConfeccion_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(volverPrincipal) instanceNewForm(new MenuPrincipal());
        }

        private void askUserSaveSBC()
        {
            if (MessageBox.Show("¿Guardar SBC?", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                saveSBC();
            }
        }

        private void saveSBC()
        {
            saveFileDialogSBCs.FileName = this.sbc.Nombre;
            saveFileDialogSBCs.Filter = "SBC Sistema Basado en Conocimiento (*.sbc)|*.sbc|All files (*.*)|*.*";
            if (saveFileDialogSBCs.ShowDialog() == DialogResult.OK)
            {
                File.Create(saveFileDialogSBCs.FileName).Close();
                Stream stream = File.Open(saveFileDialogSBCs.FileName, FileMode.Create);
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                bformatter.Serialize(stream, this.sbc);
                stream.Close();
                DialogResult = DialogResult.OK;
                MessageBox.Show("Archivo guardado");
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void proyectoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SBC sbcAux = loadSBC();
            if (sbcAux != null) 
            {
                instanceNewForm(new MenuConfeccion(sbcAux));
                volverPrincipal = false;
                this.Close();
            } 
        }

        private void rebuildNodos(List<Nodo> baseConocimiento)
        {
            foreach(Nodo nodo in baseConocimiento)
            {
                addNUC(nodo, baseConocimiento,panelLienzo);
            }
        }

        private SBC loadSBC()
        {
            SBC sbc = null;
            try
            {
                openFileDialogSBC.Filter = "SBC Sistema Basado en Conocimiento (*.sbc)|*.sbc|All files (*.*)|*.*";
                if (openFileDialogSBC.ShowDialog() == DialogResult.OK)
                {
                    Stream stream = File.Open(openFileDialogSBC.FileName, FileMode.Open);
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    sbc = (SBC)bformatter.Deserialize(stream);
                    stream.Close();
                    sbc.Nombre = openFileDialogSBC.FileName.Split('\\').Last().Split('.').First();
                }
            }
            catch
            {
                MessageBox.Show("Archivo inválido");
            }
            return sbc;
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveSBC();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveSBC();
        }

        private void MenuConfeccion_FormClosing(object sender, FormClosingEventArgs e)
        {
            askUserSaveSBC();
        }
    }
}
