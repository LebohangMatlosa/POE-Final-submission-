using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
    abstract class Leader : Enemy
    {
        [NonSerialized] public Random r;
        private Tile LeaderEnemies;

        public Tile leaderEnemies
        {
            get { return leaderEnemies; }
            set { leaderEnemies = value; }
        }
        public Leader(int i, int j, TileType Type = TileType.Enemy, char Symbol = 'L', int enemeyDamage = 2, int HP = 20) : base(i, j, Type, 'L', 2, 20, 20)
        {

        }

        public virtual Movement Move(Movement leadersMovement)
        {
            switch (leadersMovement)
            {
                case Movement.up:
                    {
                        x--;
                        return leadersMovement;
                    }

                case Movement.down:
                    {
                        x++;
                        return leadersMovement;
                    }

                case Movement.left:
                    {
                        y--;
                        return leadersMovement;
                    }

                case Movement.right:
                    {
                        y++;
                        return leadersMovement;
                    }
            }

            return (Movement)leadersMovement;
        }

        public override String ToString()
        {
            return "Leader" + " at [" + x.ToString() + y.ToString() + "]" + Damage;
        }




    }
}
