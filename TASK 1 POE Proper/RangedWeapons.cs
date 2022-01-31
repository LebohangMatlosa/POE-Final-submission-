using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
    abstract class RangedWeapons : Weapon_Class
    {
        public enum RangeWeapons
        {
            Rifle, LongBow, 
        }
        public RangedWeapons(RangeWeapons WeaponType, int i = -1, int j = -1, TileType ConstructType = TileType.Weapon, char ConstructSymbol = '.') : base(ConstructSymbol, i, j, ConstructType)
        {
            if (RangeWeapons.LongBow == WeaponType)
            {
                base.symbol = 'L';
                base.DURABILITY = 4;
                base.RANGE = 2;
                base.DAMAGE = 4;
                base.COST = 6;
            }
            if (RangeWeapons.Rifle == WeaponType)
            {
                base.symbol = 'R';
                base.DAMAGE = 5;
                base.COST = 7;
                base.RANGE = 3;
                base.DURABILITY = 10;

            }
           
            base.RANGE = 1;
            x = i;
            y = j;
        }
       
    }
    
}
