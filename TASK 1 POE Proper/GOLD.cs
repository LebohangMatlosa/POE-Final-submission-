using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
    class GOLD : Item
    {
        private Random r = new Random();
        private int amoutOfGold;

        public int Gold()
        {
            return amoutOfGold;
        }

        public GOLD(int x, int y) : base(x, y, TileType.Gold, '+')
        {
            
        }
    }
}
