using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroinvestP._03.Interfaces;

namespace MicroinvestP._03
{
   public class MallardDuck : Duck ,IEat,IMakeSound,ISwim,IFlyable
   {
       public MallardDuck(string name, string color, int age) : base(name, color, age)
       {

       }

       public void Eat()
       {
           Console.WriteLine("Start Eating");
       }

       public void MakeSound()
       {
           Console.WriteLine("Quack");
        }

       public void Swim()
       {
           Console.WriteLine("Duck Start Swimming");
        }

       public void Fly()
       {
           Console.WriteLine("Duck Take Fly");
       }
   }
}

