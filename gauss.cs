using System;
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
                    if(j == 0)
                    {
                        if (matgauss[i, j] > 0)
                        {
                            Console.Write(" "+matgauss[i, j] + "x ");
                        }
                        else
                        {
                            Console.Write(matgauss[i, j] + "x ");
                        }
                    }
                   if(j == 1)
                    {
                        if (matgauss[i, j] > 0)
                        {
                            Console.Write("+" + matgauss[i, j] + "y ");
                        }
                        else
                        {
                            Console.Write(matgauss[i, j] + "y ");
                        }
                    }
                   if (j == 2)
                    {
                        if (matgauss[i, j] > 0)
                        {
                            Console.Write("+" + matgauss[i, j] + "z = ");
                        }
                        else
                        {
                            Console.Write(matgauss[i, j] + "z = ");
                        }
                    }
                   if (j == 3)
                    {
                        if (matgauss[i, j] > 0)
                        {
                            Console.Write(" " + matgauss[i, j]);
                        }
                        else
                        {
                            Console.Write(matgauss[i, j]);
                        }
                    }
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
                    if (i == 1 && j >= 1)
                    {
                        matgauss[i, j] = (((matgauss[0, 0]) * (matgauss[i, j])) - ((matgauss[1, 0]) * (matgauss[i - 1, j])));
                    }
                    
                    if (i == 2 && j >= 1)
                    {
                        matgauss[i, j] = (((matgauss[0, 0]) * (matgauss[i, j])) - ((matgauss[2, 0]) * (matgauss[i - 2, j])));
                    }
                    
                    
                }
                Console.WriteLine();
            }

            


           

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                   
                    if ((i == 2)&&(j >= 2))
                    {
                        matgauss[i, j] = (((matgauss[1,1]) * (matgauss[i, j])) - ((matgauss[2, 1]) * (matgauss[i - 1, j])));
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
            
        }
    }
}
