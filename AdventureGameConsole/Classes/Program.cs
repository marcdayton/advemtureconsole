using System;

namespace AdventureGameConsole
{
    class Program
    {
    static void Main(string[] args)
        {
            string userInput;
            bool userQuit = false;


            while (!userQuit)
            {
                Console.Write("What will you do? :>");

                userInput = Console.ReadLine();
                if(userInput != "quit")
                {


                }
                else { userQuit = true; }
            }
        }

    }
}
