using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Wars_Card_Game.Backend.Game.Enums
{
    public enum ActionType
    {
        Damage = 0,
        Heal = 1,
        ApplyStatusEffect = 2,
        RemoveStatusEffect = 3,
        ModifyStat = 4,
    }
}
