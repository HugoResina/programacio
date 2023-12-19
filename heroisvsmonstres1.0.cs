using System;
using System.Xml.Schema;

class rpg
{
    static void Main(string[] args)
    {

        const string openGame = "1.Iniciar nova batalla\n0.Sortir";
        const string chooseHowToPlay = "si vols jugar en mode facil, prem 1\nsi vols jugar en mode normal,prem 2\nsi vols jugar en mode dificil prem 3\nsi vols personalitzar el teu joc, prem 4";
        const string explain = "- en el mode facil, les teves estadistiques seran mes altes, y les del enemic mes baixes\n - en el mode normal, ambdues estadistiques estaran equilibrades\n - en el mode dificil, les teves estadistiqes seran mes baixes i les del enemic mes altes\n - si personalitzes, escolliras tu les estadistiques de tothom";
        const string invalidvalue = "valor invalid, tens ";
        const string tries = " intents";
        const string failthrice = "has fallat, tres cops seguits, si et torna a passar ";
        const string failtimes = " cops mes el joc es tancara";
        const string turnnum = "torn: ";
        const int tres = 3;


        bool validaction = false;
        bool correct = false;
        bool archerturn = false;
        bool barbarianturn = false;
        bool wizardturn = false;
        bool druidturn = false;
        bool monsterturn = false;
        bool archerprotect = false;
        bool barbarianprotect = false;
        bool wizardprotect = false;
        bool druidprotect = false;
        bool stun = false;


        int barbarianultcounter, stuncounter, ult, archerult, barbarianult, wizardult, druidult, action, turn, characterselector, restart, wrongAnswer, correctAnswer, play, mode, archerDmg,  barbarianDmg, wizardDmg, druidDmg, monsterDmg;
        float truedmg, druidDef, monsterDef, wizardDef, barbarianDef, archerDef, archerHp, barbarianHp, wizardHp, druidHp, monsterHp, maxarcherHp, maxdruidHp, maxwizardHp, maxbarbarianHp;


        maxdruidHp = 0;
        maxwizardHp = 0;
        maxbarbarianHp = 0;
        maxarcherHp = 0;
        archerHp = 0;
        archerDmg = 0;
        archerDef = 0;
        barbarianHp = 0;
        barbarianDmg = 0;
        barbarianDef = 0;
        wizardHp = 0;
        wizardDmg = 0;
        wizardDef = 0;
        druidHp = 0;
        druidDmg = 0;
        druidDef = 0;
        monsterHp = 0;
        monsterDmg = 0;
        monsterDef = 0;
        restart = 0;
        correctAnswer = 0;
        wrongAnswer = 0;
        characterselector = 0;
        turn = 0;
        action = 0;
        archerult = 0;
        barbarianult = 0;
        wizardult = 0;
        druidult = 0;
        ult = 0;
        stuncounter = 2;
        barbarianultcounter = 3;
        
            Console.WriteLine(openGame);
            play = Convert.ToInt16(Console.ReadLine());
           
        
            if (play == 1)
            {
            Console.WriteLine();
            Console.WriteLine(chooseHowToPlay);
                    Console.WriteLine();
                    Console.WriteLine(explain);

                    mode = Convert.ToInt16(Console.ReadLine());

                    if (mode == 1)
                    {
                        archerHp = 2000;
                        maxarcherHp = 2000;
                        archerDmg = 300;
                        archerDef = 40;
                        barbarianHp = 3750;
                        maxbarbarianHp = 3750;
                        barbarianDmg = 250;
                        barbarianDef = 45;
                        wizardHp = 1500;
                        maxwizardHp = 1500;
                        wizardDmg = 350;
                        wizardDef = 35;
                        druidHp = 2500;
                        maxdruidHp = 2500;
                        druidDmg = 120;
                        druidDef = 40;
                        monsterHp = 9000;
                        monsterDmg = 200;
                        monsterDef = 20;


                    }
                    else if (mode == 2)
                    {
                        archerHp = 1750;
                        maxarcherHp = 1750;
                        archerDmg = 240;
                        archerDef = 33;
                        barbarianHp = 3375;
                        maxbarbarianHp = 3375;
                        barbarianDmg = 200;
                        barbarianDef = 40;
                        wizardHp = 1250;
                        maxwizardHp = 1250;
                        wizardDmg = 325;
                        wizardDef = 28;
                        druidHp = 2250;
                        maxdruidHp = 2250;
                        druidDmg = 95;
                        druidDef = 33;
                        monsterHp = 10500;
                        monsterDmg = 300;
                        monsterDef = 25;
                    }
                    else if (mode == 3)
                    {
                        archerHp = 1500;
                        maxarcherHp = 1500;
                        archerDmg = 180;
                        archerDef = 25;
                        barbarianHp = 3000;
                        maxbarbarianHp = 3000;
                        barbarianDmg = 150;
                        barbarianDef = 35;
                        wizardHp = 1000;
                        maxwizardHp = 1000;
                        wizardDmg = 300;
                        wizardDef = 20;
                        druidHp = 2000;
                        maxdruidHp = 2000;
                        druidDmg = 70;
                        druidDef = 25;
                        monsterHp = 12000;
                        monsterDmg = 400;
                        monsterDef = 30;
                    }
                    else if (mode == 4)
                    {


                        do
                        {

                            do
                            {
                                if (restart != tres)
                                {
                                    Console.WriteLine("escriu els atributs de la vida per la arquera, ha de ser entre 1500 i 2000");
                                    maxarcherHp = archerHp = Convert.ToInt16(Console.ReadLine());
                                    if (archerHp < 1500 || archerHp > 2000)
                                    {
                                        wrongAnswer++;
                                        Console.WriteLine(invalidvalue + (3 - wrongAnswer) + tries);
                                        if (wrongAnswer == tres)
                                        {
                                            restart++;
                                            wrongAnswer = 0;
                                            Console.WriteLine(failthrice + (3 - restart) + failtimes);
                                        }
                                    }
                                    else
                                    {
                                        correct = true;
                                        correctAnswer++;
                                    }
                                }
                            } while (!correct);



                            do
                            {
                                if (restart != tres)
                                {
                                    correct = false;
                                    Console.WriteLine("escriu els atributs del atac per la arquera, ha de ser entre 180 i 300");
                                    archerDmg = Convert.ToInt16(Console.ReadLine());
                                    if (archerDmg < 180 || archerDmg > 300)
                                    {
                                        wrongAnswer++;
                                        Console.WriteLine(invalidvalue + (3 - wrongAnswer) + tries);
                                        if (wrongAnswer == tres)
                                        {
                                            restart++;
                                            wrongAnswer = 0;
                                            Console.WriteLine(failthrice + (3 - restart) + failtimes);
                                        }
                                    }
                                    else
                                    {
                                        correct = true;
                                        correctAnswer++;
                                    }
                                }
                            } while (!correct);

                            do
                            {
                                if (restart != tres)
                                {
                                    correct = false;
                                    Console.WriteLine("escriu els atributs de la reducció de dany per la arquera, ha de ser entre 25 i 40");
                                    archerDef = Convert.ToInt16(Console.ReadLine());
                                    if (archerDef < 25 || archerDef > 40)
                                    {
                                        wrongAnswer++;
                                        Console.WriteLine(invalidvalue + (3 - wrongAnswer) + tries);
                                        if (wrongAnswer == tres)
                                        {
                                            restart++;
                                            wrongAnswer = 0;
                                            Console.WriteLine(failthrice + (3 - restart) + failtimes);
                                        }
                                    }
                                    else
                                    {
                                        correct = true;
                                        correctAnswer++;
                                    }
                                }
                            } while (!correct);

                        } while (correctAnswer != tres);
                        correctAnswer = 0;



                        do
                        {
                            do
                            {
                                if (restart != tres)
                                {
                                    Console.WriteLine("escriu els atributs de la vida pel barbar, ha de ser entre 3000 i 3750");
                                    maxbarbarianHp = barbarianHp = Convert.ToInt16(Console.ReadLine());
                                    if (barbarianHp < 3000 || barbarianHp > 3750)
                                    {
                                        wrongAnswer++;
                                        Console.WriteLine(invalidvalue + (3 - wrongAnswer) + tries);
                                        if (wrongAnswer == tres)
                                        {
                                            restart++;
                                            wrongAnswer = 0;
                                            Console.WriteLine(failthrice + (3 - restart) + failtimes);

                                        }
                                    }
                                    else
                                    {
                                        correct = true;
                                        correctAnswer++;
                                    }
                                }
                            } while (!correct);



                            do
                            {
                                if (restart != tres)
                                {
                                    correct = false;
                                    Console.WriteLine("escriu els atributs del atac pel barbar, ha de ser entre 150 i 250");
                                    barbarianDmg = Convert.ToInt16(Console.ReadLine());
                                    if (barbarianDmg < 150 || barbarianDmg > 250)
                                    {
                                        wrongAnswer++;
                                        Console.WriteLine(invalidvalue + (3 - wrongAnswer) + tries);
                                        if (wrongAnswer == tres)
                                        {
                                            restart++;
                                            wrongAnswer = 0;
                                            Console.WriteLine(failthrice + (3 - restart) + failtimes);
                                        }
                                    }
                                    else
                                    {
                                        correct = true;
                                        correctAnswer++;
                                    }
                                }
                            } while (!correct);

                            do
                            {
                                if (restart != tres)
                                {
                                    correct = false;
                                    Console.WriteLine("escriu els atributs de la reducció de dany pel barbar, ha de ser entre 35 i 45");
                                    barbarianDef = Convert.ToInt16(Console.ReadLine());
                                    if (barbarianDef < 35 || barbarianDef > 45)
                                    {
                                        wrongAnswer++;
                                        Console.WriteLine(invalidvalue + (3 - wrongAnswer) + tries);
                                        if (wrongAnswer == tres)
                                        {
                                            restart++;
                                            wrongAnswer = 0;
                                            Console.WriteLine(failthrice + (3 - restart) + failtimes);
                                        }
                                    }
                                    else
                                    {
                                        correct = true;
                                        correctAnswer++;
                                    }
                                }
                            } while (!correct);

                        } while (correctAnswer != tres);
                        correctAnswer = 0;




                        do
                        {
                            do
                            {
                                if (restart != tres)
                                {
                                    Console.WriteLine("escriu els atributs de la vida per la maga, ha de ser entre 1000 i 1500");
                                    maxwizardHp = wizardHp = Convert.ToInt16(Console.ReadLine());
                                    if (wizardHp < 1000 || wizardHp > 1500)
                                    {
                                        wrongAnswer++;
                                        Console.WriteLine(invalidvalue + (3 - wrongAnswer) + tries);
                                        if (wrongAnswer == tres)
                                        {
                                            restart++;
                                            wrongAnswer = 0;
                                            Console.WriteLine(failthrice + (3 - restart) + failtimes);
                                        }
                                    }
                                    else
                                    {
                                        correct = true;
                                        correctAnswer++;
                                    }
                                }
                            } while (correct == false);



                            do
                            {
                                if (restart != tres)
                                {
                                    correct = false;
                                    Console.WriteLine("escriu els atributs del atac per la  maga, ha de ser entre 300 i 350");
                                    wizardDmg = Convert.ToInt16(Console.ReadLine());
                                    if (wizardDmg < 300 || wizardDmg > 350)
                                    {
                                        wrongAnswer++;
                                        Console.WriteLine(invalidvalue + (3 - wrongAnswer) + tries);
                                        if (wrongAnswer == tres)
                                        {
                                            restart++;
                                            wrongAnswer = 0;
                                            Console.WriteLine(failthrice + (3 - restart) + failtimes);
                                        }
                                    }
                                    else
                                    {
                                        correct = true;
                                        correctAnswer++;
                                    }
                                }
                            } while (!correct);

                            do
                            {
                                if (restart != tres)
                                {
                                    correct = false;
                                    Console.WriteLine("escriu els atributs de la reducció de dany per la maga, ha de ser entre 20 i 35");
                                    wizardDef = Convert.ToInt16(Console.ReadLine());
                                    if (wizardDef < 20 || wizardDef > 35)
                                    {
                                        wrongAnswer++;
                                        Console.WriteLine (invalidvalue + (3 - wrongAnswer) + tries);
                                        if (wrongAnswer == tres)
                                        {
                                            restart++;
                                            wrongAnswer = 0;
                                            Console.WriteLine(failthrice + (3 - restart) + failtimes);
                                        }
                                    }
                                    else
                                    {
                                        correct = true;
                                        correctAnswer++;
                                    }
                                }
                            } while (!correct);

                        } while (correctAnswer != tres);
                        correctAnswer = 0;



                        do
                        {
                            do
                            {
                                if (restart != tres)
                                {
                                    Console.WriteLine("escriu els atributs de la vida pel druida, ha de ser entre 2000 i 2500");
                                    maxdruidHp = druidHp = Convert.ToInt16(Console.ReadLine());
                                    if (druidHp < 2000 || druidHp > 2500)
                                    {
                                        wrongAnswer++;
                                        Console.WriteLine(invalidvalue + (3 - wrongAnswer) + tries);
                                        if (wrongAnswer == tres)
                                        {
                                            restart++;
                                            wrongAnswer = 0;
                                            Console.WriteLine(failthrice + (3 - restart) + failtimes);
                                        }
                                    }
                                    else
                                    {
                                        correct = true;
                                        correctAnswer++;
                                    }
                                }
                            } while (correct == false);



                            do
                            {
                                if (restart != tres)
                                {
                                    correct = false;
                                    Console.WriteLine("escriu els atributs del atac pel druida, ha de ser entre 70 i 120");
                                    druidDmg = Convert.ToInt16(Console.ReadLine());
                                    if (druidDmg < 70 || druidDmg > 120)
                                    {
                                        wrongAnswer++;
                                        Console.WriteLine(invalidvalue + (3 - wrongAnswer) + tries);
                                        if (wrongAnswer == tres)
                                        {
                                            restart++;
                                            wrongAnswer = 0;
                                            Console.WriteLine(failthrice + (3 - restart) + failtimes);
                                        }
                                    }
                                    else
                                    {
                                        correct = true;
                                        correctAnswer++;
                                    }
                                }
                            } while (!correct);

                            do
                            {
                                if (restart != tres)
                                {
                                    correct = false;
                                    Console.WriteLine("escriu els atributs de la reducció de dany pel druida, ha de ser entre 25 i 40");
                                    druidDef = Convert.ToInt16(Console.ReadLine());
                                    if (druidDef < 25 || druidDef > 40)
                                    {
                                        wrongAnswer++;
                                        Console.WriteLine(invalidvalue + (3 - wrongAnswer) + tries);
                                        if (wrongAnswer == tres)
                                        {
                                            restart++;
                                            wrongAnswer = 0;
                                            Console.WriteLine(failthrice + (3 - restart) + failtimes);
                                        }
                                    }
                                    else
                                    {
                                        correct = true;
                                        correctAnswer++;
                                    }
                                }
                            } while (!correct);

                        } while (correctAnswer != tres);
                        correctAnswer = 0;



                        do
                        {
                            do
                            {
                                if (restart != tres)
                                {
                                    Console.WriteLine("escriu els atributs de la vida pel monstre, ha de ser entre 9000 i 12000");
                                    monsterHp = Convert.ToInt16(Console.ReadLine());
                                    if (monsterHp < 9000 || monsterHp > 12000)
                                    {
                                        wrongAnswer++;
                                        Console.WriteLine(invalidvalue + (3 - wrongAnswer) + tries);
                                        if (wrongAnswer == tres)
                                        {
                                            restart++;
                                            wrongAnswer = 0;
                                            Console.WriteLine(failthrice + (3 - restart) + failtimes);
                                        }
                                    }
                                    else
                                    {
                                        correct = true;
                                        correctAnswer++;
                                    }
                                }
                            } while (!correct);



                            do
                            {
                                if (restart != tres)
                                {
                                    correct = false;
                                    Console.WriteLine("escriu els atributs del atac pel monstre, ha de ser entre 250 i 400");
                                    monsterDmg = Convert.ToInt16(Console.ReadLine());
                                    if (monsterDmg < 250 || monsterDmg > 400)
                                    {
                                        wrongAnswer++;
                                        Console.WriteLine(invalidvalue + (3 - wrongAnswer) + tries);
                                        if (wrongAnswer == tres)
                                        {
                                            restart++;
                                            wrongAnswer = 0;
                                            Console.WriteLine(failthrice + (3 - restart) + failtimes);
                                        }
                                    }
                                    else
                                    {
                                        correct = true;
                                        correctAnswer++;
                                    }
                                }
                            } while (correct == false);

                            do
                            {
                                if (restart != tres)
                                {
                                    correct = false;
                                    Console.WriteLine("escriu els atributs de la reducció de dany pel druida, ha de ser entre 20 i 30");
                                    monsterDef = Convert.ToInt16(Console.ReadLine());
                                    if (monsterDef < 20 || monsterDef > 30)
                                    {
                                        wrongAnswer++;
                                        Console.WriteLine(invalidvalue + (3 - wrongAnswer) + tries);
                                        if (wrongAnswer == tres)
                                        {
                                            restart++;
                                            wrongAnswer = 0;
                                            Console.WriteLine(failthrice + (3 - restart) + failtimes);
                                        }
                                    }
                                    else
                                    {
                                        correct = true;
                                        correctAnswer++;
                                    }
                                }
                            } while (!correct);

                        } while (correctAnswer != tres);
                        correctAnswer = 0;
                    }

                    if (restart != tres)
                    {

                        do
                        {
                            Console.WriteLine(turnnum + (turn + 1));


                            do
                            {
                                if (characterselector == 0)
                                {
                                    archerturn = true;
                                }
                                else if (characterselector == 1)
                                {
                                    barbarianturn = true;
                                }
                                else if (characterselector == 2)
                                {
                                    wizardturn = true;
                                }
                                else if (characterselector == 3)
                                {
                                    druidturn = true;
                                }
                                else if (characterselector == 4)
                                {
                                    monsterturn = true;
                                }

                        restart = 0;

                                do
                                {

                                if (archerturn)
                                {
                                    Console.WriteLine("arquera " + "selecciona l'accio:\n1. Atacar\n2.protegir-se\n3.Habilitat especial");
                                    action = Convert.ToInt16(Console.ReadLine());
                                }
                                else if (barbarianturn)
                                {
                                    Console.WriteLine("barbar " + "selecciona l'accio:\n1. Atacar\n2.protegir-se\n3.Habilitat especial");
                                    action = Convert.ToInt16(Console.ReadLine());
                                }
                                else if (wizardturn)
                                {
                                    Console.WriteLine("maga " + "selecciona l'accio:\n1. Atacar\n2.protegir-se\n3.Habilitat especial");
                                    action = Convert.ToInt16(Console.ReadLine());
                                }
                                else if (druidturn)
                                {
                                    Console.WriteLine("druida  " + "selecciona l'accio:\n1. Atacar\n2.protegir-se\n3.Habilitat especial");

                                    action = Convert.ToInt16(Console.ReadLine());
                                }

                            

                                    if (action == 1)
                                    {
                                        Console.WriteLine();
                                        if (archerturn)
                                        {
                                            truedmg = (archerDmg - (archerDmg * (monsterDef / 100)));
                                            monsterHp -= truedmg;
                                            Console.WriteLine("arquera " + "ataca a monstre amb " + archerDmg + " de dany. El monstre es defensa i rep nomes " + truedmg + " de dany.\nVida restant del monstre: " + monsterHp);
                                            truedmg = 0;
                                            archerturn = false;
                                    Console.WriteLine();
                                }
                                        else if (barbarianturn)
                                        {
                                            truedmg = (barbarianDmg - (barbarianDmg * (monsterDef / 100)));
                                            monsterHp -= truedmg;
                                            Console.WriteLine("barbar" + "ataca a monstre amb " + barbarianDmg + " de dany. El monstre es defensa i rep nomes " + truedmg + " de dany.\nVida restant del monstre: " + monsterHp);
                                            truedmg = 0;
                                            barbarianturn = false;
                                    Console.WriteLine();
                                }

                                        else if (wizardturn)
                                        {
                                            truedmg = (wizardDmg - (wizardDmg * (monsterDef / 100)));
                                            monsterHp -= truedmg;
                                            Console.WriteLine("maga" + "ataca a monstre amb " + wizardDmg + " de dany. El monstre es defensa i rep nomes " + truedmg + " de dany.\nVida restant del monstre: " + monsterHp);
                                            truedmg = 0;
                                            wizardturn = false;
                                    Console.WriteLine();
                                }
                                        else if (druidturn)
                                        {
                                            truedmg = (druidDmg - (druidDmg * (monsterDef / 100)));
                                            monsterHp -= truedmg;
                                            Console.WriteLine("druida" + "ataca a monstre amb " + druidDmg + " de dany. El monstre es defensa i rep nomes " + truedmg + " de dany.\nVida restant del monstre: " + monsterHp);
                                            truedmg = 0;
                                            druidturn = false;
                                    Console.WriteLine();
                                }
                                characterselector++;
                            }
                                    if (action == 2)
                                    {
                                        Console.WriteLine();
                                        if (archerturn)
                                        {
                                            archerprotect = true;
                                            archerDef *= 2;
                                            archerturn = false;

                                        }
                                        else if (barbarianturn)
                                        {
                                            barbarianprotect = true;
                                            barbarianDef *= 2;
                                            barbarianturn = false;
                                        }

                                        else if (wizardturn)
                                        {
                                            wizardprotect = true;
                                            wizardDef *= 2;
                                            wizardturn = false;
                                        }
                                        else if (druidturn)
                                        {
                                            druidprotect = true;
                                            druidDef *= 2;
                                            druidturn = false;
                                        }
                                characterselector++;
                            }

                                    if (action == 3)
                                    {
                                        Console.WriteLine();
                                        if (archerturn && archerult == 4)
                                        {
                                            stun = true;
                                            stuncounter--;
                                            archerult = 0;
                                            Console.WriteLine("la arquera ha paralitzat el monstre, aquest no podra atacar durant dos torns ");
                                    characterselector++;
                                }
                                        else if (barbarianturn && barbarianult == 4)
                                        {
                                            barbarianDef = 100;
                                            barbarianultcounter--;
                                            barbarianult = 0;
                                            Console.WriteLine("el barbar ha pujat la seva defensa a 100 durant 3 torns");
                                    characterselector++;

                                }
                                        else if (wizardturn && wizardult == 4)
                                        {
                                            truedmg = ((wizardDmg * tres) - ((tres * wizardDmg) * (monsterDef / 100)));
                                            monsterHp -= truedmg;
                                            truedmg = 0;
                                            wizardult = 0;
                                            Console.WriteLine("maga" + "ataca a monstre amb " + (wizardDmg * 3) + " de dany. El monstre es defensa i rep nomes " + truedmg + " de dany.\nVida restant del monstre: " + monsterHp);
                                    characterselector++;
                                }
                                        else if (druidturn && druidult == 4)
                                        {
                                            druidult = 0;
                                            if (archerHp > 0)
                                            {
                                                archerHp += 500;
                                                if (archerHp > maxarcherHp)
                                                {
                                                    archerHp = maxarcherHp;
                                                }
                                            }
                                            if (barbarianHp > 0)
                                            {
                                                barbarianHp += 500;
                                                if (barbarianHp > maxbarbarianHp)
                                                {
                                                    barbarianHp = maxbarbarianHp;
                                                }
                                            }
                                            if (wizardHp > 0)
                                            {
                                                wizardHp += 500;
                                                if (wizardHp > maxwizardHp)
                                                {
                                                    wizardHp = maxwizardHp;
                                                }
                                            }
                                            if (druidHp > 0)
                                            {
                                                druidHp += 500;
                                                if (druidHp > maxdruidHp)
                                                {
                                                    druidHp = maxdruidHp;
                                                }
                                            }
                                            Console.WriteLine("el druida ha curat al seu equip\narquera: " + archerHp + "\nbarbar: " + barbarianHp + "\nmaga: " + wizardHp + "\ndruida: " + druidHp);
                                    characterselector++;
                                }

                                        else
                                        {
                                            
                                            Console.WriteLine("aquesta habilitat encara no esta llesta, li queden " + (5 - ult) + "torns per poder utilitzarla");


                                        }


                                    }




                                } while (validaction );

                        

                                 if (characterselector == 4 && !stun )
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("torn del monstre!, ataca a tothom");

                                    truedmg = (monsterDmg - (monsterDmg * (archerDef / 100)));
                                    archerHp -= truedmg;
                                    Console.WriteLine();
                                    Console.WriteLine("El Monstre ataca a l’Arquera amb " + monsterDmg + " de dany. L’Arquera es defensa i rep només " + truedmg + " de dany. Vida restant de l’Arquera: " + archerHp);
                                    if (archerHp <= 0)
                                    {
                                        Console.WriteLine("l'arquera ha mort");
                                    }
                                    truedmg = 0;

                                    truedmg = (monsterDmg - (monsterDmg * (barbarianDef / 100)));
                                    barbarianHp -= truedmg;
                                    Console.WriteLine();
                                    Console.WriteLine("El Monstre ataca al barbar amb " + monsterDmg + " de dany. El barbar es defensa i rep només " + truedmg + " de dany. Vida restant del barbar: " + barbarianHp);
                                    if (barbarianHp <= 0)
                                    {
                                Console.WriteLine();
                                Console.WriteLine("el barbar ha mort");
                                    }
                                    truedmg = 0;



                                    truedmg = (monsterDmg - (monsterDmg * (wizardDef / 100)));
                                    wizardHp -= truedmg;
                            Console.WriteLine();
                            Console.WriteLine("El Monstre ataca a la maga amb " + monsterDmg + " de dany. La maga es defensa i rep només " + truedmg + " de dany. Vida restant de la maga: " + wizardHp);
                                    if (wizardHp <= 0)
                                    {
                                Console.WriteLine();
                                Console.WriteLine("la maga ha mort");
                                    }
                                    truedmg = 0;



                                    truedmg = (monsterDmg - (monsterDmg * (druidDef / 100)));
                                    druidHp -= truedmg;
                            Console.WriteLine();
                            Console.WriteLine("El Monstre ataca al druida amb " + monsterDmg + " de dany. El druida es defensa i rep només " + truedmg + " de dany. Vida restant del druida: " + druidHp);
                                    if (druidHp <= 0)
                                    {
                                Console.WriteLine();
                                Console.WriteLine("el druida ha mort");
                                    }
                                    truedmg = 0;


                                }
                                else if (stun)
                                {
                            Console.WriteLine();
                            Console.WriteLine("el monstre no pot atacar durant " + stuncounter + "torns");
                                }


                                if (archerprotect)
                                {
                                    archerDef /= 2;
                                    archerprotect = false;
                                }
                                else if (barbarianprotect)
                                {
                                    barbarianDef /= 2;
                                    barbarianprotect = false;
                                }
                                else if (wizardprotect)
                                {
                                    wizardDef /= 2;
                                    wizardprotect = false;
                                }
                                else if (druidprotect)
                                {
                                    druidDef /= 2;
                                    druidprotect = false;
                                }

                            } while (characterselector != 5);



                            archerturn = false;
                            barbarianturn = false;
                            wizardturn = false;
                            druidturn = false;
                            monsterturn = false;
                            turn++;
                            archerult++;
                            barbarianult++;
                            wizardult++;
                            druidult++;
                            characterselector = 0;
                            validaction = false;




                        } while ((archerHp >= 0 && barbarianHp >= 0 && wizardHp >= 0 && druidHp > 0) || monsterHp >= 0);

                        if (monsterHp <= 0)
                        {
                    Console.WriteLine();
                    Console.WriteLine("el monstre ha mort");
                        }
                        else
                        {
                    Console.WriteLine();
                    Console.WriteLine("el monstre ha vençut als herois");
                        }
                    }
   
            }
        }
    }








