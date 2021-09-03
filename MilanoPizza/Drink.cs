namespace MilanoPizza
{
    using System;
    public class Drink
    {

        private Sizes DrinkSizes;
        private decimal Cost = 0.0M;
        private int Amount = 0;

        public Drink()
        {
            DrinkSizes = new Sizes();
        }
        public  void OrderDrink()
        {
            Console.WriteLine("Hello Welcome to the Drink ordering form!");
        }

        
    }
}