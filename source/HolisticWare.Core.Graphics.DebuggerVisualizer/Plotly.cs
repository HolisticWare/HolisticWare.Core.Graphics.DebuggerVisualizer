using System;
namespace Core.Graphics.DebuggerVisualizer
{
    public class Plotly
    {
        public Plotly()
        {
        }

        public static string Data
        {
            get
            {
                return $@"
                    {{
                       ""kind"" : {{ ""plotly"": true }},
                       ""data"" : 
                        [
                            placeholder_data_array
                        ]
                    }}
                    ";
            }
        }
    }
}
