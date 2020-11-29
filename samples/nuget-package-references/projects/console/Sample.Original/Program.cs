using System;

using Core.Graphics.DebuggerVisualizer;

namespace Sample.Original
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Install: 
                Debug Visualizer
                hediet.debug-visualizer
            */
            LinkedList<int> list = new LinkedList<int>();
            /* 
                1.  set breakpoint
                2.  open/view command pallete
                3.  in the Debug Visualizer window paste command that vizualizes
                    ```
                    list.Visualize()
                    ```
                    `Visualize()` is method that returns JSON string that vizualizes data
            */
            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.Append(4);

            Console.WriteLine("Hello World!");


        }
    }
}
