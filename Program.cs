using System.ComponentModel;

namespace Assignment3_1_2
{
    internal class Program
    {
        // If year is leap(Divisible by 4, not divisible by 100 unless divisible by 400). Given a year as integer, write a method that checks if year is leap.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year ex.(2016 equals True, 2018 equals false)");
            Console.Write("Year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CheckForLeapYear(year));
        }

        // First rule out whether the year is divisible by 4, if not return false
        // If true, check if year is divisible by 100 and NOT divisible by 400, if this is true return false, else return true.
        static bool CheckForLeapYear(int yearToCheck)
        {
            if (yearToCheck % 4 == 0)
            {
                if(yearToCheck % 100 == 0 && yearToCheck % 400 != 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
            
        }
    }
}
