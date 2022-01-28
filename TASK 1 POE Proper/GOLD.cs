using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
    class GOLD : Items
    {
        private int gold;

        public int GOLDDROP
        {
            get { return gold; }
            set { gold = value; }
        }

        private Random RANDOM_GOLD_GENERATOR;

        public GOLD(int goldX, int goldY, TileType goldTile, int goldAmount):base(goldX,goldY,goldTile, goldAmount)
        {
            goldX = X;
            goldY = Y;
            goldAmount = RANDOM_GOLD_GENERATOR.Next(1,6);
        }
    }
}
