

namespace Weapons
{
    public abstract class Weapon
    {
        private string weaponName;
        private string weaponKind;

        private int damage;

        public string WeaponName
        {
            get
            {
                return this.weaponName;
            }
            protected set
            {
                this.weaponName = value;
            }
        }
        public string WeaponKind 
        { 
            get
            {
                return this.weaponKind;
            }
            protected set
            {
                this.weaponKind = value;
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

        public Weapon()
        {

        }

       
    }
}
