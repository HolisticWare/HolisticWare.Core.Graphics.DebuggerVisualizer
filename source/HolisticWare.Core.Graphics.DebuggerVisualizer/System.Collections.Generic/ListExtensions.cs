using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Graphics.DebuggerVisualizer.System.Collections.Generic
{
    public static partial class ListExtensions
    {
        public static string Visualize<T>(this List<T> collection)
        {
            List<List<T>> multi_collection = new List<List<T>>();
            multi_collection.Add(collection);

            return multi_collection.Visualize();
        }

        public static string Visualize<T>(this List<List<T>> collection)
        {
            int m = collection.Count();

            string json = Plotly.Data;

            for (int j = 0; j < m; j++)
            {
                int n = collection.ElementAt(j).Count();

                StringBuilder data = new StringBuilder();
                data.Append($@"{{ ");
                data.Append($@"""y"" : ");
                data.Append($@"[ ");
                for (int i = 0; i < n; i++)
                {
                    data.Append($@"{collection.ElementAt(j).ElementAt(i)}");
                    if (i < n - 1)
                    {
                        data.Append(", ");
                    }
                }
                data.Append($@" ]");
                data.Append($@" }}");

                if (j < m - 1)
                {
                    json = json.Replace
                                    (
                                        "placeholder_data_array",
                                        data
                                            .AppendLine(",")
                                            .Append("                            ")
                                            .Append("placeholder_data_array")
                                            .ToString()
                                    );
                }
                else
                {
                    json = json.Replace
                                    (
                                        "placeholder_data_array",
                                        data.ToString()
                                    );
        }
            }

            return json;
        }

        /*
        public static string Visualize(this List<sbyte> collection)
        {
            StringBuilder data = new StringBuilder();
            int n = collection.Count();
            data.Append("[ ");
            for (int i = 0; i < n; i++)
            {
                data.Append($"{collection.ElementAt(i)}");
                if (i < n - 1)
                {
                    data.Append(", ");
                }
            }
            data.Append(" ]");

            string json = Plotly.Data.Replace("placeholder_data", data.ToString());

            return json;
        }

        public static string Visualize(this List<byte> collection)
        {
            StringBuilder data = new StringBuilder();
            int n = collection.Count();
            data.Append("[ ");
            for (int i = 0; i < n; i++)
            {
                data.Append($"{collection.ElementAt(i)}");
                if (i < n - 1)
                {
                    data.Append(", ");
                }
            }
            data.Append(" ]");

            string json = Plotly.Data.Replace("placeholder_data", data.ToString());

            return json;
        }

        public static string Visualize(this List<short> collection)
        {
            StringBuilder data = new StringBuilder();
            int n = collection.Count();
            data.Append("[ ");
            for (int i = 0; i < n; i++)
            {
                data.Append($"{collection.ElementAt(i)}");
                if (i < n - 1)
                {
                    data.Append(", ");
                }
            }
            data.Append(" ]");

            string json = Plotly.Data.Replace("placeholder_data", data.ToString());

            return json;
        }

        public static string Visualize(this List<ushort> collection)
        {
            StringBuilder data = new StringBuilder();
            int n = collection.Count();
            data.Append("[ ");
            for (int i = 0; i < n; i++)
            {
                data.Append($"{collection.ElementAt(i)}");
                if (i < n - 1)
                {
                    data.Append(", ");
                }
            }
            data.Append(" ]");

            string json = Plotly.Data.Replace("placeholder_data", data.ToString());

            return json;
        }

        public static string Visualize(this List<int> collection)
        {
            StringBuilder data = new StringBuilder();
            int n = collection.Count();
            data.Append("[ ");
            for (int i = 0; i < n; i++)
            {
                data.Append($"{collection.ElementAt(i)}");
                if (i < n - 1)
                {
                    data.Append(", ");
                }
            }
            data.Append(" ]");

            string json = Plotly.Data.Replace("placeholder_data", data.ToString());

            return json;
        }

        public static string Visualize(this List<uint> collection)
        {
            StringBuilder data = new StringBuilder();
            int n = collection.Count();
            data.Append("[ ");
            for (int i = 0; i < n; i++)
            {
                data.Append($"{collection.ElementAt(i)}");
                if (i < n - 1)
                {
                    data.Append(", ");
                }
            }
            data.Append(" ]");

            string json = Plotly.Data.Replace("placeholder_data", data.ToString());

            return json;
        }

        public static string Visualize(this List<long> collection)
        {
            StringBuilder data = new StringBuilder();
            int n = collection.Count();
            data.Append("[ ");
            for (int i = 0; i < n; i++)
            {
                data.Append($"{collection.ElementAt(i)}");
                if (i < n - 1)
                {
                    data.Append(", ");
                }
            }
            data.Append(" ]");

            string json = Plotly.Data.Replace("placeholder_data", data.ToString());

            return json;
        }

        public static string Visualize(this List<ulong> collection)
        {
            StringBuilder data = new StringBuilder();
            int n = collection.Count();
            data.Append("[ ");
            for (int i = 0; i < n; i++)
            {
                data.Append($"{collection.ElementAt(i)}");
                if (i < n - 1)
                {
                    data.Append(", ");
                }
            }
            data.Append(" ]");

            string json = Plotly.Data.Replace("placeholder_data", data.ToString());

            return json;
        }

        public static string Visualize(this List<float> collection)
        {
            StringBuilder data = new StringBuilder();
            int n = collection.Count();
            data.Append("[ ");
            for (int i = 0; i < n; i++)
            {
                data.Append($"{collection.ElementAt(i)}");
                if (i < n - 1)
                {
                    data.Append(", ");
                }
            }
            data.Append(" ]");

            string json = Plotly.Data.Replace("placeholder_data", data.ToString());

            return json;
        }

        public static string Visualize(this List<double> collection)
        {
            StringBuilder data = new StringBuilder();
            int n = collection.Count();
            data.Append("[ ");
            for (int i = 0; i < n; i++)
            {
                data.Append($"{collection.ElementAt(i)}");
                if (i < n - 1)
                {
                    data.Append(", ");
                }
            }
            data.Append(" ]");

            string json = Plotly.Data.Replace("placeholder_data", data.ToString());

            return json;
        }

        public static string Visualize(this List<decimal> collection)
        {
            StringBuilder data = new StringBuilder();
            int n = collection.Count();
            data.Append("[ ");
            for (int i = 0; i < n; i++)
            {
                data.Append($"{collection.ElementAt(i)}");
                if (i < n - 1)
                {
                    data.Append(", ");
                }
            }
            data.Append(" ]");

            string json = Plotly.Data.Replace("placeholder_data", data.ToString());

            return json;
        }
        */
    }
}
