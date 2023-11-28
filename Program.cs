using System;
public class gauss
{
    public static void Main(string[] args)
    {
        char ple = 'X';

        int height = 16;
        int counter = 17;
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

        char[,] campana = new char[height, (height + 1)];

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
                for (int j = 0; j < campana.GetLength(0); j++)
                {
                    for (int i = 0; i < campana.GetLength(1); i++)
                    {
                        switch (right)
                        {
                            case 0:
                                campana[j, (height - cell1counter) ] = ple;
                                cell1counter++;
                                break;
                            case 1:
                                campana[j, (height - cell2counter)] = ple;
                                cell2counter++;
                                break;
                            case 2:
                                campana[j, (height - cell3counter)] = ple;
                                cell3counter++;
                                break;
                            case 3:
                                campana[j, (height - cell4counter)] = ple;
                                cell4counter++;
                                break;
                            case 4:
                                campana[j, (height - cell5counter)] = ple;
                                cell5counter++;
                                break;
                            case 5:
                                campana[j, (height - cell6counter)] = ple;
                                cell6counter++;
                                break;
                            case 6:
                                campana[j, (height - cell7counter)] = ple;
                                cell7counter++;
                                break;
                            case 7:
                                campana[j, (height - cell8counter)] = ple;
                                cell8counter++;
                                break;
                            case 8:
                                campana[j, (height - cell9counter)] = ple;
                                cell9counter++;
                                break;
                            case 9:
                                campana[j, (height - cell10counter)] = ple;
                                cell10counter++;
                                break;
                            case 10:
                                campana[j, (height - cell11counter)] = ple;
                                cell11counter++;
                                break;
                            case 11:
                                campana[j, (height - cell12counter)] = ple;
                                cell12counter++;
                                break;
                            case 12:
                                campana[j, (height - cell13counter)] = ple;
                                cell13counter++;
                                break;
                            case 13:
                                campana[j, (height - cell14counter)] = ple;
                                cell14counter++;
                                break;
                            case 14:
                                campana[j, (height - cell15counter)] = ple;
                                cell15counter++;
                                break;
                            case 15:
                                campana[j, (height - cell16counter)] = ple;
                                cell16counter++;
                                break;
                            case 16:
                                campana[j, (height - cell17counter)] = ple;
                                cell17counter++;
                                break;
                        }
                    }
                }
            counter = 17;
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



    
