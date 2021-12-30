using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace IP_TranslatorCalculator.Pages
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        static NetworkOptimizer nw = new NetworkOptimizer();

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
            NavigationService.Navigate(new Pages.Sugo());
            ContentChange();
        }

        private void Btn_MouseEnter(object sender, MouseEventArgs e)
        {
            nw.Btn_MouseEnter(sender, e);

        }

        public void Btn_MouseLeave(object sender, MouseEventArgs e)
        {
            nw.Btn_MouseLeave(sender, e);
        }

        //MINDEN átméreteződés után az új megnyitott ablak középen, az uj megnyitott ablak méretétől függetlentül


    }
}
