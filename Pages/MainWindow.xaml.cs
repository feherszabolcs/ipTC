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
using IP_TranslatorCalculator.BackEnd;


namespace IP_TranslatorCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// sugó fül(osztáy, priv, maszk)
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void btn_minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }


        private void Window_SizeChanged(object sender, SizeChangedEventArgs e) //Nincs használva jelenleg
        {
            double screenWidth = SystemParameters.PrimaryScreenWidth;
            double screenHeight = SystemParameters.PrimaryScreenHeight;
            double windowWidth = this.Width;
            double windowHeight = this.Height;
            this.Left = (screenWidth / 2) - (windowWidth / 2);
            this.Top = (screenHeight / 2) - (windowHeight / 2);
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
        static PublicIP ip = new PublicIP();
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

        private void btn_minimize_Click_1(object sender, RoutedEventArgs e)
        {
                this.WindowState = WindowState.Minimized;
        }
    }
}