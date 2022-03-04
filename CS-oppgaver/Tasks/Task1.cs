using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_oppgaver.Tasks
{
    public class Task1
    {
        public static void Run(string[] args)
        {
            Console.WriteLine(AddNumbers());
        }
        public static int AddNumbers()
        {
            int num1 = 5;
            int num2 = 10;
            return num1 + num2;
        }
    }
}
