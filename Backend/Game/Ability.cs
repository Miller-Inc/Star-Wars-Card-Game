using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Wars_Card_Game.Backend.Game
{
    public class Ability
    {
        public string Name { get; set; } = "Not Set";

        public string Description { get; set; } = "Not Set";

        public float BaseDamage { get; set; }

        public int Cooldown { get; set; }

        public AbilityType Type { get; set; }

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
}
