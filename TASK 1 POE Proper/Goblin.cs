using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
    class Goblin : Enemy
    {
        public Goblin(int i, int j, TileType ConstructType, char Symbol, int ConstructEnemyDamage, int ConstructHp) : base(i, j, ConstructType, 'G', 1, 10, 10)
        {

        }

        public override MovementEnum ReturnMove(MovementEnum GoblinMove)
        {
            switch (GoblinMove)
            {
                case MovementEnum.Up:
                    {
                        x--;
                        return GoblinMove;
                    }

                case MovementEnum.Down:
                    {
                        x++;
                        return GoblinMove;
                    }

                case MovementEnum.Left:
                    {
                        y--;
                        return GoblinMove;
                    }

                case MovementEnum.Right:
                    {
                        y++;
                        return GoblinMove;
                    }
            }

            return (MovementEnum)GoblinMove;
        }

        public override String ToString()
        {
            return "Goblin" + " at [" + x.ToString() + y.ToString() + "]" + Damage;
        }
    }
}
