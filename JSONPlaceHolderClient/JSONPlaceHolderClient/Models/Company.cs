using Newtonsoft.Json;

namespace JSONPlaceHolderClient.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Company
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "catchPhrase")]
        public string CatchPhrase { get; set; }

        [JsonProperty(PropertyName = "bs")]
        public string Bs { get; set; }
    }
}