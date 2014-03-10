using _01_TDD2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
    }
}
