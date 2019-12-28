

using Characters.MainChar;
using Interfaces;
using System;
using Utilities;

namespace Characters.Opponents
{
    public abstract class Opponent : IOpponentAttack, IDefend, ICharge
    {
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
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException(string.Empty, "Health points can't be lower then 0 or higher then 100");
                else
                    this.healthPoints = value;
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
            private set
            {
                if (this.HealthPoints == 0)
                    this.isAlive = false;
                else
                    this.isAlive = true;
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
            gladiator.HealthPoints = gladiator.HealthPoints + gladiator.ChestArmor.ArmorPoints - this.Damage;
            this.AbilityPoints--;
            Tools.ColorfulWriteLine($"{this.ToString()} hit {gladiator.Name} for {this.Damage}\n\n" +
                $"{gladiator.Name} health points is equal to {gladiator.HealthPoints}\n\n" +
                $"{this.ToString()} ability points decreased by 1\n\n" +
                $"{this.ToString()} abilitiy points is equal to {this.AbilityPoints}", ConsoleColor.Red);
        }

        public void Defend()
        {
            Tools.ColorfulWriteLine($"{this.ToString()} is in defending pose, his health is increased by 1", ConsoleColor.Red);
            this.HealthPoints++;
        }

        public void Charge()
        {
            Tools.ColorfulWriteLine($"{this.ToString()} is walked away a bit to charge up, his ability points is increased by 1", ConsoleColor.Red);
            this.AbilityPoints++;
        }
    }
}
