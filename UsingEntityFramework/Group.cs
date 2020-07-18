using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingEntityFramework
{
    // создаем модель таблицы Group
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Year { get; set; }//int? --означает что int может принимать null(быть пустым)
        //Так описуем связь с таблицей Song
        public virtual ICollection<Song> Songs { get; set; }
    }
}
