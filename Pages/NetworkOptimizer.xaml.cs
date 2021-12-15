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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IP_TranslatorCalculator.Pages
{
    /// <summary>
    /// Interaction logic for NetworkOptimizer.xaml
    /// </summary>
    public partial class NetworkOptimizer : Page
    {
        public NetworkOptimizer()
        {
            InitializeComponent();
        }
        private void BtnHome_click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Width = 650;
            Application.Current.MainWindow.Height = 800;
            NavigationService.Navigate(new Pages.Page1());
            Application.Current.MainWindow.ResizeMode = ResizeMode.NoResize;
        }
    }
}
