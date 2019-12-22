

using Enums;

namespace Armors
{
    public abstract class Armor
    {
        
        private ArmorKind armorKind;

        private int armorPoints;
        private int dodge;

        public ArmorKind ArmorKind 
        { 
            get
            {
                return this.armorKind;
            }
            protected set
            {
                this.armorKind = value;
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
        public int Dodge 
        { 
            get
            {
                return this.dodge;
            }
            protected set
            {
                this.dodge = value;
            }
        }
        
        public Armor()
        {

        }
        
        public Armor(ArmorKind armorKind, int armorPoints, int dodge)
        {
            this.ArmorKind = armorKind;
            this.ArmorPoints = armorPoints;
            this.Dodge = dodge;
        }
        

            

       
    }
}
