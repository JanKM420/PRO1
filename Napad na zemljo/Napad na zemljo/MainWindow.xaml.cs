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

namespace Napad_na_zemljo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random r = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Btn_Start_Click(object sender, RoutedEventArgs e)
        {
            DodajSovražnika();
        }

        private void DodajSovražnika()
        {
            ContentControl sovraznik = new ContentControl();
            sovraznik.Template = Resources["PredlogaSovražnika"] as ControlTemplate;
            AnimirajSovražnika(sovraznik, 0, (int)(igralniDel.ActualWidth - 100), "(Canvas.Left");
            int visina = (int)(igralniDel.ActualHeight - 100);
            AnimirajSovražnika(sovraznik, r.Next(visina), r.Next(visina), "(Canvas.Top)");
            igralniDel.Children.Add(sovraznik);

        
        }

        private void AnimirajSovražnika(ContentControl sovraznik, int v1, int v2, string v3)
        {
            Storyboard zgodba = new Storyboard()
            {
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };

            DoubleAnimation animacija = new DoubleAnimation()
            {
                From = v1,
                To = v2,
                Duration = new Duration(TimeSpan.FromSeconds(r.Next(4, 6)))
            };
            PropertyPath x = new PropertyPath(v3);

            Storyboard.SetTarget(animacija, sovraznik);
            Storyboard.SetTargetProperty(animacija, x);
            zgodba.Children.Add(animacija);
            zgodba.Begin();

        }




    }
}
