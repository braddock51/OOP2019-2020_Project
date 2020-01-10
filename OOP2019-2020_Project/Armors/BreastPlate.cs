using Enums;
using Utilities;

namespace Armors
{
    public class BreastPlate : Armor
    {
        
        
        public BreastPlate()
            : base(ArmorKind.HalfHeavy, Consts.BreastPlate.BREAST_PLATE_ARMOR_POINTS, Consts.BreastPlate.BREAST_PLATE_ARMOR_DODGE)
        {

        }

        public override void GetArmorInfo()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return "BreastPlate Armor";
        }
    }
}
