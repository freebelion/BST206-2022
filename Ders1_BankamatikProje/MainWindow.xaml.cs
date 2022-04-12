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

namespace Ders1_BankamatikProje
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private decimal bakiye;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void bakiyeIslem(object sender, EventArgs e)
        {
            Button btnIslem = sender as Button;
            if (btnIslem != null)
            {
                bakiye += Convert.ToInt32(btnIslem.Tag);
                tbBakiye.Text = bakiye.ToString("C");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tbBakiye.Text = bakiye.ToString("C");
        }
    }
}
