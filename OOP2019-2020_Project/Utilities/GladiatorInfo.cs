

using Characters.MainChar;
using System;
using System.Collections.Generic;
using System.IO;

namespace Utilities
{
    public static class GladiatorInfo
    {
        private static string gladiatorInfoDirectoryPath = @"Info\";
        private static string gladiatorInfoFileName = "GladiatorInfo.txt";
        private static DirectoryInfo gladiatorInfoDir = new DirectoryInfo(gladiatorInfoDirectoryPath);
        private static FileInfo gladiatorInfoFile = new FileInfo(gladiatorInfoDirectoryPath + gladiatorInfoFileName);
        private static List<string> fullInfo = new List<string>();

        public static void GladiatorInitialize(Gladiator gladiator)
        {
            if (!gladiatorInfoDir.Exists)
            {

                gladiatorInfoDir.Create();
            }

            if(!gladiatorInfoFile.Exists)
            {
                gladiatorInfoFile.Create().Close();

                using(StreamWriter sw = gladiatorInfoFile.CreateText())
                {
                    sw.WriteLine($"Name: {gladiator.Name}");
                    sw.WriteLine($"Ability Points: {gladiator.AbilityPoints}");
                    sw.WriteLine($"Health Points: {gladiator.HealthPoints}");
                    sw.WriteLine($"Level: {gladiator.Level}");
                    sw.WriteLine($"Armor: {gladiator.ChestArmor.ToString()}");
                    sw.WriteLine($"Weapon: {gladiator.ArmWeapon.ToString()}");

                }

                using (StreamReader sr = gladiatorInfoFile.OpenText())
                {
                    string line = string.Empty;

                    while ((line = sr.ReadLine()) != null)
                    {
                        fullInfo.Add(line);
                    }
                }
                

            }
        }

        

        public static void UpdateFullInfo(Gladiator gladiator)
        {
            fullInfo.Add($"Name: {gladiator.Name}");
            fullInfo.Add($"Ability Points: {gladiator.AbilityPoints}");
            fullInfo.Add($"Health Points: {gladiator.HealthPoints}");
            fullInfo.Add($"Level: {gladiator.Level}");
            fullInfo.Add($"Armor: {gladiator.ChestArmor.ToString()}");
            fullInfo.Add($"Weapon: {gladiator.ArmWeapon.ToString()}");




        }

        
        
        
        
        public static void PrintFullInfo()
        {
            foreach (var item in fullInfo)
            {
                Console.WriteLine(item);
            }
        }
    }
}
