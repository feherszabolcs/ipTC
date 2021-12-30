using IP_TranslatorCalculator.BackEnd;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace IP_TranslatorCalculator.Keszitok
{
    /// <summary>
    /// Interaction logic for Authors.xaml
    /// </summary>
    public partial class Authors : Window
    {
        static PublicIP ip = new PublicIP();
        public Authors()
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
