

using Characters.MainChar;
using Characters.Opponents;
using Enums;
using System;
using System.Threading;
using Utilities;

namespace Weapons
{
    public class LongSword : Weapon
    {
        

        public LongSword()
            : base(WeaponKind.Sword, Consts.LongSword.DEFAULT_LONG_SWORD_DAMAGE, Consts.LongSword.DEFAULT_LONG_SWORD_CRITICAL, Consts.LongSword.DEFAULT_COURAGE_COST)
        {

        }

        private void Courage()
        {
            this.Critical += 5;

            Tools.ColorfulWriteLine(" _____                                  \n" +
                                    "/  __ \\                                 \n" +
                                    "| /  \\/ ___  _   _ _ __ __ _  __ _  ___ \n" +
                                    "| |    / _ \\| | | | '__/ _` |/ _` |/ _ \\ \n" +
                                    "| \\__/\\ (_) | |_| | | | (_| | (_| |  __/\n" +
                                    " \\____/\\___/ \\__,_|_|  \\__,_|\\__, |\\___|\n" +
                                    "                              __/ |     \n" +
                                    "                             |___/      \n\n\n", ConsoleColor.Blue);

            Tools.ColorfulWriteLine("Your critical is increased by 5\n\n\n\n", ConsoleColor.Green);

            Thread.Sleep(2500);
            Console.Clear();


        }

        public override void GetWeaponInfo()
        {
            Console.WriteLine($"Type: {base.KindOfWeapon.ToString()}\n" +
                              $"Name of weapon: {this.ToString()}\n" +
                              $"Damage: {Consts.LongSword.DEFAULT_LONG_SWORD_DAMAGE}\n" +
                              $"Critical: {Consts.LongSword.DEFAULT_LONG_SWORD_CRITICAL}\n" +
                              $"Special skill: Courage - add 5 critical points for one round\n");
        }

        public override void Skill(Opponent enemy)
        {
            this.Courage();
        }

        public override string ToString()
        {
            return "Long Sword";
        }
    }
}
