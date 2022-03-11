using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapProje1
{
    public partial class HesapForm : Form
    {
        public HesapForm()
        {
            InitializeComponent();

            FormOlustur();
        }

        private void FormOlustur()
        {
            this.Text = "Hesap Makinesi";
            this.BackColor = Color.AliceBlue;
            // this.Size = new System.Drawing.Size(400, 500);
            this.Width = 400;
            this.Height = 500;
        }
    }
}
