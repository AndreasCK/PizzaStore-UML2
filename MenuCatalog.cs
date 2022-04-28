using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore2
{
    class MenuCatalog
    {
        Dictionary<int, Pizza> pizzas;
       

        public MenuCatalog()
        {
            pizzas = new Dictionary<int, Pizza>();
        }

        public void CreatePizza(Pizza pizza)
       
            {
                pizzas.Add(pizza.PizzaID, pizza);
            }
        

        public Pizza ReadPizza(int PizzaID)
        {
            return pizzas[PizzaID];
        }

        public void UpdatePizza(Pizza pizza, int NewPrice, string NewName)
        {
            pizza.Price = NewPrice;
            pizza.Name = NewName;
        }
        public void DeletePizza(Pizza pizza)
        {
            pizzas.Remove(pizza.PizzaID);
        }

        public Pizza SearchPizza(int PizzaID)

        {
            return pizzas[PizzaID];
        }


        public void PrintMenu()
        {        
                foreach (var Pizza in pizzas)
               
            {
                Console.WriteLine(Pizza);
            }

        }
            
    }
}
