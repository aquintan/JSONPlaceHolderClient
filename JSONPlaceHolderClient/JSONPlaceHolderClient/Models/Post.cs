using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace JSONPlaceHolderClient.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Post : IFilterable
    {
        private static IReadOnlyCollection<string> _filteredFields = new List<string> { "userId", "id" };

        [JsonProperty(PropertyName = "userId")]
        public int UserId { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "body")]
        public string Body { get; set; }

        public IList<string> FilteredFields
        {
            get
            {
                return new List<string>(_filteredFields);
            }
        }

        public override string ToString()
        {            
            return JsonConvert.SerializeObject(this);
        }
    }
}