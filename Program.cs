using System;
class transposta
{
    static void Main(string[] args)
    {
        const int rows = 7;
        const int columns = 3;

        int[,] matriu = new int[rows, columns];
        int[,] trans = new int[columns, rows];

        for (int i = 0; i < matriu.GetLength(0); i++)
        {
            for (int j = 0; j < matriu.GetLength(1); j++)
            {
                matriu[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        for (int i = 0; i < matriu.GetLength(0); i++)
        {
            for (int j = 0; j < matriu.GetLength(1); j++)
            {
                Console.Write(matriu[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        for (int j = 0; j < matriu.GetLength(0); j++)
        {
            for (int i = 0; i < matriu.GetLength(1); i++)
            {
                trans[i,j] = matriu[j,i];
            }
        }

        for (int i = 0; i < trans.GetLength(0); i++)
        {
            for (int j = 0; j < trans.GetLength(1); j++)
            {
                Console.Write(trans[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}