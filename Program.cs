
using System;
//Write a program that asks for three integers
//Compare them and display the largest number and the smallest number
namespace HW_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int val1;
            int val2;
            int val3;
            string entry;


            Console.WriteLine("Enter the Number");
            val1 = val2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the next Number");
            entry = Console.ReadLine();

            while (entry != "H")
            {
                val3 = Convert.ToInt32(entry);

                if (val3 > val1)
                {
                    val1 = val3;
                }
                else if (val3 > val2)
                {
                    val2 = val3;
                }
                Console.WriteLine("Enter the Number or Exit");
                entry = Console.ReadLine();

            }
            Console.WriteLine(" Largest number is : " + val1 + " . ");
            Console.WriteLine(" Smallest number is : " + val2 + " . ");
            Console.ReadLine();
        }
    }
}