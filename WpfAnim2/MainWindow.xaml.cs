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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAnim2
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

      private void btnRenkDegistir_Click(object sender, RoutedEventArgs e)
      {
         btnRenkDegistir.Background = new SolidColorBrush(Colors.LightGray);
         ColorAnimation clrAnim = new ColorAnimation();
         clrAnim.From = Colors.LightGray;
         clrAnim.To = Colors.DarkRed;
         clrAnim.Duration = new Duration(TimeSpan.FromSeconds(5));
         clrAnim.AutoReverse = true;
         btnRenkDegistir.Background.BeginAnimation(SolidColorBrush.ColorProperty, clrAnim);
      }

      private void btnDondur_Click(object sender, RoutedEventArgs e)
      {
         Storyboard oyku = new Storyboard();
         DoubleAnimation dondurAnim = new DoubleAnimation();
         dondurAnim.Duration = TimeSpan.FromSeconds(5);
         dondurAnim.From = 0;
         dondurAnim.To = 180;
         dondurAnim.AutoReverse = true;
         oyku.Children.Add(dondurAnim);
         Storyboard.SetTargetProperty(dondurAnim,
               new PropertyPath("RenderTransform.Angle"));
         Storyboard.SetTarget(dondurAnim, btnDondur);
         oyku.Begin();
      }

      private void btnYamult_Click(object sender, RoutedEventArgs e)
      {
         Storyboard yamultucu = new Storyboard();
         DoubleAnimation yamultXAnim = new DoubleAnimation(),
            yamultYAnim = new DoubleAnimation();
         // Animasyonların ardışık gerçekleşmesini sağla
         yamultXAnim.BeginTime = new TimeSpan(0,0,0);
         yamultXAnim.From = 0;
         yamultXAnim.To = 15;
         yamultXAnim.Duration = new TimeSpan(0, 0, 3);
         yamultYAnim.BeginTime = new TimeSpan(0, 0, 3);
         yamultYAnim.From = 0;
         yamultYAnim.To = 30;
         yamultYAnim.Duration = new TimeSpan(0, 0, 3);
         yamultucu.Children.Add(yamultXAnim);
         yamultucu.Children.Add(yamultYAnim);
         Storyboard.SetTargetProperty(yamultXAnim,
               new PropertyPath("RenderTransform.AngleX"));
         Storyboard.SetTargetProperty(yamultYAnim,
               new PropertyPath("RenderTransform.AngleY"));
         Storyboard.SetTarget(yamultXAnim, btnYamult);
         Storyboard.SetTarget(yamultYAnim, btnYamult);
         yamultucu.Begin();
      }

      private void btnKaydir_Click(object sender, RoutedEventArgs e)
      {
         Storyboard kaydirici = this.Resources["Kaydirici"] as Storyboard;
         Storyboard.SetTarget(kaydirici.Children.ElementAt(0) as DoubleAnimation, btnKaydir);
         Storyboard.SetTarget(kaydirici.Children.ElementAt(1) as DoubleAnimation, btnKaydir);
         kaydirici.Begin();
      }
   }
}
