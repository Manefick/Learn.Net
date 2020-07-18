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
            using (var context = new MyDBConect())
            {
                // создаем, записываем даные в таблицу гроуп, создавая екземпляр класса Гроуп
                var group = new Group()
                {
                    Name = "Ramstain",
                    Year = 1994
                };
                //Добавляем нашу таблицу в промежуточную/кешированую БД
                context.Groups.Add(group);
                //Сохраняем все в БД
                context.SaveChanges();

                //выводим содержимое наей таблицы гроуп которая записана в базу
                Console.WriteLine($"id: {group.Id} name: {group.Name} year: {group.Year}");
            }
            Console.ReadLine();
        }
    }
}
