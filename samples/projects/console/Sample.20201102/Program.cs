using System.Collections.Generic;
using System.Linq;

using Core.Graphics.DebuggerVisualizer.System.Collections.Generic;

namespace Sample.Original
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>()
            {
                1, 2, 4, 8, 32, 56, 34
            };
            
            List<double> doubles = new List<double>()
            {
                1.1, 2.2, 4.4, 8.9, 32.2, 56.0, 34.2
            };

            string json = null;
            
            json = ints.Visualize();
            json = doubles.Visualize();
            
            return;
        }
    }
}
