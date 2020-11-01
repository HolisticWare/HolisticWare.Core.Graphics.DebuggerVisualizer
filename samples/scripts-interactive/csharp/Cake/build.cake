#reference "../../../../source/HolisticWare.Core.Graphics.DebuggerVisualizer/bin/Debug/netstandard2.0/HolisticWare.Core.Graphics.DebuggerVisualizer.dll"

#tool "Cake.CoreCLR"

using Core.Graphics.DebuggerVisualizer;


/*
Install: 
    Debug Visualizer
    hediet.debug-visualizer
*/
Core.Graphics.DebuggerVisualizer.LinkedList<int> list = new Core.Graphics.DebuggerVisualizer.LinkedList<int>();
/* 
    1.  set breakpoint
    2.  open/view command pallete and run
        Debug Visualizer: New View
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


