using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASK_1_POE_Proper
{
     class Hero : Character
    {
        public Hero(int x, int y, TileType ConstructType, char Symbol, int ConstructHp, int ConstructMaxHP) : base(x, y, ConstructType, 'H')
        {
            damage = 2;
            hp = ConstructHp;
            maxHp = ConstructMaxHP;
        }
        

        public override Movement returnMove(Movement move)
        {
            switch (move)
            {
                case Movement.up:
                    {
                        x--;
                        return move;
                    }

                case Movement.down:
                    {
                        y--;
                        return move;
                    }

                case Movement.left:
                    {
                        x++;
                        return move;
                    }

                case Movement.right:
                    {
                        y++;
                        return move;
                    }
            }

            return Character.Movement.stationary;
        }

        public Attacking ReturnAttack(Attacking attack)
        {
            switch (attack)
            {
                case Attacking.up:
                    {
                        if (MAP.map[x - 1, y] is Enemy)
                        {
                            System.Windows.Forms.MessageBox.Show("Hit!");
                        }
                        return attack;
                    }

                case Attacking.down:
                    {
                        if (MAP.map[x + 1, y] is Enemy)
                        {
                            MessageBox.Show("Hit");
                        }
                        return attack;
                    }

                case Attacking.left:
                    {
                        if (MAP.map[x, y - 1] is Enemy)
                        {
                            MessageBox.Show("Hit"); 
                        }
                        return attack;
                    }

                case Attacking.right:
                    {
                        if (MAP.map[x, y + 1] is Enemy)
                        {

                        }
                        return attack;
                    }
            }

            return Character.Attacking.stationary;
        }
        public override String ToString()
        {
            return "Hero" + " at [" + x.ToString() + y.ToString() + "]" + Damage;
        }

    }
}
