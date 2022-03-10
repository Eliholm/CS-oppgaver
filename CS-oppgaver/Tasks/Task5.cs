using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_oppgaver.Tasks
{
    public class Task5
    {
        public static void Run(string[] args)
        {
            Console.WriteLine(CheckIfSame(30, 15));
        }

        public static bool CheckIfSame(int num1, int num2)
        {
            if (num1 == 30 || num2 == 30 || num1 + num2 == 30)
            return true;
            return false;
        }
    }
}
