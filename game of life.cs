using System;
public class conwaysgameoflife
{
    public static void Main(string[] args)
    {
        int neighbourCounter = 0;
        int[,] grit = new int[50, 50];


    }
    public static bool checkBox(int[,] grit , int neighbourCounter)
    {
        for (int i = 0; i < grit.GetLength(0); i++)
        {
            for (int j = 0; j < grit.GetLength(1); j++)
            {
                if (grit[i, j])
                {

                }
            }
        }
    }
}