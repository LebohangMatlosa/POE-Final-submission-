using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
    class Map 
    {
        private int WidthMin;
        private int WidthMax;
        private int mapHeight;
        private int mapWidth;
        public int borderHeight;
        public int borderWidth;
        private int heightMax;
        private int heightMin;
        private int AmountOfEnemy;

        public static int goldColleted = 0;
        public static bool canMove = true;


        public Hero characterPlayer;
        public Enemy[] enemies;
        public GOLD gold;
        public MeleeWeaponClass meleeWeapon;
        public static Tile[,] map;

        
        
        private static Random numbers = new Random();
        private static Random random = new Random();
        private static int amountOfEnemies = random.Next(1, 9);
        private static Random goblinAmount = new Random();
        private static int amountOfGoblins = goblinAmount.Next(1, amountOfEnemies);
        private static Random mageAmount = new Random();
        private static int amount = mageAmount.Next(1, amountOfEnemies);
        private static Random meleeWepaonAmount = new Random();
        private static int AmountOfmeleeWeapon = meleeWepaonAmount.Next(1, 5);
        private static Random goldAmount = new Random();
        private static int AmountOfGold = goblinAmount.Next(1, 5);
        
        public static Hero player;
        Enemy enemy;

        

        public Map(int widthMin, int widthMax, int minHeight, int maxHeight, int EnemiesAmount)
        {
            AmountOfEnemy = EnemiesAmount;
            heightMin = minHeight;
            heightMax = maxHeight;
            WidthMin = widthMin;
            WidthMax = widthMax;
            

            borderHeight = mapHeight + 2;
            borderWidth = mapWidth + 2;

            mapHeight = numbers.Next(minHeight, maxHeight);
            mapWidth = numbers.Next(widthMin, widthMax);

            enemies = new Enemy[AmountOfEnemy];
            map = new Tile[borderWidth, borderHeight];

            MapMaker();
        }

        private Tile Create(Tile.TileType type, Type EnemyType = null)
        {
            int posX = numbers.Next(1, mapWidth);
            int posY = numbers.Next(1, mapHeight);

            if (posX > mapHeight || posY > mapWidth)
            {
                return Create(type, EnemyType);
            }

            if (type == Tile.TileType.Enemy)
            {
                return (Enemy)Activator.CreateInstance(EnemyType, posX, posY, type, EnemyType == typeof(Goblin) ? 'G' : 'M', 1, 10);
            }
            else if (type == Tile.TileType.Hero)
            {
                return new Hero(posX, posY, type, 'H', 20, 20);
            }
            else if (type == Tile.TileType.Gold)
            {
                return new GOLD(posX, posY);
            }
            

            return new Hero(posX, posY, Tile.TileType.Hero, 'H', 20, 20);

        }

        private void MapMaker()
        {
            for (int x = 0; x < borderWidth; x++)
            {
                for (int y = 0; y < borderHeight; y++)
                {
                    map[x, y] = new emptyTile(x, y, Tile.TileType.Empty);

                    if (x == 0 || x == borderWidth - 1 || y == 0 || y == borderHeight - 1)
                    {
                        map[x, y] = new Obstacle(x, y, Tile.TileType.Obstacle);
                    }
                }
            }

            player = (Hero)Create(Tile.TileType.Hero);
            map[player.X(), player.Y()] = player;

            for (int i = 0; i < AmountOfEnemy; i++)
            {
                enemies[i] = (Mage)Create(Tile.TileType.Enemy, typeof(Mage));
                map[enemies[i].X(), enemies[i].Y()] = enemies[i];
            }

            for (int i = 0; i < AmountOfEnemy; i++)
            {
                enemies[i] = (Goblin)Create(Tile.TileType.Enemy, typeof(Goblin));
                map[enemies[i].X(), enemies[i].Y()] = enemies[i];
            }


            for (int i = 0; i < 1; i++)
            {
                enemies[i] = (Leader)Create(Tile.TileType.Enemy, typeof(Leader));
                map[enemies[i].X(), enemies[i].Y()] = enemies[i];
            }

            for (int i = 0; i < AmountOfGold + 1; i++)
            {
                gold = (GOLD)Create(Tile.TileType.Gold);
                map[gold.X(), gold.Y()] = gold;
            }

            /*for (int i = 0; i < meleeWeaponAmt + 1; i++)
            {
                meleeWeapon = (MeleeWeapon)Create(Tile.TileType.Weapon);
                map[meleeWeapon.GetX(), meleeWeapon.GetY()] = meleeWeapon;
            }*/

        }

        public void MoveHero(Character.Movement move)
        {
            int x = player.X();
            int y = player.Y();

            switch (move)
            {
                case Character.Movement.up:
                    {
                        x--;
                        break;
                    }

                case Character.Movement.down:
                    {
                        x++;
                        break;
                    }

                case Character.Movement.left:
                    {
                        y--;
                        break;
                    }

                case Character.Movement.right:
                    {
                        y++;
                        break;
                    }
            }

            if (map[x, y] is Goblin || map[x, y] is Obstacle || map[x, y] is Mage || map[x, y] is Leader)
            {
                canMove = false;
                return;
            }

            map[player.X(), player.Y()] = new emptyTile(player.X(), player.Y(), Tile.TileType.Empty);
            player.returnMove(move);

            if (map[player.X(), player.Y()] is GOLD)
            {
                goldColleted = goldColleted + 1;
            }

            map[player.X(), player.Y()] = player;
        }

        public void HeroAttack(Character.Attacking attack)
        {
            int x = player.X();
            int y = player.Y();

            switch (attack)
            {
                case Hero.Attacking.up:
                    {
                        Tile tile = map[x - 1, y];
                        if (tile is Enemy)
                        {
                            Enemy enemy = (Enemy)tile;
                            enemy.TakeDamage();
                            enemy.isDead();

                            if (enemy.isDead())
                            {
                                map[x - 1, y] = new emptyTile(x - 1, y, Tile.TileType.Empty);
                            }
                        }
                        break;
                    }

                case Hero.Attacking.down:
                    {
                        if (map[x + 1, y] is Enemy)
                        {
                            Tile tile = map[x + 1, y];
                            if (tile is Enemy)
                            {
                                Enemy enemy = (Enemy)tile;
                                enemy.TakeDamage();
                                enemy.isDead();

                                if (enemy.isDead())
                                {
                                    map[x + 1, y] = new emptyTile(x + 1, y, Tile.TileType.Empty);
                                }
                            }
                        }
                        break;
                    }

                case Hero.Attacking.left:
                    {
                        if (map[x, y - 1] is Enemy)
                        {
                            Tile tile = map[x, y - 1];
                            if (tile is Enemy)
                            {
                                Enemy enemy = (Enemy)tile;
                                enemy.TakeDamage();
                                enemy.isDead();

                                if (enemy.isDead())
                                {
                                    map[x, y - 1] = new emptyTile(x, y - 1, Tile.TileType.Empty);
                                }
                            }
                        }
                        break;
                    }

                case Hero.Attacking.right:
                    {
                        if (map[x, y + 1] is Enemy)
                        {
                            Tile tile = map[x, y + 1];
                            if (tile is Enemy)
                            {
                                Enemy enemy = (Enemy)tile;
                                enemy.TakeDamage();
                                enemy.isDead();

                                if (enemy.isDead())
                                {
                                    map[x, y + 1] = new emptyTile(x, y + 1, Tile.TileType.Empty);
                                }
                            }
                        }
                        break;
                    }
            }




            // public void UpdateVision()  //Updates the vision array for each character 
            //{

            //}
        }

        public void MoveEnemy(Character.Movement move)
        {
            for (int i = 0; i < AmountOfEnemy; i++)
            {


                int x = enemies[i].X();
                int y = enemies[i].Y();

                switch (move)
                {
                    case Character.Movement.up:
                        {
                            x--;
                            break;
                        }

                    case Character.Movement.down:
                        {
                            x++;
                            break;
                        }

                    case Character.Movement.left:
                        {
                            y--;
                            break;
                        }

                    case Character.Movement.right:
                        {
                            y++;
                            break;
                        }
                }

                if (map[x, y] is Goblin || map[x, y] is Obstacle || map[x, y] is Mage || enemies[i] is Mage)
                {
                    canMove = false;
                    return;
                }

                map[enemies[i].X(), enemies[i].Y()] = new emptyTile(enemies[i].X(), enemies[i].Y(), Tile.TileType.Empty);
                enemies[i].returnMove(move);

                map[x, y] = enemies[i];
            }
        }
    }
      

    
}
