using Enums;

namespace Armors
{
    public class LeatherArmor : Armor
    {
        public const int LEATHER_ARMOR_ARMOR_POINTS = 5;
        public const int LEATHER_ARMOR_DODGE = 5;
        
        public LeatherArmor()
            : base(ArmorKind.Light, LEATHER_ARMOR_ARMOR_POINTS, LEATHER_ARMOR_DODGE)
        {

        }
    }
}
