using Regin.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Regin.Pages
{
    /// <summary>
    /// Логика взаимодействия для Verify.xaml
    /// </summary>
    public partial class Verify : Page
    {
        public Verify()
        {
            InitializeComponent();
        }

        private void resend(object sender, RoutedEventArgs e)
        {

        }

        private void SetCode(object sender, RoutedEventArgs e)
        {
            
        }

        private void Back(object sender, MouseButtonEventArgs e)
        {
            MainWindow.mainWindow.frame.Navigate(new Pages.Login());
        }
    }
}
