# HolisticWare.Core.Graphics.DebuggerVisualizer

HolisticWare.Core.Graphics.DebuggerVisualizer

## References / Links

*   https://hediet.github.io/visualization/?darkTheme=1
*   
*   https://marketplace.visualstudio.com/items?itemName=hediet.debug-visualizer

*   https://github.com/hediet/vscode-debug-visualizer

    *   https://github.com/hediet/vscode-debug-visualizer/tree/master/demos/csharp

*   https://addyosmani.com/blog/visualize-data-structures-vscode/

*   https://awesomeopensource.com/project/hediet/vscode-debug-visualizer

*   https://www.reddit.com/r/webdev/comments/f5a6h4/vs_code_debug_visualizer_what_a_time_to_be_alive/

*   https://en.wikipedia.org/wiki/Mathematical_operators_and_symbols_in_Unicode

------------------------------------------------------------------------------------------------------

How to use VS Code Data Visualizer in few easy steps

Clone HolisticWare.Core.Graphics.DebuggerVisualizer GitHub 

Open Samples -> Projects -> Console -> Sampple.2020110

Open Program.cs or (if you have VS Code in you local path) just put command code -n . at Terminal CLI

Preparing VS Code:

Install VS Code Extenson "Debug Visualzer"

Clck View -> Commaand Palette -> Debug Vsualzer: New View

Click Termmnal -> New Terminal

At Terminal CLI enter command: dotnet build

After the build process finishes, enter command: dotnet run

Now is time for Debugging and Visalizing !!!

Click on Debug mode in VS Code

Put Break point on line "json = ints.Visualize();"

Click on Run -> .Net Core Lounch (top left side of the VS Code Debugg mode)

Copy part of the line json = ints.Visualize(); -> "ints.Visualize()" in Debug Visualizer Text box

VOALA (!!!) and Graph is here !!!

Do the same with lines: json = doubles.Visualize(); and json = ints_multi.Visualize();
