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

namespace Zajecia1_FizzBazz_GUI_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var game=new Zajecia1_FizzBuzz.Game();
            List<string> numbers = new List<string>();
            for (int i = 1; i <= 15; i++)
            {
                numbers.Add(string.Format("i:{0} {1}",i,game.Say(i)));
            }
            lb1.ItemsSource = numbers;
        }
    }
}
