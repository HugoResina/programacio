using System;
using System.Text.RegularExpressions;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Introdueix el teu Gmail:");
        string cadena = Console.ReadLine()??"";
        if (ValidateLettersNums(cadena))
        {
            Console.WriteLine("es una cadena valida");
        }
        else
        {
            Console.WriteLine("no es valida");
        }

    }

    public static bool ValidateLettersNums(string cadena)
    {
        /*bool valid = cadena.All(char.IsLetterOrDigit);

        if (!valid) 
        {
            return false;
        }
        return valid;
        */

        bool valid = true;
        foreach (char c in cadena) 
        {
            bool noNumLetter = Regex.IsMatch(c.ToString(), "^[a-zA-Z_0-9]");
            if (!noNumLetter)
            {
                valid = false;
            }
        }
        if (!valid) 
        {
            return false;
        }
        return valid;
    }
}