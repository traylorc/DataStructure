using System;
using DataStructure;
using DataStructureLib;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {



            var stack = new Stack<int>();
            for(var idx = 0; idx < 100; idx++)
            {
                stack.Push(idx);
            }
            while(!stack.Empty)
            {
                Console.WriteLine($"{stack.Pop()}");
            }

        }
    }
}
