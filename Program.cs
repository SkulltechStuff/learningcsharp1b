namespace learningcsharp1;
class Program
{
    static void Main(string[] args)
    {
        string username = "Kat";

        Console.WriteLine("Hello, User!");
        Console.WriteLine("Please enter your name");
        username = Console.ReadLine();
        Console.WriteLine($"Goodbye, {username}!");
        Console.WriteLine("How are you?");
        Console.ReadKey(true);
    }
}
