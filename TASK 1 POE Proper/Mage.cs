using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
    class Mage:Enemy
    {
        public Mage(int i, int j, TileType ConstructType, char Symbol, int ConstructEnemyDamage, int ConstructHp) : base(i, j, ConstructType, 'M', 5, 5, 5)
        {

        }

        public override Movement returnMove(Movement MageMove)
        {
            MageMove = Movement.stationary;

            return MageMove;
        }

        public override String ToString()
        {
            return "Mage" + " at [" + x.ToString() + y.ToString() + "]" + Damage;
        }
    }
}
