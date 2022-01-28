using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
    public class Tile 

    {
        private int damage;

        public int DAMAGE
        {
            get { return damage; }
            set { damage = value; }
        }


        private Hero playercharacter;

        public Hero PLAYERCHARACTER
        {
            get { return playercharacter; }
            set { playercharacter = value; }
        }

    }

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
    public enum MovementDirection
    {
        noMovement,
        Up,
        Down,
        Left,
        Right,
    }
    abstract class tile
    {
        
        protected int x;
        protected int y;
        protected TileType typeOfTile;
        protected Tile(int posX, int posY)
        {
            posX = x;
            posY = y;
            
        }


        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y= value; }
        }
        private int enemies;
        
        public int ENEMIES
        {
            get { return enemies; }
            set { enemies = value; }
        }
        private bool typeoftile;

        public bool TYPEOFTILE
        {
            get { return typeoftile; }
            set { typeoftile = value; }
        }


            
        public void emptyTile()
        {

        }

    }
}
