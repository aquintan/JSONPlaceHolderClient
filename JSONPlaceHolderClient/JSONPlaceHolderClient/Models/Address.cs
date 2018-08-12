using Newtonsoft.Json;

namespace JSONPlaceHolderClient.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Address
    {
        [JsonProperty(PropertyName = "street")]
        public string Street { get; set; }

        [JsonProperty(PropertyName = "suite")]
        public string Suite { get; set; }

        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        [JsonProperty(PropertyName = "zipcode")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "geo")]
        public Geolocation Geolocation { get; set; }
    }
}