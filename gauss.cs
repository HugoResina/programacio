﻿using System;
namespace gauss
{
    public class hugoResina
    {
        public static void Main(string[] args)
        {
            const int rows = 3;
            const int columns = 4;


            int[,] matfix = new int[rows, columns];
            int[,] matgauss = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matgauss[i, j] = matfix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("matriu que sera transformada");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matgauss[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("matriu que quedara fixa");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matfix[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            //canvi valors pre 0

            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (i == 2 && j >= 2)
                    {
                        matgauss[i, j] = (((matgauss[1, 1]) * (matgauss[i, j])) - ((matgauss[2, 1]) * (matgauss[i - 1, j])));
                    }
                    /*
                    if (i == 3 && j >= 2)
                    {
                        matgauss[i, j] = (((matgauss[1, 1]) * (matgauss[i, j])) - ((matgauss[3, 1]) * (matgauss[i - 2, j])));
                    }
                    */
                    
                }
                Console.WriteLine();
            }

            //escriure matriu 
            Console.WriteLine("matriu triangulada i calculada intent");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matgauss[i, j] + " ");
                }
                Console.WriteLine();
            }



            /*

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                   
                    if ((i == 3)&&(j >= i))
                    {
                        matgauss[i, j] = (((matgauss[2,2]) * (matgauss[i, j])) - ((matgauss[3, 2]) * (matgauss[i - 1, j])));
                    }
                    

                }
                Console.WriteLine();
            }



            

            Console.WriteLine();
            Console.WriteLine();


            //triangulació

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j < i)
                    {
                        matgauss[i, j] = 0;
                    }

                }
                Console.WriteLine();

            }

            //escriure matriu 
            Console.WriteLine("matriu triangulada i calculada");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matgauss[i, j] + " ");
                }
                Console.WriteLine();
            }
            */
        }
    }
}
