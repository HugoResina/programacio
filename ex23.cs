using System;
using System.Drawing;
using System.Reflection.Metadata;

public class ex23
{
    public static void Main(string[] args)
    {
        double  baserect, heightrect,  pentagonside;
        decimal squareside;
        float radius;

        Console.WriteLine("escull de quin poligon vols el area?");
        Console.WriteLine("A.-Quadrat\nB.-Rectangle\nC.-Cercle\nD.-Pentagon");
        string letter = Console.ReadLine() ?? "";
        letter = letter.ToUpper();

        switch (letter)
        {
            case "A":
                Console.WriteLine("introdueix la mesura del costat del cuadrat (m):");
                squareside = Convert.ToDecimal(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("area del cuadrat:");
                Console.WriteLine(String.Format("{0:0.00}", area(squareside)) + " m^2");
                break;
            case "B":
                Console.WriteLine("introdueix la mesura de la base del rectangle(m):");
                baserect = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("introdueix la mesura de l'alçada del rectangle(m):");
                heightrect = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("area del rectangle:");
                Console.WriteLine(String.Format("{0:0.00}", area(baserect, heightrect)) + " m^2");
                break;
            case "C":
                Console.WriteLine("introdueix la mesura del radi del cercle(m):");
                radius = Convert.ToSingle(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("area del cercle:");
                Console.WriteLine(String.Format("{0:0.00}", area(radius)) + " m^2");
                break;
            case "D":
                Console.WriteLine("introdueix la mesura del costat del pentagon(m):");
                pentagonside = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("area del pentagon:");
                Console.WriteLine(String.Format("{0:0.00}", area(pentagonside)) + " m^2");
                break;
        }
    }
 
    public static decimal area(decimal squareside)
    {
        return squareside * squareside;
    }
    public static double area(double pentagonside)
    {
        //*(Math.PI / 180) para pasar a radianes(la libreria math de c# usa radianes!!!)
        double apotema = pentagonside / (2 * Math.Tan(36 * (Math.PI / 180)));
        return ((pentagonside * 5 * apotema) / 2);
    }
    public static double area(double baserect, double heightrect)
    {
        return baserect * heightrect;
    }
    public static double area(float radius)
    {
        return Math.PI * (Math.Pow(radius, 2));
    }
   
}