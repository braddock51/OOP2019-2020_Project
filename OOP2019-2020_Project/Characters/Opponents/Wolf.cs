

using Interfaces;

namespace Characters.Opponents
{
    public class Wolf : Opponent, IAttack, IDefend, ICharge, IOpponentSkill
    {
        public const int DEFAULT_WOLF_ABILITY_POINTS = 10;
        public const int DEFAULT_WOLF_HEALTH_POINTS = 30;
        public const int DEFAULT_WOLF_DAMAGE = 10;

        public Wolf()
            : base(DEFAULT_WOLF_ABILITY_POINTS, DEFAULT_WOLF_HEALTH_POINTS, DEFAULT_WOLF_DAMAGE)
        {

        }

        private void ClawRage()
        {
            base.Damage += 2;
            
        }
        
        public void Attack()
        {
            throw new System.NotImplementedException();
        }

        public void Charge()
        {
            throw new System.NotImplementedException();
        }

        public void Defend()
        {
            throw new System.NotImplementedException();
        }

        public void Skill()
        {
            throw new System.NotImplementedException();
        }
    }
}
