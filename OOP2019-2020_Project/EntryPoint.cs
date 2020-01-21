


using Armors;
using Characters.MainChar;
using Characters.Opponents;
using Enums;
using Interfaces;
using System;
using System.Threading;
using Utilities;
using Weapons;

namespace OOP2019_2020_Project
{
    public class EntryPoint
    {
        static void Main()
        {


            try
            {
                bool gameOver = true;

                while (gameOver)
                {

                    string startMenuSelect = null;
                    while (startMenuSelect != "0" && startMenuSelect != "1" && startMenuSelect != "2")
                    {
                        Arts.StartMenu();
                        startMenuSelect = Console.ReadLine();
                        Console.Clear();
                        if (startMenuSelect == "2")
                        {
                            Tools.AuthorInfo();
                            Tools.ColorfulWriteLine("\n\n\n\n\nPRESS ANY KEY", ConsoleColor.Green);
                            Console.ReadKey();
                            Console.Clear();
                            startMenuSelect = null;
                        }

                    }


                    if (startMenuSelect == "0")
                        break;



                    Arts.GladiatorName();
                    string name = Console.ReadLine();
                    Gladiator glad = new Gladiator(name);

                    Console.Clear();

                    Arts.ArmYourGladiator();

                    Thread.Sleep(1500);
                    Console.Clear();




                    string weaponSelect = null;
                    while (weaponSelect != "a" && weaponSelect != "b" && weaponSelect != "c")
                    {
                        Arts.ChoseYourWeapon();
                        weaponSelect = Console.ReadLine();

                        Console.Clear();


                    }

                    switch (weaponSelect)
                    {
                        case "a":
                            glad.ArmWeapon = new LongSword();
                            break;
                        case "b":
                            glad.ArmWeapon = new Hatchet();
                            break;
                        case "c":
                            glad.ArmWeapon = new Hammer();
                            break;
                    }

                    string armorSelect = null;
                    while (armorSelect != "a" && armorSelect != "b" && armorSelect != "c")
                    {
                        Arts.ChoseYourArmor();
                        armorSelect = Console.ReadLine();
                        Console.Clear();
                    }

                    switch (armorSelect)
                    {
                        case "a":
                            glad.ChestArmor = new FullPlateArmor();
                            break;
                        case "b":
                            glad.ChestArmor = new BreastPlate();
                            break;
                        case "c":
                            glad.ChestArmor = new LeatherArmor();
                            break;
                    }



                    string startSelect = null;
                    while (startSelect != "1" && startSelect != "2" && startSelect != "0")
                    {
                        Tools.ColorfulWriteLine("1: START THE FIGHT\n\n" +
                                                "2: CHECK YOUR GLADIATOR STATS\n\n" +
                                                "0: return to the first menu.", ConsoleColor.Red);
                        startSelect = Console.ReadLine();
                        Console.Clear();

                        if (startSelect == "2")
                        {
                            glad.GetGladiatorStats();
                            glad.ArmWeapon.GetWeaponInfo();
                            glad.ChestArmor.GetArmorInfo();
                            Tools.ColorfulWriteLine("\n\n\n\n\nPRESS ANY KEY", ConsoleColor.Green);
                            Console.ReadKey();
                            startSelect = null;
                            Console.Clear();

                        }
                    }

                    if (startSelect == "0")
                        continue;

                    Arts.Intro();

                    Wolf wolfie = new Wolf();
                    int roundCounter = 0;
                    string moveSelect = null;
                    while (glad.IsAlive)
                    {
                        roundCounter++;

                        while (moveSelect != "1" && moveSelect != "2" && moveSelect != "3" && moveSelect != "4" && moveSelect != "0")
                        {
                            Console.WriteLine($"                                Round {roundCounter}\n\n\n\n" +
                                          $"Make your move:\n\n" +
                                          $"1. Attack\n\n" +
                                          $"2. Defend\n\n" +
                                          $"3. Charge\n\n" +
                                          $"4. Weapon skill\n\n\n\n\n\n" +
                                          $"0: break the fight and come back to main menu");
                            moveSelect = Console.ReadLine();
                            Console.Clear();
                        }

                        if (moveSelect == "1")
                            glad.Attack(wolfie);
                        else if (moveSelect == "2")
                            glad.Defend();
                        else if (moveSelect == "3")
                            glad.Defend();
                        else if (moveSelect == "4")
                        {
                            if (glad.AbilityPoints >= 4)
                                glad.ArmWeapon.Skill(wolfie);
                            else
                            {
                                Tools.ColorfulWriteLine("You are out of AP, need to charge up to use ur skill\n\n\n\n" +
                                                        "PRESS ANY KEY TO CONTINUE", ConsoleColor.Cyan);
                                Console.ReadKey();
                                Console.Clear();

                                roundCounter--;
                                goto Found;

                            }
                        }
                        else
                            goto MainMenu;



                        Random rnd = new Random();
                        int los = rnd.Next(0, 6);

                        if (wolfie.HealthPoints <= 0)
                        {
                            Tools.ColorfulWriteLine($"\n\n\n\n\n                          You kill the wolf.\n" +
                                                    $"                          {glad.Name} is victourius !!!", ConsoleColor.DarkGreen);

                            Tools.ColorfulWriteLine("\n\n\n\n\n\n" +
                                                "PRESS ANY KEY TO CONTINUE", ConsoleColor.White);


                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }

                        if (glad.ArmWeapon.bleedCounter > 0)
                        {
                            Arts.Bleed();
                            wolfie.HealthPoints -= 5;
                            glad.ArmWeapon.bleedCounter--;



                            Thread.Sleep(2000);
                            Console.Clear();
                        }



                        if (glad.ArmWeapon.KindOfWeapon == WeaponKind.Sword && moveSelect == "4")
                        {

                            glad.AbilityPoints -= Consts.LongSword.DEFAULT_COURAGE_COST;
                            glad.Attack(wolfie);
                            glad.ArmWeapon.Critical = Consts.LongSword.DEFAULT_LONG_SWORD_CRITICAL;
                            wolfie.Attack(glad);
                        }

                        else if (glad.ArmWeapon.KindOfWeapon == WeaponKind.Axe && glad.ArmWeapon.bleedChance && moveSelect == "4")
                        {
                            glad.ArmWeapon.bleedCounter = 3;
                            Tools.ColorfulWriteLine("\n\n\n\n\n" +
                                                    "Your AP decrease by 5\n\n\n\n\n", ConsoleColor.Green);

                            glad.AbilityPoints -= glad.ArmWeapon.SkillCost;
                            wolfie.Attack(glad);
                        }
                        else if (glad.ArmWeapon.KindOfWeapon == WeaponKind.Axe && !glad.ArmWeapon.bleedChance && moveSelect == "4")
                        {
                            Tools.ColorfulWriteLine("\n\n\n\n\n" +
                                                    "Your AP decrease by 5\n\n\n\n\n", ConsoleColor.Green);

                            glad.AbilityPoints -= glad.ArmWeapon.SkillCost;
                            wolfie.Attack(glad);
                        }


                        else if (glad.ArmWeapon.KindOfWeapon == WeaponKind.Blunt && glad.ArmWeapon.stunChance && moveSelect == "4")
                        {
                            glad.AbilityPoints -= glad.ArmWeapon.SkillCost;
                            glad.Attack(wolfie);

                        }

                        else if (glad.ArmWeapon.KindOfWeapon == WeaponKind.Blunt && !glad.ArmWeapon.stunChance && moveSelect == "4")
                        {

                            glad.AbilityPoints -= glad.ArmWeapon.SkillCost;
                            wolfie.Attack(glad);

                        }

                        else if (los > 2)
                        {
                            wolfie.Skill(glad);

                        }

                        else if (wolfie.AbilityPoints < 3)
                        {
                            wolfie.Charge();
                        }

                        else if (wolfie.HealthPoints < 5 && los > 2)
                        {
                            wolfie.Defend();
                        }

                        else
                        {
                            wolfie.Attack(glad);
                        }

                    Found:
                        moveSelect = null;






                    }


                MainMenu:
                    continue;




                }

                Arts.DemoArt();
                Thread.Sleep(1500);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}
