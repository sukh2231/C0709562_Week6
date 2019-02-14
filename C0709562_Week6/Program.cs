using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190214b
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkBench2 wb2 = new WorkBench2();
            wb2.VariableA = 7;
            WorkBench2.VariableB = 8;
            wb2.Run();
            WorkBench2 wb2_b = new WorkBench2();
            Console.WriteLine(WorkBench2.VariableB);
        }
    }

    class WorkBench2
    {
        public int VariableA;
        public static int VariableB;

        public void Run()
        {
            Console.WriteLine(" VariableA is {0} ", VariableA);
            Console.WriteLine(" VariableB is {0} ", VariableB);
            VariableA++;
            VariableB++;
            Console.WriteLine(" VariableA is {0} ", VariableA);
        }

        public static void RunB() { VariableB++; }
    }

    class WorkBench
    {
        Random rand = new Random();
        int randomChoice = 0;

        public void Run()
        {
            // commit
            randomChoice = rand.Next(0, 25);
            // printing variables is called tracing
            Console.WriteLine("POINT A: randomChoice is {0} ", randomChoice);
            for (Console.WriteLine("YIPPIE"); MethodA(); Console.WriteLine(MethodB()))
            {
                Console.WriteLine("Happy Valentine's Day!!");
                Console.ReadLine();
            }
        }

        public bool MethodA()
        {
            if (randomChoice < 13)
            {
                return true;
            }
            return false;

        }

        public string MethodB()
        {
            string[] letters = new string[13] { "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string output;

            output = letters[randomChoice];
            return output;
        }

    }


}