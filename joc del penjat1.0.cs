using System;
using System.Security.Cryptography.X509Certificates;

namespace practicapenjat
{
    public class HugoResina
    {
        public static void Main(string[] args)
        {

            const string asteriscs = "*********************************";
            const string welcome = "Benvolgut/da al joc del penjat!!!";
            const string chooseDif = "Escull el nivell de dificultat: ";
            const string difLevel = "A.Facil\nB.Normal\nC.Dificil\nD.Expert";
            const string youveChosen = "has seleccionat la dificulat ";
            const string pressAny = "prem cualsevol lletra per continuar...";
            const string writeText = "escriu un text per poder extreure una paraula per jugar,\ncontra mes paraules tingui mes dificil sera\nsi cap paraula es trobada per ser seleccionada, jugaras amb una paraula preseleccionada.";
            const string letsBegin = "Molt bé, doncs comencem";
            const string youHave = "et queden ";
            const string tries = " intents";
            const string chooseAWord = "escull una lletra";
            const string lost = "Has perdut, mes sort en la proxima";
            const string won = "Felicitats, has guanyat";



            bool normal = false;
            bool hard = false;
            bool expert = false;
            bool found = false;
            bool completed = false;
            bool fail = false;
            bool written = false;

            int lives;

            
            
            lives = 0;
            

            char[,] alphabet = new char[,] { { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I' }, { 'J', 'K', 'L', 'M', 'N', 'Ñ', 'O', 'P', 'Q' }, { 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' } };
            int[,] alphabetnum = new int[,] { { '0', '0', '0', '0', '0', '0', '0', '0', '0' }, { '0', '0', '0', '0', '0', '0', '0', '0', '0' }, { '0', '0', '0', '0', '0', '0', '0', '0', '0' } };
            char[,] hang = new char[7, 11]
         {
            { ' ', '+', '=', '=', '=', '=', '=', ' ', ' ', ' ', ' ' },
            { ' ', '|', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ' },
            { ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            { ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            { ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            { ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            { '_', '=', '=', '=', '=', '=', '=', '=', '=', '=', '=' }
         };


           



            string A = "A";
            string B = "B";
            string C = "C";
            string D = "D";
            string easyWord = "facil!";
            string normalWord = "normal!";
            string hardWord = "dificil!";
            string expertWord = "expert!";
            string gl = "Bona sort!!!";







            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(asteriscs);
            Console.WriteLine(welcome);
            Console.WriteLine(asteriscs);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(chooseDif);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(difLevel);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            string dificulty = Console.ReadLine();
            dificulty = dificulty.ToUpper();
            Console.WriteLine();

            if (dificulty.Equals(A))
            {
                
                Console.WriteLine(youveChosen + easyWord);
                lives = 7;
            }
            else if (dificulty.Equals(B))
            {
                normal = true;
                Console.WriteLine(youveChosen + normalWord);
                lives = 5;
            }
            else if (dificulty.Equals(C))
            {
                hard = true;
                Console.WriteLine(youveChosen + hardWord);
                lives = 4;
            }
            else if (dificulty.Equals(D))
            {
                expert = true;
                Console.WriteLine(youveChosen + expertWord);
                lives = 3;
            }

            Console.WriteLine(gl);
            Console.WriteLine();

            Console.WriteLine(pressAny);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(writeText);
            string text = Console.ReadLine();
            string[] words = text.Split(' ');
            string word = "";




            foreach (string i in words)
            {
                if ((i.Length == (4)) && (!found))
                {
                    word = i;
                    found = true;
                    
                }
                else if ((i.Length == (5)) && (!found))
                {
                    word = i;
                    found = true;
                    
                }
                else if ((i.Length == (6)) && (!found))
                {
                    word = i;
                    found = true;
                    
                }
                else if ((i.Length == (7)) && (!found))
                {
                    word = i;
                    found = true;
                    
                }
            }
            if (!found)
            {
                word = "numero";
            }

            word = word.ToUpper();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(letsBegin);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();


            char[] wordletters = word.ToCharArray();

            while (!(completed || fail))
            {
                Console.WriteLine();
                Console.WriteLine(youHave + lives + tries);
                Console.WriteLine();



                for (int i = 0; i < alphabet.GetLength(0); i++)
                {
                    for (int j = 0; j < alphabet.GetLength(1); j++)
                    {

                        if (alphabetnum[i, j] == '0')
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(alphabet[i, j] + " ");

                        }
                        else if (alphabetnum[i, j] == '1')
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(alphabet[i, j] + " ");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (alphabetnum[i, j] == '2')
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(alphabet[i, j] + " ");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    Console.WriteLine();
                }

                Console.WriteLine(chooseAWord);
                string letter = Console.ReadLine();
                letter = letter.ToUpper();
                

                for (int i = 0; i < alphabet.GetLength(0); i++)
                {
                    for (int j = 0; j < alphabet.GetLength(1); j++)
                    {

                        if (word.Contains(letter) && (alphabet[i, j].ToString() == letter))
                        {
                            alphabetnum[i, j] = '2';
                        }
                        else if (!word.Contains(letter) && (alphabet[i, j].ToString() == letter))
                        {
                            alphabetnum[i, j] = '1';
                            lives--;
                        }

                    }
                }

                Console.WriteLine();
                Console.WriteLine();

                if (normal)
                {
                    hang[2, 6] = 'O';
                }
                else if (hard) 
                {
                    hang[2, 6] = 'O';
                    hang[3, 6] = '|';
                }
                else if (expert)
                {
                    hang[2, 6] = 'O';
                    hang[3, 6] = '|';
                    hang[3, 5] = '/';
                }

                switch (lives)
                {
                    case 6:
                        break;
                    case 5:
                        hang[2, 6] = 'O';
                        break;
                    case 4:
                        hang[3, 6] = '|';
                        break;
                    case 3:
                        hang[3, 5] = '/';
                        break;
                    case 2:
                        hang[3, 7] = '\\';
                        break;
                    case 1:
                        hang[4, 5] = '/';
                        break;
                    case 0:
                        hang[4, 7] = '\\';
                        break;
                }


                
                for (int i = 0; i < hang.GetLength(0); i++)
                {
                    for (int j = 0; j < hang.GetLength(1); j++)
                    {
                        Console.Write(hang[i, j]);
                    }
                    Console.WriteLine();
                }




                foreach (char i in wordletters)
                {

                    for (int j = 0; j < alphabet.GetLength(0); j++)
                    {
                        for (int k = 0; k < alphabet.GetLength(1); k++)
                        {
                            if (i == alphabet[j,k] && alphabetnum[j,k] == '2')
                            {
                                Console.Write(i + " ");
                                written = true;
                            }
                            
                        }
                    }
                    if (!written)
                    {
                        Console.Write("_ ");
                    }

                    written = false;
                }


                completed = true;

                foreach (char i in wordletters)
                {
                    bool letterFound = false;

                    for (int j = 0; j < alphabet.GetLength(0) && !letterFound; j++)
                    {
                        for (int k = 0; k < alphabet.GetLength(1) && !letterFound; k++)
                        {
                            if (i == alphabet[j, k] && alphabetnum[j, k] == '2')
                            {
                                letterFound = true;
                            }
                        }
                    }

                    if (!letterFound)
                    {
                        completed = false;
                    }
                }


                if (lives <= 0)
                {
                    fail = true;
                    Console.WriteLine(lost);
                }
                if (completed)
                {
                    Console.WriteLine(won);
                }

            }
        }      
    }
}
