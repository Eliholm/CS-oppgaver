using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_oppgaver.Tasks
{
    public class Task7
    {

        public static void Run(string[] args)
        {
            PrintCharacters();
        }

        public static void PrintCharacters()
        {
            string animal = "Enhjørning";

            foreach (char character in animal) 
            {
                Console.WriteLine(character);
            }
        }
    }
}
