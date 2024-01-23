using System;
public class Gameoflife
{
    public static void Main(string[] args)
    {
       int matrixSide = 25;
        
        Random rnd = new Random();
        int counter = 0;
        bool[,] grid = new bool[matrixSide,2*matrixSide];
        bool[,] auxGrid = new bool[matrixSide, 2*matrixSide];

        /*bool[,] grid = {{ false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false }};
        
     bool[,] auxGrid = {{ false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
                        { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false }};
        */
        //creacio de una matriu auxiliar igual a la principal


        for (int i = 0; i < grid.GetLength(0); i++)
        {
            for (int j = 0; j < grid.GetLength(1); j++)
            {
                auxGrid[i, j] = grid[i, j];
            }
        }
        //inicialitza la matriu amb cel·les aleatories vives(true) o mortes(false)
        for (int i = 0; i < grid.GetLength(0); i++)
        {
            for (int j = 0; j < grid.GetLength(1); j++)
            {
                int randomState = rnd.Next(2);
                if (randomState == 0)
                {
                    grid[i, j] = true;
                }
                else
                {
                    grid[i, j] = false;
                }
            }
        }

        do
        {
            Console.Clear();

            //asigna color segons el valor de la matriu
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {

                    if (grid[i, j])
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.DarkBlue;

                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }

                    Console.Write(" ");

                    Console.ResetColor();
                }
                Console.WriteLine();
            }
            //comprova el estat de cada cel·la per reasignar el seu valor(si cal)
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                   counter = counterFunc(grid, grid.GetLength(0), grid.GetLength(1), i, j);
                    
                    if (grid[i, j])
                    {
                        if (counter < 2)
                        {
                            auxGrid[i, j] = false;
                        }
                        else if (counter == 2 || counter == 3)
                        {
                            auxGrid[i, j] = true;
                        }
                        else if (counter > 3)
                        {
                            auxGrid[i, j] = false;
                        }

                    }
                    if (!grid[i, j] && counter == 3)
                    {
                        auxGrid[i, j] = true;
                    }
                }
            }

            //asignar el valor actualitzat a la matriu principal
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    grid[i, j] = auxGrid[i, j];

                }
            }
            Thread.Sleep(150);
        } while (true);

    }
    public static int counterFunc(bool[,] grid,int numfil,int numcol , int i, int j)
    {
        int counter = 0;
        if (j == 0)
        {
            //cantonada esquerra superior
            if (i == 0)
            {
                counter += (grid[i + 1, j]) ? 1 : 0;
                counter += (grid[i + 1, j + 1]) ? 1 : 0;
                counter += (grid[i, j + 1]) ? 1 : 0;
            }
            //cantonada esquerra inferior
            else if (i == numfil - 1)
            {
                counter += (grid[i, j + 1]) ? 1 : 0;
                counter += (grid[i - 1, j + 1]) ? 1 : 0;
                counter += (grid[i - 1, j]) ? 1 : 0;
            }
            //resta de costat esquerra
            else
            {
                counter += (grid[i + 1, j]) ? 1 : 0;
                counter += (grid[i + 1, j + 1]) ? 1 : 0;
                counter += (grid[i, j + 1]) ? 1 : 0;
                counter += (grid[i - 1, j + 1]) ? 1 : 0;
                counter += (grid[i - 1, j]) ? 1 : 0;
            }
        }
        //costat dreta
        else if (j == numcol - 1)
        {
            //cantonada dreta superior
            if (i == 0)
            {
                counter += (grid[i + 1, j - 1]) ? 1 : 0;
                counter += (grid[i, j - 1]) ? 1 : 0;
                counter += (grid[i + 1, j]) ? 1 : 0;
            }
            //cantonada dreta inferior
            else if (i == numfil - 1)
            {
                counter += (grid[i, j - 1]) ? 1 : 0;
                counter += (grid[i - 1, j - 1]) ? 1 : 0;
                counter += (grid[i - 1, j]) ? 1 : 0;
            }
            //resta de costat dreta
            else
            {
                counter += (grid[i, j - 1]) ? 1 : 0;
                counter += (grid[i - 1, j - 1]) ? 1 : 0;
                counter += (grid[i - 1, j]) ? 1 : 0;
                counter += (grid[i + 1, j]) ? 1 : 0;
                counter += (grid[i + 1, j - 1]) ? 1 : 0;
            }
        }
        //costat inferior sense cantonades
        else if (i == numfil - 1 && j != 0 && j != numcol - 1)
        {
            counter += (grid[i, j - 1]) ? 1 : 0;
            counter += (grid[i, j + 1]) ? 1 : 0;
            counter += (grid[i - 1, j - 1]) ? 1 : 0;
            counter += (grid[i - 1, j + 1]) ? 1 : 0;
            counter += (grid[i - 1, j]) ? 1 : 0;
        }
        //costat superior sense cantonades
        else if (i == 0 && j != 0 && j != numcol - 1)
        {
            counter += (grid[i, j + 1]) ? 1 : 0;
            counter += (grid[i + 1, j + 1]) ? 1 : 0;
            counter += (grid[i + 1, j - 1]) ? 1 : 0;
            counter += (grid[i + 1, j]) ? 1 : 0;
            counter += (grid[i, j - 1]) ? 1 : 0;
        }
        //graelles interiors
        else
        {
            counter += (grid[i + 1, j]) ? 1 : 0;
            counter += (grid[i - 1, j]) ? 1 : 0;
            counter += (grid[i, j + 1]) ? 1 : 0;
            counter += (grid[i, j - 1]) ? 1 : 0;
            counter += (grid[i + 1, j + 1]) ? 1 : 0;
            counter += (grid[i - 1, j - 1]) ? 1 : 0;
            counter += (grid[i + 1, j - 1]) ? 1 : 0;
            counter += (grid[i - 1, j + 1]) ? 1 : 0;
        }
        return counter;
    }
}