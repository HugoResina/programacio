using System;
class rpg
{
    static void Main(string[] args)
    {

        /*que hace un vector sin sentido ni direccióm en una montaña?
        escalar*/

        const string openGame = "per iniciar una nova batalla, prem 1, si vols sortir, prem 2";
        const string reopenGame = "si vols tornar a jugar, prem 1, si no, prem cualsevol altre numero";
        const string chooseHowToPlay = "si vols jugar en mode facil, prem 1\nsi vols jugar en mode normal,prem 2\nsi vols jugar en mode dificil prem 3\nsi vols personalitzar el teu joc, prem 4";
        const string explain = "- en el mode facil, les teves estadistiques seran mes altes, y les del enemic mes baixes\n  en el mode normal, ambdues estadistiques estaran equilibrades\n  en el mode dificil, les teves estadistiqes seran mes baixes i les del enemic mes altes\n  si personalitzes, escolliras tu les estadistiques de tothom";
        int play, replay, mode, archerDmg, archerDef, archerHpReg, barbarianDmg, barbarianDef, barbarianHpReg, wizardDmg, wizardDef, wizardHpReg, druidDmg, druidDef, druidHpReg, monsterDef, monsterDmg, monsterHpReg;
        float archerHp, barbarianHp, wizardHp, druidHp, monsterHp;
        Console.WriteLine(openGame);
        play = Convert.ToInt16(Console.ReadLine());
        if (play == 1)
        {
            do
            {
                Console.WriteLine(chooseHowToPlay);
                Console.WriteLine("");
                Console.WriteLine(explain);

                mode = Convert.ToInt16(Console.ReadLine());

                if (mode == 1)
                {
                    archerHp = 2000;
                    archerDmg = 300;
                    archerDef = 50;
                    archerHpReg = 5;
                    barbarianHp = 3750;
                    barbarianDmg = 250;
                    barbarianDef = 65;
                    barbarianHpReg = 5;
                    wizardHp = 1500;
                    wizardDmg = 350;
                    wizardDef = 40;
                    wizardHpReg = 5;
                    druidHp = 2500;
                    druidDmg = 120;
                    druidDef = 40;
                    druidHpReg = 7;
                    monsterHp = 9000;
                    monsterDmg = 200;
                    monsterDef = 25;
                    monsterHpReg = 1;


                }
                else if (mode == 2)
                {
                    archerHp = 1750;
                    archerDmg = 240;
                    archerDef = 40;
                    archerHpReg = 4;
                    barbarianHp = 3375;
                    barbarianDmg = 200;
                    barbarianDef = 53;
                    barbarianHpReg = 4;
                    wizardHp = 1250;
                    wizardDmg = 325;
                    wizardDef = 33;
                    wizardHpReg = 4;
                    druidHp = 2250;
                    druidDmg = 95;
                    druidDef = 33;
                    druidHpReg = 6;
                    monsterHp = 10500;
                    monsterDmg = 300;
                    monsterDef = 33;
                    monsterHpReg = 2;
                }
                else if (mode == 3)
                {
                    archerHp = 1500;
                    archerDmg = 180;
                    archerDef = 30;
                    archerHpReg = 2;
                    barbarianHp = 3000;
                    barbarianDmg = 150;
                    barbarianDef = 40;
                    barbarianHpReg = 2;
                    wizardHp = 1000;
                    wizardDmg = 300;
                    wizardDef = 25;
                    wizardHpReg = 2;
                    druidHp = 2000;
                    druidDmg = 70;
                    druidDef = 25;
                    druidHpReg = 5;
                    monsterHp = 12000;
                    monsterDmg = 400;
                    monsterDef = 40;
                    monsterHpReg = 2;
                }
                else if (mode == 4)
                {

                    archerHp = Convert.ToInt16(Console.ReadLine());

                    archerDmg = Convert.ToInt16(Console.ReadLine());

                    archerDef = Convert.ToInt16(Console.ReadLine());

                    archerHpReg = Convert.ToInt16(Console.ReadLine());

                    barbarianHp = Convert.ToInt16(Console.ReadLine());

                    barbarianDmg = Convert.ToInt16(Console.ReadLine());

                    barbarianDef = Convert.ToInt16(Console.ReadLine());

                    barbarianHpReg = Convert.ToInt16(Console.ReadLine());

                    wizardHp = Convert.ToInt16(Console.ReadLine());

                    wizardDmg = Convert.ToInt16(Console.ReadLine());

                    wizardDef = Convert.ToInt16(Console.ReadLine());

                    wizardHpReg = Convert.ToInt16(Console.ReadLine());

                    druidHp = Convert.ToInt16(Console.ReadLine());

                    druidDmg = Convert.ToInt16(Console.ReadLine());

                    druidDef = Convert.ToInt16(Console.ReadLine());

                    druidHpReg = Convert.ToInt16(Console.ReadLine());

                    monsterHp = Convert.ToInt16(Console.ReadLine());

                    monsterDmg = Convert.ToInt16(Console.ReadLine());

                    monsterDef = Convert.ToInt16(Console.ReadLine());

                    monsterHpReg = Convert.ToInt16(Console.ReadLine());

                }


                
                Console.WriteLine(reopenGame);
                replay = Convert.ToInt16(Console.ReadLine());
            } while (replay == 1);
        }
    }
}