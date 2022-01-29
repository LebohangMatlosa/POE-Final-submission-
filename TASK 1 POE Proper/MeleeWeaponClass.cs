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
            LongSword, Dagger
        }
        
        public MeleeWeaponClass(MELEEWEAPONS typeOfWeapon, int k, int l, TileType Type = TileType.Weapon)
        {
            if(MELEEWEAPONS.LongSword == typeOfWeapon)
            {
                base.symbol = 'D';
                
            }
        }
    }
}
