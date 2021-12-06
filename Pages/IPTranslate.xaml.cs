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
            ResetOutput();
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
            ResetOutput();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ChbBin.IsChecked = true;
        }

        private void BtnHome_click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow = new MainWindow();
            Application.Current.MainWindow.Show();
            Window.GetWindow(this).Close();
        }

        private void TbBinform_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex reg = new Regex("[^0-1]+");
            e.Handled = reg.IsMatch(e.Text);
        }

        private void btnTranslate_Click(object sender, RoutedEventArgs e)
        {
            if(ChbBin.IsChecked == true)
            {
                string output = "";
                string binS = TbBinform.Text;
                if (binS.Length != 32) {
                    MessageBox.Show("A megadott bináris forma nem 32 bit hosszú!", "Konvertálási hiba!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    string first = binS.Substring(0, 8);
                    string second = binS.Substring(8, 8);
                    string third = binS.Substring(16, 8);
                    string fourth = binS.Substring(24, 8);
                    output = String.Format($"{BinToDec(first)}.{BinToDec(second)}.{BinToDec(third)}.{BinToDec(fourth)}");
                    tbOutput.Visibility = (Visibility) 0;
                    tbOutput.Text = output;
                    lblOut.Content = "A binárisan megadott szám decimális formában leírva:";
                }
            }
            else
            {
                string output = String.Format($"{Convert.ToString(int.Parse(tb1.Text), 2)}{Convert.ToString(int.Parse(tb2.Text), 2)}{Convert.ToString(int.Parse(tb3.Text), 2)}{Convert.ToString(int.Parse(tb4.Text), 2)}");
                tbOutput.Visibility = (Visibility)0;
                tbOutput.Text = output;
                lblOut.Content = "A decimálisan megadott szám bináris formában:";

            }
        }
        private string BinToDec(string octett) {

            int r = Convert.ToInt32(octett, 2);            
            return r.ToString();
        }
        private void ResetOutput()
        {
            tbOutput.Text = "";
            tbOutput.Visibility = Visibility.Hidden;
            lblOut.Content = "";
            TbBinform.Text = tb1.Text = tb2.Text = tb3.Text = tb4.Text = "";

        }

        private void tbDec_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex reg = new Regex("[^0-9]+");
            e.Handled = reg.IsMatch(e.Text);
            string s = ((TextBox) sender).Text;
            string fText = s + e.Text;
            if (!reg.IsMatch(e.Text))
            {
                e.Handled = int.Parse(fText) > 255;
            }
            else MessageBox.Show("Számot adjon meg!", "Beviteli hiba!", MessageBoxButton.OK, MessageBoxImage.Warning);

        }
    }
}
