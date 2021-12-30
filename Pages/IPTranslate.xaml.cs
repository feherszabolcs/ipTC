using IP_TranslatorCalculator.BackEnd;
using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace IP_TranslatorCalculator.Pages
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
        static PublicIP ip = new PublicIP();
        static NetworkOptimizer nw = new NetworkOptimizer();
        public void ChbDec_Checked(object sender, RoutedEventArgs e)
        {

            if (ChbBin.IsChecked == true)
            {
                ChbBin.IsChecked = false;
                ChbDec.Foreground = ip.FromHex("#FFF4A261");
                ChbBin.Foreground = Brushes.White;
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
            if (ChbDec.IsChecked == true)
            {
                ChbBin.IsEnabled = false;
                ChbBin.Foreground = ip.FromHex("#FFF4A261");
                ChbDec.Foreground = Brushes.White;
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
            ChbBin.Foreground = ip.FromHex("#FFF4A261");
        }

        private void BtnHome_click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Width = 650;
            Application.Current.MainWindow.Height = 800;
            NavigationService.Navigate(new Pages.Page1());
            Application.Current.MainWindow.ResizeMode = ResizeMode.NoResize;
        }

        private void TbBinform_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex reg = new Regex("[^0-1]+");
            e.Handled = reg.IsMatch(e.Text);
        }

        private void btnTranslate_Click(object sender, RoutedEventArgs e)
        {
            if (ChbBin.IsChecked == true)
            {
                string output = "";
                string binS = TbBinform.Text;
                if (binS.Length != 32)
                {
                    MessageBox.Show("A megadott bináris forma nem 32 bit hosszú!", "Konvertálási hiba!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    string first = binS.Substring(0, 8);
                    string second = binS.Substring(8, 8);
                    string third = binS.Substring(16, 8);
                    string fourth = binS.Substring(24, 8);
                    output = String.Format($"{BinToDec(first)}.{BinToDec(second)}.{BinToDec(third)}.{BinToDec(fourth)}");
                    tbOutput.Visibility = (Visibility)0;
                    tbOutput.Text = output;
                    lblOut.Content = "A binárisan megadott szám decimális formában leírva:";
                }
            }
            else
            {
                string output = OctettToBin(tb1.Text) + OctettToBin(tb2.Text) + OctettToBin(tb3.Text) + OctettToBin(tb4.Text);
                tbOutput.Visibility = (Visibility)0;
                tbOutput.Text = output;
                lblOut.Content = "A decimálisan megadott szám bináris formában:";

            }
        }
        public string BinToDec(string octett)
        {
            int r = 0;
            if (octett.Length == 8)
            {
                r = Convert.ToInt32(octett, 2);
            }

            return r.ToString();
        }
        public string OctettToBin(string octett)
        {
            return Convert.ToString(int.Parse(octett), 2).PadLeft(8, '0');
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
            string s = ((TextBox)sender).Text;
            string fText = s + e.Text;
            if (!reg.IsMatch(e.Text))
            {
                e.Handled = int.Parse(fText) > 255;
            }
            else MessageBox.Show("Számot adjon meg!", "Beviteli hiba!", MessageBoxButton.OK, MessageBoxImage.Warning);

        }
        static PublicIP p = new PublicIP();

        private void btnOwnIp_Click(object sender, RoutedEventArgs e)
        {
            string ip = p.StoreIP().ToString();
            string[] m = ip.Split('.');
            if (ChbDec.IsChecked == true)
            {
                tb1.Text = m[0]; tb2.Text = m[1]; tb3.Text = m[2]; tb4.Text = m[3];
            }
            else
            {
                TbBinform.Text = OctettToBin(m[0]) + OctettToBin(m[1]) + OctettToBin(m[2]) + OctettToBin(m[3]);
            }
        }

        private void Btn_MouseEnter(object sender, MouseEventArgs e)
        {
            nw.Btn_MouseEnter(sender, e);
        }

        public void Btn_MouseLeave(object sender, MouseEventArgs e)
        {
            nw.Btn_MouseLeave(sender, e);
        }

        public void BtnHome_MouseEnter(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            ImageBrush ib = new ImageBrush();
            Image i = new Image();
            i.Source = new BitmapImage(new Uri(@"home_button.png", UriKind.Relative));
            ib.ImageSource = i.Source;
            btn.Background = ib;
        }

        public void BtnHome_MouseLeave(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            ImageBrush ib = new ImageBrush();
            Image i = new Image();
            i.Source = new BitmapImage(new Uri(@"home_button_light.png", UriKind.Relative));
            ib.ImageSource = i.Source;
            btn.Background = ib;
        }
    }
}
