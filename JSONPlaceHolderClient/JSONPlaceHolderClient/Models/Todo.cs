using Newtonsoft.Json;

namespace JSONPlaceHolderClient.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Toto
    {
        [JsonProperty(PropertyName = "userId")]
        public int AlbumId { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "completed")]
        public bool Url { get; set; }
    }
}