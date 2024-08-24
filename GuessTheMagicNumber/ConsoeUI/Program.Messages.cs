partial class Program
{
    public static void DisplayHeader()
    {
        Console.WriteLine("Welcome to Guess the Magic Number!");
    }

    public static void DisplayGetName()
    {
        Console.Write("Please enter your name: ");
    }

    public static void DisplayRules(string name)
    {
        Console.Clear();
        Console.WriteLine($"Hello, {name}.");
        Console.WriteLine("The rules to this game are simple.");
        Console.WriteLine("I have a number between a certain range of numbers stored in memory.");
        Console.WriteLine("Do you think you could guess the number?");
        Console.WriteLine("The range and number of attempts before the game will end depends on the difficulty selected.");
    }

    public static void DisplayMenu()
    {
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine("Difficullty: ");
        Console.WriteLine("------------");
        Console.WriteLine("1) Easy\n2) Normal\n3) Hard");
        Console.Write(">>> ");
    }
}
