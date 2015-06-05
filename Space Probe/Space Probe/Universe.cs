using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Probe
{
    class Universe
    {
        public int row = 10;
        public int col = 10;
        static Random random = new Random();
        public List<KeyValuePair<string, double>> elements = new List<KeyValuePair<string,double>>();
        public int[] startCoord;
        public int[] finishCoord;



        public Universe(int row, int col)
        {
            this.row = row;
            this.col = col;
            startCoord = generateRandomStartFinishPoint();
            finishCoord = generateRandomStartFinishPoint();
            elements.Add(new KeyValuePair<string, double>("astroid", 0.05));
            elements.Add(new KeyValuePair<string, double>("gravity", 0.05));
            elements.Add(new KeyValuePair<string, double>("space", 0.9));
        }

        public Universe()
        {
            startCoord = generateRandomStartFinishPoint();
            finishCoord = generateRandomStartFinishPoint();
            elements.Add(new KeyValuePair<string, double>("astroid", 0.05));
            elements.Add(new KeyValuePair<string, double>("gravity", 0.05));
            elements.Add(new KeyValuePair<string, double>("space", 0.9));
        }

        public void drawMatrix()
        {
            char[,] universe = new char[row,col];

            for(int i=0;i<universe.GetLength(0);i++)
            {
                for(int j=0;j<universe.GetLength(1);j++)
                {
                    //universe[i,j] = generateRandom();
                }
            }

            for (int i = 0; i < universe.GetLength(0); i++)
            {
                for (int j = 0; j < universe.GetLength(1); j++)
                {
                        Console.Write(string.Format("{0}", universe[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            Console.ReadLine();
        }


        //randoms a astroid, gravity well, or space based on a weighted percentage
        public string generateRandom() 
        {
            double diceRoll = random.NextDouble();

            double cumulative = 0.0;
            for (int i = 0; i < elements.Count; i++)
            {
                cumulative += elements[i].Value;
                if (diceRoll < cumulative)
                {
                    string selectedElement = elements[i].Key;
                    return selectedElement;
                    //Console.WriteLine("RNG: "+selectedElement);
                    break;
                }
            }
            return "Error";
        }

        public int[] generateRandomStartFinishPoint()
        {
            startCoord = new int[2];
            finishCoord = new int[2];
            int[] container = new int[2];
            container[0] = random.Next(0, col); //Xcoord
            container[1] = random.Next(0, row);//Ycoord

            return container;
        }
    }
}
