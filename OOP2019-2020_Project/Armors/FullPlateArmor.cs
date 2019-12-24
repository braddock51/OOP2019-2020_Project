using Enums;

namespace Armors
{
    public class FullPlateArmor : Armor
    {
        public const int FULL_PLATE_ARMOR_ARMOR_POINTS = 10;
        public const int FULL_PLATE_ARMOR_DODGE = 0;

        public FullPlateArmor()
            : base(ArmorKind.Heavy, FULL_PLATE_ARMOR_ARMOR_POINTS, FULL_PLATE_ARMOR_DODGE)
        {

        }

        public override string ToString()
        {
            return "FullPlate Armor";
        }
    }
}
