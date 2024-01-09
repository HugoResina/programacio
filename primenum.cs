using System;
public class primerec
{
    public static void Main(string[] args)
    {
        int num;
        int secondnum;
        num = Convert.ToInt32(Console.ReadLine());
        secondnum = num - 1;
        Console.WriteLine("si surt 0 no es primer, si dona 1 ho és");
        Console.WriteLine(Primerec(num, secondnum));
    }
    public static int Primerec (int n, int m)
    {
        if ((n % 2 == 0 && n != 2)||(n == 1))
        {
            return 0;
        }
        else
        {
            if (n / m == 0)
            {
                return 0;
            }
            else if (m > 2)
            {
               return Primerec(n, m-1);
            }
            else
            {
                return 1;
            }
        }
    }
}