using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaProje1
{
    public partial class BankamatikForm : Form
    {
        private decimal bakiye = 0;

        public BankamatikForm()
        {
            InitializeComponent();
        }

        private void btnYatir10TL_Click(object sender, EventArgs e)
        {
            bakiye += 10;
            bakiyeGoster();
        }

        private void Yatir20TL(object sender, EventArgs e)
        {
            bakiye += 20;
            bakiyeGoster();
        }

        private void btnYatir50TL_Click(object sender, EventArgs e)
        {
            bakiye += 50;
            bakiyeGoster();
        }

        private void bakiyeGoster()
        {
            tbBakiye.Text = bakiye.ToString("C");
        }
    }
}
