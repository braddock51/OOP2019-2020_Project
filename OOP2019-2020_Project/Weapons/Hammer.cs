

using Characters.Opponents;
using Enums;
using Interfaces;
using System;
using System.Threading;
using Utilities;

namespace Weapons
{
    public class Hammer : Weapon
    {
        public const int DEFAULT_HAMMER_DAMAGE = 10;
        public const int DEFAULT_HAMMER_CRITICAL = 0;

        public Hammer()
            : base(WeaponKind.Blunt, DEFAULT_HAMMER_DAMAGE, DEFAULT_HAMMER_CRITICAL)
        {

        }

        
        private void Stun(Opponent enemy)
        {
            Random rnd = new Random();
            int los = rnd.Next(1, 11);
            Console.WriteLine(los);

            if(los <= 4)
            {
                Tools.ColorfulWriteLine(" ___  _____  _  _  _   _ \n" +
                                        "/  _)(_   _)( )( )( \\ ( )\n" +
                                        "\\_'-.  | |  | || || \\\\| |\n" +
                                        " __) ) ( )  ( L| )( )\\\\ )\n" +
                                        "/___/  /_\\  /____\\/_\\ \\_\\\n", ConsoleColor.DarkYellow);
                Tools.ColorfulWriteLine($"\n\n\n\n{enemy.ToString()} lost his turn\n\n\n", ConsoleColor.Green);

                base.stunChance = true;
            }

            else
            {
                Tools.ColorfulWriteLine(" ___  _____  _  _  _   _    ____  __   _  _    ____  __   \n" +
                                        "/  _)(_   _)( )( )( \\ ( )  (  __)(  ) ( )( )  (  __)(  )  \n" +
                                        "\\_'-.  | |  | || || \\\\| |  | |_  /o \\ | || |  | |_  |   \\ \n" +
                                        " __) ) ( )  ( L| )( )\\ )  ( __)( __ )( )( )_ (  _) ( O  )\n" +
                                        "/___/  /_\\  /____\\/_\\ \\_\\  /_\\  /_\\/_\\/_\\/___\\/____\\/___/ \n\n\n\n", ConsoleColor.Red);
                base.stunChance = false;

                Thread.Sleep(2000);
                Console.Clear();
            }
        }
        
        public override void Skill(Opponent enemy)
        {
            this.Stun(enemy);
        }

        public override string ToString()
        {
            return "Hammer";
        }

        public override void GetWeaponInfo()
        {
            Console.WriteLine($"Type: {base.KindOfWeapon.ToString()}\n" +
                              $"Name of weapon: {this.ToString()}\n" +
                              $"Damage: {DEFAULT_HAMMER_DAMAGE}\n" +
                              $"Critical: {DEFAULT_HAMMER_CRITICAL}\n" +
                              $"Special skill: Stun - Some chance to taking a round from the opponent");
        }
    }
}
