using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
    class Map : Tile
    {
        char[,] gameMap = new char[8,14];
        string[] enemy = new string[4];
        string[] item = new string[5];
        string goblin;
        string mage;

        int mapWidth = 14;
        int mapHeight = 8;

        Random r = new Random();

        protected Random Random_Number_Generator = new Random();
        private Tile [,] mapcontainer;

        public Tile [,] MAPCONTAINER
        {
            get { return mapcontainer; }
            set { mapcontainer = value; }
        }


        private int mapwidth;

        public int MAPWIDTH
        {
            get { return mapwidth; }
            set { mapwidth = value; }
        }
        private int mapheight;

        public int MAPHEIGHT
        {
            get { return mapheight; }
            set { mapheight = value; }
        }


        public Map(int widthMax,  int widthMin, int heightMIn, int heightMax, int enemyAmount, int goblin, int mage, int goldOnMap )
        {
            string[,] mapSize = new string[8, 14];
            heightMax = 10;
            heightMIn = 5;
            widthMax = 14;
            widthMin = 7;
            MAPHEIGHT = Random_Number_Generator.Next(heightMIn, heightMax);

            MAPWIDTH = Random_Number_Generator.Next(widthMin, widthMax);

            MAPCONTAINER = new Tile[mapWidth, mapHeight];
            enemies = new List<Enemy>();
            mage = 4;
            goblin = 5;


            enemies = Random_Number_Generator.Next(goblin, mage);


            

             

            UpdateVision();

        }
        
        private Tile Create(int tileEnumType)
        {
           for(int x = 0; x < 15; x++)
            {
                for(int y = 0; y < 9; y++)
                {
                    gameMap[x, y].ToString(); 
                }
            }
        }
        void GenerateInitialMap(int gobAmount)
        {
            for(int y = 0; y < MAPWIDTH; y++)
            {
                for(int x=0; x < MAMPHEIGHT; x++)
                {
                    if(x == 0 || x == MAPWIDTH -1 || y ==0 || y = mapHeight - 1)
                    {
                        Create(TileType.Barrier, x, y);
                    }
                    else
                    {
                        Create(TileType.Empty, x, y); 
                    }
                }
            }
            Create(TileType.Hero);
            {
                for(int e =0; e < gobAmount; e++)
                {
                    Create(TileType.Enemy);   
                }
            }
            
            {
                for(int w = 0; w < 10; w++)
                {
                    for(int t =0; t <10; t++)
                    {
                        Create(TileType.Gold, w, t );
                        int gold = Random_Number_Generator.Next(1, 5);

                    }
                }
            }
        }
        public override string ToString()
        {
            string MapString = " ";
            for(int y = 0; y < MAPWIDTH; y++)
            {
                for(int x = 0; x < MAPHEIGHT; x++)
                {
                    MapString += MAPCONTAINER[x, y];
                }
                MapString += "\n";    
            }
            return MapString;
        }
        public void Create(TileType typeOfTile, int X = 0, int Y = 0)
        {
            switch (typeOfTile)
            {
                case TileType.Barrier:
                    Obstacle NewBarrier = new Obstacle(X, Y, "#", typeOfTile);
                    MAPCONTAINER[X, Y] = NewBarrier;
                    break;
                case TileType.Empty:
                    emptyTile NewEmptyTile = new emptyTile(X, Y, " ", typeOfTile);
                    MAPCONTAINER[X, Y] = NewEmptyTile;
                    break;
                case TileType.Hero:
                    int HeroX = Random_Number_Generator.Next(0, MAPWIDTH);
                    int HeroY = Random_Number_Generator.Next(0, MAPHEIGHT);
                    
                    while(MAPCONTAINER[HeroX, HeroY].TYPEOFTILE ! = TileType.Empty)
                    {
                         HeroX = Random_Number_Generator.Next(0, MAPWIDTH);
                         HeroY = Random_Number_Generator.Next(0, MAPHEIGHT);

                    }

                    Hero NewHero = new Hero(HeroX, HeroY, "H", 100, 100, 10);
                    PLAYERCHARACTER = NewHero; 
                    MAPCONTAINER[HeroX, HeroY] = NewHero
             
            }
        static void UpdateVision()
        {
            foreach (Enemy E in 
        }
        private List<Enemy> enemies;
        public List<Enemy> Enemies;
    }
      

    
}
