

using Enums;

namespace Armors
{
    public abstract class Armor
    {
        
        private ArmorKind armorKind;

        private int armorPoints;
        private int dodge;

        public ArmorKind KindOfWeapon 
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
            set
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
            set
            {
                this.dodge = value;
            }
        }
        
        public Armor()
        {

        }
        
        public Armor(ArmorKind armorKind, int armorPoints, int dodge)
        {
            this.KindOfWeapon = armorKind;
            this.ArmorPoints = armorPoints;
            this.Dodge = dodge;
        }
        

            

       
    }
}
