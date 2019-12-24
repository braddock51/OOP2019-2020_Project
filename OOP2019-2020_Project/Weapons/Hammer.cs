

using Enums;

namespace Weapons
{
    public class Hammer : Weapon
    {
        public const int DEFAULT_HAMMER_DAMAGE = 10;
        public const int DEFAULT_HAMMER_CRITICAL = 0;

        public Hammer()
            : base(WeaponKind.Blunt, DEFAULT_HAMMER_DAMAGE, DEFAULT_HAMMER_CRITICAL)
        {

        }

        public override string ToString()
        {
            return "Hammer";
        }
    }
}
