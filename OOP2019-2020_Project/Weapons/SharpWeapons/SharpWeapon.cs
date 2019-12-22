

namespace Weapons.SharpWeapons
{
    public class SharpWeapon : Weapon
    {
        public const string SHARP_WEAPON_NAME = "Sharp";
        
        public SharpWeapon()
        {
            base.WeaponKind = SHARP_WEAPON_NAME;
        }
    }
}
