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

namespace Ders3_MarketProje
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Urun> Urunler { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = this;
            Urunler = new ObservableCollection<Urun>();
            
            Urun u = new Urun();
            u.Ad = "Ekmek";
            u.Kategori = UrunKategori.Gida;
            u.Fiyat = 2.75;
            Urunler.Add(u);

            u = new Urun();
            u.Ad = "Kabak";
            u.Kategori = UrunKategori.Gida;
            u.Fiyat = 12.5;
            Urunler.Add(u);

            u = new Urun();
            u.Ad = "Akıl";
            u.Kategori = UrunKategori.Luks;
            u.Fiyat = double.MaxValue;
            Urunler.Add(u);

            Urunler[0].Fiyat = 3.50;
        }
    }
}
