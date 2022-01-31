using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
    class MeleeWeaponClass : Weapon_Class
    {
        public enum MELEEWEAPONS
        {
            Dagger, LongSword
        }
        
        public MeleeWeaponClass(MELEEWEAPONS typeOfWeapon, int k = -1, int l = -1, TileType Type = TileType.Weapon, char symbolConstruct = '*') : base(symbolConstruct, l, k, Type )
        {
            if(MELEEWEAPONS.LongSword == typeOfWeapon)
            {
                base.symbol = 'L';
                base.DURABILITY = 6;
                base.DAMAGE = 4;
                base.COST = 5;
            }
            if (MELEEWEAPONS.Dagger == typeOfWeapon)
            {
                base.symbol = 'D';
                base.DAMAGE = 3;
                base.COST = 3;
                base.DURABILITY = 10;
            }
            base.x = k;
            base.y = l;

            
        }
    }
}
