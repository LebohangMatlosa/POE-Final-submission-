using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
    abstract class RangedWeapons : Weapon_Class
    {
        private int RANGE;

        protected RangedWeapons(string LongBow, string Rifle, int rANGE, int range)
        {
            RANGE = rANGE;
            this.range = range;
            Random weapon = new Random();
            weapon.Next(LongBow, Rifle);
            while (Rifle)
            {
                DAMAGE = 3;
                COST = 3;
                DURABILITY = 10;
            }
            else
            {
                DAMAGE = 4;
                COST = 5;
                DURABILITY = 6;
            }
        }

        public int range
        {
            get { return RANGE; }
            set { RANGE = value; }
        }
        public enum rangedweapons
        {
            LongBow,
            Rifle
        }
        public void 
        public override int Range()
        {
            return base.Range = RANGE;
        } 

    }
    
}
