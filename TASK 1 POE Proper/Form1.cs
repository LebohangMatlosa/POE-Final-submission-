using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASK_1_POE_Proper
{
     

    abstract class Weapon : Item
    {
        protected int Damage;
        protected int Range;
        protected int Durability;
        protected int Cost;
        string weaponType;

        

        protected Weapon(int damage, int range, int durability, int cost, string weaponType, int posX, int posY)
        {
            Damage = damage;
            Range = range;
            Durability = durability;
            Cost = cost;
            this.weaponType = weaponType;    
        }

        public class MeleeWeapon
        {
            int damage;
            int durability;
            int cost;
            string LongSword;
            string Dagger;
            public MeleeWeapon(int posX, int posY,string WeaponA, string weaponA, string weaponB)
            {
                weaponA = LongSword;
                weaponB = Dagger;

                if (weaponA.Contains(LongSword))
                {
                    damage = 4;
                    durability = 6;
                    cost = 5;
                }
                else weaponB.Contains(Dagger);

                if (weaponB.Contains(Dagger))
                {
                    damage = 3;
                    cost = 3;
                    durability = 10;
                }
            }
            public enum weapontypes
            {
                Dagger, Longsword
            }
            public override string ToString()
            {
                return base.ToString();
            }
       
        }  
    }
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            List<Tile> tile = new List<Tile>();
            weapon LongSword = new weapon();
            weapon Dagger = new weapon();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
