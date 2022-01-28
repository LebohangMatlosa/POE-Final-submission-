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
        private string enemyType;


        protected Enemy(int EnemyX, int EnemyY,TileType enemy ,int enemyDamage, int enemyhp, int enemy_maxHp, string typeOfEnemy) : base(EnemyX, EnemyY,enemy, typeOfEnemy, enemyDamage, enemyhp, enemy_maxHp)
        {
            EnemyX = X;
            EnemyY = Y;
            damage = DAMAGE;
            hp = HP;


        }

      

        public string EnemyType
        {
            get { return enemyType; }
            set { enemyType = value; }
        }


        override public String ToString()
        {
            return enemyType + "at" + "["+ X +","+ Y+"]"+"(Amount "+ DAMAGE + " )" ;
        }
       
    }
}
