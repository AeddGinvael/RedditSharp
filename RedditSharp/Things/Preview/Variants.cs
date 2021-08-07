using Newtonsoft.Json;

namespace RedditSharp.Things
{
    public class Variants
    {
        [JsonProperty("obfuscated")]
        public ContentSource Obfuscated { get; set; }
        
        [JsonProperty("gif")]
        public ContentSource Gif { get; set; }

        [JsonProperty("mp4")]
        public ContentSource Mp4 { get; set; }

        [JsonProperty("nsfw")]
        public ContentSource Nsfw { get; set; }
    }
}