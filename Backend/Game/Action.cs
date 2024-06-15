using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Star_Wars_Card_Game.Backend.Game.Enums;

namespace Star_Wars_Card_Game.Backend.Game
{
    /// <summary>
    /// Actions are the things that happen when an ability is used. They can be used to modify stats, apply status effects, etc.
    /// </summary>
    public class Action
    {
        public float AffectedStatValue { get; set; } = 1f;

        public int NumberOfTargets { get; set; } = 1;

        public ActionType Type { get; set; } = ActionType.Damage;

        public string Description { get; set; } = "This action damages the target enemy";

        /// <summary>
        /// Targets are in the order of: [Allied Leader, self, Selected Ally, Enemy Leader, Selected Enemy, All Enemies]
        /// AoE just needs to set the final value to true for each section
        /// </summary>
        public List<bool> Targets { get; set; } = [false, false, false, false, false, false,
            // Enemy Units
            false, false, false, false, false, false];

        public Dictionary<int, Allignment> AffectedAllignments { get; set; } = new Dictionary<int, Allignment>() { { 1, Allignment.Any } };

        public Dictionary<int, string> AffectedClasses { get; set; } = new Dictionary<int, string>() { { 1, "Any" } };

        public Dictionary<int, string> AffectedUnits { get; set; } = new Dictionary<int, string>() { { 1, "Any" } };

        public Action(float affectedStatValue, int numberOfTargets, List<bool> targets)
        {
            this.AffectedStatValue = affectedStatValue;
            this.NumberOfTargets = numberOfTargets;
            this.Targets = targets;
        }

        public StatusEffect StatusEffect { get; set; } = new();

        public Action()
        {

        }
    }

    #region DefaultActions

    public static class DefaultActions
    {
        /// <summary>
        /// This action is used to damage the selected enemy unit, and is the default action for most abilities
        /// To set the damage value, change the AffectedStatValue property
        /// </summary>
        public static Action defDamageSelected = new()
        {
            Type = ActionType.Damage,
            Targets = [false, false, false,
            // Enemy Units
            false, true, false],
            NumberOfTargets = 1,
            Description = "Damage the target enemy"
        };

        public static Action DamageSelected(float amount) 
        {
            Action action = defDamageSelected;
            action.AffectedStatValue = amount;
            return action;
        }

        /// <summary>
        /// This action is used to heal the selected ally unit, and is the default action for most healing abilities
        /// To set the heal value, change the AffectedStatValue property
        /// </summary>
        public static Action defHealSelected = new()
        {
            Type = ActionType.Heal,
            Targets = [false, false, true,
            // Enemy Units
            false, false, false],
            NumberOfTargets = 1,
            Description = "Heal the selected ally"
        };

        public static Action HealSelected(float amount)
        {
            Action action = defHealSelected;
            action.AffectedStatValue = amount;
            return action;
        }

        public static Action defDamageAllEnemies = new()
        {
            Type = ActionType.Damage,
            Targets = [false, false, false,
                // Enemy Units
                true, true, true],
            NumberOfTargets = 6,
            Description = "Damgae all enemy units"
        };

        public static Action DamageAllEnemies(float amount)
        {
            Action action = defDamageAllEnemies;
            action.AffectedStatValue = amount;
            return action;
        }

        public static Action defHealAllAllies = new()
        {
            Type = ActionType.Heal,
            Targets = [true, true, true,
                // Enemy Units
                false, false, false],
            NumberOfTargets = 6,
            Description = "Heal all allied units"
        };

        public static Action HealAllAllies(float amount)
        {
            Action action = defHealAllAllies;
            action.AffectedStatValue = amount;
            return action;
        }

        /// <summary>
        /// You need to set the status effect to apply in the StatusEffect property, default is DamageOverTime
        /// </summary>
        public static Action defApplyStatusEffect = new()
        {
            Type = ActionType.ApplyStatusEffect,
            Targets = [false, false, false,
                // Enemy Units
                false, true, false],
            NumberOfTargets = 1,
            Description = "Apply a status effect to the target enemy",
            StatusEffect = DefaultStatusEffects.defDamageOverTime,
        };

        public static Action ApplyStatusEffect(StatusEffect effect)
        {
            Action action = defApplyStatusEffect;
            action.StatusEffect = effect;
            return action;
        }


    }
    #endregion
}
