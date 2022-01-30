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

        private int enemyDamage;
        int damageTaken = 2;

        public int EnemyDamage
        {
            get { return enemyDamage; }
            set { enemyDamage = value; }
        }

        public Enemy(int x, int y, TileType ConstructType, char Symbol, int ConstructEnemyDamage, int ConstructHp, int ConstructMaxHP) : base(x, y, ConstructType, Symbol)
        {
            damage = ConstructEnemyDamage;
            hp = ConstructHp;
            maxhp = ConstructMaxHP;

        }

        public void TakeDamage()
        {
            Hp -= damageTaken;
        }

        public override String ToString()
        {
            return "EnemyClassName" + " at [" + x.ToString() + y.ToString() + "]" + Damage;
        }
    }
}
