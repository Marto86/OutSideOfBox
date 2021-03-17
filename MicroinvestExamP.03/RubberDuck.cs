using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroinvestP._03.Interfaces;

namespace MicroinvestP._03
{
    public class RubberDuck : Duck ,IMakeSound,ISwim
    {
        public RubberDuck(string name, string color, int age) : base(name, color, age)
        {

        }

        
        public void MakeSound()
        {
            Console.WriteLine("Quack");
        }

        public void Swim()
        {
            Console.WriteLine("Duck Start Swimming");
        }
    }
}
