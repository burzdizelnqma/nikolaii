using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uchilishte
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("vuvedi kolko dni e rabotil v meseca");
            double n = double.Parse(Console.ReadLine());
            Console.Write("vuvedi pechalba za den");
           double m = double.Parse(Console.ReadLine());
            Console.Write("vuvedi kursa dolara sprqmo leva") ;
            double kurs = double.Parse(Console.ReadLine());

            double mesec = n * m;
            double godina = (mesec * 12 ) + (mesec * 2.5);
           

        }
    }
}
