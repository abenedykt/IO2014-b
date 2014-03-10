using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz1;

namespace UserInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Game Game_1=new Game();
            Console.WriteLine("Podaj ilosć:");
            int n = 0;
            n = Convert.ToInt32(Console.ReadLine());
            StreamWriter sw=new StreamWriter("D:/game.txt");

            for (int i = 1; i < n; i++)
            {
                
                Console.WriteLine(Game_1.Say(i).ToString());

                sw.Write(Game_1.Say(i).ToString()+"\n");
            }
            
          sw.Close();
            

        }
    }
}
