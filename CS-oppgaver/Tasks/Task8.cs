using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_oppgaver.Tasks
{
    public class Task8
    {

        public static void Run(string[] args)
        {
            PrintRunTimes();
        }

        public static void PrintRunTimes()
        {
            bool condition = true;
            int i = 1;
            while (condition)
            {
                if (i <= 10)
                {
                    Console.WriteLine("Runde nr " + i);
                    i++;
                }
                else { condition = false; }

            }
        }
    }
}
