using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{




    class Program
    {
        public int[,] stackOfLogs;
        public int min = 0;
        public int x;
        public int y;
        public int numOfLogsToPile;

        public void storageArea()
        {
            int storageAreaLength;
            //Console.WriteLine("Input Storage Area :");
            //storageAreaLength = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Creating " + storageAreaLength + " , " + storageAreaLength + "array");
            //this.stackOfLogs = new int[storageAreaLength,storageAreaLength];
            this.stackOfLogs = new int[3,3]{ { 1,1,1},{ 2,1,3},{ 1,4,1}};

            Console.WriteLine("Number of logs to pile on matrix stack:");
            this.numOfLogsToPile = Convert.ToInt32(Console.ReadLine());

        }

        public void sortLogs()
        {
            
            int rowLength = stackOfLogs.GetLength(0);
            int colLength = stackOfLogs.GetLength(1);

            while (numOfLogsToPile > 0)
            { 
                for (int i = 0; i < rowLength; i++)
                {
                    for (int j = 0; j < colLength; j++)
                    {
                        if (min > stackOfLogs[i, j])
                        {
                            min = stackOfLogs[i, j];
                            x = i;
                            y = j;
                        }
                        else if (min == stackOfLogs[i, j])
                        {
                            min = stackOfLogs[i, j];
                            x = i;
                            y = j;
                        }
                        else if(min == 0 )
                        {
                            min = stackOfLogs[i, j];
                            x = i;
                            y = j;
                        }
                        else{ }
                    }
                }
                stackOfLogs[x, y] = stackOfLogs[x,y]+1;
                numOfLogsToPile--;
            }
        }


        public void printLogs()
        {

            int rowLength = stackOfLogs.GetLength(0);
            int colLength = stackOfLogs.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", stackOfLogs[i,j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Challenge #217 [Easy] Lumberjack Pile Problem");
            Console.WriteLine("http://www.reddit.com/r/dailyprogrammer/comments/3840rp/20150601_challenge_217_easy_lumberjack_pile/");

            Program logs = new Program();
            logs.storageArea();
            logs.sortLogs();
            logs.printLogs();


            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }


    }
}
