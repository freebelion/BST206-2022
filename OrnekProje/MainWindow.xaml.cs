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
using Microsoft.Win32;

namespace OrnekProje
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddCategory(object sender, RoutedEventArgs e)
        {
            OrnekMarket.Add(new Category());
        }

        private void AddProduct(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if(btn != null)
            {
                Category reyon = (Category)btn.DataContext;
                reyon.Products.Add(new Product());
            }
        }

        private void SetImage(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                Product prod = (Product)btn.DataContext;
                OpenFileDialog dlgDosyaAc = new OpenFileDialog();
                dlgDosyaAc.Multiselect = false;
                dlgDosyaAc.Filter = "Resim dosyaları (*.bmp, *.jpg, *png)|*.bmp;*.jpg;*.png";
                if (dlgDosyaAc.ShowDialog() == true)
                {
                    prod.ImageFile = dlgDosyaAc.FileName;
                    btn.DataContext = prod;
                }
            }
        }
    }
}
