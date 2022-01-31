using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
    class Shop 
    {
        [NonSerialized]
        public Random r = new Random();
        private Character Buyer;

        private Weapon_Class[] stock;

        public Weapon_Class[] Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public Shop(Character buyer)
        {
            Buyer = buyer;
            Stock = new Weapon_Class[3];
            r = new Random();

            for (int i = 0; i < 3; i++)
            {
                Stock[i] = RandomWeapon(r.Next(4));
            }
        }

        private Weapon_Class RandomWeapon(int RandWeap)
        {
            Weapon_Class Output = null;

            switch (RandWeap)
            {
                case 0:
                    Output = new RangedWeapons(RangedWeapons.RANGEDWEAPONS.Rifle);
                    break;
                case 1:
                    Output = new RangedWeapons(RangedWeapons.RANGEDWEAPONS.LongBow);
                    break;
                case 2:
                    Output = new MeleeWeaponClass(MeleeWeaponClass.MELEEWEAPONS.Dagger);
                    break;
                case 3:
                    Output = new MeleeWeaponClass(MeleeWeaponClass.MELEEWEAPONS.LongSword);
                    break;
            }

            return Output;
        }


         /*public bool CanBuy(int num)
         {
             bool Output = false;
             Weapon_Class Purchase;
             Purchase = Stock[num];

             if (Purchase.COST > Buyer.GoldPurse)
             {
                 Output = false;
             }
             else
             {
                 Output = true;
             }
             return Output;
         }

         public void Buy(int num)
         {
             Buyer. = Buyer.GoldPurse - Stock[num].COST;
             Buyer.Pickup(,Stock[num]);
             r = new Random();
             Stock[num] = RandomWeapon(r.Next(4));
         }

         public string DisplayWeapon(int num)
         {
             string Output = "";

             switch (Stock[num].Symbol)
             {
                 case 'D':
                     Output = "Buy Dagger for 3 Gold";
                     break;

                 case 'B':
                     Output = "Buy LongBow for 6 Gold";
                     break;

                 case 'S':
                     Output = "Buy LongSword for 5 Gold";
                     break;

                 case 'R':
                     Output = "Buy Rifle for 7 Gold";
                     break;
             }
             return Output;


         }*/ 
    }
}
