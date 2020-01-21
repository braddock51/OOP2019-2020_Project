using Enums;
using Armors;
using Characters.Opponents;
using Interfaces;
using System;
using Weapons;
using Utilities;
using System.Threading;

namespace Characters.MainChar
{
    public class Gladiator : IAttack, ICharge, IDefend
    {
        Random rnd = new Random();

        
        
        private string name;

        private int abilityPoints;
        private int healthPoints;
        

        private Armor chestArmor;
        private Weapon armWeapon;

        private bool isAlive;

        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                this.name = value;
            }
        }

        public int AbilityPoints
        {
            get
            {
                return this.abilityPoints;
            }
            set
            {
                this.abilityPoints = value;
            }
        }
        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                this.healthPoints = value;
            }
        }
        

        public Armor ChestArmor
        {
            get
            {
                return this.chestArmor;
            }
            set
            {
                this.chestArmor = value;
            }
        }
        public Weapon ArmWeapon
        {
            get
            {
                return this.armWeapon;
            }
            set
            {
                this.armWeapon = value;
            }
        }

        public bool IsAlive
        {
            get
            {
                return this.isAlive;
            }
            set
            {
                this.isAlive = value;
            }
        }

        public Gladiator()
        {

        }

        public Gladiator(string name)
        {
            this.Name = name;
            this.AbilityPoints = Consts.Gladiator.DEFAULT_GLADIATOR_ABILITY_POINTS;
            this.HealthPoints = Consts.Gladiator.DEFAULT_GLADIATOR_HEALTH_POINTS;
            this.IsAlive = true;
            

        }
            


        public void Attack(Opponent enemy)
        {
            int attackCost = 1;
            
            if (this.ArmWeapon.KindOfWeapon == WeaponKind.Sword)
            {
                Tools.ColorfulWriteLine("                              .___.                             \n" +
                                        "          /)               ,-^     ^-.                          \n" +
                                        "         //               /           \\                         \n" +
                                        ".-------| |--------------/  __     __  \\-------------------.__  \n" +
                                        "|WMWMWMW| |>>>>>>>>>>>>> | />>\\   />>\\ |>>>>>>>>>>>>>>>>>>>>>>:>\n" +
                                        "`-------| |--------------| \\__/   \\__/ |-------------------'^^  \n" +
                                        "         \\\\               \\    /|\\    /                         \n" +
                                        "          \\)               \\   \\_/   /                          \n" +
                                        "                            |       |                           \n" +
                                        "                            |+H+H+H+|                           \n" +
                                        "                            \\       /                           \n" +
                                        "                             ^-----^                            \n", ConsoleColor.White);
            }




            if (this.AbilityPoints <= 0)
            {
                Console.WriteLine("You are out of AP");
                this.Charge();

            }
            
            else
            {
                int criticalRnd = rnd.Next(1, 18);
                
                
                
                if (criticalRnd <= this.ArmWeapon.Critical)
                {
                        
                        
                    enemy.HealthPoints = enemy.HealthPoints - this.ArmWeapon.Damage * 4;
                        this.AbilityPoints--;
                        Tools.ColorfulWriteLine($"{this.Name} has critical hit for {this.ArmWeapon.Damage * 4} to {enemy.ToString()}\n\n" +
                            $"{enemy.ToString()} health points is equal to {enemy.HealthPoints}\n\n" +
                            $"Your ability points decreased by {attackCost}\n\n" +
                            $"Now you have {this.AbilityPoints - (attackCost)} ability points" +
                            $"\n\n\n\n" +
                            $"PRESS KEY TO CONTINUE", ConsoleColor.Green);

                    Console.ReadKey();
                    Console.Clear();


                }

                else
                    {
                        enemy.HealthPoints = enemy.HealthPoints - this.ArmWeapon.Damage;
                        this.AbilityPoints--;
                        Tools.ColorfulWriteLine($"{this.Name} hit {enemy.ToString()} for {this.ArmWeapon.Damage}\n\n" +
                            $"{enemy.ToString()} health points is equal to {enemy.HealthPoints}\n\n" +
                            $"Your ability points decreased by {attackCost}\n\n" +
                            $"Now you have {this.AbilityPoints} ability points\n\n" +
                            $"\n\n\n\n" +
                            $"PRESS KEY TO CONTINUE", ConsoleColor.Green);

                    Console.ReadKey();
                    Console.Clear();

                }
                
                
                

            }
                    
        }
                

        public void Defend()
        {
            Tools.ColorfulWriteLine("                .--..--..--..--.   \n" +
                                    "                / .. \\.. \\.. \\.. \\\n" +
                                    "                \\ \\/\\ \\/\\ \\/\\ \\/ / \n" +
                                    "                 \\/ /\\/ /\\/ /\\/ /  \n" +
                                    "                 / /\\/ /\\/ /\\/ /\\  \n" +
                                    "                / /\\ \\/\\ \\/\\ \\/\\ \\ \n" +
                                    "                \\ \\/\\ \\/\\ \\/\\ \\/ / \n" +
                                    "                 \\/ /\\/ /\\/ /\\/ /  \n" +
                                    "                 / /\\/ /\\/ /\\/ /\\  \n" +
                                    "                / /\\ \\/\\ \\/\\ \\/\\ \\ \n" +
                                    "                \\ \\/\\ \\/\\ \\/\\ \\/ / \n" +
                                    "                 \\/ /\\/ /\\/ /\\/ /  \n" +
                                    "                 / /\\/ /\\/ /\\/ /\\  \n" +
                                    "                / /\\ \\/\\ \\/\\ \\/\\ \\ \n" +
                                    "                \\ `'\\ `'\\ `'\\ `' / \n" +
                                    "                 `--'`--'`--'`--'  \n" +
                                    "\n\n\n", ConsoleColor.DarkMagenta);




            Tools.ColorfulWriteLine($"{this.Name} is in defending pose, armor is increased by 1" +
                $"\n\n\n\n" +
                $"PRESS KEY TO CONTINUE", ConsoleColor.Green);
            this.ChestArmor.ArmorPoints++;

            Console.ReadKey();
            Console.Clear();
        }
            
            
        public void Charge()
        {
            Tools.ColorfulWriteLine("                                        _\n" +
                                    "                                     _ooOoo_\n" +
                                    "                                    o8888888o\n" +
                                    "                                    88'. '88\n" +
                                    "                                    (| -_- |)\n" +
                                    "                                    O\\  =  /O\n" +
                                    "                                 ____/`---'\\____\n" +
                                    "                               .'  \\\\|     |//  `.\n" +
                                    "                              /  \\\\|||  :  |||//  \\\n" +
                                    "                             /  _||||| -:- |||||_  \\\n" +
                                    "                             |   | \\\\\\  -  /'| |   |\n" +
                                    "                             | \\_|  `\\`---'//  |_/ |\n" +
                                    "                             \\  .-\\__ `-. -'__/-.  /\n" +
                                    "                           ___`. .'  /--.--\\  `. .'___\n" +
                                    "                        .'' '<  `.___\\_<|>_/___.' _> \''.\n" +
                                    "                       | | :  `- \\`. ;`. _/; .'/ /  .' ; |\n" +
                                    "                       \\  \\ `-.   \\_\\_`. _.'_/_/  -' _.' /\n" +
                                    "             ===========`-.`___`-.__\\ \\___  /__.-'_.'_.-'================\n" +
                                    "                           `=--=-'                   \n\n\n", ConsoleColor.Magenta);


            Tools.ColorfulWriteLine($"{this.Name} is walked away a bit to use some meditation, ability points increased by 5" +
                $"\n\n\n\n" +
                $"PRESS ANY KEY TO CONTINUE", ConsoleColor.Green);
            this.AbilityPoints += 5;

            Console.ReadKey();
            Console.Clear();
        }
            
           
        public void GetGladiatorStats()
        {
            Console.WriteLine($"Name: {this.Name}\n" +
                              $"Health: {this.HealthPoints}\n" +
                              $"Ability points: {this.AbilityPoints}\n");
        }

    }
}
