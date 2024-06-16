using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Star_Wars_Card_Game.Backend.Game.Enums;

namespace Star_Wars_Card_Game.Backend.Game
{
    public class Ability
    {
        public string Name { get; set; } = "Slap";

        public string Description { get; set; } = "The most basic, default attack that does almost nothing";

        public float BaseAmount { get; set; } = 1f;

        public int Cooldown { get; set; } = 0; 

        public AbilityType Type { get; set; } = AbilityType.Basic;

        public AffectedStat AffectedStat { get; set; } = AffectedStat.Health;

        public List<AbilityAction> Actions { get; set; } = [];

        public Ability(string name, string description, int baseAmount, int cooldown, AbilityType type)
        {
            Name = name;
            Description = description;
            BaseAmount = baseAmount;
            Cooldown = cooldown;
            Type = type;
        }

        public Ability()
        {

        }
    }


}
