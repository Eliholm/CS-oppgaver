using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_oppgaver.Tasks
{
    public class Task9
    {
        static readonly Random Random = new Random();

        static int UserPoints = 0;

        
        public static void Run(string[] args)
        {
            bool CharIsValid = true;
            while (CharIsValid)
            {
                int num1 = Random.Next(1, 12);
                int num2 = Random.Next(1, 12);

                string answer = $"{num1} _ {num2}";

                Console.WriteLine(answer);

                string char1 = Console.ReadLine();
                CharIsValid = UpdatePoints(char1, num1, num2);

                string points = $"Dine poeng er: {UserPoints}";
                Console.WriteLine(points);
            }
        }
        
        public static bool UpdatePoints(string char1, int num1, int num2)
        {
            if (char1 == "<")
            {
                if (num1 < num2) { AddPoint(); }
                else { RemovePoint(); }
                return true;
            }

            if (char1 == ">")
            {
                if (num1 > num2) { AddPoint(); }
                else { RemovePoint(); }
                return true;
            }

            if (char1 == "=")
            {
                if (num1 == num2) { AddPoint(); }
                else { RemovePoint(); }
                return true;
            }
            return false;
        }

        public static void AddPoint()
        {
            UserPoints += 1;
        }

        public static void RemovePoint()
        {
              UserPoints--;
        }
    }
}
