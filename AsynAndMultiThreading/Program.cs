using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsynAndMultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Thread
            ////Создаем поток который при запуске  вызывает  ф-ю без параметров
            //Thread thread = new Thread(DoSomething);
            ////запуск потока
            //thread.Start();
            ////Создаем поток который при запуске  вызывает  ф-ю с параметрами
            //Thread thread1 = new Thread(DoSomethingWithParametrs);
            ////Запуск потока, с передачей параметров функции
            //thread1.Start(10000000);

            //int j = 0;
            //for (int i = 0; i < int.MaxValue; i++)
            //{
            //    j++;
            //    if (j % 10000 == 0)
            //        Console.WriteLine("Основной поток");
            //}
            #endregion

            Console.WriteLine("Main");
            TestAsync(20);
            Console.WriteLine("Continue MAin");

            for (int i = 0; i < 10; i++)
                Console.WriteLine("Main");

            Console.ReadLine();
        }
        static void DoSomething()
        {
            int j = 0;
            for (int i = 0; i < int.MaxValue; i++)
            {
                j++;
                if (j % 10000 == 0)
                    Console.WriteLine("DoSomethig");
            }
        }
        static void DoSomethingWithParametrs(object max)// в потоки можно передавать тип только object
        {
            int k = 0;
            for (int f = 0; f < (int)max; f++)
            { 
                k++;
                if(k%10000 ==0)
                    Console.WriteLine("DoSomethingWithParametrs");
            }
        }

        static void Metod(int k)
        {
            for(int i =0;i<k;i++)
                Console.WriteLine("Async");
        }
        //Асинхронный метод 
        static async Task TestAsync(int x)
        {
            Console.WriteLine("Begin Async");
            //Создаеться новый асинхронный поток
            await Task.Run(() => Metod(x));
            Console.WriteLine("End Async");
        }
    }
}
