

using Characters.MainChar;
using Interfaces;
using System;

namespace Characters.Opponents
{
    public class Wolf : Opponent, IOpponentAttack, IDefend, ICharge, IOpponentSkill
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
        
        public void Attack(Gladiator gladiator)
        {
            gladiator.HealthPoints = gladiator.HealthPoints + gladiator.ChestArmor.ArmorPoints - base.Damage;
            base.AbilityPoints--;
        }

        public void Charge()
        {
            base.AbilityPoints++;
        }

        public void Defend()
        {
            base.HealthPoints++;
        }

        public void Skill(Gladiator gladiator)
        {
            this.ClawRage(gladiator);
        }
    }
}
