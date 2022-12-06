Console.Write("Please, enter your name: ");
string username = Console.ReadLine();

if (username.ToLower() == "dasha")
{
    Console.WriteLine("Welcome back, Dasha!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}