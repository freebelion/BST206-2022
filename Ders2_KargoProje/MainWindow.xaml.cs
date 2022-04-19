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

namespace Ders2_KargoProje
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random rnd = new Random();
        private ObservableCollection<Kargo> kargolar;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            kargolar = new ObservableCollection<Kargo>();

            lbKargolar.ItemsSource = kargolar;
            lbKargolar.DisplayMemberPath = "Agirlik";
        }

        private void YukAl(object sender, RoutedEventArgs e)
        {
            int yuk_sayisi = rnd.Next(1, 5);

            for (int i = 0; i < yuk_sayisi; i++)
            {
                kargolar.Add(new Kargo(50 * rnd.NextDouble()));
            }
        }

        private void YukGonder(object sender, RoutedEventArgs e)
        {
            int yuk_sayisi = rnd.Next(1, 5);

            for (int i = 0; i < yuk_sayisi; i++)
            {
                kargolar.RemoveAt(0);
            }
        }
    }
}
