using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Ders4_BankaProje
{
    public class Hesap : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OzellikDegisti(string ozellik_adi)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(ozellik_adi));
            }
        }

        private static int hesapSayisi = 0;
        private int hesapNo;
        private decimal hesapBakiyesi = 0;

        public Hesap()
        {
            hesapSayisi++;
            hesapNo = hesapSayisi;
        }

        public int HesapNo
        {
            get { return hesapNo; }
        }

        public decimal Bakiye
        {
            get { return hesapBakiyesi; }
            private set { hesapBakiyesi = value; }
        }

        public void ParaEkle(decimal tutar)
        {
            Bakiye += tutar;
            OzellikDegisti("Bakiye");
        }

        public void ParaCek(decimal tutar)
        {
            if(Bakiye >= tutar)
            {
                Bakiye -= tutar;
                OzellikDegisti("Bakiye");
            }
        }
    }
}
