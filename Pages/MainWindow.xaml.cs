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
            Application.Current.MainWindow.Width = 1600;
            Application.Current.MainWindow.Height = 900;
            Application.Current.MainWindow.MinHeight = 850;
            Application.Current.MainWindow.MinWidth = 1300;
        }

        private void BtnClick_Optimizer(object sender, RoutedEventArgs e)
        {
            Main.Content = new NetworkOptimizer();
        }       

        private void BtnClick_Nw(object sender, RoutedEventArgs e)
        {
            Main.Content = new MainWindow();
        }
        private void BtnHome_click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow = new MainWindow();
            Application.Current.MainWindow.Show();
            Window.GetWindow(this).Close();
        }


        //MINDEN átméreteződés után az új megnyitott ablak középen, az uj megnyitott ablak méretétől függetlentül

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            double screenWidth = SystemParameters.PrimaryScreenWidth;
            double screenHeight =SystemParameters.PrimaryScreenHeight;
            double windowWidth = this.Width;
            double windowHeight = this.Height;
            this.Left = (screenWidth / 2) - (windowWidth / 2);
            this.Top = (screenHeight / 2) - (windowHeight / 2);
        }
    }
}
