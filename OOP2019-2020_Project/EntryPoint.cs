


using Armors;
using Characters.MainChar;
using Characters.Opponents;
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
                    Thread.Sleep(1000);
                    

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
