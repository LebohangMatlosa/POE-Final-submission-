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
        private Random goldGeneration;

        public GOLD(int goldx, int goldy, int goldAmount) : base(TileType.Gold, (char)goldx, goldy, goldAmount)
        {
            goldx = x;
            goldy = y;
            goldAmount = goldGeneration.Next(1, 6);
        }
        public GOLD(int x, int y) : base(x, y, TileType.Gold, '+')
        {
            
        }
    }
}
