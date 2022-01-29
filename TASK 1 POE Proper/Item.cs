using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
     abstract class Item : tile
    {
        int typeOfItem;
        protected char symbol;
        
        protected Item(TileType ConstructType, char symbolconstructor, int K, int L) : base(K, L, ConstructType, symbolconstructor)
        {

        }

        public Item(int K, int L, TileType Type, char symbol) : base(K, L, Type, symbol)
        {
        }

        public override string ToString()
        {
            return typeOfItem.ToString();
        }
    }
}
