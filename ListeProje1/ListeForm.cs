using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListeProje1
{
    public partial class ListeForm : Form
    {
        public ListeForm()
        {
            InitializeComponent();
        }

        private void lbListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbEleman.Text = lbListe.Text;
        }

        private void tbEleman_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                lbListe.Items.Add(tbEleman.Text);
            }
        }

        private void ListeKutusu_TusaBasildi(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                while(lbListe.SelectedItems.Count > 0)
                {
                    lbListe.Items.Remove(lbListe.SelectedItem);
                }
            }
        }
    }
}
