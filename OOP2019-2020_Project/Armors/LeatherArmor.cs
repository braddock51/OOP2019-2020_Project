using Enums;
using Utilities;

namespace Armors
{
    public class LeatherArmor : Armor
    {
        
        
        public LeatherArmor()
            : base(ArmorKind.Light, Consts.LeatherArmor.LEATHER_ARMOR_ARMOR_POINTS, Consts.LeatherArmor.LEATHER_ARMOR_DODGE)
        {

        }

        public override void GetArmorInfo()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return "Leather Armor";
        }
    }
}
