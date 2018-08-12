using Newtonsoft.Json;

namespace JSONPlaceHolderClient.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Post
    {
        [JsonProperty(PropertyName = "userId")]
        public int UserId { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "body")]
        public string Body { get; set; }

        public override string ToString()
        {            
            return JsonConvert.SerializeObject(this);
        }
    }
}