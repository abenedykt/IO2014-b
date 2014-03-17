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
            Regex regexSrodek = new Regex("(?<X>[^ ]+)( +)(?<Y>[^ ]+)");
            Match matchSrodek = regexSrodek.Match(lines[1]);

            dzialka.Srodek = new Punkt()
            {
                X = Convert.ToDouble(matchSrodek.Groups["X"].Value),
                Y = Convert.ToDouble(matchSrodek.Groups["Y"].Value)
            };
            int count = Convert.ToInt32(lines[2]);
            for (int i = 3; i < count + 3; i++)
            {
                Regex regexWierzcholek = new Regex("(?<trash>[^ ]+)( +)(?<X>[^ ]+)( +)(?<Y>[^ ]+)");
                Match matchWierzcholek = regexWierzcholek.Match(lines[i]);
               
                dzialka.Wierzcholki.Add(new Punkt()
                {
                    X = Convert.ToDouble(matchWierzcholek.Groups["X"].Value),
                    Y = Convert.ToDouble(matchWierzcholek.Groups["Y"].Value)
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