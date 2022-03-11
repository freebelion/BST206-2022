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
        /// <summary>
        /// Kontrolleri temsil edecek değişken tanımlarını bu bölgede topladık.
        /// </summary>
        #region
        // Kontroller arasında ve form içerisinde bırakacağımız kenar boşluğu (marjin)
        private int marjin = 5;
        // Hesap makinesi ekranını temsil edecek olan metin kutusunun referans değişkeni
        private TextBox tbEkran;
        #endregion

        public HesapForm()
        {
            InitializeComponent();

            FormOlustur();
            KontrollerOlustur();
            KontrolleriYerlestir();
        }

        /// <summary>
        /// Form görünümünü değiştirecek komutları topladığımız fonksiyon
        /// </summary>
        private void FormOlustur()
        {
            this.Text = "Hesap Makinesi";
            this.BackColor = Color.AliceBlue;
            this.Font = new Font(FontFamily.GenericSansSerif, 14);
            // this.Size = new System.Drawing.Size(400, 500);
            this.Width = 400;
            this.Height = 500;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        /// <summary>
        /// Form üzerindeki kontrolleri oluşturup ekleyen komutları içeren fonksiyon
        /// </summary>
        private void KontrollerOlustur()
        {
            tbEkran = new TextBox(); // ekranı temsil eden metin kutusu nesnesini oluştur.
            this.Controls.Add(tbEkran); // metin kutusunu formun kontroller koleksiyonuna ekliyoruz.
            tbEkran.BackColor = Color.LightBlue; // ayırt edici bir geriplan rengi belirle.
            tbEkran.Multiline = true; // ekranı çok satırlı yap ki yüksekliğini biz belirleyelim.
            tbEkran.BorderStyle = BorderStyle.FixedSingle; // ekran kutusu kenarlığı düz çizgi olsun.
        }

        private void KontrolleriYerlestir()
        {

            tbEkran.Height = this.Height / 3; // ekran yüksekliğini form yüksekliğiyle orantıla.
            tbEkran.Left = marjin; // ekran kutusu formun sol kenarından marjin kadar içeride olacak.
            tbEkran.Top = marjin; // ekran kutusu formun üst kenarından marjin kadar içeride olacak.

            // ekran kutusu genişliği form iç bölge genişliğinden iki marjin eksik olacak
            tbEkran.Width = this.ClientRectangle.Width - 2 * marjin;
        }
    }
}
