using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{   
    abstract class tile
    {

        protected int x;
        protected int y;
        protected char symbols; 
        public enum TileType
        {
            Character,
            Hero,
            Enemy,
            Gold,
            Weapon,
            Empty,
            Barrier,
            attack,


        }


        public int X()
        {
            return x;   
        }

        public tile(int K, int L, TileType Type, char symbol)
        {
            x = K;
            y = L;
            symbol = symbols;
            Enumtype = Type;
        }
        public int Y()
        {
            return y;
        }
        private int enemies;
        
        public int ENEMIES
        {
            get { return enemies; }
            set { enemies = value; }
        }
        protected TileType Enumtype;
        public TileType enumtype
        {
            get { return enumtype; }
            set { Enumtype = value; }
        }
        
    }
}
