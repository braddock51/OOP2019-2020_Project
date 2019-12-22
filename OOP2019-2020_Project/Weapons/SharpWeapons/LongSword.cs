

namespace Weapons.SharpWeapons
{
    public class LongSword : SharpWeapon
    {
        public const string LONG_SWORD_NAME = "Long sword";
        public const int LONG_SWORD_DAMAGE = 10;

        public LongSword()
        {
            base.WeaponName = LONG_SWORD_NAME;
            base.Damage = LONG_SWORD_DAMAGE;
        }
    }
}
