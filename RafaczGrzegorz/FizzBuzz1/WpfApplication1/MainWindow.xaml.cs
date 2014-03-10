using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
using FizzBuzz1;

namespace WpfApplication1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Game Game_1 = new Game();
          //  sahd.Text = "podaj ilość";
            int n = 0;
            n = Convert.ToInt32(nr2.Text);
            StreamWriter sw = new StreamWriter("D:/game.txt");

            for (int i = 1; i < n; i++)
            {

                sahd.Items.Add(Game_1.Say(i).ToString() + "\n");

                sw.Write(Game_1.Say(i).ToString() + "\n");
            }
            
            sw.Close();
        }

        private void sahd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
