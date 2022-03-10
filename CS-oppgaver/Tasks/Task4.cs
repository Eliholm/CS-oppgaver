using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_oppgaver.Tasks
{
    public class Task4
    {
        public static void Run(string[] args)
        {
            Console.WriteLine(CheckNumbers(7, 4));
        }

        public static int CheckNumbers(int num1, int num2)
        {
            if (num1 == num2) { return num1 + num2; }
            else { return num1 * num2; }
        }
    }
}
