using System;

namespace Excercise_13
{
    class Program
    {
        static void Main(string[] args)
        //User inputs am integer

        //Console output the number and counts down to zero

        //Console asks if the user wants to enter another number
        {
           

            while (true)
            {
                Console.Write("Hello user please enter a number: ");
                int userNumber = int.Parse(Console.ReadLine());

                for (int i = userNumber; i >= 0; --i)

                {

                    Console.WriteLine(i);



                }

                Console.WriteLine("Would you like to input another number? Y or N");
                string userInput = Console.ReadLine().ToLower();

                if (userInput == "n")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
            }


        }
    }
}
