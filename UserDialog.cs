using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaStore2
{
    public static class UserDialog 
    {
        
        static FastFood GetNewFastFood()
        {
            FastFood Pizza = new FastFood();
            Console.Clear();
            Console.WriteLine("----------------------");
            Console.WriteLine("| Creating Pizza |");
            Console.WriteLine("----------------------");
            Console.WriteLine();
            Console.Write("Enter name: ");
            Pizza.Name = Console.ReadLine();

            string input = "";
            Console.Write("Enter price: ");
            try
            {
                input = Console.ReadLine();
                Pizza.Price = Int32.Parse(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Unable to parse '{input}' - Message: {e.Message}");
                throw;
            }

            return Pizza;
        }
        static int MainMenuChoice(List<string> menuItems)
        {
            Console.Clear();
            Console.WriteLine("-------------------");
            Console.WriteLine("| Big Momma Pizza Menu |");
            Console.WriteLine("-------------------");
            Console.WriteLine();
            Console.WriteLine("Options:");
            foreach (string choice in menuItems)
            {
                Console.WriteLine(choice);
            }

            Console.Write("Enter option#: ");
            string input = Console.ReadKey().KeyChar.ToString();

            try
            {
                int result = Int32.Parse(input);
                return result;
            }

            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{input}'");
            }
            return -1;
        }
        static public void Run()
        {
            bool proceed = true;
            List<string> mainMenulist = new List<string>()
            {
                "0. Quit",
                "1. Create new pizza",
                "2. SubMenu 2"
            };

            while (proceed)
            {
                int MenuChoice = MainMenuChoice(mainMenulist);
                Console.WriteLine();
                switch (MenuChoice)
                {
                    case 0:
                        proceed = false;
                        Console.WriteLine("Quitting");
                        break;
                    case 1:
                        try
                        {
                            FastFood Pizza = GetNewFastFood();
                            Console.WriteLine($"You created: {Pizza}");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"No order created");
                        }
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine($"You selected: {mainMenulist[MenuChoice]}");
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;
                }
            }

        }
    }
}


