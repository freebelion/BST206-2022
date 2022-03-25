using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafikProje1
{
    public partial class GrafikForm : Form
    {
        private const int boyut = 1;
        private Size boyutlar;
        private List<Rectangle> noktalar;
        private bool cizimBasladi = false;
        private Graphics yuzey;

        public GrafikForm()
        {
            InitializeComponent();
            noktalar = new List<Rectangle>();
            boyutlar = new Size(boyut, boyut);
        }

        private void GrafikForm_Load(object sender, EventArgs e)
        {
            yuzey = this.CreateGraphics();
        }

        private void GrafikForm_MouseDown(object sender, MouseEventArgs e)
        {
            cizimBasladi = true;
        }

        private void GrafikForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            foreach(Rectangle r in noktalar)
            {
                gr.FillRectangle(Brushes.Black, r);
            }
        }

        private void GrafikForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void GrafikForm_MouseUp(object sender, MouseEventArgs e)
        {
            cizimBasladi = false;
        }

        private void GrafikForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(cizimBasladi)
            {
                Rectangle r = new Rectangle(e.Location, boyutlar);
                yuzey.FillRectangle(Brushes.Black, r);
                noktalar.Add(r);
            }
        }
    }
}
