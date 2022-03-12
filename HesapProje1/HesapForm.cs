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
        #region Kontrol Degişkenleri Tanımları
        // Kontroller arasında ve form içerisinde bırakacağımız kenar boşluğu (marjin)
        private int marjin = 5;
        // Düğmeler için boyutlar
        private int dugmeGenislik, dugmeYukseklik;
        // Hesap makinesi ekranını temsil edecek olan metin kutusunun referans değişkeni
        private TextBox tbEkran;
        // Rakam ve işlem düğmeleri dizisi
        private Button[] dugmeler;
        // Rakam ve işlem düğmeleri için referans değişkenleri
        Button btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9,
               btnToplama, btnCikarma, btnCarpma, btnBolme, btnSil, btnEsit;
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
            // this.Size = new System.Drawing.Size(400, 500);
            this.Width = 400;
            this.Height = 500;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            // Form boyutunun değişmesi kontrollerin yeniden yerleştirilmesini gerektirir.
            // Boyut değişimi bitince çağrılacak fonksiyonu belirle.
            this.ResizeEnd += HesapForm_ResizeEnd;
        }

        /// <summary>
        /// Form boyutu değişince çağrılacak olan bu fonksiyon
        /// kontrolleri yeniden yerleştirme işini ilgili fonksiyona havale ediyor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HesapForm_ResizeEnd(object sender, EventArgs e)
        {
            KontrolleriYerlestir();
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

            dugmeler = new Button[16]; // düğmeler dizisini oluştur
            // dizi elemanlarını yeni düğmeler olarak oluştur ve forma ekle
            for(int i= 0; i < 16; i++)
            {
                dugmeler[i] = new Button();
                dugmeler[i].BackColor = Color.LightBlue;
                this.Controls.Add(dugmeler[i]);
            }

            // rakam ve işlem düğme referanslarını belirle
            btn0 = dugmeler[0];
            btnSil = dugmeler[1];
            btnEsit = dugmeler[2];
            btnBolme = dugmeler[3];
            btn1 = dugmeler[4];
            btn2 = dugmeler[5];             
            btn3 = dugmeler[6];
            btnCarpma = dugmeler[7];
            btn4 = dugmeler[8];
            btn5 = dugmeler[9];
            btn6 = dugmeler[10];   
            btnCikarma = dugmeler[11];
            btn7 = dugmeler[12];
            btn8 = dugmeler[13];
            btn9 = dugmeler[14];
            btnToplama = dugmeler[15];

            // düğme etiketlerini belirle
            btn0.Text = "0";
            btn1.Text = "1";
            btn2.Text = "2";
            btn3.Text = "3";
            btn4.Text = "4";
            btn5.Text = "5";
            btn6.Text = "6";
            btn7.Text = "7";
            btn8.Text = "8";
            btn9.Text = "9";
            btnToplama.Text = "+";
            btnCikarma.Text = "-";
            btnCarpma.Text = "*";
            btnBolme.Text = "/";
            btnSil.Text = "C";
            btnEsit.Text = "=";
        }

        private void KontrolleriYerlestir()
        {
            this.SuspendLayout(); // yeniden yerleştirme işlemlerini görüntüleme

            tbEkran.Height = this.ClientRectangle.Height / 3; // ekran yüksekliğini formun iç bölge yüksekliğiyle orantıla.
            tbEkran.Left = marjin; // ekran kutusu formun sol kenarından marjin kadar içeride olacak.
            tbEkran.Top = marjin; // ekran kutusu formun üst kenarından marjin kadar içeride olacak.
            // ekran kutusu genişliği form iç bölge genişliğinden iki marjin eksik olacak
            tbEkran.Width = this.ClientRectangle.Width - 2 * marjin;

            // düğme boyutlarını hesapla
            dugmeYukseklik = (this.ClientRectangle.Height - tbEkran.Bottom - 5 * marjin) / 4;
            dugmeGenislik = (this.ClientRectangle.Width - 5 * marjin) / 4;
            // düğmeleri yerleştir
            for (int i = 0; i < 16; i++)
            {
                dugmeler[i].Width = dugmeGenislik;
                dugmeler[i].Height = dugmeYukseklik;
                dugmeler[i].Left = this.ClientRectangle.Left + marjin + (i % 4) * (dugmeGenislik + marjin);
                dugmeler[i].Top = this.ClientRectangle.Bottom - (1 + (int)(i / 4)) * (dugmeYukseklik + marjin);
            }

            this.ResumeLayout(true); // yerleştirme bitti; yeniden görüntüleyebeliriz.
        }
    }
}
