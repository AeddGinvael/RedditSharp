using System.Collections.Generic;
using Newtonsoft.Json;

namespace RedditSharp.Things
{
    public class ContentSource
    {
        [JsonProperty("source")]
        public Source Source { get; set; }

        [JsonProperty("resolutions")]
        public List<Resolution> Resolutions { get; set; }
    }
}