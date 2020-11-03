using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Graphics.DebuggerVisualizer.System.Collections.Generic
{
    // global::System.Collections.Generic.

    //List<>
    //LinkedList
    //Queue<>
    //SortedList
    //SortedSet
    //Stack

    public static partial class IEnumerableExtensions
    {
        public static string Visualize<T>(this IEnumerable<T> collection)
        {
            int n = collection.Count();

            StringBuilder data = new StringBuilder();
            data.Append($@"{{ ");
            data.Append($@"""?"" : ");
            data.Append($@"[ ");
            for (int i = 0; i < n; i++)
            {
                data.Append($@"{collection.ElementAt(i)}");
                if (i < n - 1)
                {
                    data.Append(", ");
                }
            }
            data.Append($@" ]");
            data.Append($@" }}");

            string json = Plotly.Data.Replace("placeholder_data_array", data.ToString());

            return json;
        }

        public static string Visualize<T>(this IEnumerable<IEnumerable<T>> collection)
        {
            int m = collection.Count();

            string json = null;
            for (int j = 0; j < m; j++)
            {
                int n = collection.ElementAt(j).Count();

                StringBuilder data = new StringBuilder();
                data.Append($@"{{ ");
                data.Append($@"""?"" : ");
                data.Append($@"[ ");
                for (int i = 0; i < n; i++)
                {
                    data.Append($@"{collection.ElementAt(i)}");
                    if (i < n - 1)
                    {
                        data.Append(", ");
                    }
                }
                data.Append($@" ]");
                data.Append($@" }}");

                json = Plotly.Data.Replace("placeholder_data_array", data.ToString());
            }

            return json;
        }
    }
}
