using Interface_Segregation;

IOnlineStore onlineStore = new OnlineStore();

onlineStore.AddProduct(1, 1);
onlineStore.AddProduct(2, 10);
onlineStore.AddProduct(3, 100);

onlineStore.SetCheckoutInfo(new CheckoutInfo());

var order = onlineStore.Checkout();
Console.WriteLine($"Order created, Id = {order.Id}");