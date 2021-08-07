using Newtonsoft.Json;

namespace RedditSharp.Things
{
    public class RedditVideoPreview
    {
        [JsonProperty("bitrate_kbps")]
        public int BitrateKbps { get; private set; }
        
        [JsonProperty("fallback_url")]
        public string FallbackUrl { get; private set; }
        
        [JsonProperty("height")]
        public int Height { get; private set; }
        
        [JsonProperty("width")]
        public int Width { get; private set; }
        
        [JsonProperty("scrubber_media_url")]
        public string ScrubberMediaUrl { get; private set; }

        [JsonProperty("dash_url")]
        public string DashUrl { get; private set; }

        [JsonProperty("duration")]
        public int Duration { get; private set; }

        [JsonProperty("hls_url")]
        public string HlsUrl { get; private set; }

        [JsonProperty("is_gif")]
        public bool IsGif { get; private set; }

        [JsonProperty("transcoding_status")]
        public string TranscodingStatus { get; private set; }
    }
}