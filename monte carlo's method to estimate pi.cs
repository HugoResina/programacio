using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace montecarlosmethodtoestimatepi
{
    public class pimontecarlo
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            
            
            int counter = 1;

            Console.WriteLine("que tan petit vols que sigui el error del calcul (10^-?)");
            int errorPow = Convert.ToInt32(Console.ReadLine());

            double aux = 3.14;
            double inside = 0;
            double pi= 0 ;
            double error = 1;
            Console.WriteLine("generara 10000 punts per iteració");
            double iteration = 10000;

            double cota = Math.Pow(10, -errorPow);

            while (error > cota)
            {
                for (int i = 0; i < iteration; i++) 
                {
                    int x = rnd.Next(0, 10000001);
                    int y = rnd.Next(0, 10000001);
                    
                    if (Math.Pow(x-5000000,2) + Math.Pow(y-5000000,2) <= Math.Pow(5000000,2))
                    {
                        inside++;
                    }

                }
                aux = pi;
                pi = ((inside/(counter*iteration))*4);
                error = Math.Abs(pi - aux);
                counter++;
            }
            Console.WriteLine("pi: " + pi);
            Console.WriteLine(counter-1);
            Console.WriteLine("auxiliar: "+aux);
            Console.WriteLine(inside);
            Console.WriteLine((counter-1)*(iteration));
        }
    }
        
}
