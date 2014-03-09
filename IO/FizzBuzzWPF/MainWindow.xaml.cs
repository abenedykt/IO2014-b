using System;
using System.Collections.Generic;
using System.IO;
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
using FizzBuzz;

namespace FizzBuzzWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var items = new List<string>();
            var game = new Game();
            for (int j = int.Parse(StartRangeTextBox.Text); j < int.Parse(EndRangeTextBox.Text); j++)
            {
                items.Add(j + " " + game.Say(j));
            }
            GameListBox.ItemsSource = items;
        }

    }
}
