using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace LearnDomain
{
    class Program
    {
        static void Main(string[] args)
        {
            //DisplayDADStatus();
            //DisplayAssamblyByDomain();
            AppDomain localDomain = AppDomain.CurrentDomain;
            //InitDAD();//оповещение о загрузке сборок 
            //Уведомление о выгрузке стандартного\локального домена
            localDomain.ProcessExit += (o, s) => { Console.WriteLine("Local domain is unload"); };
            DisplayAssamblyByDomain(localDomain);
            CreateNewDomain();
            InitDAD();


            Console.ReadLine();
        }

        private static void DisplayDADStatus()
        {
            AppDomain dom = AppDomain.CurrentDomain;
            Console.WriteLine("{0} {1} {2} {3}",dom.BaseDirectory,dom.FriendlyName,dom.Id,dom.IsDefaultAppDomain());
        }
        static void DisplayAssamblyByDomain()
        {
            AppDomain appDomain = AppDomain.CurrentDomain;
            var ollAsembly = from i in appDomain.GetAssemblies() orderby i.GetName().Name select i;
            foreach(var ass in ollAsembly)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(appDomain.FriendlyName);
                Console.WriteLine($"Assembly name: {ass.GetName().Name}\nAssembly version: {ass.GetName().Version}");
            }
        }
        //увидомление о загрузке сборок
        static void InitDAD()
        {
            AppDomain app = AppDomain.CurrentDomain;
            app.AssemblyLoad += (o, s) =>
            {
                Console.WriteLine($"Assembly {s.LoadedAssembly.GetName().Name} is load");
            };
        }
        private static void CreateNewDomain()
        {
            //Создание нового домена
            AppDomain newDomain = AppDomain.CreateDomain("SecondDomain");
            //оповещение о выгрузке нового(второго домена)
            newDomain.DomainUnload += (o, s) => { Console.WriteLine("Second Domain is unload"); };
            InitDAD();
            //Загрузка сборки в созданый второй домен
            try
            {
                newDomain.Load("Task2Cinema");
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("------------Second Domains--------");
            DisplayAssamblyByDomain(newDomain);
            //выгружаем домен
            AppDomain.Unload(newDomain);
        }

        private static void NewDomain_DomainUnload(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        static void DisplayAssamblyByDomain(AppDomain ad)
        {
            var loadDomains = from d in ad.GetAssemblies() orderby d.GetName().Name select d;
            foreach(var a in loadDomains)
            {
                Console.WriteLine($"{a.GetName().Name}--{a.GetName().Version}");
            }
        }
    }
}
