using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Wars_Card_Game.Backend.Game
{
    public class Ablility
    {
        public string Name { get; set; } = "Not Set";

        public string Description { get; set; } = "Not Set";

        public float BaseDamage { get; set; }

        public int Cooldown { get; set; }

        public AblilityType Type { get; set; }

        public Ablility(string name, string description, int damage, int cooldown, AblilityType type)
        {
            Name = name;
            Description = description;
            BaseDamage = damage;
            Cooldown = cooldown;
            Type = type;
        }

        public Ablility()
        {

        }
    }

    public enum AblilityType
    {
        Basic = 0, 
        Special = 1, 
        Ultimate = 2, 

    }
}
