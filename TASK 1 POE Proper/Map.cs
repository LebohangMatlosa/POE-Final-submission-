using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
    class MAP
    {
        public static Tile[,] map;
        public Hero playerCharacter;
        public Enemy[] enemies;
        public GOLD gold;
        public MeleeWeaponClass meleeWeapon;

        private int mapHeight;
        private int mapWidth;
        private int MinHeight;
        private int MaxHeight;
        private int MinWidth;
        private int MaxWidth;
        public int borderHeight;
        public int borderWidth;
        private int enemyAmount;

        private static Random numbers = new Random();
        private static Random rand = new Random();
        private static int enemyAmt = rand.Next(1, 9);
        private static Random goblinAmount = new Random();
        private static int goblinAmt = goblinAmount.Next(1, enemyAmt);
        private static Random mageAmount = new Random();
        private static int mageAmt = mageAmount.Next(1, enemyAmt);
        private static Random meleeWepaonAmount = new Random();
        private static int meleeWeaponAmt = meleeWepaonAmount.Next(1, 5);
        private static Random goldAmount = new Random();
        private static int goldennAmt = goblinAmount.Next(1, 5);
        public static int goldCollected = 0;
        public static bool canMove = true;
        public static Hero player;
        Enemy enemy;

        ////////THANK YOU FOR VISTING THE PILLAR OF VARIABLES\\\\\\\\\

        public MAP(int minHeight, int maxHeight, int minWidth, int maxWidth, int amtEnemy)
        {
            MinHeight = minHeight;
            MaxHeight = maxHeight;
            MinWidth = minWidth;
            MaxWidth = maxWidth;
            enemyAmount = amtEnemy;

            mapHeight = numbers.Next(minHeight, maxHeight);
            mapWidth = numbers.Next(minWidth, maxWidth);

            borderHeight = mapHeight + 2;
            borderWidth = mapWidth + 2;

            map = new Tile[borderWidth, borderHeight];

            enemies = new Enemy[enemyAmount];

            MakeMap();
        }

        private Tile Create(Tile.TileType type, Type EnemyType = null)
        {
            int positionX = numbers.Next(1, mapWidth);
            int positionY = numbers.Next(1, mapHeight);

            if (positionX > mapHeight || positionY > mapWidth)
            {
                return Create(type, EnemyType);
            }

            if (type == Tile.TileType.Enemy)
            {
                return (Enemy)Activator.CreateInstance(EnemyType, positionX, positionY, type, EnemyType == typeof(Goblin) ? 'G' : 'M', 1, 10);
            }
            else if (type == Tile.TileType.Hero)
            {
                return new Hero(positionX, positionY, type, 'H', 20, 20);
            }
            else if (type == Tile.TileType.Gold)
            {
                return new GOLD(positionX, positionY);
            }
            /*else if (type == Tile.TileType.Weapon)
            {
                return new MeleeWeapon(positionX, positionY)
            }*/

            return new Hero(positionX, positionY, Tile.TileType.Hero, 'H', 20, 20);

        }

        private void MakeMap()
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

            for (int i = 0; i < enemyAmount; i++)
            {
                enemies[i] = (Mage)Create(Tile.TileType.Enemy, typeof(Mage));
                map[enemies[i].X(), enemies[i].Y()] = enemies[i];
            }

            for (int i = 0; i < enemyAmount; i++)
            {
                enemies[i] = (Goblin)Create(Tile.TileType.Enemy, typeof(Goblin));
                map[enemies[i].X(), enemies[i].Y()] = enemies[i];
            }


            for (int i = 0; i < 1; i++)
            {
                enemies[i] = (Leader)Create(Tile.TileType.Enemy, typeof(Leader));
                map[enemies[i].X(), enemies[i].Y()] = enemies[i];
            }

            for (int i = 0; i < goldennAmt + 1; i++)
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
                goldCollected = goldCollected + 1;
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




            // public void UpdateVision()  
            //{

            //}
        }

        public void MoveEnemy(Character.Movement move)
        {
            for (int i = 0; i < enemyAmount; i++)
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
