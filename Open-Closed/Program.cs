using Open_Closed;

Console.WriteLine("Choose a language: ");
Console.WriteLine("1. English");
Console.WriteLine("2. Norwegian");
Console.WriteLine("3. Swedish");
Console.WriteLine("4. Vietnamese");

var l = Console.ReadLine();
Greeting? greeting = null;

switch (l)
{
    case "1":
        greeting = new Greeting(Languages.English);
        break;

    case "2":
        greeting = new Greeting(Languages.Norwegian);
        break;

    case "3":
        greeting = new Greeting(Languages.Swedish);
        break;

    case "4":
        greeting = new Greeting(Languages.Vietnamese);
        break;
}

if (greeting != null)
{
    greeting.SayHi();
}

