using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogJmp
{
    class Program
    {
        static int solution(int X, int Y, int D)
        {
            int steps = 0;
            for (int i=X; i <= Y; i += D)
            {
                steps++;
            }
            //while (X + D < Y)
            //{
            //    X += D;
            //    steps++;
            //}
            return steps;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(solution(10, 85, 30));
            Console.ReadLine();
        }
    }
}
