using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace _03_Substitute
{
    public class GeoImport
    {
        private string[] GetLines(string data)
        {
            return data.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
        }

        public string GetFieldNumber(string data)
        {
            var lines = GetLines(data);

            return lines[0].Trim();
        }

        public int GetNumberOfPoints(string data)
        {
            var lines = GetLines(data);

            return Convert.ToInt32(lines[2]);
        }

        private string GetCoord(string line, int pos)
        {
            return line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[pos];
        }

        private double ToDouble(string number)
        {
            return Convert.ToDouble(number.Replace('.', ','));
        }

        public double GetX(string data)
        {
            var lines = GetLines(data);
            return ToDouble(GetCoord(lines[1], 1));
        }

        public double GetY(string data)
        {
            var lines = GetLines(data);
            return ToDouble(GetCoord(lines[1], 2));
        }

        public double GetXOfPoint(string data)
        {
            return ToDouble(GetCoord(data, 1));
        }

        public double GetYOfPoint(string data)
        {
            return ToDouble(GetCoord(data, 2));
        }

        public double GetXMin(string data)
        {
            var lines = GetPoints(data);
            return lines.Select(GetXOfPoint).OrderBy(n => n).FirstOrDefault();
        }

        public double GetYMin(string data)
        {
            var lines = GetPoints(data);
            return lines.Select(GetYOfPoint).OrderBy(n => n).FirstOrDefault();
        }

        private IEnumerable<string> GetPoints(string data)
        {
            return GetLines(data).Skip(3);
        }

        public double GetXMax(string data)
        {
            var lines = GetPoints(data);
            return lines.Select(GetXOfPoint).OrderBy(n => n).Reverse().FirstOrDefault();
        }

        public double GetYMax(string data)
        {
            var lines = GetPoints(data);
            return lines.Select(GetYOfPoint).OrderBy(n => n).Reverse().FirstOrDefault();
        }

        public IEnumerable<string> SplitFields(string data)
        {
            return Regex.Split(data, @"(?:\r\n){2,}");
        }
    }
}
