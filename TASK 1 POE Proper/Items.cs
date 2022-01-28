using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
    abstract class Items : Tile
    {
        public Items(int posX, int posY, TileType Item, int numberOfItems) : base (posX, posY, Item)
        {
            posX = X;
            posY = Y;
            Item = TYPEOFTILE;
        }

        public abstract override string ToString()
        {
            return TYPEOFTILE;
        }
    }
}
