using System.Data.Common;
using System.Security.Cryptography;

namespace Exercise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problem 1
            //prompt for row width

            Console.Write("Enter number of rows");
            int rowWidth = int.Parse(Console.ReadLine());
            Console.Write("Enter row width");
            int numRows = int.Parse(Console.ReadLine());



            // print rows

            
            
            for (int i = 0; i < rowWidth; i++)
            {
                for (int j = 0; j < numRows; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();

                //print rows of asterisks
            }


            //.Problem 2

            // Prompt for max # asterisks
            Console.Write("Enter max asterisks");
            int numAsterisks = int.Parse(Console.ReadLine());


            // Loop to print rows of asterisks
            for (int currRow = 0; currRow < numAsterisks; currRow++)
            {   //print rows of asterisks

                for (int j = 0; j <= currRow; j++)
                {
                    // print asterisks on a row
                    Console.Write("*");

                }
                Console.WriteLine();

            }
        }


   






    }
}