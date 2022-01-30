using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
    abstract class Character : Tile
    {
        protected int Hp;
        protected int MaxHp;
        protected int Damage;
        protected char Symbol;
        bool dead = false;

        public Tile[] characterVision = new Tile[4];

        public int hp
        {
            get { return Hp; }
            set { Hp = value; }
        }

        public int maxhp
        {
            get { return MaxHp; }
            set { MaxHp = value; }
        }

        public int damage
        {
            get { return Damage; }
            set { Damage = value; }
        }

        public enum MovementEnum
        {
            NoMovement = 0,
            Up = 1,
            Left = 2,
            Right = 3,
            Down = 4
        }

        public enum AttackEnum
        {
            NoAttack = 0,
            Up = 1,
            Left = 2,
            Right = 3,
            Down = 4
        }

        protected Character(int x, int y, TileType ConstructType, char ConstructSymbol) : base(x, y, ConstructType, ConstructSymbol)
        {
            ConstructSymbol = Symbol;
        }



        public int Positions()
        {
            return x;
        }

        public virtual void Attack(Character target)
        {
            target.Hp = target.Hp - 10;
        }

        public bool IsDead() //Check if the character is dead
        {
            if (Hp < 1)
            {
                dead = true;
            }

            return dead;
        }


        public virtual bool CheckRange(Character target)    //Check if the target is in range of the character
        {
            return true;
        }

        private int DistanceTo(Character target)    //Determines the absolute distance between the character and the target
        {
            return 5;
        }

        public void Move(MovementEnum move)  //Edites a units X and Y valaues in order to move it
        {

        }

        public abstract MovementEnum ReturnMove(MovementEnum move = 0);  //Returns a direction of movement


        public abstract override string ToString();  //overrides traditional object ToString Method



    }
}
