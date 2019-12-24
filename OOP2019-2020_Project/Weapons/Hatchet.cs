

using Enums;

namespace Weapons
{
    public class Hatchet : Weapon
    {
        public const int DEFAULT_HATCHET_DAMAGE = 7;
        public const int DEFAULT_HATCHET_CRITICAL = 3;

        public Hatchet()
            : base(WeaponKind.Axe, DEFAULT_HATCHET_DAMAGE, DEFAULT_HATCHET_CRITICAL)
        {

        }

        public override string ToString()
        {
            return "Hatchet";
        }
    }
}
