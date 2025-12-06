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

namespace Regin.Pages
{
    /// <summary>
    /// Логика взаимодействия для SetPin.xaml
    /// </summary>
    public partial class SetPin : Page
    {
        public SetPin(string email)
        {
            InitializeComponent();
        }

        private void Confirm(object sender, RoutedEventArgs e)
        {

        }

        private void Back(object sender, MouseButtonEventArgs e)
        {
            MainWindow.mainWindow.frame.Navigate(new Pages.Login());
        }
    }
}
