using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WorkWithFielsAndSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            //Отображение информации о дисках компютера
            #region Drive Info
            //DriveInfo[] driveInfo = DriveInfo.GetDrives();
            //foreach(DriveInfo i in driveInfo)
            //{
            //    Console.WriteLine(i.Name);
            //    Console.WriteLine(i.TotalFreeSpace);
            //    Console.WriteLine(i.DriveType);
            //}
            #endregion

            //CreatAndWriteText(new string[] {"qqqqq","wwwwwww","ggggggggg" }, @"C:\Users\alexg\OneDrive\Рабочий стол\testFile.txt");
            //WriteText();
            //ReadFiel(DisplayDirectoryFile(@"E:\UseIO","*.txt"));
            ReadText();


            Console.ReadLine();
        }
        //Create and write text into the file
        static void CreatAndWriteText(string[] text, string pathNamef)
        {
            File.WriteAllLines(pathNamef, text);
        }
        // Read text from fiel
        static void ReadFiel(string pathAndFileName)
        {
            foreach(var i in File.ReadAllLines(pathAndFileName))
                Console.WriteLine(i);
        }
        //Show file from directory and return path by file
        static string DisplayDirectoryFile(string path= @"C:\Users\alexg\OneDrive\Рабочий стол", string typeFile = "*.txt")
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] txt = dir.GetFiles(typeFile);
            foreach (var i in txt)
            {
                Console.WriteLine($"Name :{i.Name}, path: {i.FullName}");
            }
            //возвращаем путь к файлу text3.txt
            var g = from x in txt where x.Name == "text3.txt" select x;
            return g.First().FullName;//как отсортировать по имени в return
        }
        // Create and write text file
        static void WriteText()
        {
            //Формат записи текста с кодировкой UTF8
            using (StreamWriter writer = File.CreateText(@"E:\UseIO\text3.txt"))
            //Общий формат записи
            //using (StreamWriter wr = new StreamWriter(@"E:\UseIO\text3.txt", false, Encoding.UTF8))
            {
                writer.WriteLine("jdfjjkjgflkg");
                for (int i = 0; i < 10; i++)
                    writer.Write(i);
            }
        }
        static void ReadText(string path= @"E:\UseIO\text3.txt")
        {
            using(StreamReader reader = File.OpenText(path))
            {
                string result = null;
                while ((result = reader.ReadLine()) != null)
                    Console.WriteLine(result);
                //string gg = reader.ReadToEnd();
                //Console.WriteLine(gg);
            }
        }
    }
}
    