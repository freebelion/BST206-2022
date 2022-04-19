using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders3_MarketProje
{
    public enum UrunKategori
    { Gida, Esya, Luks }

    public class Urun
    {
        private double urunFiyati;

        public string Ad { get; set; } // auto-property definition

        public UrunKategori Kategori { get; set; }

        public double Fiyat
        {
            get { return urunFiyati; }
            set
            {
                if(value >= 0)
                { urunFiyati = value; }
                else
                {
                    throw new ApplicationException("Ürün fiyatı negatif olamaz!");
                }
            }
        }
    }
}
