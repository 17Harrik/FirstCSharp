using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user how many pizzas that want to eat
            Console.WriteLine("How many pizzas would you like to eat? ");
            int answer = int.Parse(Console.ReadLine());

            // Loop for number of times given by the user 
            for (int i = 0; i < answer; i++)
            {
                // Concatinates the number of pizzas to the string
                Console.WriteLine("Eat pizza number " + (i+1));
            }

            string topping = "pineapple";

            while (topping == "pineapple") ;
            {
                Console.WriteLine("What's your favourite topping?");
                topping = Console.ReadLine();
            }

            Console.ReadLine();

        }
    }
}
