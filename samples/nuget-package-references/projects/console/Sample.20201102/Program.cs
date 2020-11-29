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

            List<List<int>> ints_multi = new List<List<int>>()
            {
                new List<int>
                {
                    1, 2, 4, 8, 32, 56, 34
                },
                new List<int>
                {
                    11, 22, 44, 88, 55, 99, 342
                },
            };

            string json = null;
            
            json = ints.Visualize();
            json = doubles.Visualize();
            json = ints_multi.Visualize();

            return;
        }
    }
}
