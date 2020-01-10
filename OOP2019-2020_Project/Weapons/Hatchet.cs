

using Characters.Opponents;
using Enums;
using System;
using Utilities;

namespace Weapons
{
    public class Hatchet : Weapon
    {
        public const int DEFAULT_HATCHET_DAMAGE = 7;
        public const int DEFAULT_HATCHET_CRITICAL = 3;
        public const int DEFAULT_BLEED_COST = 5;

        public Hatchet()
            : base(WeaponKind.Axe, DEFAULT_HATCHET_DAMAGE, DEFAULT_HATCHET_CRITICAL, DEFAULT_BLEED_COST)
        {

        }

        private void Bleed(Opponent enemy)
        {
            Random rnd = new Random();
            int los = rnd.Next(1, 11);

            if (los <= 6)
            {
                Tools.ColorfulWriteLine(" ___    _                      _ \n" +
                                    "(  _`\\ (_ )                   ( )\n" +
                                    "| (_) ) | |    __     __     _| |\n" +
                                    "|  _ <' | |  /'__`\\ /'__`\\ /'_` |\n" +
                                    "| (_) ) | | (  ___/(  ___/( (_| |\n" +
                                    "(____/'(___)`\\____)`\\____)`\\__,_)\n\n\n\n", ConsoleColor.Red);

                Tools.ColorfulWriteLine("Bleed succeeded\n" +
                                        "Your enemy will bleed for 3 rounds, losing some life every round", ConsoleColor.Green);

                base.bleedChance = true;
            }
            else
            {
                Tools.ColorfulWriteLine(" ___    _                      _     ___    _____  _  _      ___    ___   \n" +
                                        "(  _`\\ (_ )                   ( )   (  _`\\ (  _  )(_)( )    (  _`\\ (  _`\\ \n" +
                                        "| (_) ) | |    __     __     _| |   | (_(_)| (_) || || |    | (_(_)| | ) |\n" +
                                        "|  _ <' | |  /'__`\\ /'__`\\ /'_` |   |  _)  |  _  || || |  _ |  _)_ | | | )\n" +
                                        "| (_) ) | | (  ___/(  ___/( (_| |   | |    | | | || || |_( )| (_( )| |_) |\n" +
                                        "(____/'(___)`\\____)`\\____)`\\__,_)   (_)    (_) (_)(_)(____/'(____/'(____/'", ConsoleColor.DarkGray);

                base.bleedChance = false;
            }
            
        }

        public override void GetWeaponInfo()
        {
            Console.WriteLine($"Type: {base.KindOfWeapon.ToString()}\n" +
                              $"Name of weapon: {this.ToString()}\n" +
                              $"Damage: {DEFAULT_HATCHET_DAMAGE}\n" +
                              $"Critical: {DEFAULT_HATCHET_CRITICAL}\n" +
                              $"Special skill: Bleed - Some chance to inflict bleed to the enemy, it's deals some damage for 3 rounds");
        }

        public override void Skill(Opponent enemy)
        {
            this.Bleed(enemy);
        }

        public override string ToString()
        {
            return "Hatchet";
        }
    }
}
