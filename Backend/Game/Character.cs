using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Wars_Card_Game.Backend.Game
{
    public class Character
    {

        public string Name { get; set; }

        public int Health { get; set; }

        public int Attack { get; set; }

        public int Defense { get; set; }

        public int Speed { get; set; }

        public List<string> Classes { get; set; }

        public Allignment Allignment { get; set; }

        public List<Ability> Ablilities { get; set; }


    }
}
