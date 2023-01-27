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

namespace Napad_na_zemljo
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Btn_Start_Click(object sender, RoutedEventArgs e)
        {
            DodajSovražnika();
        }

        private void DodajSovražnika()
        {
            ContentControl sovražnik = new ContentControl();
            sovražnik. Template = Resources ["PredlogaSovražnika"] 
        
        }

        private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<TabControl>
        e)
        {

        }

        private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
