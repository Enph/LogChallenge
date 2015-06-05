using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Probe
{
    class Universe
    {
        public int row = 15;
        public int col = 15;
        static Random random = new Random();
        public List<KeyValuePair<char, double>> elements = new List<KeyValuePair<char,double>>();
        public int[] startCoord;
        public int[] finishCoord;



        public Universe(int row, int col)
        {
            this.row = row;
            this.col = col;
            elements.Add(new KeyValuePair<char, double>('A', 0.05));
            elements.Add(new KeyValuePair<char, double>('G', 0.05));
            elements.Add(new KeyValuePair<char, double>('S', 0.9));
        }

        public Universe()
        {
            elements.Add(new KeyValuePair<char, double>('A', 0.05));
            elements.Add(new KeyValuePair<char, double>('G', 0.05));
            elements.Add(new KeyValuePair<char, double>('S', 0.9));
        }

        //randoms a astroid, gravity well, or space based on a weighted percentage
        public char generateRandom() 
        {
            double diceRoll = random.NextDouble();

            double cumulative = 0.0;
            for (int i = 0; i < elements.Count; i++)
            {
                cumulative += elements[i].Value;
                if (diceRoll < cumulative)
                {
                    char selectedElement = elements[i].Key;
                    return selectedElement;
                    //Console.WriteLine("RNG: "+selectedElement);
                    break;
                }
            }
            return 'E';
        }

        public void generateRandomStartFinishPoint()
        {
            startCoord = new int[2];
            finishCoord = new int[2];
            startCoord[0] = random.Next(1, col); //Xcoord
            startCoord[1] = random.Next(1, row);//Ycoord

            finishCoord[0] = random.Next(0, col);
            finishCoord[1] = random.Next(0, row);

        }
    }
}
