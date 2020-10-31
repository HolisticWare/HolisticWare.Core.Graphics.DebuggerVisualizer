using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Core.Graphics.DebuggerVisualizer
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public abstract class ExtractedData
    {
        [JsonProperty("kind")]
        public Dictionary<string, bool> Kind
        {
            get
            {
                var d = new Dictionary<string, bool>();
                foreach (var tag in Tags)
                {
                    d.Add(tag, true);
                }
                return d;
            }
        }

        [JsonIgnore]
        public abstract string[] Tags { get; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
 }

