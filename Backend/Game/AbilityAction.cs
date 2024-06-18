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
    public class AbilityAction
    {
        public float AffectedStatValue { get; set; } = 1f;

        public int NumberOfTargets { get; set; } = 1;

        public ActionType Type { get; set; } = ActionType.Damage;

        public string Description { get; set; } = "This action damages the target enemy";

        public CharactersAffected AffectedCharacters { get; set; } = CharactersAffected.TargetEnemy;

        public ApplicationType ApplicationType { get; set; } = ApplicationType.Additive; 

        public Dictionary<int, Allignment> AffectedAllignments { get; set; } = new Dictionary<int, Allignment>() { { 1, Allignment.Any } };

        public Dictionary<int, string> AffectedClasses { get; set; } = new Dictionary<int, string>() { { 1, "Any" } };

        public Dictionary<int, string> AffectedUnits { get; set; } = new Dictionary<int, string>() { { 1, "Any" } };

        public AbilityAction(float affectedStatValue, int numberOfTargets, CharactersAffected charactersAffected)
        {
            this.AffectedStatValue = affectedStatValue;
            this.NumberOfTargets = numberOfTargets;
            this.AffectedCharacters = charactersAffected;
        }

        public StatusEffect StatusEffect { get; set; } = new();

        public AbilityAction()
        {

        }

        public string GenerateDescription()
        {
            
            Description = "";
            
            // Starts by declaring the action type in string form
            if (this.Type == ActionType.Heal)
            {
                Description = "Heals ";
            }
            else if (this.Type == ActionType.Damage)
            {
                Description = "Damages ";
            }
            else if (this.Type == ActionType.ApplyStatusEffect)
            {
                Description = "Applies a status effect to ";
            }
            else if (this.Type == ActionType.ModifyStat)
            {
                Description = "Modifies ";
            }
            else if (this.Type == ActionType.RemoveStatusEffect)
            {
                Description = "Removes a status effect from ";
            }

            // Adds the type of characters affected
            if (this.AffectedCharacters == CharactersAffected.Self)
            {
                Description += "this unit ";
            }
            else if (this.AffectedCharacters == CharactersAffected.TargetAlly)
            {
                Description += "the target ally ";
            }
            else if (this.AffectedCharacters == CharactersAffected.TargetEnemy)
            {
                Description += "the target enemy ";
            }
            else if (this.AffectedCharacters == CharactersAffected.AllAllies)
            {
                Description += "all allied units ";
            }
            else if (this.AffectedCharacters == CharactersAffected.AllEnemies)
            {
                Description += "all enemy units ";
            }
            else if (this.AffectedCharacters == CharactersAffected.All)
            {
                Description += "all units ";
            }
            else if (this.AffectedCharacters == CharactersAffected.EnemyLeader)
            {
                Description += "the enemy leader ";
            }
            else if (this.AffectedCharacters == CharactersAffected.AllyLeader)
            {
                Description += "the allied leader ";
            }
            else if (this.AffectedCharacters == CharactersAffected.AllySpecificClass)
            {
                Description += "all allied units of the class(es) ";
                foreach (var item in this.AffectedClasses)
                {
                    Description += item.Value + " ";
                }
            }
            else if (this.AffectedCharacters == CharactersAffected.AllySpecificUnit)
            {
                Description += "the allied unit ";
                foreach (var item in this.AffectedUnits)
                {
                    Description += item.Value + " ";
                }
            }
            else if (this.AffectedCharacters == CharactersAffected.AllySpecificAllignment)
            {
                Description += "all allied units of the allignment(s) "; 
                foreach (var item in this.AffectedAllignments)
                {
                    Description += item.Value + " ";
                }
            }
            else if (this.AffectedCharacters == CharactersAffected.EnemySpecificClass)
            {
                Description += "all enemy units of the class(es) ";
                foreach (var item in this.AffectedClasses)
                {
                    Description += item.Value + " ";
                }
            }
            else if (this.AffectedCharacters == CharactersAffected.EnemySpecificUnit)
            {
                Description += "the following enemy unit(s): ";
                foreach (var item in this.AffectedUnits)
                {
                    Description += item.Value + " ";
                }
            }
            else if (this.AffectedCharacters == CharactersAffected.EnemySpecificAllignment)
            {
                Description += "all enemy units of the allignment ";
                foreach (var item in this.AffectedAllignments)
                {
                    Description += item.Value + " ";
                }
            } 
            
            return Description;
        }
    }

    #region DefaultActions

    public static class DefaultActions
    {
        /// <summary>
        /// This action is used to damage the selected enemy unit, and is the default action for most abilities
        /// To set the damage value, change the AffectedStatValue property
        /// </summary>
        public static AbilityAction defDamageSelected = new()
        {
            Type = ActionType.Damage,
            AffectedCharacters = CharactersAffected.TargetEnemy,
            NumberOfTargets = 1,
            Description = "Damage the target enemy"
        };

        public static AbilityAction DamageSelected(float amount) 
        {
            AbilityAction action = defDamageSelected;
            action.AffectedStatValue = amount;
            return action;
        }

        /// <summary>
        /// This action is used to heal the selected ally unit, and is the default action for most healing abilities
        /// To set the heal value, change the AffectedStatValue property
        /// </summary>
        public static AbilityAction defHealSelected = new()
        {
            Type = ActionType.Heal,
            AffectedCharacters = CharactersAffected.TargetAlly,
            NumberOfTargets = 1,
            Description = "Heal the selected ally"
        };

        public static AbilityAction HealSelected(float amount)
        {
            AbilityAction action = defHealSelected;
            action.AffectedStatValue = amount;
            return action;
        }

        public static AbilityAction defDamageAllEnemies = new()
        {
            Type = ActionType.Damage,
            AffectedCharacters = CharactersAffected.AllEnemies,
            NumberOfTargets = 6,
            Description = "Damgae all enemy units"
        };

        public static AbilityAction DamageAllEnemies(float amount)
        {
            AbilityAction action = defDamageAllEnemies;
            action.AffectedStatValue = amount;
            return action;
        }

        public static AbilityAction defHealAllAllies = new()
        {
            Type = ActionType.Heal,
            AffectedCharacters = CharactersAffected.AllAllies,
            NumberOfTargets = 6,
            Description = "Heal all allied units"
        };

        public static AbilityAction HealAllAllies(float amount)
        {
            AbilityAction action = defHealAllAllies;
            action.AffectedStatValue = amount;
            return action;
        }

        /// <summary>
        /// You need to set the status effect to apply in the StatusEffect property, default is DamageOverTime
        /// </summary>
        public static AbilityAction defApplyStatusEffect = new()
        {
            Type = ActionType.ApplyStatusEffect,
            AffectedCharacters = CharactersAffected.TargetEnemy,
            NumberOfTargets = 1,
            Description = "Apply a status effect to the target enemy",
            StatusEffect = DefaultStatusEffects.defDamageOverTime,
        };

        public static AbilityAction ApplyStatusEffect(StatusEffect effect)
        {
            AbilityAction action = defApplyStatusEffect;
            action.StatusEffect = effect;
            return action;
        }


    }
    #endregion
}
