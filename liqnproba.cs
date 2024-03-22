using System;
using System.Diagnostics;
using System.Timers;
public class Program
{
    public static void Main()
    {
        List<int> nums = new List<int>{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -1, -2, -3, -4, -5, -6, -7, -8, -9, -10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        List<int> list = new List<int> { 1,6,3,6,4,2,1,6,8,5,2,1,5,8,5,3,1,5,8};
        string paraula = "mes enlla del be i el mal";

        
        //ex 1
        Console.WriteLine("ex1");
        var parells = from x in nums
                      where x%2 == 0
                      select x;
        foreach (int x in parells)
        {
            Console.WriteLine(x);
        }
        //ex 2
        Console.WriteLine("ex2");
        var positius = from x in nums
                       where x>0
                       select x;
        foreach (int x in positius)
        {
            Console.WriteLine(x);
        }
        //ex 3
        Console.WriteLine("ex3");
        var over20 = from x in nums
                     where x>20
                     select x;
        foreach(int x in over20)
        {
            Console.WriteLine(x + " quadrat: " + x*x);
        }
        //ex 4
        Console.WriteLine("ex4");
        //Console.WriteLine("introdueix el numero que vols contar en la llista:");
        //int num = Convert.ToInt16(Console.ReadLine());
        int num = 5;
        var numtimes = from x in list
                       where x == num
                       select x;
        int times = numtimes.Count();
        Console.WriteLine("el numero " + num + " apareix " + times + " cops");

        //ex 5
        Console.WriteLine("ex 5");
        List<char> chars = new List<char>();
        foreach (char c in paraula)
        {
            if (!(chars.Contains(c) || c.ToString() == " "))
            {
                chars.Add(c);
                var numchar = from x in paraula
                              where x == c
                              select x;
                int timeschar = numchar.Count();
                Console.WriteLine(c + " apareix " + timeschar + " cops");
            }
        }

        //ex 6
        Console.WriteLine("ex 6 aka basura");

        //ex 7      
        Console.WriteLine("ex 7");
        List<int> norep = new List<int>();
        foreach (int n in list)
        {
            if (!norep.Contains(n))
            {
                norep.Add(n);   
                var timesnum = from x in list
                               where x == n
                               select x;
                int count = timesnum.Count();
                Console.WriteLine(n + " apareix " + count + " cops, " + n + "*" + count + "= " + n * count);
            }
        }
        //ex 8
        Console.WriteLine("ex 8");
        
        List<string> ciutats = new List<string> { "ROMA", "LONDRES", "NAIROBI", "CALIFÒRNIA", "ZURICH", "NOVA DELHI", "AMSTERDAM", "ABU DHABI", "PARÍS"};
        char first = 'A';
        char last = 'M';

            var ciu = from x in ciutats
                        where x.StartsWith(first) && x.EndsWith(last)
                        select x;

        foreach(var ci in ciu)
        {
            Console.WriteLine(ci);
        }

        //ex 9
        Console.WriteLine("ex 9");

        List<int> ints = new List<int>();
        Console.WriteLine("introdueix 15 numeros:");
        for (int i = 0; i <  15; i++)
        {
            int numadd = Convert.ToInt32(Console.ReadLine());
            ints.Add(numadd);
        }
        var Gt80 = from x in ints
                   where x > 80
                   select x;
        Console.WriteLine("valors majors a 80;");
        foreach (var g in Gt80)
        {
            Console.WriteLine(g);
        }

        //ex 10
        Console.WriteLine("ex 10");


    }
}