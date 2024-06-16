using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Wars_Card_Game.Backend.Game.Enums
{
    public enum CharactersAffected
    {
        None = -1,
        Self = 0,
        TargetAlly = 1,
        TargetEnemy = 2,
        AllAllies = 3,
        AllEnemies = 4,
        All = 5, 
        EnemyLeader = 6,
        AllyLeader = 7,
        AllySpecificClass = 8,
        AllySpecificUnit = 9,
        AllySpecificAllignment = 10,
        EnemySpecificClass = 11,
        EnemySpecificUnit = 12,
        EnemySpecificAllignment = 13,
    }
}
