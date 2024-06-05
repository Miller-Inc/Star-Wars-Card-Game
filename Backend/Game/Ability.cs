using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Wars_Card_Game.Backend.Game
{
    public class Ability
    {
        public string Name { get; set; } = "Slap";

        public string Description { get; set; } = "The most basic, default attack that does almost nothing";

        public float BaseDamage { get; set; } = 1f;

        public int Cooldown { get; set; } = 0; 

        public AbilityType Type { get; set; } = AbilityType.Basic;

        public AffectedStat AffectedStat { get; set; } = AffectedStat.Health;

        List<Action> Actions { get; set; } = [];

        public Ability(string name, string description, int damage, int cooldown, AbilityType type)
        {
            Name = name;
            Description = description;
            BaseDamage = damage;
            Cooldown = cooldown;
            Type = type;
        }

        public Ability()
        {

        }
    }

    public enum AbilityType
    {
        Basic = 0, 
        Special = 1, 
        Ultimate = 2, 

    }

    public enum AffectedStat
    {
        Health = 0, 
        Attack = 1, 
        Defense = 2, 
        Speed = 3, 
    }


}
