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

namespace SBC_Maker
{
    public partial class MenuConfeccion : Form
    {
        private SBC sbc;
        private List<(string, (Posicion, Posicion))> datosFlecha = new();
        private bool mouseDown = false;
        public MenuConfeccion(string nombre)
        {
            InitializeComponent();
            this.sbc = new SBC(nombre, new ConfiguracionMotor());
            this.SetStyle(ControlStyles.Opaque, true);
        }
        
        public MenuConfeccion(SBC sbc)
        {
            InitializeComponent();
            this.sbc = sbc;
        }

        private void MenuConfeccion_Load(object sender, EventArgs e)
        {
            DoubleBuffered = false;
        }

        private void conjuntoDifusoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
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
                NodoUserControl NUC = new NodoUserControl(menuRegla.nodo, sbc.BaseConocimiento);
                ExtendEvents(NUC);
                this.panelLienzo.Controls.Add(NUC);
            }
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

            this.datosFlecha.Add((ID,(posAnt,posCon)));
        }

        private void panelLienzo_Paint(object sender, PaintEventArgs e)
        {
            foreach((string,(Posicion,Posicion)) datos in datosFlecha)
            {
                DrawArrow(datos,e.Graphics);
            }
        }

        private void DrawArrow((string, (Posicion, Posicion)) datos,Graphics g)
        {
            Pen p = new Pen(Brushes.Black,5);
            p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(p,
                       datos.Item2.Item1.X+45,
                       datos.Item2.Item1.Y+45,
                       datos.Item2.Item2.X+45,
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
    }
}
