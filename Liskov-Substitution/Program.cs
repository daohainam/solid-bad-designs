using Liskov_Substitution;

var r = new Rectangle(10, 20);
Console.WriteLine($"Rectangle (10, 20) Area: {r.GetArea()}");

r = new Square(10);
Console.WriteLine($"Square (10,10 ) Area: {r.GetArea()}");

r.Width = 20;
int area = r.GetArea();
Console.WriteLine($"Rectangle (20,10 ) Area: {r.GetArea()}");
if (area != 200)
{
    Console.WriteLine("What the hell???");
}
