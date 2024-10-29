// MathGame + - * / history
String[] menuOptions = new string[] {"1", "2", "3", "4", "5", "6", "exit"};
DisplayMenu();
String input = GetMenuInput();
Console.WriteLine($"Selected Option {input}");
/* switch (input)
{
    case "1":
    {
        //Addition();
        break;
    }
    default:
} */
//Display menu - select 1 to 5 or exit
void DisplayMenu ()
{
    Console.Clear();
    Console.WriteLine("*****     MATH GAME     *****\n");
    Console.WriteLine("\tSelect Option:");
    Console.WriteLine("   1 - Addition");
    Console.WriteLine("   2 - Subtraction");
    Console.WriteLine("   3 - Multiplication");
    Console.WriteLine("   4 - Division");
    Console.WriteLine("   5 - Show operations history\n");
    Console.WriteLine("   6 - Exit\n");

}
//User input
String GetMenuInput()
{
    string? menuInput;
    do
    {
        menuInput = Console.ReadLine();
    }
    while (!menuOptions.Contains(menuInput.ToLower()));
    
    //    Console.WriteLine("Invalid Input. Try Again...");
    
    
    return menuInput;
}
//switch case 1 to 5