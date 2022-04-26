using System;
using System.Collections.Generic;
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
using System.Collections.ObjectModel;
using Microsoft.Win32;

namespace Ders5_ResimProje
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> Resimler { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = this;
            Resimler = new ObservableCollection<string>();
        }

        private void btnResimEkle_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlgDosyaAc = new OpenFileDialog();
            dlgDosyaAc.Multiselect = false;
            dlgDosyaAc.Filter = "Resim dosyaları (*.bmp, *.jpg, *png)|*.bmp;*.jpg;*.png";
            if (dlgDosyaAc.ShowDialog() == true)
            {
                Resimler.Add(dlgDosyaAc.FileName);
            }
        }
    }
}
