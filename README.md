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

*   plotly

    *   https://plotly-json-editor.getforge.io/

    *   Fully formatted JSON chart schema for every chart type: 
    
        *   https://api.plot.ly/v2/plot-schema?sha1=%27%27

    *   Raw JSON (plain text) chart schema for every chart type: 
    
        *   https://api.plot.ly/v2/plot-schema?format=json&sha1=%27%27


## How to use VS Code Data Visualizer in few easy steps

1.  Clone HolisticWare.Core.Graphics.DebuggerVisualizer GitHub 

2.  Open Samples -> Projects -> Console -> Sample.2020110

3.  Open Program.cs or (if you have VS Code in you local path) just put command code -n . (at Terminal CLI)

4.  Preparing VS Code:

    1.  Install VS Code Extenson "Debug Visualzer"

5.  Clck View -> Commaand Palette -> Debug Vsualzer: New View

6.  Click Termmnal -> New Terminal

7.  At Terminal CLI enter command: dotnet build

8.  After the build process finishes, enter command: dotnet run

9.  Now is time for Debugging and Visualizing !!!

10. Click on Debug mode in VS Code

11. Put Break point on line "json = ints.Visualize();"

12. Click on Run -> .Net Core Lounch (top left side of the VS Code Debugg mode)

13. Copy part of the line json = ints.Visualize(); -> "ints.Visualize()" in Debug Visualizer Text box

14. VOILA (!!!) and Graph is here !!!

15. Do the same with lines: json = doubles.Visualize(); and json = ints_multi.Visualize();
