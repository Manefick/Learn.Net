using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingEntityFramework
{
    //Подключение к базе даных
    public class MyDBConect: DbContext
    {
        public MyDBConect() : base("DbConectionString")
        {
        }
        //Указываем какие у нас таблицы в БД
        public DbSet<Group> Groups { get; set; }
        public DbSet<Song> Songs { get; set; }

    }
}
