using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        /// <summary>
        /// Targets are in the order of: [Allied Leader, self, Selected Ally, Enemy Leader, Selected Enemy, All Enemies]
        /// AoE just needs to set the final value to true for each section
        /// </summary>
        public List<bool> Targets { get; set; } = [false, false, false, false, false, false,
            // Enemy Units
            false, false, false, false, false, false];

        public Dictionary<int, Allignment> AffectedAllignments { get; set; } = new Dictionary<int, Allignment>() { { 1, Allignment.Any } };

        public Dictionary<int, string> AffectedClasses { get; set; } = new Dictionary<int, string>() { { 1, "Any" } };

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

    public enum ActionType
    {
        Damage = 0,
        Heal = 1,
        ApplyStatusEffect = 2,
        RemoveStatusEffect = 3,
        ModifyStat = 4,
    }

    #region DefaultActions

    public static class DefaultActions
    {
        /// <summary>
        /// This action is used to damage the selected enemy unit, and is the default action for most abilities
        /// To set the damage value, change the AffectedStatValue property
        /// </summary>
        public static Action DamageSelected = new()
        {
            Type = ActionType.Damage,
            Targets = [false, false, false,
            // Enemy Units
            false, true, false],
            NumberOfTargets = 1,
        };

        /// <summary>
        /// This action is used to heal the selected ally unit, and is the default action for most healing abilities
        /// To set the heal value, change the AffectedStatValue property
        /// </summary>
        public static Action HealSelected = new()
        {
            Type = ActionType.Heal,
            Targets = [false, false, true,
            // Enemy Units
            false, false, false],
            NumberOfTargets = 1,
        };

        public static Action DamageAllEnemies = new()
        {
            Type = ActionType.Damage,
            Targets = [false, false, false,
                // Enemy Units
                true, true, true],
            NumberOfTargets = 6,
        };

        public static Action HealAllAllies = new()
        {
            Type = ActionType.Heal,
            Targets = [true, true, true,
                // Enemy Units
                false, false, false],
            NumberOfTargets = 6,
        };

        /// <summary>
        /// You need to set the status effect to apply in the StatusEffect property
        /// </summary>
        public static Action ApplyStatusEffect = new()
        {
            Type = ActionType.ApplyStatusEffect,
            Targets = [false, false, false,
                // Enemy Units
                false, true, false],
            NumberOfTargets = 1
        };


    }
    #endregion
}
