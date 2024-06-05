using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Wars_Card_Game.Backend.Game
{
    public class StatusEffect
    {
        public int Duration { get; set; } = 1;

        public AffectedStat AffectedStat { get; set; } = AffectedStat.Health;

        /// <summary>
        /// The amount to change the stat by percentage
        /// </summary>
        public float Amount { get; set; } = 0.85f;

        public StatusApplicationType ApplicationType { get; set; } = StatusApplicationType.Multiplicative;

        public StatusEffect(int duration, StatusApplicationType applicationType, AffectedStat affectedStat, float amount)
        {
            Duration = duration;
            AffectedStat = affectedStat;
            Amount = amount;
            ApplicationType = applicationType;
        }

        public StatusEffect()
        {

        }
    }

    public enum  StatusApplicationType
    {
        Additive, 
        Multiplicative, 
        LoseTurn
    }

    public class DefaultStatusEffects
    {
        public static StatusEffect ReduceMaxHealth = new(3, StatusApplicationType.Multiplicative, AffectedStat.Health, 0.85f);
        public static StatusEffect DamageOverTime = new(3, StatusApplicationType.Additive, AffectedStat.Health, -10f);
        public static StatusEffect ReduceSpeed = new(3,StatusApplicationType.Multiplicative, AffectedStat.Speed, 0.85f);
        public static StatusEffect Stun = new(1,StatusApplicationType.LoseTurn, AffectedStat.Speed, 1.0f);
        public static StatusEffect IncreaseSpeed = new(3,StatusApplicationType.Multiplicative, AffectedStat.Speed, 1.15f);
        public static StatusEffect IncreaseAttack = new(3,StatusApplicationType.Multiplicative, AffectedStat.Attack, 1.15f);
        public static StatusEffect IncreaseDefense = new(3,StatusApplicationType.Multiplicative, AffectedStat.Defense, 1.15f);
        public static StatusEffect IncreaseHealth = new(3,StatusApplicationType.Multiplicative, AffectedStat.Health, 1.15f);

    }
}
