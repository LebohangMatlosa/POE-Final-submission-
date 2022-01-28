using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
        abstract class Character : Tile
    {
        Tile[] Vision;
        protected int hp;
        protected int damage;
        protected int maxHp;

        private int gold;

        public int Gold
        {
            get { return gold; }
            set { gold = value; }
        }


        public Character(int posX , int posY, TileType tileType) : base(posX , posY)
        {

        }
           
             
        public int HP 
        {
            get { return hp; }
            set { hp = value; }
        }
        public enum Movement
        {
            noMovement,
            Up,
            Down,
            Left,
            Right,
        }
        public enum TileType
        {

        }
                         

        public virtual void Attack(Character target)
        {
            HP = MAX_HP - Damage;
        }

        public bool isDead()
        {
            return true;
        }

        public virtual bool CheckRange(Character target)
        {
            return true;
        }

        private int DistanceTo(Character target)
        {
            
        }
        public void Move(Movement)
        {

        }
        public void Pickup(item i, int gold)
        {
            for(int p = 0; p <gold; p++)
            {
                for(int N = 0; N )
            }

            for(int u = 0; u < gold )
        }
        
    }

}
