using IP_TranslatorCalculator.BackEnd;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using IP_TranslatorCalculator.Keszitok;

namespace IP_TranslatorCalculator.Pages
{
    /// <summary>
    /// Interaction logic for Sugo.xaml
    /// </summary>
    public partial class Sugo : Page
    {
        static IPTranslate i = new IPTranslate();
        static PublicIP p = new PublicIP();
        public Sugo()
        {
            InitializeComponent();
        }

        private void BtnHome_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Width = 650;
            Application.Current.MainWindow.Height = 800;
            NavigationService.Navigate(new Pages.Page1());
            Application.Current.MainWindow.ResizeMode = ResizeMode.NoResize;
        }

        private void BtnHome_MouseEnter(object sender, MouseEventArgs e)
        {
            i.BtnHome_MouseEnter(sender, e);
        }
        private void BtnHome_MouseLeave(object sender, MouseEventArgs e)
        {
            i.BtnHome_MouseLeave(sender, e);
        }
        static Keszitok.Authors a = new Keszitok.Authors();
        private void btnAuthors_Click(object sender, RoutedEventArgs e)
        {
            a.Show();
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
    }
}
