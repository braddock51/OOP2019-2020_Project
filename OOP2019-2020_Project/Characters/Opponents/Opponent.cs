

using Characters.MainChar;
using Interfaces;
using System;
using System.Threading;
using Utilities;

namespace Characters.Opponents
{
    public abstract class Opponent : IOpponentAttack, IDefend, ICharge
    {
        Random rnd = new Random();
        
        private int abilityPoints;
        private int healthPoints;
        private int damage;

        private bool isAlive;


        public int AbilityPoints
        {
            get
            {
                return this.abilityPoints;
            }
            protected set
            {
                this.abilityPoints = value;
            }
        }
        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    this.healthPoints = value;
                }
                else
                {
                    //throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 100.");
                }
            }
        }
        public int Damage 
        { 
            get
            {
                return this.damage;
            }
            protected set
            {
                this.damage = value;
            }
        }

        public bool IsAlive
        {
            get
            {
                return this.isAlive;
            }
            set
            {
                this.isAlive = value;
            }
        }

        public Opponent()
        {

        }
        
        public Opponent(int abilityPoints, int healthPoints, int damage)
        {
            this.AbilityPoints = abilityPoints;
            this.HealthPoints = healthPoints;
            this.Damage = damage;
            this.IsAlive = true;
            
        }

        public void Attack(Gladiator gladiator)
        {
            int los = rnd.Next(1, 16);
            Console.WriteLine(los);

            if (this.AbilityPoints <= 0)
            {
                
                this.Charge();

            }

            else
            {
                if (los <= gladiator.ChestArmor.Dodge)
                {
                    Tools.ColorfulWriteLine("______          _            \n" +
                                            "|  _  \\        | |           \n" +
                                            "| | | |___   __| | __ _  ___ \n" +
                                            "| | | / _ \\ / _` |/ _` |/ _ \\n" +
                                            "| |/ / (_) | (_| | (_| |  __/\n" +
                                            "|___/ \\___/ \\__,_|\\__, |\\___|\n" +
                                            "                   __/ |     \n" +
                                            "                  |___/      \n", ConsoleColor.DarkGreen);


                    Tools.ColorfulWriteLine($"{gladiator.Name} dodge wolf attack.\n\n", ConsoleColor.Green);

                    Thread.Sleep(3000);
                    Console.Clear();
                }

                else
                {
                    gladiator.HealthPoints = gladiator.HealthPoints + gladiator.ChestArmor.ArmorPoints - this.Damage;
                    this.AbilityPoints--;
                    Tools.ColorfulWriteLine($"{this.ToString()} hit {gladiator.Name} for {this.Damage}\n\n" +
                        $"{gladiator.Name} health points is equal to {gladiator.HealthPoints}\n\n" +
                        $"{this.ToString()} ability points decreased by 1\n\n" +
                        $"{this.ToString()} abilitiy points is equal to {this.AbilityPoints}\n\n" +
                        $"\n\n\n\n" +
                        $"PRESS KEY TO CONTINUE", ConsoleColor.Red);

                    Console.ReadKey();
                    Console.Clear();

                }
            }

            
        }

        public void Defend()
        {
            
            
            Tools.ColorfulWriteLine($"{this.ToString()} is in defending pose, his health is increased by 1\n\n" +
                $"\n\n\n\n" +
                $"PRESS KEY TO CONTINUE", ConsoleColor.Red);
            this.HealthPoints++;

            Console.ReadKey();
            Console.Clear();
        }

        public void Charge()
        {
            Tools.ColorfulWriteLine("                         ,ood8888booo,          \n" +
                                    "                      ,oda8a888a888888bo,       \n" +
                                    "                   ,od88888888aa888aa88a8bo,    \n" +
                                    "                 ,da8888aaaa88a888aaaa8a8a88b,  \n" +
                                    "                ,oa888aaaa8aa8888aaa8aa8a8a88o, \n" +
                                    "               ,88888aaaaaa8aa8888a8aa8aa888a88,\n" +
                                    "               8888a88aaaaaa8a88aa8888888a888888\n" +
                                    "               888aaaa88aa8aaaa8888; ;8888a88888\n" +
                                    "               Y888a888a888a8888;'   ;888888a88Y\n" +
                                    "                Y8a8aa8a888a88'      ,8aaa8888Y \n" +
                                    "                 Y8a8aa8aa8888;     ;8a8aaa88Y  \n" +
                                    "                  `Y88aa8888;'      ;8aaa88Y'   \n" +
                                    "          ,,;;;;;;;;'''''''         ;8888Y'     \n" +
                                    "       ,,;                         ,888P        \n" +
                                    "      ,;  ,;,                      ;''          \n" +
                                    "     ;       ;          ,    ,    ,;            \n" +
                                    "    ;  ;,    ;     ,;;;;;   ;,,,  ;             \n" +
                                    "   ;  ; ;  ,' ;  ,;      ;  ;   ;  ;            \n" +
                                    "   ; ;  ; ;  ;  '        ; ,'    ;  ;           \n" +
                                    "   `;'  ; ;  '; ;,       ; ;      ; ',          \n" +
                                    "        ;  ;,  ;,;       ;  ;,     ;;;          \n" +
                                    "         ;,,;             ;,,;                  \n", ConsoleColor.Red);

            Tools.ColorfulWriteLine($"{this.ToString()} is walked away a bit to charge up, his ability points is increased by 1\n\n" +
                $"\n\n\n\n" +
                $"PRESS KEY TO CONTINUE", ConsoleColor.Red);
            this.AbilityPoints++;

            Console.ReadKey();
            Console.Clear();
        }
    }
}
