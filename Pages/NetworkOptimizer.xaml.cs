using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
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
            Application.Current.MainWindow.Height = 830;
            NavigationService.Navigate(new Pages.Page1());
            Application.Current.MainWindow.ResizeMode = ResizeMode.NoResize;
        }
        static PublicIP p = new PublicIP();

        private void tbIP_PreviewTextInput(object sender, TextCompositionEventArgs e) //:(
        {
            Regex reg = new Regex("[^0-9]+");
            e.Handled = reg.IsMatch(e.Text);
            string s = ((TextBox)sender).Text;
            string fText = s + e.Text;
            if (!reg.IsMatch(e.Text))
            {
                e.Handled = int.Parse(fText) > 256;
            }
        }

        private void btnUseOwnIP_Click(object sender, RoutedEventArgs e)
        {
            tbIpAddress.Text = p.StoreIP().ToString();
        }

        private void tbDevCount_GotFocus(object sender, RoutedEventArgs e)
        {
            if(tbDevCount.Text == "") MessageBox.Show("Egy jó tanács: Gondoljon a hálózat bővíthetőségére.", "Tipp.", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
