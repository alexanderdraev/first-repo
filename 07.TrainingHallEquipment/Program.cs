using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.TrainingHallEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double budget = double.Parse(Console.ReadLine());
            double n = double.Parse(Console.ReadLine());
            double money_spent = 0;
            for (int i = 0; i < n; i++)
            {
                String s = Console.ReadLine();
 
                double price = double.Parse(Console.ReadLine());
 
                double quantity = double.Parse(Console.ReadLine());
                // int quantity = int.Parse(Console.ReadLine());
 
                money_spent += price * quantity;

                if (quantity <= 2)
                    Console.WriteLine("Adding {0} {1}s to cart.",quantity,s);
                else Console.WriteLine("Adding {0} {1}s to cart.",quantity,s);
            }
 
            if (money_spent <= budget)
            {
                Console.WriteLine("Subtotal: ${0:F2}",money_spent);
                Console.WriteLine("Money left: ${0:F2}", Math.Abs(budget - money_spent));
            }
            else
            {
                Console.WriteLine("Subtotal: ${0:F2}", money_spent);
                Console.WriteLine("Not enough. We need ${0:F2} more.", money_spent-budget);
            }
 
        }
    }
}
    