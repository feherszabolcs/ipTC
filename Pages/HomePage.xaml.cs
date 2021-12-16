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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1: Page
    {

        public Page1()
        {
            InitializeComponent();
        }
        private void ContentChange()
        {
            Application.Current.MainWindow.ResizeMode = ResizeMode.CanResize;
            Application.Current.MainWindow.Width = 650;
            Application.Current.MainWindow.Height = 800;
            Application.Current.MainWindow.MinHeight = 800;
            Application.Current.MainWindow.MinWidth = 650;

        }
        private void BtnClick_Translate(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.IPTranslate());
            ContentChange();
        }

        private void BtnClick_Optimizer(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.NetworkOptimizer());
            ContentChange();
        }

        private void BtnClick_Nw(object sender, RoutedEventArgs e)
        {
            //Main.Content = new MainWindow();
        }


        //MINDEN átméreteződés után az új megnyitott ablak középen, az uj megnyitott ablak méretétől függetlentül


    }
}
