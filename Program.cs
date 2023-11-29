using System;

namespace PositiveNumbertoExcelColumnName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter positive integers to convert to Excel column names. Enter a non-positive number to exit.");

        while (true)
        {
            Console.Write("Enter a positive integer: ");
            // To check the positive int
            if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
            {
                string columnName = NumberToTitle(number);
                Console.WriteLine($"Number: {number}  =>  Column Name: {columnName}");
            }
            else
            {
                Console.WriteLine("Exiting the program.");
                break;
            }
        }
        }
        static string NumberToTitle(int number)
       {
        return ConvertToTitleRecursive(number);
       }

        static string ConvertToTitleRecursive(int number)
        {
        if (number == 0)
        {
            return "";
        }
        // to check the column name
        int remainder = (number - 1) % 26;
        char digit = (char)('A' + remainder);
        return ConvertToTitleRecursive((number - 1) / 26) + digit;
        }
        }
    
}
