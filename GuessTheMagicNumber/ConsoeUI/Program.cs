using ConsoleUI;


partial class Program
{
    static void Main(string[] args)
    {
        #region Task List
        //TODO: Display menu
        //TODO: Generate a random number between 1-100
        //TODO: Ask user for their guess
        //TODO: Check if users guess matches target number
        //TODO: If guess matches, Congratulate the user, display magic number, and number of attempts
        //TODO: If guess does not match increment attempts by 1
        #endregion

        
        DisplayHeader();
        string userName = ConsoleFunctions.GetName();
        DisplayRules(userName);
        DisplayMenu();
        ConsoleFunctions.GetDifficultly();
    }
}

