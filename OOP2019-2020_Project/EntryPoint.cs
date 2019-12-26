﻿


using Armors;
using Characters.MainChar;
using Characters.Opponents;
using System;
using Utilities;
using Weapons;

namespace OOP2019_2020_Project
{
    public class EntryPoint
    {
        static void Main()
        {

            Gladiator glad = new Gladiator("Jaro");
            Wolf wolfie = new Wolf();

            glad.ArmWeapon = new LongSword();
            glad.ChestArmor = new BreastPlate();

            while(glad.IsAlive && wolfie.IsAlive)
            {
                Console.WriteLine("Gladiator turn:\n" +
                    "1. Attack\n" +
                    "2. Defend\n" +
                    "3.Charge\n" +
                    "4. Skill");
                int select = int.Parse(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        glad.Attack(wolfie);
                        
                        break;
                    case 2:
                        glad.Defend();
                        
                        break;
                    case 3:
                        glad.Charge();
                        
                        break;
                       
                }
                
                Console.WriteLine("Wolf turn:\n" +
                    "1. Attack\n" +
                    "2. Defend\n" +
                    "3.Charge\n" +
                    "4. Skill");
                int enemySelect = int.Parse(Console.ReadLine());

                switch (enemySelect)
                {
                    case 1:
                        wolfie.Attack(glad);
                        Console.WriteLine($"Glad health is {glad.HealthPoints}");
                        break;
                    case 2:
                        wolfie.Defend();
                        Console.WriteLine($"Wolf health is {wolfie.HealthPoints}");
                        break;
                    case 3:
                        wolfie.Charge();
                        Console.WriteLine($"Wolfie AbilityPoints is {wolfie.AbilityPoints}");
                        break;
                    case 4:
                        wolfie.Skill(glad);
                        break;


                }
                if(glad.HealthPoints == 0)
                {
                    glad.IsAlive = false;
                    Tools.ColorfulWriteLine($"{wolfie.ToString()} defeat you.\n" +
                        $"You DIED", ConsoleColor.Red);
                }
                else if(wolfie.HealthPoints == 0)
                {
                    glad.IsAlive = false;
                    Tools.ColorfulWriteLine($"You defeat {wolfie.ToString()}.\n\n" +
                        $"{glad.Name} is victorious", ConsoleColor.Green);
                }
            }

            Console.ReadLine();
        }
    }
}
