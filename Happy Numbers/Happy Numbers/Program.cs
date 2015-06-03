using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

/*
By: Eric Boisvert

Challenge Taken From: http://www.reddit.com/r/dailyprogrammer_ideas/comments/2ydta5/easy_happy_numbers/
Who knew numbers could be happy? Happy numbers are another topic from mathematics that is pure fun!
You are given a number N. To determine whether or not it is a happy number, you replace it by the sum of the squares of its digits, repeatedly, until:
1) You obtain the number 1, or
2) You obtain a number that has been obtained before (so you are in a never-ending loop!)
If you happen to obtain N=1, then the original number is a happy number!
INPUT
A natural number N.
OUTPUT
You should output the string "Happy" if the number is a happy number, else output "Sad".
EXAMPLE
Given the number N = 836, determine whether it is a happy number:
836 -> 82 +32 + 62 = 109
109 -> 12 + 02 + 92 = 82
82 -> 82 + 22 = 68
68 -> 62 + 82 = 100
100 -> 12 = 1
So 836 is a happy number!

*/


namespace Happy_Numbers
{
    public class Program
    {
        public static int startingNumber;

        static void Main(string[] args)
        {
            Program happyNumber = new Program();
            Console.WriteLine("Input Number:");
            startingNumber = Convert.ToInt32(Console.ReadLine());
            happyNumber.startProgram(startingNumber);

            Console.ReadLine();  
        }

        public void startProgram(int startingNumber)
        {
            List<int> answers = new List<int>();
            int num = calculate(startingNumber);
            answers.Add(num);
            bool stop = checkList(answers);
            while (!stop)
            {
                if (!checkList(answers))
                {
                    int newNum = calculate(answers[answers.Count() - 1]);
                    answers.Add(newNum);
                }
                else
                {
                    Console.ReadLine();
                }
            }
        }

        public int calculate(int startingNumber)
        {
            int temp = 0;
            int[] digits = startingNumber.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
            for (int i = 0; i < digits.Length; i++)
            {
                temp += (int)Math.Pow(digits[i], 2);
            }
            Console.WriteLine("Answer: " + temp);
            return temp;
        }

        public bool checkList(List<int> checkList)
        {
            var duplicates = checkList.GroupBy(i => i).Where(g => g.Count() > 1).Select(g => g.Key);
            foreach (var d in duplicates)
                Console.WriteLine(d);

            foreach(int i in checkList)
            {
                if(i == 1)
                    {
                        Console.WriteLine("Happy Number Found");
                        return true;
                    }
            }

            if (duplicates.Count() > 1)
                return true;

            foreach (var d in duplicates)
                Console.WriteLine("Duplicate Found: "+ d);
         
            return false;
        }
    }
}
