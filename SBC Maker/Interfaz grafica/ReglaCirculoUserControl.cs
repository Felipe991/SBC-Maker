using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBC_Maker.Interfaz_grafica
{
    public partial class ReglaCirculoUserControl : UserControl
    {
        TextBox textBox1;
        TextBox textBox2;
        Panel circle;
        public ReglaCirculoUserControl()
        {
            InitializeComponent();
            textBox1 = new TextBox { Parent = this, Width = 100, Left = 20, Top = 20, Height = 80, AutoSize = false };
            textBox2 = new TextBox { Parent = this, Width = 100, Left = 20, Top = textBox1.Bottom };
            ShowCircle();
        }
        void ShowCircle()
        {
            circle = new Panel
            {
                Parent = this,
                BackColor = Color.Red,
                Top = textBox1.Top,
                Left = textBox1.Left,
                Width = textBox1.Width,
                Height = textBox1.Height + textBox2.Height
            };

            using (var path = new GraphicsPath())
            {
                var rect = new Rectangle(0, 0, circle.Width, circle.Height);
                path.AddEllipse(rect);
                rect.Inflate(-5, -5);
                path.AddEllipse(rect);

                circle.Region = new Region(path);
                circle.BringToFront();
            }
        }
    }
}
