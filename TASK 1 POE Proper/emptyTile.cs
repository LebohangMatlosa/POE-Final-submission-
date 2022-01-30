using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
    class emptyTile : Tile
    {
        public emptyTile(int x, int y, TileType ConstructType) : base(x, y, ConstructType, '.')
        {

        }
    }
}
