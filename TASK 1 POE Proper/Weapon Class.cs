using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
    public abstract class Weapon_Class : Tile
    {
        private int Range;

        public int RANGE
        {
            get { return Range; }
            set { Range = value; }
        }

        private int damage;

        public int DAMAGE
        {
            get { return damage; }
            set { damage = value; }
        }
       
        private int durability;

        public int DURABILITY
        {
            get { return durability; }
            set { durability = value; }
        }

        private int cost;

        public int COST
        {
            get { return cost; }
            set { cost = value; }
        }
        private int weaponType;

        protected Weapon_Class(int damage, int dAMAGE, int durability, int dURABILITY, int cost, int cOST, int weaponType, int wEAPONTYPE, string longSword, string Dagger)
        {
            this.damage = damage;
            DAMAGE = dAMAGE;
            this.durability = durability;
            DURABILITY = dURABILITY;
            this.cost = cost;
            COST = cOST;
            this.weaponType = weaponType;
            WEAPONTYPE = wEAPONTYPE;
            
        }

        protected Weapon_Class( int LongSword, int Dagger, int range, int rANGE, int damage, int dAMAGE, int durability, int dURABILITY, int cost, int cOST, int weaponType, int wEAPONTYPE)
        {
            Range = range;
            RANGE = rANGE;
            this.damage = damage;
            DAMAGE = dAMAGE;
            this.durability = durability;
            DURABILITY = dURABILITY;
            this.cost = cost;
            COST = cOST;
            this.weaponType = weaponType;
            WEAPONTYPE = wEAPONTYPE;

            Random weapon = new Random();
            weapon.Next(Dagger, LongSword);
            while( Dagger )
            {
                damage = 3;
                cost = 3;
                durability = 10;
            }
            else
            {
                damage = 4;
                cost = 5;         
                durability = 6;
            }
        }

        public int WEAPONTYPE
        {
            get { return weaponType; }
            set { weaponType = value; }
        }
        public class MeleeWeapon
        {
           public enum Weapons
            {
                LongSword,
                Dagger
            }
            
            public override int Range()
            {
                return base.damage = 1;
            }
           

            public static void Weapon(int Y, int x)
            {
                MeleeWeapon longSword = new MeleeWeapon();
                MeleeWeapon Dagger = new MeleeWeapon(); 

                longSword.Range = 1;
                Dagger.Range = 1;

                Random r = new Random();
                int x = longSword;
                
                int Y = Dagger;
                r.Next(x, Y);

            }

            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }

            public override int Range()
            {
                return base.Range();
            }

            public override string ToString()
            {
                return base.ToString();
            }
        }
        



    }
}
