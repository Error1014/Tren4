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

namespace Tren4.Pages
{
    /// <summary>
    /// Логика взаимодействия для AutorizationPage.xaml
    /// </summary>
    public partial class AutorizationPage : Page
    {
        public AutorizationPage()
        {
            InitializeComponent();
        }

        private void Whod(object sender, RoutedEventArgs e)
        {
            if ((LoginBox.Text=="1")&&(PasswordBox.Password=="1"))
            {
                MainWindow.MainWindowFrame.Content = new Pages.TaskPage();
            }
            else
            {
                MainWindow.MainWindowFrame.Content = new Pages.TaskPage();
            }
        }
    }
}
