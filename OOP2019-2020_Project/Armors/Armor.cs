

namespace Armors
{
    public abstract class Armor
    {
        private string armorName;

        private int armorPoints;

        public string ArmorName
        {
            get
            {
                return this.armorName;
            }
            protected set
            {
                this.armorName = value;
            }
        }

        public int ArmorPoints
        {
            get
            {
                return this.armorPoints;
            }
            protected set
            {
                this.armorPoints = value;
            }
        }

        public Armor()
        {

        }

        public Armor(string armorName, int armorPoints)
        {
            this.ArmorName = armorName;
            this.ArmorPoints = armorPoints;
        }
    }
}
