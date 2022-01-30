using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
    abstract class Character : Tile
    {
        protected char symbol;
        protected int hp;
        protected int damage;
        protected int maxHp;
        protected int distance;

        public Tile[] vision = new Tile[4];
        bool death = false;


        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }
        private weapon Weapon;

        public int weapons
        {
            get { return weapons; }
            set { weapons = value; }
        }

        public int MaxHp
        {
            get { return maxHp; }
            set { maxHp = value; }
        }



        public int Distance
        {
            get { return distance; }
            set { distance = value; }
        }

        public Character(int posX, int posY, TileType Type, char Symbol) : base(posX, posY, Type, Symbol)
        {
            Symbol = symbol;
        }


        public int HP
        {
            get { return hp; }
            set { hp = value; }
        }
        public enum Movement
        {
            stationary = 0,
            up = 1,
            down = 2,
            left = 3,
            right = 4,
        }
        public enum Attacking
        {
            stationary = 0,
            up = 1,
            down = 2,
            left = 3,
            right = 4,
        }


        public virtual void Attack(Character enemy)
        {
            enemy.hp = enemy.hp - 10;
        }

        public bool isDead()
        {
            if (hp == 0)
            {
                death = true;
            }
            return true;
        }
        private int DistanceTo(Character enemy)
        {
            return 10;
        }
        public void Move(Movement e)
        {

        }
        public int location()
        {
            return x;
        }

        public abstract Movement returnMove(Movement e = 0);
        public virtual bool CheckRange(Character target)
        {
            return true;
        }
        public abstract override string ToString();
        public void Pickup(Item i, int gold)
        {
            for(int p = 0; p <gold; p++)
            {
                for(int N = 0; N> gold; N++)
                {

                }
            }

            for(int u = 0; u < gold;)
            {

            }
        }
    }
}
