

using Characters.Opponents;
using Enums;

namespace Weapons
{
    public class LongSword : Weapon
    {
        public const int DEFAULT_LONG_SWORD_DAMAGE = 5;
        public const int DEFAULT_LONG_SWORD_CRITICAL = 5;

        public LongSword()
            : base(WeaponKind.Sword, DEFAULT_LONG_SWORD_DAMAGE, DEFAULT_LONG_SWORD_CRITICAL)
        {

        }

        public override void GetWeaponInfo()
        {
            throw new System.NotImplementedException();
        }

        public override void Skill(Opponent enemy)
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return "Long Sword";
        }
    }
}
