using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
    class Mage:Enemy
    {
        public Mage(int MageX, int MageY) : base (MageX, MageY)
        {
            int MageHp = 5;
            int MageDamage = 5;
        }

        public override int ReturnMove()
        {
            throw new NotImplementedException();
        }

        public override bool CheckRange(Character target)
        {
            return base.CheckRange(target);
        }
    }
}
