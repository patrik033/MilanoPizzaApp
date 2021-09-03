using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MilanoPizza
{
    class Program : Drink
    {

        private static List<Pizza> pizzaList = new List<Pizza>();
        private static Pizza myPizza = new Pizza();
        private static Drink myDrink = new Drink();
        static void Main(string[] args)
        {
            
            Logo();
            string welcomeMessage = "Hello, Welcome to Pizzeria Milano, do you want to order something (y/n): ";
            string output = Message(welcomeMessage);
            if(output.Trim().ToLower() == "y")
            {
                while (output != "3")
                {
                    Menu();
                    output = Message("What do you want to order: ");
                    switch (output)
                    {
                        case "1":
                            myPizza.OrderPizza();
                            pizzaList.Add(myPizza);
                            break;
                        case "2":
                            myDrink.OrderDrink();
                            break;
                    }
                } 
            }
            GoodByeMessage();
 
            Console.ReadLine();


        }

        private static void Logo()
        {
            int counter = 0;
            for (int i = 0; i < 6; i++)
            {
                Console.Clear();
                switch (counter % 6)
                {
                    case 0:
                        Console.WriteLine(@"

██████╗░██╗███████╗███████╗███████╗██████╗░██╗░█████╗░  ███╗░░░███╗██╗██╗░░░░░░█████╗░███╗░░██╗░█████╗░
");
                        break;

                    case 1:
                        Console.WriteLine(@"

██████╗░██╗███████╗███████╗███████╗██████╗░██╗░█████╗░  ███╗░░░███╗██╗██╗░░░░░░█████╗░███╗░░██╗░█████╗░
██╔══██╗██║╚════██║╚════██║██╔════╝██╔══██╗██║██╔══██╗  ████╗░████║██║██║░░░░░██╔══██╗████╗░██║██╔══██╗
");
                        break;

                    case 2:
                        Console.WriteLine(@"

██████╗░██╗███████╗███████╗███████╗██████╗░██╗░█████╗░  ███╗░░░███╗██╗██╗░░░░░░█████╗░███╗░░██╗░█████╗░
██╔══██╗██║╚════██║╚════██║██╔════╝██╔══██╗██║██╔══██╗  ████╗░████║██║██║░░░░░██╔══██╗████╗░██║██╔══██╗
██████╔╝██║░░███╔═╝░░███╔═╝█████╗░░██████╔╝██║███████║  ██╔████╔██║██║██║░░░░░███████║██╔██╗██║██║░░██║
");
                        break;
                    case 3:

                        Console.WriteLine(@"

██████╗░██╗███████╗███████╗███████╗██████╗░██╗░█████╗░  ███╗░░░███╗██╗██╗░░░░░░█████╗░███╗░░██╗░█████╗░
██╔══██╗██║╚════██║╚════██║██╔════╝██╔══██╗██║██╔══██╗  ████╗░████║██║██║░░░░░██╔══██╗████╗░██║██╔══██╗
██████╔╝██║░░███╔═╝░░███╔═╝█████╗░░██████╔╝██║███████║  ██╔████╔██║██║██║░░░░░███████║██╔██╗██║██║░░██║
██╔═══╝░██║██╔══╝░░██╔══╝░░██╔══╝░░██╔══██╗██║██╔══██║  ██║╚██╔╝██║██║██║░░░░░██╔══██║██║╚████║██║░░██║
");
                        break;
                    case 4:
                        Console.WriteLine(@"

██████╗░██╗███████╗███████╗███████╗██████╗░██╗░█████╗░  ███╗░░░███╗██╗██╗░░░░░░█████╗░███╗░░██╗░█████╗░
██╔══██╗██║╚════██║╚════██║██╔════╝██╔══██╗██║██╔══██╗  ████╗░████║██║██║░░░░░██╔══██╗████╗░██║██╔══██╗
██████╔╝██║░░███╔═╝░░███╔═╝█████╗░░██████╔╝██║███████║  ██╔████╔██║██║██║░░░░░███████║██╔██╗██║██║░░██║
██╔═══╝░██║██╔══╝░░██╔══╝░░██╔══╝░░██╔══██╗██║██╔══██║  ██║╚██╔╝██║██║██║░░░░░██╔══██║██║╚████║██║░░██║
██║░░░░░██║███████╗███████╗███████╗██║░░██║██║██║░░██║  ██║░╚═╝░██║██║███████╗██║░░██║██║░╚███║╚█████╔╝
");
                        break;
                    case 5:
                        Console.WriteLine(@"

██████╗░██╗███████╗███████╗███████╗██████╗░██╗░█████╗░  ███╗░░░███╗██╗██╗░░░░░░█████╗░███╗░░██╗░█████╗░
██╔══██╗██║╚════██║╚════██║██╔════╝██╔══██╗██║██╔══██╗  ████╗░████║██║██║░░░░░██╔══██╗████╗░██║██╔══██╗
██████╔╝██║░░███╔═╝░░███╔═╝█████╗░░██████╔╝██║███████║  ██╔████╔██║██║██║░░░░░███████║██╔██╗██║██║░░██║
██╔═══╝░██║██╔══╝░░██╔══╝░░██╔══╝░░██╔══██╗██║██╔══██║  ██║╚██╔╝██║██║██║░░░░░██╔══██║██║╚████║██║░░██║
██║░░░░░██║███████╗███████╗███████╗██║░░██║██║██║░░██║  ██║░╚═╝░██║██║███████╗██║░░██║██║░╚███║╚█████╔╝
╚═╝░░░░░╚═╝╚══════╝╚══════╝╚══════╝╚═╝░░╚═╝╚═╝╚═╝░░╚═╝  ╚═╝░░░░░╚═╝╚═╝╚══════╝╚═╝░░╚═╝╚═╝░░╚══╝░╚════╝░");
                        break;

                }
                counter++;
                Thread.Sleep(350);
            }



        }
        private static string Message(string textMessage)
        {
            Console.Write($"\n{textMessage}");
            string returnMessage = Console.ReadLine();
            return returnMessage;
        }
        private static void Menu()
        {
            Console.WriteLine("1) Order a Pizza");
            Console.WriteLine("2) Order Something to drink");
            Console.WriteLine("3) Leave the pizza");
        }
        private static void GoodByeMessage()
        {
            Console.WriteLine("Goodbye");
            Thread.Sleep(400);
            Console.WriteLine("Press any key to exit");
        }
    }
}
