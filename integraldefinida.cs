using System;
namespace integraldefinida
{
    public class frikada
    {
        public static void Main(string[] args)
        {
            int num = 0;
            int secondnum = 2;
            double div = 1000000;
            double counter = 0;
            double sumarea = 0;

            


            /*en aquest cas es dos, pero aquest dos seria la distancia entre els numeros 
            que defineixen la integral.*/
            //tambe en un futur, la funcio a integrar i els valors que la defineixen seran introduits per teclat.

            double fakeintegral = 2 / div;
            Console.WriteLine( "/"+secondnum+ "\n|\n|  X^2 + 3X - 5 =  \n/"+num);

            while (counter < 2)
            {
                counter += fakeintegral;
                double area = fakeintegral * (Math.Pow(counter, 2) + (3*counter) - 5);
                sumarea += area;
            }
            Console.WriteLine(sumarea);


        }
    }
}