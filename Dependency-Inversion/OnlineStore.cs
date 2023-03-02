using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion
{
    public class OnlineStore
    {
        private readonly ConsolePrinter printer;
        private readonly FileStorage storage;

        public ShoppingCart Cart { get; private set; }

        public OnlineStore(ConsolePrinter printer, FileStorage storage) {
            Cart = new ShoppingCart();

            this.printer = printer;
            this.storage = storage;
        }

        public void Save()
        {
            storage.Save(Cart);
        }

        public void Load()
        {
            var cart = storage.Load();
            if (cart != null)
            {
                this.Cart = cart;
            }
            else
            {
                throw new Exception("Error loading cart");
            }
        }

        public void Print()
        {
            printer.Print(Cart);
        }
    }
}
