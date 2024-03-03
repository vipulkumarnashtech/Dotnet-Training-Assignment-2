using System;
using System.Globalization;
using System.Text;

namespace PascalCaseGenerator;

class Program
{
    static void Main(string[] args)
    {
        //Take input from the user
        Console.WriteLine("Enter a few words separated by space:");
        string input = Console.ReadLine();

        //Display the variable name in Pascal Case
        string pascalCaseName = ConvertToPascalCase(input);
        Console.WriteLine("PascalCase Variable Name: " + pascalCaseName);
    }

    static string ConvertToPascalCase(string input)
    {
        StringBuilder pascalCaseBuilder = new StringBuilder();

        bool capitalizeNext = true;
        //Traverse over each character in the string
        foreach (char c in input)
        {
            //Checks if the character is a letter or a digit
            if (char.IsLetterOrDigit(c))
            {
                if (capitalizeNext)
                {
                    pascalCaseBuilder.Append(char.ToUpper(c));
                    capitalizeNext = false;
                }
                else
                {
                    pascalCaseBuilder.Append(char.ToLower(c));
                }
            }
            else
            {
                capitalizeNext = true;
            }
        }

        return pascalCaseBuilder.ToString();
    }
}
