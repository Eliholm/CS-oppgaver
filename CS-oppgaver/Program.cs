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
                case "3":
                    Task3.Run(args);
                    break;
                case "4":
                    Task4.Run(args);
                    break;
                case "5":
                    Task5.Run(args);
                    break;
                case "6":
                    Task6.Run(args);
                    break;
                case "7":
                    Task7.Run(args);
                    break;
                case "8":
                    Task8.Run(args);
                    break;
                case "9":
                    Task9.Run(args);
                    break;
            }
        }

    static void WriteTasks()
        {
            Console.WriteLine("1: Task 1");
            Console.WriteLine("2: Task 2");
            Console.WriteLine("3: Task 3");
            Console.WriteLine("4: Task 4");
            Console.WriteLine("5: Task 5");
            Console.WriteLine("6: Task 6");
            Console.WriteLine("7: Task 7");
            Console.WriteLine("8: Task 8");
            Console.WriteLine("9: Task 9");
        }
    }
}
