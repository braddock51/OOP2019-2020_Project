using Armors;
using Characters;
using Weapons;

namespace Melees
{
    public abstract class Melee : Character
    {
        public const int DEFAULT_MELEE_ABILITY_POINTS = 10;
        public const int DEFAULT_MELEE_HEALTH_POINTS = 100;

        private Weapon handWeapon;
        private Armor wornArmor;


        

        public Melee(Weapon sword, Armor armor)
            : base(string.Empty, DEFAULT_MELEE_ABILITY_POINTS, DEFAULT_MELEE_HEALTH_POINTS)
        {

        }
    }
}
