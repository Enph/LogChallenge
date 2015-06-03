using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_218_Sad_Cycles
{
    class Program
    {
        public int basedNumber, startingNumber;
        public List <int>answers;

        public int answer =0;


        static void Main(string[] args)
        {
            Program sadCycle = new Program();
            Console.WriteLine("Input Number:");
            sadCycle.basedNumber = Convert.ToInt32(Console.ReadLine());
            sadCycle.startingNumber = Convert.ToInt32(Console.ReadLine());


            sadCycle.calculate(sadCycle.basedNumber,sadCycle.startingNumber);
            Console.ReadLine();
        }


        void calculate(int basedNumber,int startingNumber)
        {


        }
    }
}
