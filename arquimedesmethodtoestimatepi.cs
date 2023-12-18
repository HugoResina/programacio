using System;
namespace ArquimedesPi
{
    public class Pi
    {
        public static void Main(string[] args)
        {
            double numsides;
            Console.WriteLine("introdueix els costats del poligon inscrit: ");
            numsides = Convert.ToDouble(Console.ReadLine());

            double side;
            double radius = 10;
            side = (2 * radius * (Math.Sin(180 / numsides)*(Math.PI/180)));
            double perimeter = side * numsides;
            double diametre = 2 * radius;
            Console.WriteLine("pi: " + (perimeter / diametre));
        }
    }
}