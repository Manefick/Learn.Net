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
            int[] test = { 2, 1, 1, 1, 1, 1, 1 };
            var a = test.GroupBy(x => x);//разделяет даніе на группи
            Console.WriteLine(test.GroupBy(x=>x).Single(x=>x.Count()==1).Key);
            //Как через линкю найти  повторяющияся символ 
            


            Console.ReadLine();
        }
    }
}
