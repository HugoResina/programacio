using Predicate;
using System;
public class Program
{
    public delegate double Exp(int x, int y);
    public delegate double SqR(int x);
    public delegate double Avg(int[] ints);
    public delegate string EoO(int x);
    public delegate int Fibb(int x);
    public static void Main()
    {
        Exp power = Helper.Exponent;
        SqR root = Helper.SquareR;
        Avg avarage = Helper.Avarage;
        EoO evenOrOdd = Helper.EvenOrOdd;
        Fibb FibbonacciPosition = Helper.Fibonacci;

        int x = 25;
        int y = 2;
        int[] arraynums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        /*
        Console.WriteLine("introdueix un valor x");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("introdueix un valor y");
        y = Convert.ToInt32(Console.ReadLine());
        */

        double result = power(x, y);  
        Console.WriteLine("resultat potencia: " + result);
        double result2 = root(x);
        Console.WriteLine("resultat arrel: " + result2);

        double avg = avarage(arraynums);
        Console.WriteLine("valor mitja: " +  avg);

        Console.WriteLine(evenOrOdd(x));

        Console.WriteLine("introdueix la posicio a comprovar de la successio de fibonacci");
        int pos = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("el numero en la posicio " + pos + " és: " + FibbonacciPosition(pos));
    }
}