public class Program
{
    static int numOfDice;
    static string answer;
    static Random diceroll = new Random();
    static bool goAgain = true;
    public static void Main()
    {
        Console.WriteLine("Welcome to the Grand Circus Casino!");
        while (goAgain == true)
        {
            try
            {
                numOfDice = GetUserNumber("How many sides should each die have?");
                answer = GetUserInput("Would you like to roll the dice? y or n: ");

                if (answer == "n" || answer == "n")
                {
                    Console.WriteLine("Safe bet");
                    
                }
                else
                {
                    
                    RandomDiceRoll(numOfDice);
                   
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("I'm sorry the number needs to be positive.");
                break;
            }


            goAgain = RunAgain();




        }
        static bool RunAgain()
        {
            string answer = GetUserInput("Would you like to roll dice again? Please enter y or n").ToLower();

            if (answer == "y" || answer == "yes")
                return true;
            else if (answer == "n" || answer == "no")
            {
                Console.WriteLine("Goodbye!");
                return false;
               
            }
            else
            {
                Console.WriteLine("I'm sorry I didn't understand that response. Please enter y or n");
                return RunAgain();
            }
        }
        static string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            return input;
        }
        static int GetUserNumber(string prompt)
        {
            Console.WriteLine(prompt);
            try
            {
                int input = int.Parse(Console.ReadLine());
                return input;
            }

            catch (FormatException e)
            {
                Console.WriteLine("I'm sorry that is not a valid input please use a positive number.");
                return GetUserNumber(prompt);
            }
            
        }   
            static void RandomDiceRoll(int numOfDice)
        {
            while (true)
            {
                try
                {
                    int roll1 = diceroll.Next(1, numOfDice + 1);
                    int roll2 = diceroll.Next(1, numOfDice + 1);
                    int total = roll1 + roll2;
                    Console.WriteLine($"You rolled a {roll1} and a {roll2} which is a total of {total}.");
                    while (numOfDice == 6)
                    {


                        if (roll1 == 1 && roll2 == 1)
                        {
                            Console.WriteLine("Snake Eyes!");
                        }
                        else if (roll1 == 1 && roll2 == 2)
                        {
                            Console.WriteLine("Ace Deuce!");
                        }
                        else if (roll1 == 2 && roll2 == 1)
                        {
                            Console.WriteLine("Ace Deuce");
                        }

                        else if (roll1 == 6 && roll2 == 6)
                        {
                            Console.WriteLine("Box Cars!");
                        }
                        else if (total == 7 || total == 11)
                        {
                            Console.WriteLine("Win!");
                        }
                        else if (total == 2 || total == 3 || total == 12)
                        {
                            Console.WriteLine("Crap!");
                        }
                        break;
                    }
                    
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("The dice can't be negative please try a positive number");
                }


                break;


            }

        }
    }
}
