using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
    public class Game_Engine : Character
    {
        private Map gamemap;

        public Map GAMEMAP
        {
            get { return gamemap; }
            set { gamemap = value; }
        }

    }
    public GameEngine()
    {
        GAMEMAP = new Map(10, 10, 10, 10, 5);
    }
    public bool MovePlayer(MovementDirection Direction)
    {
       
    }
    public void EnemyAttacs()
    {

    }
    public enum Movement
    {
        noMovement,
        Up,
        Down,
        Left,
        Right,
    public void EnemyMovement(string hero, string gobl)
    {
        if(hero.movement = false)
        {
            G
        }
    }
}
 