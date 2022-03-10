using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_oppgaver.Tasks
{
    public class Task3
    {
        public static void Run(string[] args)
        {
            Console.WriteLine(IsEven(5, 5));
        }

        public static bool IsEven(int num1, int num2)
        {
            if (num1 == num2) { return true; }
            return false;
        }
    }
}
