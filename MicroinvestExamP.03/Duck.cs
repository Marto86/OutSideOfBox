using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroinvestP._03
{
   public abstract class Duck
    {
        public Duck(string name , string color ,int age)
        {
            this.Name = name;
            this.Age = age;
            this.Color = color;
        }

        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
    }
}
