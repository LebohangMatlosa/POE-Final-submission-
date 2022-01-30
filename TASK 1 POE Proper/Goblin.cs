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

        public override Movement returnMove(Movement GoblinMove)
        {
            switch (GoblinMove)
            {
                case Movement.up:
                    {
                        x--;
                        return GoblinMove;
                    }

                case Movement.down:
                    {
                        x++;
                        return GoblinMove;
                    }

                case Movement.left:
                    {
                        y--;
                        return GoblinMove;
                    }

                case Movement.right:
                    {
                        y++;
                        return GoblinMove;
                    }
            }

            return (Movement)GoblinMove;
        }

        public override String ToString()
        {
            return "Goblin" + " at [" + x.ToString() + y.ToString() + "]" + Damage;
        }
    }
}
