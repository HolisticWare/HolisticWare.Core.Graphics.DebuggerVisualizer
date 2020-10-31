using System;
using Core.Graphics.DebuggerVisualizer;

namespace Sample.Original
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>();
            // visualize `list.Visualize()` here!
            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.Append(4);
            
            Console.WriteLine("Hello World!");


        }
    }
}
