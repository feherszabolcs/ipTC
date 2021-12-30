using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using IP_TranslatorCalculator.BackEnd;

namespace IP_TranslatorCalculator.Infos
{
    /// <summary>
    /// Interaction logic for InfoWindow.xaml
    /// </summary>
    public partial class InfoWindow : Window
    {
        PublicIP ip = new PublicIP();
        public InfoWindow()
        {
            InitializeComponent();
        }
        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void btn_minimize_Click_1(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
        private void btn_close_MouseEnter(object sender, MouseEventArgs e)
        {
            btn_close.Background = Brushes.Red;
        }

        private void btn_close_MouseLeave(object sender, MouseEventArgs e)
        {
            btn_close.Background = ip.FromHex("#FF605C");
        }

        private void btn_minimize_MouseEnter(object sender, MouseEventArgs e)
        {
            btn_minimize.Background = Brushes.Yellow;
        }

        private void btn_minimize_MouseLeave(object sender, MouseEventArgs e)
        {
            btn_minimize.Background = ip.FromHex("#FFBD44");
        }
    }
}
