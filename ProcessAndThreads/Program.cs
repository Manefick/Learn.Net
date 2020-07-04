using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProcessAndThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            GetProcessByPID(3316);
            StartAndKillProcess();

            Console.ReadLine();
        }

        static void ListAllRaningProcess()
            //Вывести в консоль все отсортированые по ПИД процеси
        {
            var runingProcess = from proc in Process.GetProcesses() orderby proc.Id select proc;

            //var k = from p in runingProcess select p.Id;
            //int y = k.ElementAt(4);
            foreach(var i in runingProcess)
            {
                Console.WriteLine($"PID: {i.Id}; Process name: {i.ProcessName}");
            }
        }
        static void GetProcessByPID(int k)
        {
            //получение одного конкретного процеса с помощью PID
            Process process = null;
            try
            {
                process = Process.GetProcessById(k);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //
            ProcessThreadCollection thread = process.Threads;
            foreach (ProcessThread th in thread)
            { 
                Console.WriteLine($"Process {process.ProcessName} have threads: {th.Id} {th.ThreadState} {th.BasePriority} {th.StartTime}"); 
            }
        }
        static void StartAndKillProcess()
        {
            Process proc = null;
            try
            {
                proc = Process.Start("msedge.exe","www.facebook.com");
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("if you wont stop process enter 1 and press enter");
            int choise = int.Parse(Console.ReadLine());
            if (choise == 1)
            {
                try
                {
                    proc.Kill();
                }
                catch(InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
