using System;
public class gauss
{
    public static void Main(string[] args)
    {
        char ple = 'X';

        int height = 16;
        int counter = 16;
        int balls = 30;
        int left = 0;
        int right = 0;
        int num = 0;

        int cell1counter = 0;
        int cell2counter = 0;
        int cell3counter = 0;
        int cell4counter = 0;
        int cell5counter = 0;
        int cell6counter = 0;
        int cell7counter = 0;
        int cell8counter = 0;
        int cell9counter = 0;
        int cell10counter = 0;
        int cell11counter = 0;
        int cell12counter = 0;
        int cell13counter = 0;
        int cell14counter = 0;
        int cell15counter = 0;
        int cell16counter = 0;
        int cell17counter = 0;
        Random rand = new Random();

        char[,] campana = new char[height, height];

        while (balls > 0)
        {
            
            while (counter > 0)
            {
                left = 0;
                right = 0;
                num = rand.Next(2);
                if (num == 0)
                {
                    right++;
                    counter--;
                }
                else if (num == 1)
                {
                    left++;
                    counter--;
                }
            }
                for (int i = 0; i < campana.GetLength(0); i++)
                {
                    for (int j = 0; j < campana.GetLength(1); j++)
                    {
                        switch (right)
                        {
                            case 0:
                                campana[ (height - cell1counter), j] = ple;
                                cell1counter++;
                                break;
                            case 1:
                                campana[ (height - cell2counter), j] = ple;
                                cell2counter++;
                                break;
                            case 2:
                                campana[ (height - cell3counter), j] = ple;
                                cell3counter++;
                                break;
                            case 3:
                                campana[ (height - cell4counter), j] = ple;
                                cell4counter++;
                                break;
                            case 4:
                                campana[ (height - cell5counter), j] = ple;
                                cell5counter++;
                                break;
                            case 5:
                                campana[ (height - cell6counter), j] = ple;
                                cell6counter++;
                                break;
                            case 6:
                                campana[ (height - cell7counter), j] = ple;
                                cell7counter++;
                                break;
                            case 7:
                                campana[ (height - cell8counter), j] = ple;
                                cell8counter++;
                                break;
                            case 8:
                                campana[ (height - cell9counter), j] = ple;
                                cell9counter++;
                                break;
                            case 9:
                                campana[ (height - cell10counter), j] = ple;
                                cell10counter++;
                                break;
                            case 10:
                                campana[ (height - cell11counter), j] = ple;
                                cell11counter++;
                                break;
                            case 11:
                                campana[ (height - cell12counter), j] = ple;
                                cell12counter++;
                                break;
                            case 12:
                                campana[ (height - cell13counter), j] = ple;
                                cell13counter++;
                                break;
                            case 13:
                                campana[ (height - cell14counter), j] = ple;
                                cell14counter++;
                                break;
                            case 14:
                                campana[ (height - cell15counter), j] = ple;
                                cell15counter++;
                                break;
                            case 15:
                                campana[ (height - cell16counter), j] = ple;
                                cell16counter++;
                                break;
                            case 16:
                                campana[ (height - cell17counter), j] = ple;
                                cell17counter++;
                                break;
                        }
                    }
                }
            counter = 16;
            balls--;
            }

        for (int i = 0; i < campana.GetLength(0); i++)
        {
            for (int j = 0; j < campana.GetLength(1); j++)
            {
                if (campana[i, j] == ple)
                {
                    Console.Write(ple + " ");
                }
                else
                {
                    Console.Write(" ");
                }

            }
            Console.WriteLine();
        }

    } 
    }



    
