
using Armors;
using Interfaces;
using System;
using Weapons;

namespace Characters.MainChar
{
    public class Gladiator : IAttack, IDefend, ICharge
    {
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
                this.abilityPoints = 10;
            }
        }
        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            protected set
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

        public Gladiator(string name, int abilityPoints, int healthPoints)
        {
            this.Name = name;
            this.AbilityPoints = abilityPoints;
            this.HealthPoints = healthPoints;
            this.level = 1;
            this.IsAlive = true;


        }

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void Defend()
        {
            throw new NotImplementedException();
        }

        public void Charge()
        {
            throw new NotImplementedException();
        }
    }
}
