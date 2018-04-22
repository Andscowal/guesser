using System;

//Namespace
namespace Numbers
{
    //Main Class
    class Program
    {
        //Entry Point
        static void Main(string[] args)
        {
            GetAppInfo(); //Run GetAppInfo function

            GreetUser(); //Greet the user

            while (true)
            {
                //Create a new Random object
                Random random = new Random();

                //Init correct number
                int correctNumber = random.Next(1, 11);

                //Init guess var
                int guess = 0;

                //Get user's number
                Console.WriteLine("Guess a number between 1 and 10");

                //While guess is not correct
                while (guess != correctNumber)
                {
                    //Get user input
                    string input = Console.ReadLine();

                    //Make sure a number has been enterred
                    if (!int.TryParse(input, out guess))
                    {
                        
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please enter a number");
                        //Keep going
                        continue;
                    }

                    //Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess to correctNumber
                    if (guess != correctNumber)
                    {
                        
                     //Print error message
                     PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }

                }

                //Output success message
                PrintColorMessage(ConsoleColor.Yellow, "You are correct!");

                //Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y") {
                    continue;
                } 
                else if (answer == "N"){
                    return;
                }
                else {
                    return;
                }
            }
        }

        //Get and display app info
        static void GetAppInfo() {
            //Set Variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Andrew Walters";

            //Set Console Color
            Console.ForegroundColor = ConsoleColor.Magenta;

            //App Info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset Console Color
            Console.ResetColor();
        }

        //Greet user
        static void GreetUser() {
            //Get user's name
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            //Greetings!
            Console.WriteLine("Hello {0}, let's play a game!", inputName);

        }

        //Print color message
        static void PrintColorMessage(ConsoleColor color, string message) {

            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}