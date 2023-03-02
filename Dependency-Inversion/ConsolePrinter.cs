using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    public class ConsolePrinter
    {
        public void Print(ShoppingCart cart)
        {
            Console.WriteLine();
            Console.WriteLine("SHOPPING CART");
            Console.WriteLine("~~~~~~~~~~~~~");

            foreach (var item in cart.Items)
            {
                Console.WriteLine($"{item.Title} - {item.Price:C} x {item.Quantity} = {item.Quantity * item.Price:C}");
            }
        }
    }
}
