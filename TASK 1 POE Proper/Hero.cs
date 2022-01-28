using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
    class Hero : Character
    {
        public Hero(int posX, int posY, int damage, int hp, int maxHp) : base(posX, posY, damage, hp, maxHp)
        {
            
            maxHp = MAX_HP;
            hp = HP;
            damage = 2;
        }

        override void ReturnMove()
        {

        }

        public override string ToString()
        {
            return "Player Stats: \n" + "HP: " + maxHp + "\n Damage: " + damage + "\n" + X + Y ;
        }
    }
}
