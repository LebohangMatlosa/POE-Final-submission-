using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
    class Goblin : Enemy
    {
        [NonSerialized] public Random r;
        public Goblin(int K, int L, TileType Type, char Symbol, int Damage, int Hp) : base(K, L, Type, 'G', 1, 10, 10)
        {

        }

        public override Movement returnMove(Movement goblinMovement)
        {
            switch (goblinMovement)
            {
                case Movement.up:
                    {
                        x--;
                        return goblinMovement;
                    }

                case Movement.down:
                    {
                        x++;
                        return goblinMovement;
                    }

                case Movement.left:
                    {
                        y--;
                        return goblinMovement;
                    }

                case Movement.right:
                    {
                        y++;
                        return goblinMovement;
                    }
            }

            return (Movement)goblinMovement;
        }

        public override String ToString()
        {
            return "Goblin" + " at [" + x.ToString() + y.ToString() + "]" + Damage;
        }
    }
}
