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
    public partial class Form1 : Form
    {
        GameEngine engine;

        public void UpdateAttackLog()
        {
            attackLog_RTB.Text = "some stuff";
        }

        public Form1()
        {
            InitializeComponent();

            engine = new GameEngine();
            lblMap.Text = engine.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void WeaponRange_Label_Click(object sender, EventArgs e)
        {

        }

        private void btnRight_Click_1(object sender, EventArgs e)
        {
            Random r = new Random();
            int enemyMove = r.Next(1, 4);

            Character.Movement somethingElse = (Character.Movement)enemyMove;

            engine.GetMap().MoveHero(Character.Movement.right);
            lblMap.Text = engine.ToString();

            goldAmount_Label.Text = MAP.goldCollected.ToString();

            engine.GetMap().MoveEnemy(somethingElse);
        }

        private void btnUp_Click_1(object sender, EventArgs e)
        {
            Random r = new Random();
            int enemyMove = r.Next(1, 4);

            Character.Movement somethingElse = (Character.Movement)enemyMove;

            engine.GetMap().MoveHero(Character.Movement.up);
            lblMap.Text = engine.ToString();

            goldAmount_Label.Text = MAP.goldCollected.ToString();

            engine.GetMap().MoveEnemy(somethingElse);
        }

        private void btnLeft_Click_1(object sender, EventArgs e)
        {
            Random r = new Random();
            int enemyMove = r.Next(1, 4);

            Character.Movement somethingElse = (Character.Movement)enemyMove;

            engine.GetMap().MoveHero(Character.Movement.left);
            lblMap.Text = engine.ToString();

            goldAmount_Label.Text = MAP.goldCollected.ToString();

            engine.GetMap().MoveEnemy(somethingElse);
        }

        private void btnDown_Click_1(object sender, EventArgs e)
        {
            Random r = new Random();
            int enemyMove = r.Next(1, 4);

            Character.Movement somethingElse = (Character.Movement)enemyMove;

            engine.GetMap().MoveHero(Character.Movement.down);
            lblMap.Text = engine.ToString();

            goldAmount_Label.Text = MAP.goldCollected.ToString();

            engine.GetMap().MoveEnemy(somethingElse);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void attackUp_Btn_Click(object sender, EventArgs e)
        {
            engine.GetMap().HeroAttack(Character.Attacking.up);
            lblMap.Text = engine.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            engine.GetMap().HeroAttack(Character.Attacking.down);
            lblMap.Text = engine.ToString();
        }

        private void attackRight_Btn_Click(object sender, EventArgs e)
        {
            engine.GetMap().HeroAttack(Character.Attacking.right);
            lblMap.Text = engine.ToString();
        }

        private void attackLeft_Btn_Click(object sender, EventArgs e)
        {
            engine.GetMap().HeroAttack(Character.Attacking.left);
            lblMap.Text = engine.ToString();
        }

        private void attackDown_Btn_Click(object sender, EventArgs e)
        {
            engine.GetMap().HeroAttack(Character.Attacking.down);
            lblMap.Text = engine.ToString();
        }
    }
}
