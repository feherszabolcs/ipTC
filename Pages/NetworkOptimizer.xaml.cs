using IP_TranslatorCalculator.BackEnd;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

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
        public string FullIP()
        {
            return tbIp1.Text + "." + tbIp2.Text + "." + tbIp3.Text + "." + tbIp4.Text;
        }
        private void BtnHome_click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Width = 650;
            Application.Current.MainWindow.Height = 800;
            NavigationService.Navigate(new Pages.Page1());
            Application.Current.MainWindow.ResizeMode = ResizeMode.NoResize;
        }
        static PublicIP p = new PublicIP();
        static IPTranslate i = new IPTranslate();

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

        private void tbMask_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex reg = new Regex("[^0-9]+");
            e.Handled = reg.IsMatch(e.Text);
            string s = ((TextBox)sender).Text;
            string fText = s + e.Text;
            if (!reg.IsMatch(e.Text))
            {
                e.Handled = int.Parse(fText) > 32;
            }
        }
        private void btnUseOwnIP_Click(object sender, RoutedEventArgs e)
        {
            if (p.StoreIP() != null)
            {
                string[] m = p.StoreIP().ToString().Split('.');
                tbIp1.Text = m[0];
                tbIp2.Text = m[1];
                tbIp3.Text = m[2];
                tbIp4.Text = m[3];
            }
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            string nwAdd = NwAddressFinder(FullIP(), tbMask.Text);
            string startAdd = StartIp(nwAdd);
            string bIp = BroadcastIp(tbMask.Text, FullIP());
            tbDevCount.Text = p.CalculateMaxHost(FullIP(), tbMask.Text);
            tbNwAdd.Text = nwAdd;
            tbStartIp.Text = startAdd;
            tbBroadcast.Text = bIp;
            tbEndIp.Text = LastIp(bIp);

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //btnCalculate.IsEnabled = false;
        }

        public void Btn_MouseEnter(object sender, MouseEventArgs e)
        {
            Button bt = (Button)sender;
            bt.Background = p.FromHex("#E76F51");
        }

        public void Btn_MouseLeave(object sender, MouseEventArgs e)
        {
            Button bt = (Button)sender;
            bt.Background = p.FromHex("#F4A261");
        }
        private string Sub(string Binip)
        {
            string octett1 = Binip.Substring(0, 8);
            string octett2 = Binip.Substring(8, 8);
            string octett3 = Binip.Substring(16, 8);
            string octett4 = Binip.Substring(24, 8);
            return i.BinToDec(octett1) + "." + i.BinToDec(octett2) + "." + i.BinToDec(octett3) + "." + i.BinToDec(octett4); // hál cím dec formában

        }
        private string NwAddressFinder(string ip, string mask) // /24-es maszk => mask = 24 (bit)
        {
            string[] m = ip.Split('.');
            string bin = i.OctettToBin(m[0]) + i.OctettToBin(m[1]) + i.OctettToBin(m[2]) + i.OctettToBin(m[3]);
            string binMask = "";
            binMask = binMask.PadLeft(int.Parse(mask), '1');
            binMask += mask.PadLeft(32, '0');
            string output = "";
            for (int i = 0; i < 32; i++)
            {
                if (bin[i] == '1' && binMask[i] == '1') output += "1";
                else output += "0";
            }
            return Sub(output);
        }
        private string StartIp(string nwAdd)
        {
            string[] s = nwAdd.Split('.');
            int m = int.Parse(s[3]) + 1;
            return s[0] + "." + s[1] + "." + s[2] + "." + s[3].Replace(s[3], m.ToString());
        }
        private string BroadcastIp(string mask, string ip)
        {
            string binMask = "";
            binMask = binMask.PadLeft(int.Parse(mask), '1');
            binMask = binMask.PadRight(32, '0');
            string[] m = ip.Split('.');

            string binRev = Reverse(binMask);
            string bin = i.OctettToBin(m[0]) + i.OctettToBin(m[1]) + i.OctettToBin(m[2]) + i.OctettToBin(m[3]);
            string output = "";

            for (int i = 0; i < 32; i++)
            {
                if (bin[i] == '1' || binRev[i] == '1') output += "1";
                else output += "0";
            }


            return Sub(output);
        }
        public static string Reverse(string bin) // bináris maszk reverse
        {
            char[] charArray = bin.ToCharArray();
            List<char> output = new List<char>();
            foreach (var item in charArray)
            {
                if (item == '1') output.Add('0');
                else output.Add('1');
            }
            return new string(output.ToArray());
        }
        private string LastIp(string bIp)
        {
            string[] m = bIp.Split('.');
            int lastOct = int.Parse(m[3]) - 1;
            return m[0] + "." + m[1] + "." + m[2] + "." + m[3].Replace(m[3], lastOct.ToString());
        }

        private void BtnHome_MouseEnter(object sender, MouseEventArgs e)
        {
            i.BtnHome_MouseEnter(sender, e);
        }
        private void BtnHome_MouseLeave(object sender, MouseEventArgs e)
        {
            i.BtnHome_MouseLeave(sender, e);
        }
    }
}
