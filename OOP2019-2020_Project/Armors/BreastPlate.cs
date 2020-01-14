using Enums;
using System;
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
            Console.WriteLine($"Type: {base.KindOfArmor.ToString()}\n" +
                              $"Name of armor: {this.ToString()}\n" +
                              $"Armor points: {Consts.BreastPlate.BREAST_PLATE_ARMOR_POINTS}\n" +
                              $"Dodge: {Consts.BreastPlate.BREAST_PLATE_ARMOR_DODGE}\n");
                              
        }

        public override string ToString()
        {
            return "BreastPlate Armor";
        }
    }
}
