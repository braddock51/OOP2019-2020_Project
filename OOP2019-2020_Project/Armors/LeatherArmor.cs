using Enums;
using System;
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
            Console.WriteLine($"Type: {base.KindOfArmor.ToString()}\n" +
                              $"Name of armor: {this.ToString()}\n" +
                              $"Armor points: {Consts.LeatherArmor.LEATHER_ARMOR_ARMOR_POINTS}\n" +
                              $"Dodge: {Consts.LeatherArmor.LEATHER_ARMOR_DODGE}\n");
        }

        public override string ToString()
        {
            return "Leather Armor";
        }
    }
}
