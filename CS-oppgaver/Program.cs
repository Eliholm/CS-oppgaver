using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_oppgaver.Tasks;

namespace CS_oppgaver
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What task do you want to run?");
            WriteTasks();
            Console.Write("Selection: ");
            string TaskName = Console.ReadLine();
            switch (TaskName)
            {
                case "1":
                    Task1.Run(args);
                    break;
                case "2":
                    Task2.Run(args);
                    break;
            }
        }

        static void WriteTasks()
        {
            Console.WriteLine("1: Task 1");
            Console.WriteLine("2: Task 2");
        }
    }
}
