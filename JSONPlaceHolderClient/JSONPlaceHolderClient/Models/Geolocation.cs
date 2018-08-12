using Newtonsoft.Json;

namespace JSONPlaceHolderClient.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Geolocation
    {
        [JsonProperty(PropertyName = "lat")]
        public double Latitude { get; set; }

        [JsonProperty(PropertyName = "lng")]
        public double Longitude { get; set; }
    }
}