

using Characters.MainChar;
using Interfaces;
using System;
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
            Tools.ColorfulWriteLine("Wolf use ClawRage\n" +
                "He jump to you with his sharp claws\n\n", ConsoleColor.DarkRed);
            base.Damage += 2;
            base.AbilityPoints -= 5;
            base.Attack(gladiator);
            base.Damage = Consts.Wolf.DEFAULT_WOLF_DAMAGE;
            
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
