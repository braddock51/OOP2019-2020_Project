
using Armors;
using Characters.Opponents;
using Interfaces;
using System;
using Weapons;
using Utilities;

namespace Characters.MainChar
{
    public class Gladiator : IAttack, ICharge, IDefend
    {
        Random rnd = new Random();

        public const int DEFAULT_GLADIATOR_ABILITY_POINTS = 10;
        public const int DEFAULT_GLADIATOR_HEALTH_POINTS = 30;
        
        
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
            private set
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
                if (this.HealthPoints == 0)
                    this.isAlive = false;
                else
                    this.isAlive = true;
            }
        }

        public Gladiator()
        {

        }

        public Gladiator(string name)
        {
            this.Name = name;
            this.AbilityPoints = DEFAULT_GLADIATOR_ABILITY_POINTS;
            this.HealthPoints = DEFAULT_GLADIATOR_HEALTH_POINTS;
            this.level = 1;
            this.IsAlive = true;


        }

        public void Attack(Opponent enemy)
        {
            int criticalRnd = rnd.Next(0, 26);
            

            for (int i = 0; i <= this.ArmWeapon.Critical; i++)
            {
                if(criticalRnd >= 0 && criticalRnd <= this.ArmWeapon.Critical)
                {
                    enemy.HealthPoints = enemy.HealthPoints - this.ArmWeapon.Damage * 2;
                    this.AbilityPoints--;
                    Tools.ColorfulWriteLine($"{this.Name} has critical hit for {this.ArmWeapon.Damage * 2} to {enemy.ToString()}\n\n" +
                        $"{enemy.ToString()} health points is equal to {enemy.HealthPoints}\n\n" +
                        $"Your ability points decreased by 1\n\n" +
                        $"Now you have {this.AbilityPoints} ability points", ConsoleColor.Green);
                    break;
                    
                    
                }
                else
                {
                    enemy.HealthPoints = enemy.HealthPoints - this.ArmWeapon.Damage;
                    this.AbilityPoints--;
                    Tools.ColorfulWriteLine($"{this.Name} hit {enemy.ToString()} for {this.ArmWeapon.Damage}\n\n" +
                        $"{enemy.ToString()} health points is equal to {enemy.HealthPoints}\n\n" +
                        $"Your ability points decreased by 1\n\n" +
                        $"Now you have {this.AbilityPoints} ability points", ConsoleColor.Green);
                    break;
                }
            }
            
            
           
        }

        public void Defend()
        {
            this.ChestArmor.ArmorPoints++;
        }

        public void Charge()
        {
            this.AbilityPoints++;
        }
    }
}
