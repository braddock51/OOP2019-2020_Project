
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
        private int level;

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
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException(string.Empty, "Health points can't be lower then 0 or higher then 100");
                else
                    this.healthPoints = value;
            }
        }
        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                if (value > 5)
                    throw new ArgumentOutOfRangeException(string.Empty, "Maximum level is 5");
                else if (value < 0)
                    throw new ArgumentOutOfRangeException(string.Empty, "Level can't be lesser then 0");
                else
                    this.level = value;
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
            private set
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
            this.level = 1;
            this.IsAlive = true;



        }

        public void Attack(Opponent enemy)
        {
            if(this.AbilityPoints == 0)
            {
                Console.WriteLine("You are out of AP, need charge up");
                this.Charge();

            }
            
            else
            {
                int criticalRnd = rnd.Next(1, 21);
                
                if (criticalRnd >= 0 && criticalRnd <= this.ArmWeapon.Critical)
                {
                        enemy.HealthPoints = enemy.HealthPoints - this.ArmWeapon.Damage * 3;
                        this.AbilityPoints--;
                        Tools.ColorfulWriteLine($"{this.Name} has critical hit for {this.ArmWeapon.Damage * 3} to {enemy.ToString()}\n\n" +
                            $"{enemy.ToString()} health points is equal to {enemy.HealthPoints}\n\n" +
                            $"Your ability points decreased by 1\n\n" +
                            $"Now you have {this.AbilityPoints} ability points", ConsoleColor.Green);

                    Thread.Sleep(5000);
                    Console.Clear();


                }

                else
                    {
                        enemy.HealthPoints = enemy.HealthPoints - this.ArmWeapon.Damage;
                        this.AbilityPoints--;
                        Tools.ColorfulWriteLine($"{this.Name} hit {enemy.ToString()} for {this.ArmWeapon.Damage}\n\n" +
                            $"{enemy.ToString()} health points is equal to {enemy.HealthPoints}\n\n" +
                            $"Your ability points decreased by 1\n\n" +
                            $"Now you have {this.AbilityPoints} ability points\n\n", ConsoleColor.Green);

                    Thread.Sleep(5000);
                    Console.Clear();

                }
                
                
                if(enemy.HealthPoints < 1)
                {
                    Tools.ColorfulWriteLine($"You kill the wolf.\n" +
                        $"{this.Name} is victourius !!!", ConsoleColor.DarkGreen);

                    enemy.IsAlive = false;
                }

            }
                    
        }
                

            
            
            
           

        public void Defend()
        {
            Tools.ColorfulWriteLine($"{this.Name} is in defending pose, armor is increased by 1", ConsoleColor.Green);
            this.ChestArmor.ArmorPoints++;
            
            Thread.Sleep(5000);
            Console.Clear();
        }

        public void Charge()
        {
            Tools.ColorfulWriteLine($"{this.Name} is walked away a bit to use some meditation, ability points increased by 1", ConsoleColor.Green);
            this.AbilityPoints++;
            
            Thread.Sleep(5000);
            Console.Clear();
        }
    }
}
