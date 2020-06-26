using System;
using System.Collections.Generic;
using System.Text;

namespace TestLibrary
{
    //Использование атрибута который устанавлевает что можно помечать этим атрибутом
    //[AttributeUsage(AttributeTargets.Method)]
    public class ColorAttribute :Attribute
    {
        public ConsoleColor color { get; set; } = ConsoleColor.Red;
        public string nameColor { get; set; }

        public ColorAttribute() { }
        public ColorAttribute(ConsoleColor c,string n)
        {
            color = c;
            nameColor = n;
        }
        public override string ToString()
        {
            return $"{color} {nameColor}";
        }
    }
}
