
// Läs in namnet
Console.WriteLine("Hello, what is your name?");

string name = Console.ReadLine();

Console.WriteLine($"Hello {name}");

// Kolla om namnet är Micke eller Karl
if (name == "Micke")
{
  Console.WriteLine("Du skrev in rätt namn!");

}
else if (name == "Karl")
{
  Console.WriteLine("Wtf, Karl?");
}
else
{
  Console.WriteLine("Du skrev in fel namn!");
}



Console.ReadLine();