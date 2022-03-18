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
        /// Form sınıfına ait değişken tanımlarını bu bölgede topladık.
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
               btnToplama, btnCikarma, btnCarpma, btnBolme, btnNokta, btnEsit;
        // İşlem argümanları ve sonuçlarını saklayacak değişkenler
        private double sayi1, sayi2, sonuc;
        // Geçerli işlemci karakterleri
        private char[] islemKarakterleri = new char[] { '+', '-', '*', '/', '=' };
        #endregion

        /// <summary>
        /// Kurucu fonksiyon form nesnesine ait üye değişkenlere ilk değerler atar.
        /// </summary>
        public HesapForm()
        {
            // İşlem değerlerini geçersiz sayılar olarak başlat
            sayi1 = double.NaN;
            sayi2 = double.NaN;
            sonuc = double.NaN;
            
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
            tbEkran.Multiline = true; // ekran artık çok satırlı olacak.
            tbEkran.BorderStyle = BorderStyle.FixedSingle; // ekran kutusu kenarlığı düz çizgi olsun.
            
            dugmeler = new Button[16]; // düğmeler dizisini oluştur
            // dizi elemanlarını yeni düğmeler olarak oluştur ve forma ekle
            for(int i= 0; i < 16; i++)
            {
                dugmeler[i] = new Button();
                dugmeler[i].BackColor = Color.LightBlue;
                this.Controls.Add(dugmeler[i]);
                // tüm düğmeler için etiketi aktaran tıklama olay fonksiyonunu ekle
                dugmeler[i].Click += RakamIslemDugme_Click;
            }

            // rakam ve işlem düğme referanslarını belirle
            btn0 = dugmeler[0];
            btnNokta = dugmeler[1];
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
            btnEsit.Text = "=";
            // Programın çalıştığı bilgisayarda geçerli olan ayarlara göre
            // ondalık ayıracı öğren ve ilgili düğmeye etiket olarak  koy.
            btnNokta.Text = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

            // İşlem düğmeleri için tıklama olayını yanıtlayacak fonksiyonlar belirle
            btnToplama.Click += IslemDugme_Click;
            btnCikarma.Click += IslemDugme_Click;
            btnCarpma.Click += IslemDugme_Click;
            btnBolme.Click += IslemDugme_Click;

            btnEsit.Click += EsitDugme_Click;

            // İşlem düğmelerinin aktiflik durumunu yanıtlayacak fonksiyon belirle
            btnToplama.EnabledChanged += IslemDugme_EnabledChanged;
            btnCikarma.EnabledChanged += IslemDugme_EnabledChanged;
            btnCarpma.EnabledChanged += IslemDugme_EnabledChanged;
            btnBolme.EnabledChanged += IslemDugme_EnabledChanged;
        }
      
        /// <summary>
        /// Rakam ya da işlem, tüm düğmeler tıklandığında
        /// etiket karakteri işlem metni olarak
        /// ekran kutusuna eklenecektir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RakamIslemDugme_Click(object sender, EventArgs e)
        {
            Button dugme = sender as Button;
            if (dugme != null)
            {
                // Mevcut bir sonuç varsa ekranı sil ve işlem argümanlarını sıfırla
                if(!double.IsNaN(sonuc))
                {
                    sayi1 = double.NaN;
                    sayi2 = double.NaN;
                    sonuc = double.NaN;
                    // Ekran kutusuna boş satır ekle
                    tbEkran.AppendText(Environment.NewLine);
                }
                // yeni işlem son satırda gözükecek
                tbEkran.AppendText(dugme.Text);
            }
        }

        private void IslemDugme_Click(object sender, EventArgs e)
        {
            // Bir işlem düğmesi tıklandığında,
            // yalnızca bir işlem yapılabilsin diye,
            // sonuç hesaplatacak eşittir düğmesi haricindeki
            // işlem düğmelerini iptal et.
            btnToplama.Enabled = false;
            btnCikarma.Enabled = false;
            btnCarpma.Enabled = false;
            btnBolme.Enabled = false;
        }

        /// <summary>
        /// Bu fonksiyonun tek amacı işlem düğmelerinin
        /// aktiflik durumuna göre renklerini belirlemektir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IslemDugme_EnabledChanged(object sender, EventArgs e)
        {
            Button dugme = sender as Button;
            if (dugme != null)
            {
                if(dugme.Enabled)
                {
                    dugme.BackColor = Color.LightBlue;
                    dugme.ForeColor = Color.Black;
                }
                else
                {
                    dugme.BackColor = Color.LightGray;
                    dugme.ForeColor = Color.Gray;
                }
            }
        }

        private void EsitDugme_Click(object sender, EventArgs e)
        {
            // Ekran kutusunun son satırı aktif işlem metnidir
            string strIslem = tbEkran.Lines.Last<string>();
            // İşlemci karakterleri ayıraçlar olarak kullanarak  işlem metnini böl
            string[] islemArgumanlari = strIslem.Split(islemKarakterleri);
            sayi1 = Convert.ToDouble(islemArgumanlari[0]);
            sayi2 = Convert.ToDouble(islemArgumanlari[1]);

            // Hangi işlemci karakteri bulunduysa o işlemi yap ve sonucu hesapla
            if(strIslem.Contains(islemKarakterleri[0]))
            {
                sonuc = sayi1 + sayi2;
            }
            else if (strIslem.Contains(islemKarakterleri[1]))
            {
                sonuc = sayi1 - sayi2;
            }
            else if (strIslem.Contains(islemKarakterleri[2]))
            {
                sonuc = sayi1 * sayi2;
            }
            else if (strIslem.Contains(islemKarakterleri[3]))
            {
                sonuc = sayi1 / sayi2;
            }
            // İşlem her neydiyse sonucu son satıra ekle
            tbEkran.AppendText(Convert.ToString(sonuc));

            // İşlem düğmelerini tekrar aktifleştir
            btnToplama.Enabled = true;
            btnCikarma.Enabled = true;
            btnCarpma.Enabled = true;
            btnBolme.Enabled = true;
        }

        private void KontrolleriYerlestir()
        {
            this.SuspendLayout(); // yeniden yerleştirme işlemlerini görüntüleme

            tbEkran.Height = this.ClientRectangle.Height / 3; // ekran yüksekliğini formun iç bölge yüksekliğiyle orantıla.
            tbEkran.Left = tbEkran.ClientRectangle.Left + marjin; // ekran kutusu formun sol kenarından marjin kadar içeride olacak.
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
