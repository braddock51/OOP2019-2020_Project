using Enums;

namespace Armors
{
    public class BreastPlate : Armor
    {
        public const int BREAST_PLATE_ARMOR_POINTS = 7;
        public const int BREAST_PLATE_ARMOR_DODGE = 3;
        
        public BreastPlate()
            : base(ArmorKind.HalfHeavy, BREAST_PLATE_ARMOR_POINTS, BREAST_PLATE_ARMOR_DODGE)
        {

        }
    }
}
