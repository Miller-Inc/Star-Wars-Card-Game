﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Star_Wars_Card_Game.Backend.Game.Enums;

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

    public class DefaultStatusEffects
    {
        public static StatusEffect defReduceMaxHealth = new(3, StatusApplicationType.Multiplicative, AffectedStat.Health, 0.85f);
        public static StatusEffect AlterMaxHealth(float amount) => new(3, StatusApplicationType.Multiplicative, AffectedStat.Health, amount);
        public static StatusEffect defDamageOverTime = new(3, StatusApplicationType.Additive, AffectedStat.Health, -10f);
        public static StatusEffect HealOverTime = new(3, StatusApplicationType.Additive, AffectedStat.Health, 10f);
        public static StatusEffect DamageOverTime(float amount) => new(3, StatusApplicationType.Additive, AffectedStat.Health, amount);
        public static StatusEffect defReduceSpeed = new(3,StatusApplicationType.Multiplicative, AffectedStat.Speed, 0.85f);
        public static StatusEffect AlterSpeed(float amount) => new(3,StatusApplicationType.Multiplicative, AffectedStat.Speed, amount);
        public static StatusEffect defStun = new(1, StatusApplicationType.LoseTurn, AffectedStat.Speed, 1.0f);
        public static StatusEffect Stun(float amount) => new(1,StatusApplicationType.LoseTurn, AffectedStat.Speed, amount);
        public static StatusEffect defIncreaseSpeed = new(3,StatusApplicationType.Multiplicative, AffectedStat.Speed, 1.15f);
        public static StatusEffect defIncreaseAttack = new(3,StatusApplicationType.Multiplicative, AffectedStat.Attack, 1.15f);
        public static StatusEffect AlterAttack(float amount) => new(3,StatusApplicationType.Multiplicative, AffectedStat.Attack, amount);
        public static StatusEffect defIncreaseDefense = new(3,StatusApplicationType.Multiplicative, AffectedStat.Defense, 1.15f);
        public static StatusEffect AlterDefense(float amount) => new(3,StatusApplicationType.Multiplicative, AffectedStat.Defense, amount);
        public static StatusEffect defIncreaseHealth = new(3,StatusApplicationType.Multiplicative, AffectedStat.Health, 1.15f);
        public static StatusEffect defAbilityBlock = new(1, StatusApplicationType.AbilityBlock, AffectedStat.Attack, 1f);
        public static StatusEffect AbilityBlock(int turns) => new(turns, StatusApplicationType.AbilityBlock, AffectedStat.Attack, 1f);
        
        private static readonly List<string> DefaultEffects = new()
        {
            "Heal Over Time 10%",
            "Damage Over Time 10%",
            "Increase Speed 10%",
            "Increase Attack 10%",
            "Increase Defense 10%",
            "Increase Health 10%",
            "Ability Block 1 turn",
            "Decrease Speed -10%", 
            "Decrease Attack -10%",
            "Decrease Defense -10%",
            "Decrease Health -10%"
        };
    }
}
