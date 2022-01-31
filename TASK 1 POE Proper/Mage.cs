using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
    class Mage:Enemy
    {
        public Mage(int MageX, int MageY, TileType mage, char symbol = 'M', int mageDamage= 5,int mageHp= 5,int maxHP =5) : base (MageX, MageY,mage,symbol,mageDamage,mageHp,maxHP)
        {
            int MageHp = mageHp;
            int MageDamage= mageDamage;
        }

        public override Movement returnMove(Movement e)
        {
            throw new NotImplementedException();
        }

        public override bool CheckRange(Character target)
        {
            return base.CheckRange(target);
        }
    }
}
