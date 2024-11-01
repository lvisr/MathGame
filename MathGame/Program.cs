using System.Collections.Generic;
// MathGame + - * / history
class MathGame 
{
    static String[] menuOptions = new string[] {"1", "2", "3", "4", "5", "6", "exit"};
    static int number1;
    static int number2;
    static int result;
    static bool exit = false;
    static List<String[]> previousGames = new List<String[]>();
    //previousGames.Add(new String[4]);
    static String[] index = {"game#", "Operation", "A", "B", "Result"};
    
    static void Main()
    {
        //previousGames.Add(index);
        previousGames.Add(new String[5]);
        while (!exit)
        {       
            
            DisplayMenu();
            String? input = GetMenuInput();
            if (input is null)
                Console.WriteLine("Invalid input");
            else
            {
                //Console.WriteLine($"Selected Option {input}");
                switch (input.ToLower())
                {
                    case "1":{
                        //Addition();
                        Console.Clear();
                        Console.WriteLine("**********      Addition   A+B=      **********");
                        Console.Write("\n\tA=");
                        number1 = GetInputNumber();
                        Console.Write("\n\tB=");
                        number2 = GetInputNumber();
                        result = number1 + number2;
                        Console.WriteLine($"\n\t{number1} + {number2} = {result}");
                        AddToHistory(input, number1, number2, result);
                        break;
                    }
                    case "2":{
                        //Subtraction();
                        Console.Clear();
                        Console.WriteLine("**********      Subtraction   A-B=      **********");
                        Console.Write("\n\tA=");
                        number1 = GetInputNumber();
                        Console.Write("\n\tB=");
                        number2 = GetInputNumber();
                        result = number1 - number2;
                        Console.WriteLine($"\n\t{number1} - {number2} = {result}");
                        AddToHistory(input, number1, number2, result);
                        break;
                    }
                    case "3":{
                        //Multiplication();
                        Console.Clear();
                        Console.WriteLine("**********      Multiplication   AxB=      **********");
                        Console.Write("\n\tA=");
                        number1 = GetInputNumber();
                        Console.Write("\n\tB=");
                        number2 = GetInputNumber();
                        result = number1 * number2;
                        Console.WriteLine($"\n\t{number1} x {number2} = {result}");
                        AddToHistory(input, number1, number2, result);
                        break;
                    }
                    case "4":{
                        //Division();
                        Console.Clear();
                        Console.WriteLine("**********       Division   A/B=        **********");
                        do
                        {
                            Console.WriteLine("\nDivisions that result in whole numbers only");
                            do
                            {
                                Console.Write("\tA=");
                                number1 = GetInputNumber();
                                if (number1 <0 || number1 >100)
                                    Console.WriteLine("Dividend must be between 0 and 100");
                            } while (number1 <0 || number1 >100);
                            do
                            {
                                Console.Write("\tB=");
                                number2 = GetInputNumber();
                                if (number2 == 0)
                                    Console.WriteLine("Divisor can't be 0");
                            } while (number2 == 0);
                        } while (number1 % number2 != 0);

                        result = number1 / number2;
                        Console.WriteLine($"\n\t{number1} / {number2} = {result}\n");
                        AddToHistory(input, number1, number2, result);
                        break;
                    }
                    case "5":{
                        Console.Clear();
                        Console.WriteLine("**********      Games History      **********\n");
                        int i = 0;
                        foreach (string[] game in previousGames)
                        {
                            //  {"game#", "Operation", "A", "B", "Result"};
                            if (i != 0)
                                Console.WriteLine($"Game #{game[0]}\t\t{game[2]}{game[1]}{game[3]} = {game[4]}");
                            i++;
                        }
                        break; 
                    }                                        
                    case "6":{
                        exit = true;
                        break;
                    }
                    case "exit":{
                        exit = true;
                        break;
                    }
                    default:
                        break;
                }
                if (!exit) {
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadLine();
                }
            }
        }
    }

    static void AddToHistory(string OperationId, int A, int B, int result)
    {
        String[] game = new string[5]; 
        //  {"game#", "Operation", "A", "B", "Result"};
        game[0] = previousGames.Count.ToString();
        switch (OperationId)
        {
            case "1":{
                game[1] = "+";
                break;
            }
            case "2":{
                game[1] = "-";
                break;
            }
            case "3":{
                game[1] = "x";
                break;
            }
            case "4":{
                game[1] = "/";
                break;
            }
            default:
                break;
        }
        game[2] = A.ToString();
        game[3] = B.ToString();
        game[4] = result.ToString();
        previousGames.Add(game);
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
                //Console.WriteLine($"Valid integer: {inputValue}");
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