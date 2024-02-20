using System;
using System.Data;
using System.Globalization;

public class cellularAutomata
{
    public static void Main()
    {
        bool[] row = new bool [81];

        bool[] row2 = new bool[81];

        int[] binNum = new int[8];

        row[40] = true;

        int ruleCounter = 0;

     
        //genera el binario
        Console.WriteLine("inserta el numero de la regla que vols visualitzar (0-255)");
        int numeroDecimal = Convert.ToInt32(Console.ReadLine());

        string binario = Convert.ToString(numeroDecimal, 2);

        

        int startAdd = binNum.Length - binario.Length;

        foreach (char b in binario)
        {
            binNum[startAdd + ruleCounter] = Convert.ToInt16(b.ToString());
            ruleCounter++;
        }
        for (int i = 0; i < binNum.Length; i++)
        {
            Console.Write(binNum[i]);
        }
        Console.WriteLine();
        do
        {


            //print
            for (int i = 0; i < row.Length; i++)
            {
                if (row[i])
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Thread.Sleep(100);
            Console.WriteLine();


            //asigna valors bool a el array que fa de pivot 
            for (int i = 0; i < row2.Length; i++)
            {
                if (i == 0)
                {
                    row2[i] = calculateNeighbourhood(row[row.Length - 1], row[i], row[i + 1], binNum);
                }
                else if (i == row.Length - 1)
                {
                    row2[i] = calculateNeighbourhood(row[i - 1], row[i], row[0], binNum);
                }
                else
                {
                    row2[i] = calculateNeighbourhood(row[i - 1], row[i], row[i + 1], binNum);
                }
            }



            for (int i = 0; i <= row2.Length - 1; i++)
            {
                row[i] = row2[i];
            };
        }while(true);

    }
    public static bool calculateNeighbourhood(bool numI, bool num, bool numD, int[] binNum)
    {
        //111
        if(numI && num && numD)
        {
            return binNum[0] != 0;
        }
        //110
        else if(numI && num && !numD) 
        { 
            return binNum[1] != 0;
        }
        //101
        else if (numI && !num && numD)
        {
            return binNum[2] != 0;
        }
        //100
        else if (numI && !num && !numD)
        {
            return binNum[3] != 0;
        }
        //011
        else if (!numI && num && numD)
        {
            return binNum[4] != 0;
        }
        //010
        else if (!numI && num && !numD)
        {
            return binNum[5] != 0;
        } 
        //001
        else if (!numI && !num && numD)
        {
            return binNum[6] != 0;
        }
        //000
        else if (!numI && !num && !numD)
        {
            return binNum[7] != 0;
        }
        return false;
    }
}