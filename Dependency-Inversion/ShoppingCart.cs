using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Dependency_Inversion
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

        public double GetTotal()
        {
            return items.Sum(i => i.Quantity * i.Price);
        }
    }
}
