using _01_TDD2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _03_Substitute;

namespace WinFormsTDD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int start = Convert.ToInt32(numericUpDown1.Value);
            int end = Convert.ToInt32(numericUpDown2.Value);

            if (start > end)
                return;


            Game game = new Game();

            for (int i = start; i <= end; i++)
            {
                listBox1.Items.Add((game.Say(i)));
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string _data = @"               1.1-800/128
        5544943.71        6532099.62         5544943.71        6532099.62 N  7
7
              1-7923        5544969.02        6532117.26        5544969.02        6532117.26   0 N N  7
              1-7880        5544908.34        6532098.97        5544908.34        6532098.97   0 N N  7
              1-7807        5544907.94        6532075.96        5544907.94        6532075.96   0 N N  7
              1-7923        5544969.02        6532117.26        5544969.02        6532117.26   0 N N  7
";

            var geoImport = new GeoImport();

          var test =  geoImport.GetXMin(_data);
        }
    }
}
