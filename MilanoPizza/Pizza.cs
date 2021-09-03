namespace MilanoPizza
{
    using System;
    public class Pizza
    {
        private Sizes PizzaSizes;
        private decimal Cost = 0.0M;
        private decimal FinalCost = 0.0M;
        private int Amount = 0;



        public void OrderPizza()
        {
            Console.WriteLine("Hello to the Pizza Ordering form");
            string pizzaType = MessageForm("What Size Pizza do you want (small/medium/large): ");
            SizeDecision(pizzaType);
            FinalCost += CalculateCost();
            ReturnMessage();
        }

        private decimal CalculateCost()
        {

            string amount = MessageForm("How many Pizzas do you want: ");
            bool toCorrectAmount = int.TryParse(amount, out Amount);
            Console.Clear();

            if (PizzaSizes == Sizes.Small)
                Cost = 5.0M;
            else if (PizzaSizes == Sizes.Medium)
                Cost = 10.0M;
            else if (PizzaSizes == Sizes.Large)
                Cost = 20.0M;

            decimal result = (Amount * Cost);
            return result;

        }


        private string MessageForm(string text)
        {

            Console.WriteLine(text);
            string returnText = Console.ReadLine().Trim().ToLower();
            return returnText;
        }

        public void ReturnMessage()
        {
            string pizzaFormSmall = @"        ____
               _,--~~    ~~--._
            ,/'  m%%%%%%=@%%m  `\.
           /' m%%o(_)%%o%%%%o%%m `\
         /' %%@=%o%%%o%%%o%(_)o%%% `\
        /  %o%%%%%=@%%%(_)%%o%%@=%%  \
       |  (_)%(_)%%o%%%o%%%%=@(_)%%%  |
       | %%o%%%%o%%%(_)%%o%%o%%%%o%%% |
       | %%o%(_)%%%%%o%(_)%%%o%%o%o%% |
       |  (_)%%=@%(_)%o%o%%(_)%o(_)%  |
        \ ~%%o%%%%%o%o%=@%%o%%@%%o%~ /
         \. ~o%%(_)%%%o%(_)%%(_)o~ ,/
           \_ ~o%=@%(_)%o%%(_)%~ _/
             `\_~~o%%%o%%%%%~~_/'
                `--..____,,--'";

            string pizzaFormLarge = @"    _____
              __--~~~     ~~~--__
           ,/'   m%%%%%%%=@%%m   `\.
         /'  m%%%o(_)%%o%%o%%%o%%m  `\
       /'  %%@=%o%%%%o%%%o%%(_)o%%%%  `\
     /'  %%%o%%%%%=@%%%(_)%%o%%%o%@=%%  `\
    /  %(_)%%(_)%%%o%%%o%%%%=@(_)%%%o%%%  \
   /  @=%%%o%%%%o%%%(_)%%o%%o%%%%o%%%o%%%  \
  |  %%o%%%%=@%%%o%%%%@=%(_)%%=@%%(_)%o%%%  |
 |  %%%%(_)%%%%o%(_)o%%o%%%o%%%%o%%o%o@=%o%  |
 |  %%o%o%%o%%%%o%%o%%o%%%%=@%o(_)%%o%o%%%%  |
 |  %(_)%%%%(_)%=@%%%(_)o%%%o%%o%%@=%%(_)%%  |
 |  %%o%(_)%%%%%o%%%%%%=@%%(_)%%o%%%o%%%%%%  |
  |  %%o%%%%o%%%%(_)o%%%%o%o%%@=%(_)%%=@%%  |
   \  %@=%%o%(_)%%%%%o%(_)%%%o%%o%%o%%%%%  /
    \  %%(_)%%%=@%(_)%o%o%%(_)%o%(_)%@=%  /
     \. ~%%%o%%%%%o%o%=@%%o%%@=%%o%%o%% ,/
       \. ~o%%(_)%%%%%o%(_)%%o%(_)o%% ,/
         \_ ~%%o%=@%(_)%%o%%(_)%%~  ,/
           `\__~~~o%%%%o%%%%%~  __/'
               `~--.._____,,--~'";

            if (PizzaSizes == Sizes.Small)
                Console.WriteLine(pizzaFormSmall);
            else if (PizzaSizes == Sizes.Large)
                Console.WriteLine(pizzaFormLarge);
            Console.WriteLine($"The final cost for {Amount} {PizzaSizes} are: {FinalCost}");

        }

        private void SizeDecision(string type)
        {
            switch (type)
            {
                case "small":
                    PizzaSizes = Sizes.Small;
                    break;
                case "medium":
                    PizzaSizes = Sizes.Medium;
                    break;
                case "large":
                    PizzaSizes = Sizes.Large;
                    break;
                default:
                    Console.WriteLine("You entered an invalid input...");
                    break;
            }
        }
    }
}