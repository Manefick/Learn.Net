using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kalk(695, 2));

            Console.ReadLine();
        }
        static double Kalk(double x, double y)
        {
            if (x< 1)
                return Kalk(x, y) / x;
            return Math.Pow((double)x.ToString()[0],y)+Kalk(x/10,y+1);
        }
    }
}
