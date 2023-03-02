using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Single_Responsibility
{
    public class ShoppingCart
    {
        private List<ShoppingCartItem> items { get; set; } = new List<ShoppingCartItem>();

        public IEnumerable<ShoppingCartItem> Items { get {  return items; } }

        public void Add(ShoppingCartItem item)
        {
            items.Add(item);
        }

        public void Remove(ShoppingCartItem item)
        {
            items.Remove(item);
        }

        public void Clear() { 
            items.Clear(); 
        }

        public void LoadFromFile(string fileName)
        {
            using var reader = new StreamReader(new FileStream(fileName, FileMode.Open));
            var jsonString = reader.ReadToEnd();
            reader.Close();

            items.Clear();
            var loadItems = JsonSerializer.Deserialize<List<ShoppingCartItem>>(jsonString);
            if (loadItems != null)
            {
                items.AddRange(loadItems);
            }
        }

        public void SaveToFile(string fileName) 
        {
            string jsonString = JsonSerializer.Serialize(items);

            using var writer = new StreamWriter(new FileStream(fileName, FileMode.Create));
            writer.Write(jsonString);
            writer.Flush();
            writer.Close();
        }

        public double GetTotal()
        {
            return items.Sum(i => i.Quantity * i.Price);
        }

        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine("SHOPPING CART");
            Console.WriteLine("~~~~~~~~~~~~~");

            foreach (var item in items)
            {
                Console.WriteLine($"{item.Title} - {item.Price:C} x {item.Quantity} = {item.Quantity * item.Price:C}");
            }
        }
    }
}
