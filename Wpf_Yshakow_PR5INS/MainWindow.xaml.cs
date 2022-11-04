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

namespace Wpf_Yshakow_PR5INS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HOTO1_Click(object sender, RoutedEventArgs e)
        {
            image1.Source = new BitmapImage(new Uri("photo/1L.jpg", UriKind.Relative));
        }

        private void HOTO2_Click(object sender, RoutedEventArgs e)
        {
            image1.Source = new BitmapImage(new Uri("photo/2.jpg", UriKind.Relative));
        }

        private void HOTO3_Click(object sender, RoutedEventArgs e)
        {
            image1.Source = new BitmapImage(new Uri("photo/3.jpg", UriKind.Relative));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string a = textbox1.Text;
            image1.Source = new BitmapImage(new Uri(a));
        }
    }
}
