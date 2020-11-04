using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Core.Graphics.DebuggerVisualizer
{
    public class Plotly
    {
        public Plotly()
        {
        }


        public string Data<T>(List<List<T>> list, bool from_jobject = true)
        {
            string json = null;

            if (from_jobject == false)
            {
                json = $@"
                    {{
                       ""kind"" : {{ ""plotly"": true }},
                       ""data"" : 
                        [
                            placeholder_data_array
                        ]
                    }}
                    ";

                int m = list.Count;

                for (int j = 0; j < m; j++)
                {
                    StringBuilder data = new StringBuilder();
                    data.Append($@"{{ ");
                    data.Append($@"""y"" : ");
                    data.Append($@"[ ");

                    List<T> l = list[j];
                    int n = l.Count;

                    for (int i = 0; i < n; i++)
                    {
                        data.Append($@"{l[i]}");
                        if (i < n - 1)
                        {
                            data.Append(", ");
                        }
                        else
                        {
                            data.Append(" ");
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
            }
            else
            {
                // https://www.newtonsoft.com/json/help/html/CreatingLINQtoJSON.htm

                JArray jarray = new JArray();

                foreach(List<T> l in list)
                {
                    JArray jarray_inner = JArray.FromObject(l);
                    JObject jo_inner = new JObject();
                    jo_inner.Add("y", jarray_inner);
                    jarray.Add(jo_inner);
                }

                JObject jo = null;
                jo = JObject.FromObject
                    (
                        new
                        {
                            kind = new JObject
                                        (
                                            new JProperty("plotly", true)
                                        ),
                            data = jarray
                        }
                    );
                json = jo.ToString();
            }

            return json;
        }

        public string Data()
        {
            string json = null;

            json = $@"
                {{
                    ""kind"" : {{ ""plotly"": true }},
                    ""data"" : 
                    [
                        placeholder_data_array
                    ]
                }}
                ";

            return json;
        }
    }
}
