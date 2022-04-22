using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ders4_BankaProje
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Hesap> Hesaplar { get; private set; }
        public Hesap AktifHesap { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = this;
            Hesaplar = new ObservableCollection<Hesap>(); 
            
            for(int i=0; i < 5; i++)
            {
                Hesaplar.Add(new Hesap());
            }
        }

        private void bakiyeIslem(object sender, EventArgs e)
        {
            Button btnIslem = sender as Button;
            if (btnIslem != null)
            {
                decimal tutar = Convert.ToDecimal(btnIslem.Tag);
                if(tutar > 0)
                {
                    AktifHesap.ParaEkle(tutar);
                }
                else
                {
                    AktifHesap.ParaCek(Math.Abs(tutar));
                }
            }
        }
    }
}
