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

namespace IP_TranslatorCalculator
{
    /// <summary>
    /// Interaction logic for IPTranslate.xaml
    /// </summary>
    public partial class IPTranslate : Page
    {
        public IPTranslate()
        {
            InitializeComponent();
        }

        private void ChbDec_Checked(object sender, RoutedEventArgs e)
        {
            if (ChbBin.IsChecked == true) {
                ChbBin.IsChecked = false;
                ChbBin.IsEnabled = true;
                ChbDec.IsEnabled = false;
            } 
            tb1.Visibility = Visibility.Visible;
            tb2.Visibility = Visibility.Visible;
            tb3.Visibility = Visibility.Visible;
            tb4.Visibility = Visibility.Visible;
            TbBinform.Visibility = Visibility.Hidden;
        }

        private void ChbBin_Checked(object sender, RoutedEventArgs e)
        {
            if (ChbDec.IsChecked == true) {
                ChbBin.IsEnabled = false;
                ChbDec.IsEnabled = true;
                ChbDec.IsChecked = false;
            } 
            tb1.Visibility = Visibility.Hidden;
            tb2.Visibility = Visibility.Hidden;
            tb3.Visibility = Visibility.Hidden;
            tb4.Visibility = Visibility.Hidden;
            TbBinform.Visibility = Visibility.Visible;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ChbBin.IsChecked = true;
        }
    }
}
