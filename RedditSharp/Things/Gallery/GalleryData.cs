using Newtonsoft.Json;

namespace RedditSharp.Things.Gallery
{
    public class GalleryData
    {
        [JsonProperty("items")]
        public GalleryItem[] Items { get; private set; }
    }

    public class GalleryItem
    {
        [JsonProperty("media_id")]
        public string MediaId { get; private set; }
        
        [JsonProperty("id")]
        public long Id { get; private set; }
        
    }
}