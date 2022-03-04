using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_oppgaver.Tasks
{
    public class Task2
    {
        public static void Run(string[] args)
        {
            Console.Write("Hei! Hva heter du? ");
            string name = Console.ReadLine();
            Console.WriteLine("Velkommen " + name);
            Console.Write("Hvor gammel er du? ");
            string age = Console.ReadLine();
            Console.WriteLine("Du er " + age + " år gammel");

            Console.ReadLine();
        }
    
    }
}
