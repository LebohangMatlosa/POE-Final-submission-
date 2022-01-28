using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
    class Shop : Tile
    {
        weapon[] weapons = new weapon[3];
        
        Random ob = new Random();
        object buyer;

        public Shop(weapon[] weapons, Random ob, object buyer)
        {
            this.weapons = weapons;
            this.ob = ob;
            this.buyer = buyer;


        }
        private weapon RandomWeapon()
        {
            if(dagger = true)
            {
                return dagger;
            }
            else
            {
                return LongSword;
            }
            else
            {
                return Rifle
            }
            else
            {
                return LongBow
            }
        }
        public bool CanBuy(int num)
        {
            if (gold> Dagger)
            {
                return true;
            }
        }
        public void Buy(int num)
        {
            for(int x= 0; x > 10; x++)
            {
                for(int y= 0; y > 10; y++)
                {
                    
                }
            }

        }
        public string DisplayWeapon(int num)
        {
            Console.WriteLine("Buy weaponType" gold);
            
          
        }
    }
}
