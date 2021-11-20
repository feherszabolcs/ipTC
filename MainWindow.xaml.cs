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

namespace IP_TranslatorCalculator
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

        private void BtnClick_Translate(object sender, RoutedEventArgs e)
        {
            Main.Content = new IPTranslate();
            //mainP.Visibility = Visibility.Hidden;
        }

        private void BtnClick_Optimizer(object sender, RoutedEventArgs e)
        {
            Main.Content = new NetworkOptimizer();
        }

        private void BtnClick_Nw(object sender, RoutedEventArgs e)
        {
            Main.Content = new NetworkOptimizer();
        }
        private void BtnHome_click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow = new MainWindow();
            Application.Current.MainWindow.Show();
            Window.GetWindow(this).Close();
        }

    }
}
