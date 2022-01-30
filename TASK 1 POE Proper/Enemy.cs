using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
    abstract class Enemy : Character
    {
        protected Random r = new Random();

        private int EnemiesDamage;
        int hploss = 2;

        public Enemy(int x, int y, TileType Type, char Symbol, int EnemyDamage, int Hp, int MaxHP) : base(x, y, Type, Symbol)
        {
            damage = EnemyDamage;
            hp = Hp;
            maxHp = MaxHP;

        }
        public int EnemyDamage
        {
            get { return EnemiesDamage; }
            set { EnemiesDamage = value; }
        }
        public void TakeDamage()
        {
            hp -= hploss;
        }

        public override String ToString()
        {
            return "EnemyName" + " at [" + x.ToString() + y.ToString() + "]" + Damage;
        }
    }
}
