


using Armors;
using Characters.MainChar;
using Characters.Opponents;
using Interfaces;
using System;
using System.Threading;
using Utilities;
using Weapons;

namespace OOP2019_2020_Project
{
    public class EntryPoint
    {
        static void Main()
        {
            
         
            bool gameOver = false;

            while(!gameOver)
            {
                Tools.ColorfulWriteLine("                   )    (      (         )    (                      *                            (      (     \n" +
                                        "          (     ( /(    )\\ )   )\\ )   ( /(    )\\ )                 (  `       (  (        (       )\\ )   )\\ )  \n" +
                                        "          )\\    )\\())  (()/(  (()/(   )\\())  (()/(   (        (    )\\))(      )\\))(   '   )\\     (()/(  (()/(  \n" +
                                        "        (((_)  ((_)\\    /(_))  /(_)) ((_)\\    /(_))  )\\       )\\  ((_)()\\    ((_)()\\ ) ((((_)(    /(_))  /(_)) \n" +
                                        "        )\\___    ((_)  (_))   (_))     ((_)  (_))   ((_)   _ ((_) (_()((_)   _(())\\_)() )\\ _ )\\  (_))   (_))   \n" +
                                        "       ((/ __|  / _ \\  | |    | |     / _ \\  / __|  | __| | | | | |  \\/  |   \\ \\((_)/ / (_)_\\(_) | _ \\  / __|  \n" +
                                        "        | (__  | (_) | | |__  | |__  | (_) | \\__ \\  | _|  | |_| | | |\\/| |    \\ \\/\\/ /   / _ \\   |   /  \\__ \\  \n" +
                                        "         \\___|  \\___/  |____| |____|  \\___/  |___/  |___|  \\___/  |_|  |_|     \\_/\\_/   /_/ \\_\\  |_|_\\  |___/  ", ConsoleColor.DarkRed);

                Tools.ColorfulWriteLine("\n\n\n\n\n\n\n\n\n\n\n\n                                               PRESS ANY KEY TO START", ConsoleColor.White);

                Console.ReadKey();
                Console.Clear();

                Tools.ColorfulWriteLine("  _  _   _     ___ _        _       _     __          _  ___     ___ _   _  \n" +
                                        " /  |_) |_  /\\  | |_   \\_/ / \\ | | |_)   /__ |   /\\  | \\  |   /\\  | / \\ |_) \n" +
                                        " \\_ | \\ |_ /--\\ | |_    |  \\_/ |_| | \\   \\_| |_ /--\\ |_/ _|_ /--\\ | \\_/ | \\ ", ConsoleColor.DarkRed);

                Tools.ColorfulWriteLine("\n\n\n\n" +
                                        "  __                                              \n" +
                                        " /__ o     _    _|_ |_   _    ._   _. ._ _   _  o \n" +
                                        " \\_| | \\/ (/_    |_ | | (/_   | | (_| | | | (/_ o \n", ConsoleColor.White);
                string name = Console.ReadLine();
                Gladiator glad = new Gladiator(name);
                GladiatorInfo.GladiatorInitialize(glad);
                Console.Clear();

                Tools.ColorfulWriteLine("                                  __          _  ___     ___ _   _    \n" +
                                        "  /\\  ._ ._ _        _      ._   /__ |   /\\  | \\  |   /\\  | / \\ |_)  \n" +
                                        " /--\\ |  | | |   \\/ (_) |_| |    \\_| |_ /--\\ |_/ _|_ /--\\ | \\_/ | \\  \n" +
                                        "                 /                                                    ", ConsoleColor.DarkRed);
                Thread.Sleep(1500);
                Console.Clear();

                string weaponSelect = null;
                while(weaponSelect != "a" && weaponSelect != "b" && weaponSelect != "c")
                { 
                    Tools.ColorfulWriteLine("  _                                                       \n" +
                                            " /  |_   _   _   _  _        _      ._    _   _   _. ._ o \n" +
                                            " \\_ | | (_) (_) _> (/_   \\/ (_) |_| |    (_| (/_ (_| |  o \n" +
                                            "                         /                _|              \n" +
                                            "\n\n\n" +
                                            " \\    / _   _. ._   _  ._   _ o \n" +
                                            "  \\/\\/ (/_ (_| |_) (_) | | _> o \n" +
                                            "               |                \n" +
                                            "\n\n\n\n" +
                                            "  _. \\    |   _  ._   _    (_        _  ._ _| \n" +
                                            " (_|  |   |_ (_) | | (_|   __) \\/\\/ (_) | (_| \n" +
                                            "     /                _|                      \n\n" +
                                            "" +
                                            " |_ \\    |_|  _. _|_  _ |_   _ _|_ \n" +
                                            " |_) |   | | (_|  |_ (_ | | (/_ |_ \n" +
                                            "    /                              \n\n" +
                                            "  _ \\    |_|  _. ._ _  ._ _   _  ._ \n" +
                                            " (_  |   | | (_| | | | | | | (/_ |  \n" +
                                            "    /                               \n\n\n\n\n", ConsoleColor.White);
                    weaponSelect = Console.ReadLine();
                    
                    Console.Clear();
                    

                }
                
                switch (weaponSelect)
                {
                    case "a":
                        glad.ArmWeapon = new LongSword();
                        break;
                    case "b":
                        glad.ArmWeapon = new Hatchet();
                        break;
                    case "c":
                        glad.ArmWeapon = new Hammer();
                        break;
                }

                string armorSelect = null;
                while (armorSelect != "a" && armorSelect != "b" && armorSelect != "c")
                {
                    Tools.ColorfulWriteLine("  /\\  ._ ._ _   _  ._ _ o \n" +
                                            " /--\\ |  | | | (_) | _> o \n" +
                                            "\n\n\n\n" +
                                            "           _         _                 \n" +
                                            "  _. \\    |_    | | |_) |   _. _|_  _  \n" +
                                            " (_|  |   | |_| | | |   |_ (_|  |_ (/_ \n" +
                                            "    /                                 \n\n" +
                                            "          _                    _                \n" +
                                            " |_ \\    |_) ._ _   _.  _ _|_ |_) |  _. _|_  _  \n" +
                                            " |_) |   |_) | (/_ (_| _>  |_ |   | (_|  |_ (/_ \n" +
                                            "    /                                           \n\n" +
                                            "  _ \\    |   _   _. _|_ |_   _  ._ \n" +
                                            " (_  |   |_ (/_ (_|  |_ | | (/_ |  \n" +
                                            "    /                              \n", ConsoleColor.White);
                    armorSelect = Console.ReadLine();
                    Console.Clear();
                }

                switch (armorSelect)
                {
                    case "a":
                        glad.ChestArmor = new FullPlateArmor();
                        break;
                    case "b":
                        glad.ChestArmor = new BreastPlate();
                        break;
                    case "c":
                        glad.ChestArmor = new LeatherArmor();
                        break;
                }

                GladiatorInfo.UpdateFullInfo(glad);

                string startSelect = null;
                while(startSelect != "1" && startSelect != "2")
                {
                    
                    Tools.ColorfulWriteLine(" ___                                                                                                                  \n" +
                                            "  |    ._   _    /|   _|_  _     _ |_   _   _ |        _      ._    _  |  _.  _| o  _. _|_  _  ._    _ _|_  _. _|_  _ \n" +
                                            "  | \\/ |_) (/_    |    |_ (_)   (_ | | (/_ (_ |<   \\/ (_) |_| |    (_| | (_| (_| | (_|  |_ (_) |    _>  |_ (_|  |_ _> \n" +
                                            "    /  |                                           /                _|                                                \n\n\n", ConsoleColor.Magenta);

                    Tools.ColorfulWriteLine(" ___             _               __ ___      _ ___    __            _ \n" +
                                            "  |    ._   _     )   _|_  _    (_   |  /\\  |_) |    /__  /\\  |\\/| |_ \n" +
                                            "  | \\/ |_) (/_   /_    |_ (_)   __)  | /--\\ | \\ |    \\_| /--\\ |  | |_ \n" +
                                            "    /  |                                                              \n\n\n", ConsoleColor.Red);
                    startSelect = Console.ReadLine();
                    Console.Clear();

                    if(startSelect == "1")
                    {
                        GladiatorInfo.PrintFullInfo();
                        Console.WriteLine("\n\n" +
                                          "Weapon info:\n");
                        glad.ArmWeapon.GetWeaponInfo();
                        Console.WriteLine("\n\n\n\n" +
                                          "PRESS ANY KEY TO CONTINUE");
                        Console.ReadKey();

                        startSelect = null;
                        Console.Clear();
                    }
                    if (startSelect == "2")
                        break;
                }


                Tools.ColorfulWriteLine("                            @@@  @@@  @@@ @@@@@@@@ @@@       @@@@@@@  @@@@@@  @@@@@@@@@@  @@@@@@@@\n" +
                                        "                            @@!  @@!  @@! @@!      @@!      !@@      @@!  @@@ @@! @@! @@! @@!     \n" +
                                        "                            @!!  !!@  @!@ @!!!:!   @!!      !@!      @!@  !@! @!! !!@ @!@ @!!!:!  \n" +
                                        "                             !:  !!:  !!  !!:      !!:      :!!      !!:  !!! !!:     !!: !!:     \n" +
                                        "                              ::.:  :::   : :: ::: : ::.: :  :: :: :  : :. :   :      :   : :: :::\n\n\n\n", ConsoleColor.Red);

                Tools.ColorfulWriteLine("                        , .  .   ,---. .  . ,--.    ,-.  ,-.  ,    ,     ,-.   ,-.  .  . ,--. .   , \n" +
                                        "                        | |\\ |     |   |  | |      /    /   \\ |    |    /   \\ (   ` |  | |    |\\ /| \n" +
                                        "                        | | \\|     |   |--| |-     |    |   | |    |    |   |  `-.  |  | |-   | V | \n" +
                                        "                        | |  |     |   |  | |      \\    \\   / |    |    \\   / .   ) |  | |    |   | \n" +
                                        "                        ' '  '     '   '  ' `--'    `-'  `-'  `--' `--'  `-'   `-'  `--` `--' '   ' \n\n\n\n", ConsoleColor.DarkYellow);

                Tools.ColorfulWriteLine("                                               PREPARE FOR THE BATTLE\n\n\n\n", ConsoleColor.Blue);

                Tools.ColorfulWriteLine("           _   _ ____ _  _ ____    ____ _ ____ ____ ___    ____ ___  ___  ____ _  _ ____ _  _ ___    _ ____    \n" +
                                        "            \\_/  |  | |  | |__/    |___ | |__/ [__   |     |  | |__] |__] |  | |\\ | |___ |\\ |  |     | [__     \n" +
                                        "             |   |__| |__| |  \\    |    | |  \\ ___]  |     |__| |    |    |__| | \\| |___ | \\|  |     | ___] ...\n", ConsoleColor.Cyan);
                Thread.Sleep(3000);
                Console.Clear();

                Tools.ColorfulWriteLine("\n\n                                            ▄▀▀▄    ▄▀▀▄  ▄▀▀▀▀▄   ▄▀▀▀▀▄     ▄▀▀▀█▄   \n" +
                                        "                                           █   █      █ █      █ █    █     █  ▄▀  ▀▄ \n" +
                                        "                                             █        █ █      █     █      █▄▄▄▄   \n" +
                                        "                                             █   ▄    █  ▀▄    ▄▀     █       █       \n" +
                                        "                                              ▀▄▀ ▀▄ ▄▀    ▀▀▀▀     ▄▀▄▄▄▄▄▄▀ █        \n" +
                                        "                                                    ▀               █        █         \n" +
                                        "                                                                                     \n" +
                                        "                            .d$$b      \n" +
                                        "                          .' TO$;\\     \n" +
                                        "                         /  : TP._;    \n" +
                                        "                        / _.;  :Tb|    \n" +
                                        "                       /   /   ;j$j    \n" +
                                        "                   _.-'       d$$$$    \n" +
                                        "                 .' ..       d$$$$;    \n" +
                                        "                /  /P'      d$$$$P. |\\ \n" +
                                        "               /   '      .d$$$P' |\\^'l                                            PRESS ANY KEY TO START FIGHT\n" +
                                        "             .'           `T$P^'''''  :\n" +
                                        "         ._.'      _.'                ;\n" +
                                        "      `-.-'.-'-' ._.       _.-'    .-' \n" +
                                        "    `.-' _____  ._              .-'    \n" +
                                        "   -(.g$$$$$$$b.              .'       \n" +
                                        "     ''^^T$$$P^)            .(:        \n" +
                                        "       _/  -'  /.'         /:/;        \n" +
                                        "    ._.'-'`-'  ')/         /;/;        \n" +
                                        " `-.-'..--''   ' /         /  ;        \n" +
                                        ".-' ..--''        -'          :        \n" +
                                        "..--''--.-'         (\\      .-(\\       \n" +
                                        "  ..--''              `-\\(\\/;`         \n", ConsoleColor.DarkGray);
                                      


                Console.ReadKey();
                Console.Clear();





                Wolf wolfie = new Wolf();
                int roundCounter = 0;
                string moveSelect = null;
                while(glad.IsAlive && wolfie.IsAlive)
                {
                    roundCounter++;
                    
                    while(moveSelect != "1" && moveSelect != "2" && moveSelect != "3" && moveSelect != "4")
                    {
                        Console.WriteLine($"                                Round {roundCounter}\n\n\n\n" +
                                      $"Make your move:\n\n" +
                                      $"1. Attack\n\n" +
                                      $"2. Defend\n\n" +
                                      $"3. Charge\n\n" +
                                      $"4. Weapon skill\n\n");
                        moveSelect = Console.ReadLine();
                    }
                    Console.Clear();

                    switch (moveSelect)
                    {
                        case "1":
                            glad.Attack(wolfie);
                            break;
                        case "2":
                            glad.Defend();
                            break;
                        case "3":
                            glad.Charge();
                            break;
                        case "4":
                            glad.ArmWeapon.Skill(wolfie);
                            break;
                    }

                    Random rnd = new Random();
                    int los = rnd.Next(0, 6);



                    if (glad.ArmWeapon.stunChance && moveSelect == "4")
                    {
                        if(glad.AbilityPoints < 4)
                        {
                            Console.Clear();
                            Console.WriteLine("You are out of ability points, can't use skill, charge up first");
                            moveSelect = null;
                            Thread.Sleep(1500);
                            Console.Clear();
                        }
                        else
                        {
                            glad.AbilityPoints -= 4;
                            glad.Attack(wolfie);
                        }
                        
                    }
                    
                    else if(!glad.ArmWeapon.stunChance && moveSelect == "4")
                    {

                        if (glad.AbilityPoints < 4)
                        {
                            Console.Clear();
                            Console.WriteLine("You are out of ability points, can't use skill, charge up first");
                            moveSelect = null;
                            Thread.Sleep(1500);
                            Console.Clear();
                            wolfie.Attack(glad);
                        }
                        else
                        {
                            glad.AbilityPoints -= 4;
                            wolfie.Attack(glad);
                        }
                            
                    }
                    
                    else if(los > 2)
                    {
                        wolfie.Skill(glad);
                        
                    }
                    
                    else if(wolfie.AbilityPoints < 3)
                    {
                        wolfie.Charge();
                    }

                    else if(wolfie.HealthPoints < 5 && los > 2)
                    {
                        wolfie.Defend();
                    }

                    else
                    {
                        wolfie.Attack(glad);
                    }


                    moveSelect = null;






                }

                

                
                 












                gameOver = true; 
            }

            //while(glad.IsAlive && wolfie.IsAlive)
            //{
            //    Console.WriteLine("Gladiator turn:\n" +
            //        "1. Attack\n" +
            //        "2. Defend\n" +
            //        "3.Charge\n" +
            //        "4. Skill");
            //    int select = int.Parse(Console.ReadLine());
            //
            //    switch (select)
            //    {
            //        case 1:
            //            glad.Attack(wolfie);
            //            
            //            break;
            //        case 2:
            //            glad.Defend();
            //            
            //            break;
            //        case 3:
            //            glad.Charge();
            //            
            //            break;
            //           
            //    }
            //    
            //    Console.WriteLine("Wolf turn:\n" +
            //        "1. Attack\n" +
            //        "2. Defend\n" +
            //        "3.Charge\n" +
            //        "4. Skill");
            //    int enemySelect = int.Parse(Console.ReadLine());
            //
            //    switch (enemySelect)
            //    {
            //        case 1:
            //            wolfie.Attack(glad);
            //            Console.WriteLine($"Glad health is {glad.HealthPoints}");
            //            break;
            //        case 2:
            //            wolfie.Defend();
            //            Console.WriteLine($"Wolf health is {wolfie.HealthPoints}");
            //            break;
            //        case 3:
            //            wolfie.Charge();
            //            Console.WriteLine($"Wolfie AbilityPoints is {wolfie.AbilityPoints}");
            //            break;
            //        case 4:
            //            wolfie.Skill(glad);
            //            break;
            //
            //
            //    }
            //    if(glad.HealthPoints == 0)
            //    {
            //        glad.IsAlive = false;
            //        Tools.ColorfulWriteLine($"{wolfie.ToString()} defeat you.\n" +
            //            $"You DIED", ConsoleColor.Red);
            //    }
            //    else if(wolfie.HealthPoints == 0)
            //    {
            //        glad.IsAlive = false;
            //        Tools.ColorfulWriteLine($"You defeat {wolfie.ToString()}.\n\n" +
            //            $"{glad.Name} is victorious", ConsoleColor.Green);
            //    }
            //}

            Console.ReadLine();
        }
    }
}
