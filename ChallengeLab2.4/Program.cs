/*
Write a C# Sharp program that takes a number and a width also a number, as input and then displays a triangle of that width, using that number.
Test Data
Enter a number: 6
Enter the desired width: 6
Expected Output:
666666
66666
6666
666
66
6
*/

namespace ChallengeLab2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App takes any choice number and any choice width, then makes a triangle out of it:");
            Console.WriteLine("Enter any number of choice: ");
            int numberChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now enter any number as a desired width to start with:");
            int widthChoice = Convert.ToInt32(Console.ReadLine());

            
            for (int i = widthChoice; i >= 1; i--) 
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(numberChoice);
                }
                Console.WriteLine();
            }
            
        }
    }
}
