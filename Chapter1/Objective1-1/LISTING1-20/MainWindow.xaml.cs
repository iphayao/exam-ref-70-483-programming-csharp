using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace Chapter1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// LISTING 1-20 Using ConfigureAwait
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            string content = await httpClient.GetStringAsync("http://www.microsoft.com")
                                             .ConfigureAwait(false);

            // Throw Exceptoin => System.InvalidOperationException: 'The calling thread cannot access this object because a different thread owns it.'
            Output.Content = content;
        }
    }
}
