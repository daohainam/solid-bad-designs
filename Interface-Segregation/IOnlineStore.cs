using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation
{
    public interface IOnlineStore
    {
        void AddProduct(int productId, int quantity);
        void RemoveProduct(int productId, int quantity);
        void SetCheckoutInfo(CheckoutInfo checkoutInfo);
        Order Checkout();
    }
}
