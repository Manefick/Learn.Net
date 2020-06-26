using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnReflection
{
    [AttributeUsage(AttributeTargets.Method|AttributeTargets.Class)]
    public class MaleAttribute:Attribute
    {
        public string mail { get; set; }
        public MaleAttribute() { }
        public MaleAttribute(string m)
        {
            mail = m;
        }
        public override string ToString()
        {
            return $"{mail}";
        }
    }
}
