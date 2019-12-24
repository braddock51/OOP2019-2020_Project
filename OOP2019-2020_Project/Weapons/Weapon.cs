

using Enums;

namespace Weapons
{
    public abstract class Weapon
    {
        private WeaponKind weaponKind;
        
        private int damage;
        private int critical;

        public WeaponKind KindOfWeapon 
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
        public int Critical 
        { 
            get
            {
                return this.critical;
            }
            protected set
            {
                this.critical = value;
            }
        }

        public Weapon()
        {

        }

        protected Weapon(WeaponKind kindOfWeapon, int damage, int critical)
        {
            this.KindOfWeapon = kindOfWeapon;
            this.Damage = damage;
            this.Critical = critical;
        }
    }
}
