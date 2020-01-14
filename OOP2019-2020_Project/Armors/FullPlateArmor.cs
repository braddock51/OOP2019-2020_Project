using Enums;
using System;
using Utilities;

namespace Armors
{
    public class FullPlateArmor : Armor
    {
        

        public FullPlateArmor()
            : base(ArmorKind.Heavy, Consts.FullPlateArmor.FULL_PLATE_ARMOR_ARMOR_POINTS, Consts.FullPlateArmor.FULL_PLATE_ARMOR_DODGE)
        {

        }

        public override void GetArmorInfo()
        {
            Console.WriteLine($"Type: {base.KindOfArmor.ToString()}\n" +
                              $"Name of armor: {this.ToString()}\n" +
                              $"Armor points: {Consts.FullPlateArmor.FULL_PLATE_ARMOR_ARMOR_POINTS}\n" +
                              $"Dodge: {Consts.FullPlateArmor.FULL_PLATE_ARMOR_DODGE}\n");
        }

        public override string ToString()
        {
            return "FullPlate Armor";
        }
    }
}
