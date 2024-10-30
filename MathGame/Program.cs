// MathGame + - * / history
class MathGame 
{
    static String[] menuOptions = new string[] {"1", "2", "3", "4", "5", "6", "exit"};
    static int number1;
    static int number2;
    static int result;
    static void Main()
    {
        DisplayMenu();
        String? input = GetMenuInput();
        Console.WriteLine($"Selected Option {input}");
        if (input is null)
            Console.WriteLine("Invalid input");
        else

        {
            switch (input.ToLower())
                {
                    case "1":{
                        //Addition();
                        Console.Clear();
                        Console.WriteLine("*****  Addition  *****");
                        Console.Write("\nPlease enter the first integer: ");
                        number1 = GetInputNumber();
                        Console.Write("\nPlease enter the second integer: ");
                        number2 = GetInputNumber();
                        result = number1 + number2;
                        Console.WriteLine($"\n {number1} + {number2} = {result}");

                        break;
                    }
                    case "6":{
                        break;
                    }
                    case "exit":{
                        break;
                    }
                    default:
                        break;
                }
        }
    }

    static int Addition (int number1, int number2)
    {
        return number1 + number2;
    }
    //Display menu - select 1 to 5 or exit
    static void DisplayMenu ()
    {
        Console.Clear();
        Console.WriteLine("*****     MATH GAME     *****\n");
        Console.WriteLine("   1 - Addition");
        Console.WriteLine("   2 - Subtraction");
        Console.WriteLine("   3 - Multiplication");
        Console.WriteLine("   4 - Division");
        Console.WriteLine("   5 - Show operations history\n");
        Console.WriteLine("   6 - Exit");
    }
    //User input
    static String? GetMenuInput()
    {
        String? menuInput;
        do
        {
            Console.Write("\nType option number or Exit: ");
            menuInput = Console.ReadLine();
            if (menuInput is null)
                continue;
            else
                menuInput = menuInput.ToLower();
        }
        while (!MathGame.menuOptions.Contains(menuInput));

        return menuInput;
    }

    static int GetInputNumber()
    {
		string? input;
		int inputValue;
        bool success = false;

        while (!success)
        {
            input = Console.ReadLine();
            success = Int32.TryParse(input, out inputValue);
            if (success)
            {   
                Console.WriteLine($"Valid integer: {inputValue}");
                return inputValue;
            }
            else
            {
                Console.Write($"\nInvalid input. Please enter a valid integer: ");
            }
        }
        return 0;
    }
}