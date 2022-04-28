using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore2
{
    class FastFood
    {


        public int Price { get; set; }
        public string Name { get; set; }

        public FastFood()
        {
            Price = 0;
            Name = "";
        }

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}";
        }

    }
}
