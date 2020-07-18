using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingEntityFramework
{
    //Создаем таблицу Song
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GroupId { get; set; }
        //Связываем текущую таблицу с таблицей Group
        public virtual Group Group { get; set; }
    }
}
