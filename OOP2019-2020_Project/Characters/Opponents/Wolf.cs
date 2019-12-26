

using Characters.MainChar;
using Interfaces;
using System;
using Utilities;

namespace Characters.Opponents
{
    public class Wolf : Opponent, IOpponentSkill
    {
        public const int DEFAULT_WOLF_ABILITY_POINTS = 10;
        public const int DEFAULT_WOLF_HEALTH_POINTS = 30;
        public const int DEFAULT_WOLF_DAMAGE = 10;

        public Wolf()
            : base(DEFAULT_WOLF_ABILITY_POINTS, DEFAULT_WOLF_HEALTH_POINTS, DEFAULT_WOLF_DAMAGE)
        {

        }

        private void ClawRage(Gladiator gladiator)
        {
            Console.Write("Wolf use ClawRage\n" +
                "He jump to you with his sharp claws");
            base.Damage += 2;
            base.AbilityPoints -= 5;
            this.Attack(gladiator);
            base.Damage = DEFAULT_WOLF_DAMAGE;
            
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
