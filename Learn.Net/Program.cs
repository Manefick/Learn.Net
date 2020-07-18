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
            //int[] test = { 2, 1, 1, 1, 1, 1, 1 };
            //var a = test.GroupBy(x => x);//разделяет даніе на группи
            //Console.WriteLine(test.GroupBy(x=>x).Single(x=>x.Count()==1).Key);

            string s = "qwertyuiopasdfg";
            string rezult="";
            int n = 0;
            foreach( char i in s)
            {
                rezult += i.ToString().ToUpper();
                for (int k = 0; k < n; k++)
                {
                    rezult += i.ToString().ToLower();
                }
                rezult += "-";
                n++;
            }
            Console.WriteLine(rezult.Remove(rezult.Length-1));
            Console.ReadLine();
        }
    }
}
