using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizonalLine hLine = new HorizonalLine(0, 10, 0, '*');
            VerticalLine vLine = new VerticalLine(10, 5, 3, '#');
            hLine.Draw();
            vLine.Draw();

            Console.ReadLine();
        }
    }
}
