using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Example
{
    class Turtle
    {
        //This static variable belongs to the class. It's shared among all instances.
        //This also means we can use the variable without creating any instances firt.
        static int turtleCount;

        public Turtle()
        {
            turtleCount++;
        }


        //This static method belongs to the class. It's shared among all instances.
        //It means we can use the method without creating any instances firt.
        public static void WarCry()
        {
            Console.WriteLine("We are an army of " + turtleCount + " turtles!!");
        }
    }
}
