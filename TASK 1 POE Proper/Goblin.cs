using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
    class Goblin : Enemy
    {
        public Goblin(int posX, int posY, int damage, int hp, int maxHp, string type) : base(posX, posY, damage, hp, maxHp, type)
        {
            hp = 10;
            damage = 1;
        }

        override ReturnMove()
        {
            r = r.Next();
        }
    }
}
