using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Core.Graphics.DebuggerVisualizer.Legacy
{
    public class TextData : ExtractedData
    {
        public override string[] Tags => new string[] { "text" };

        [JsonProperty("text")]
        public string TextValue { get; set; }

        public TextData(string text)
        {
            this.TextValue = text;
        }
    }

}

