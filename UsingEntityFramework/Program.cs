using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Подключаемся к ДБ создавая екземпляр класса ДБконект
            //using-- автоматически открывает и закрывает потключение к бд , оно безопасно
            using (var context = new MyDBConect())
            {
                // создаем, записываем даные в таблицу гроуп, создавая екземпляр класса Гроуп
                var group = new Group()
                {
                    Name = "Ramstain",
                    Year = 1994
                };
                var group1 = new Group()
                {
                    Name = "Linking park"
                };
                //Добавляем нашу таблицу в промежуточную/кешированую БД
                context.Groups.Add(group);
                context.Groups.Add(group1);
                //Сохраняем все в БД
                context.SaveChanges();

                //Create table Songs by using colections
                var songs = new List<Song>()
                {
                    new Song() {Name="Muter", GroupId=group.Id},
                    new Song() {Name ="Link", GroupId = group.Id},
                    new Song() {Name = "Abraham", GroupId = group1.Id}
                };
                context.Songs.AddRange(songs);
                context.SaveChanges();

                //выводим содержимое наей таблицы гроуп которая записана в базу
                //Console.WriteLine($"id: {group.Id} name: {group.Name} year: {group.Year}");

                foreach(var song in songs)
                {
                    Console.WriteLine($"Song name: {song.Name} Group name : {song.Group.Name}");
                }
            }
            Console.ReadLine();
        }
    }
}
