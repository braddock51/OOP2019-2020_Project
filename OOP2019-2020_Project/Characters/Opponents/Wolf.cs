

using Characters.MainChar;
using Interfaces;
using System;
using System.Threading;
using Utilities;

namespace Characters.Opponents
{
    public class Wolf : Opponent, IOpponentSkill
    {
        

        public Wolf()
            : base(Consts.Wolf.DEFAULT_WOLF_ABILITY_POINTS, Consts.Wolf.DEFAULT_WOLF_HEALTH_POINTS, Consts.Wolf.DEFAULT_WOLF_DAMAGE)
        {

        }

        private void ClawRage(Gladiator gladiator)
        {
            if(base.AbilityPoints < 5)
            {
                base.Attack(gladiator);
            }

            else
            {
                Tools.ColorfulWriteLine(" _____ _                       _     \n" +
                                        "/  ___| |                     | |    \n" +
                                        "\\ `--.| | __ _  __ _  __ _ ___| |__  \n" +
                                        " `--. \\ |/ _` |/ _` |/ _` / __| '_ \\ \n" +
                                        "/\\__/ / | (_| | (_| | (_| \\__ \\ | | |\n" +
                                        "\\____/|_|\\__,_|\\__,_|\\__,_|___/_| |_|\n" +
                                        "\n\n\n\n", ConsoleColor.Red);
                
                Tools.ColorfulWriteLine("Wolf use ClawRage\n" +
                "Dealt you a terrible blow.\n" +
                "\n\n", ConsoleColor.DarkRed);
                base.Damage += 5;
                base.AbilityPoints -= 5;
                base.Attack(gladiator);
                base.Damage = Consts.Wolf.DEFAULT_WOLF_DAMAGE;

                
            }
            
            
            
            
        }
            
            
        public void Skill(Gladiator gladiator)
        {
            this.ClawRage(gladiator);
        }

        public override string ToString()
        {
            return "Wolf";
        }
        
       

    }
}
