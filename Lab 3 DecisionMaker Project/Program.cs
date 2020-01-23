using System;

namespace Lab_3_DecisionMaker_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();

            string initialHello = "y";
            string userContinue = "y";

            while (userContinue == "y")
            {
                if (initialHello == "y")   //initial hello
                {
                    Console.WriteLine($"Hey {name}, please enter an integer between 1 and 100");
                    initialHello = "n";
                }
                
                int userInput = int.Parse(Console.ReadLine());

                if (userInput >= 1 && userInput <= 100)     //checks valid answer and removed redundant if else statments
                {
                    if (userInput % 2 == 1)
                    {
                        Console.WriteLine(userInput + " Odd.");
                    }
                    else
                    {
                        if (userInput >= 2 && userInput <= 25)
                        {
                            Console.WriteLine("Even and less than 25.");
                        }
                        else
                        {
                            Console.WriteLine("Even.");
                        }
                    }

                    userContinue = "";
                    while (userContinue != "y" && userContinue != "n")  //would you like to repeat?
                    {
                        Console.WriteLine($"Would you like to continue {name}? y/n?");
                        userContinue = Console.ReadLine();

                        if (userContinue == "n")
                        {
                            Console.WriteLine("OKBAI!!");
                        }
                        else if (userContinue == "y")
                        {
                            Console.WriteLine($"Okay {name}, please enter an integer between 1 and 100");   //stated if you want to repeat but has a different message
                        }
                        else
                        {
                            Console.WriteLine($"Hold up {name}.");  //enter valid "y" or "n" response
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Sorry {name}, that input was not valid. Please try entering another integer between 1 and 100");    //new message if you don't pass the validCheck
                }
            }
        }
    }
}

