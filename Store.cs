using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore2
{
   class Store
    {
        public void Start()
        {
            Test();
        }
   
        public void Test()
        {
            MenuCatalog MenuCat = new MenuCatalog();

            Pizza p1 = new Pizza(1, "Calzone", 67);
            Pizza p2 = new Pizza(2, "Pepperoni", 67);
            Pizza p3 = new Pizza(3, "Ham", 65);

            Console.WriteLine("Pizza Created");
            MenuCat.CreatePizza(p1);
            MenuCat.CreatePizza(p2);
            MenuCat.CreatePizza(p3);

            MenuCat.DeletePizza(p2);
            MenuCat.CreatePizza(p2);


            Console.WriteLine("Menu");
            MenuCat.PrintMenu();

            Console.WriteLine("Updating pizza 3....");
            MenuCat.UpdatePizza(p3, 58, "Cheese");
            Console.WriteLine(MenuCat.ReadPizza(3));

            Console.WriteLine(MenuCat.SearchPizza(1));
        }
    }
}
