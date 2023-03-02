using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation
{
    public class OnlineStore : IOnlineStore
    {
        private readonly Dictionary<int, int> cart = new Dictionary<int, int>();
        private CheckoutInfo? checkoutInfo = null;

        public void AddProduct(int productId, int quantity)
        {
            if (cart.ContainsKey(productId))
            {
                cart[productId] = cart[productId] + quantity;
            }
            else
            {
                cart.Add(productId, quantity);
            }
        }

        public Order Checkout()
        {
            if (checkoutInfo == null)
            {
                throw new InvalidOperationException("checkoutInfo is null");
            }

            if (cart.Count == 0) {
                throw new InvalidOperationException("cart is empty");
            }

            return new Order() { Id = 999 };
        }

        public void RemoveProduct(int productId, int quantity)
        {
            if (cart.TryGetValue(productId, out int value))
            {
                int newQuantity = value - quantity;
                if (newQuantity > 0)
                {
                    cart[productId] = newQuantity;
                }
                else
                {
                    cart.Remove(productId);
                }
            }
        }

        public void SetCheckoutInfo(CheckoutInfo checkoutInfo)
        {
            this.checkoutInfo = checkoutInfo;
        }
    }
}
