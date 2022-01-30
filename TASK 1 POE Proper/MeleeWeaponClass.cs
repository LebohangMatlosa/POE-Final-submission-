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
            LongBow, Rifle, BareHanded
        }
        
        public MeleeWeaponClass(MELEEWEAPONS typeOfWeapon, int k, int l, TileType Type = TileType.Weapon, char symbolConstruct = '*') : base(symbolConstruct, l, k, Type )
        {
            if(MELEEWEAPONS.LongBow == typeOfWeapon)
            {
                base.symbol = 'L';
                base.DURABILITY = 4;
                base.RANGE = 2;
                base.DAMAGE = 4;
                base.COST = 6;
            }
            if (MELEEWEAPONS.Rifle == typeOfWeapon)
            {
                base.symbol = 'R';
                base.DAMAGE = 5;
                base.COST = 7;
                base.RANGE = 3;
                base.DURABILITY = 10;

            }
            base.x = k;
            base.y = l;
        }
    }
}
