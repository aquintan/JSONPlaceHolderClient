using Newtonsoft.Json;

namespace JSONPlaceHolderClient.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Geolocation
    {
        [JsonProperty(PropertyName = "lat")]
        public double Street { get; set; }

        [JsonProperty(PropertyName = "lng")]
        public double Suite { get; set; }
    }
}