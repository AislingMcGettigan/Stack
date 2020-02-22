using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            int max = 5;

            for(var i = 0; i <= max; i++)
            {
                stack.Push(i);
            }

            for (var i =1; i <= max; i++)
            {
                Console.WriteLine(stack.Pop());
            }

            Console.ReadLine();
        }
    }
}
