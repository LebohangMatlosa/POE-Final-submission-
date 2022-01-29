using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
    abstract class Weapon_Class : Item
    {
        private int Range;

        public int RANGE
        {
            get { return Range; }
            set { Range = value; }
        }

        private int damage;

        public int DAMAGE
        {
            get { return damage; }
            set { damage = value; }
        }
       
        private int durability;

        public int DURABILITY
        {
            get { return durability; }
            set { durability = value; }
        }

        private int cost;

        public int COST
        {
            get { return cost; }
            set { cost = value; }
        }

        public char Symbol { get; }

        private int weaponType;

        protected Weapon_Class(char symbolConstruct, int K = -1, int L = -1, TileType Type = TileType.Weapon)
            :base(K, L, Type, symbolConstruct)
        {
            this.Symbol = symbolConstruct;
            
        }
    }
}
