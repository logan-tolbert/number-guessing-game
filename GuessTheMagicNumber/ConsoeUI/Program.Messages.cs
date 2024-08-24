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
        Console.WriteLine("I have a number between 1 and 100 stored in memory.");
        Console.WriteLine("Do you think you could guess the number?");
        Console.WriteLine("The number of attempts before failure depends on the difficulty selected.");
    }
}
