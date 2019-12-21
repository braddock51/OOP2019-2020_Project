

namespace Weapons
{
    public abstract class Weapon
    {
        private string weaponName;

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

        public Weapon(string weaponName, int damage)
        {
            this.WeaponName = weaponName;
            this.Damage = damage;
        }
    }
}
