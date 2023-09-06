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

namespace API_DZ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        ApiServic apiNumbers = new ApiNumbers();
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Get_BTN_Click(object sender, RoutedEventArgs e)
        {
            string res = string.Empty;
            apiNumbers.Zapros(random.Next(999));
            En_TB.Text = apiNumbers.res;
        }
    }
}
