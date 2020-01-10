

using Characters.Opponents;
using Enums;

namespace Weapons
{
    public abstract class Weapon
    {
        public bool stunChance;
        
        public bool bleedChance;
        public int bleedCounter = 0;


        private WeaponKind weaponKind;
        
        private int damage;
        private int critical;
        private int skillCost;

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
        public int SkillCost 
        { 
            get
            {
                return this.skillCost;
            }
            protected set
            {
                this.skillCost = value;
            }
        }

        public Weapon()
        {

        }

        protected Weapon(WeaponKind kindOfWeapon, int damage, int critical, int skillCost)
        {
            this.KindOfWeapon = kindOfWeapon;
            this.Damage = damage;
            this.Critical = critical;
            this.SkillCost = skillCost;
        }

        public abstract void GetWeaponInfo();

        public abstract void Skill(Opponent enemy);
    }
}
