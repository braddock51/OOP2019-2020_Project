

using Characters.MainChar;
using Interfaces;
using System;
using System.Threading;
using Utilities;

namespace Characters.Opponents
{
    public abstract class Opponent : IOpponentAttack, IDefend, ICharge
    {
        Random rnd = new Random();
        
        private int abilityPoints;
        private int healthPoints;
        private int damage;

        private bool isAlive;


        public int AbilityPoints
        {
            get
            {
                return this.abilityPoints;
            }
            protected set
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
                if (value >= 0 && value <= 100)
                {
                    this.healthPoints = value;
                }
                else
                {
                    //throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 100.");
                }
            }
        }
        public int Damage 
        { 
            get
            {
                return this.damage;
            }
            protected set
            {
                this.damage = value;
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

        public Opponent()
        {

        }
        
        public Opponent(int abilityPoints, int healthPoints, int damage)
        {
            this.AbilityPoints = abilityPoints;
            this.HealthPoints = healthPoints;
            this.Damage = damage;
            this.IsAlive = true;
            
        }

        public void Attack(Gladiator gladiator)
        {
            int los = rnd.Next(1, 16);
            Console.WriteLine(los);

            if (this.AbilityPoints <= 0)
            {
                
                this.Charge();

            }

            else
            {
                if (los <= gladiator.ChestArmor.Dodge)
                {
                    Tools.ColorfulWriteLine($"{gladiator.Name} dodge wolf attack.\n\n", ConsoleColor.Green);

                    Thread.Sleep(5000);
                    Console.Clear();
                }

                else
                {
                    gladiator.HealthPoints = gladiator.HealthPoints + gladiator.ChestArmor.ArmorPoints - this.Damage;
                    this.AbilityPoints--;
                    Tools.ColorfulWriteLine($"{this.ToString()} hit {gladiator.Name} for {this.Damage}\n\n" +
                        $"{gladiator.Name} health points is equal to {gladiator.HealthPoints}\n\n" +
                        $"{this.ToString()} ability points decreased by 1\n\n" +
                        $"{this.ToString()} abilitiy points is equal to {this.AbilityPoints}\n\n", ConsoleColor.Red);

                    Thread.Sleep(5000);
                    Console.Clear();

                }
            }

            
        }

        public void Defend()
        {
            Tools.ColorfulWriteLine($"{this.ToString()} is in defending pose, his health is increased by 1\n\n", ConsoleColor.Red);
            this.HealthPoints++;

            Thread.Sleep(5000);
            Console.Clear();
        }

        public void Charge()
        {
            Tools.ColorfulWriteLine($"{this.ToString()} is walked away a bit to charge up, his ability points is increased by 1\n\n", ConsoleColor.Red);
            this.AbilityPoints++;

            Thread.Sleep(5000);
            Console.Clear();
        }
    }
}
