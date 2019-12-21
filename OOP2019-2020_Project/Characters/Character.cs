using System;

namespace Characters
{
    public abstract class Character
    {
        private string name;

        private int abilityPoints;
        private int healthPoints;

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

        public Character()
        {

        }

        public Character(string name, int abilityPoints, int healthPoints)
        {
            this.Name = name;
            this.abilityPoints = abilityPoints;
            this.healthPoints = healthPoints;
        }
    }
}
