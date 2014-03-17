using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IOZad2
{
    class DzialkaParser : IParser
    {
        public Dzialka Parse(string data)
        {
            Dzialka dzialka = new Dzialka();

            string[] lines = data.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            Regex regex = new Regex("(?<X>)( +)(?<Y>)");
            Match match = regex.Match(lines[1]);
            dzialka.Srodek = new Punkt()
            {
                X = Convert.ToDouble(match.),
                Y = Convert.ToDouble(lines[1].Substring(firstspace, secondspace - firstspace))
            };
            int count = Convert.ToInt32(lines[2]);
            for (int i = 0; i < count; i++)
            {
                firstspace = lines[i + 3].IndexOf(' ');
                secondspace = lines[i + 3].IndexOf(' ', firstspace + 1);
                int thirdspace = lines[i + 3].IndexOf(' ', secondspace + 1);
                dzialka.Wierzcholki.Add(new Punkt()
                {
                    X = Convert.ToDouble(lines[i + 3].Substring(firstspace, secondspace - firstspace)),
                    Y = Convert.ToDouble(lines[i + 3].Substring(secondspace, thirdspace - secondspace))
                });
            }

            return dzialka;
        }
    }
}

//"               1.1-800/128",
//"5544943.71        6532099.62         5544943.71        6532099.62 N  7",
//"7",
//"1-7923        5544969.02        6532117.26        5544969.02        6532117.26   0 N N  7",
//"1-7880        5544908.34        6532098.97        5544908.34        6532098.97   0 N N  7",
//"1-7807        5544907.94        6532075.96        5544907.94        6532075.96   0 N N  7",
//"1-7856        5544928.59        6532085.45        5544928.59        6532085.45   0 N N  7",
//"1-7881        5544975.70        6532098.40        5544975.70        6532098.40   0 N N  7",
//"1-7907        5544972.66        6532107.54        5544972.66        6532107.54   0 N N  7",
//"1-7923        5544969.02        6532117.26        5544969.02        6532117.26   0 N N  7"