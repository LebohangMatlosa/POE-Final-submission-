using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
    class Leader
    {
        private int LeaderTargets;

        public Leader(int LeaderHp, int LeaderDamage, int X, int Y, int leaderTargets, int leadertargets )
        {
            LeaderTargets = leaderTargets;
            this.leadertargets = leadertargets;

            LeaderHp = 20;
            LeaderDamage = 2;
        }

        public int leadertargets
        {
            get { return LeaderTargets; }
            set { LeaderTargets = value; }
        }

        public override bool LeaderMovement()
        {
            return base.Equals();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ReturnMove(Movement)
        {
            if(MovementDirection = MovementDirection.Up)
            {
                return base.Movement = 1; 
            }
            if(MovementDirection = MovementDirection.Down)
            {
                return base.Movement = 2;              
            }
            if (MovementDirection = MovementDirection.Left)
            {
                return base.Movement = 3;
            }
            if (MovementDirection = MovementDirection.Right)
            {
                return base.Movement = 4;
            }

        }
    }
}
