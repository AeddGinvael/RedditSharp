using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace RedditSharp.Things.Gallery
{
    public class MediaMetadata
    {
        [JsonProperty("status")]
        public string Status { get; private set; }
        
        [JsonProperty("e")]
        public string Type { get; private set; }
        
        [JsonProperty("m")]
        public string MimeType { get; private set; }
        
        [JsonProperty("o")]
        public GalleryContent BlurContent { get; private set; }
        
        [JsonProperty("s")]
        public GalleryContent OriginalContent { get; private set; }
        
        [JsonProperty("p")]
        public IEnumerable<GalleryContent> ContentResolutions { get; private set; }
    }


    public class GalleryContent
    {
        [JsonProperty("x")]
        public int Width { get; private set; }
        
        [JsonProperty("y")]
        public int Height { get; private set; }
        
        [JsonProperty("u")]
        public string Url { get; private set; }
    }
    
}