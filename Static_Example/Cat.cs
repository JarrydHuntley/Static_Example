using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Example
{
    class Cat
    {

        private int catCount;

        public int CatCount
        {
            get { return catCount; }
            set { catCount = value; }  
        }

        public Cat()
        {
  
        }

        public void WarCry()
        {
            Console.WriteLine("We are an army of " + catCount + " cats!!");
        }
    }
}
