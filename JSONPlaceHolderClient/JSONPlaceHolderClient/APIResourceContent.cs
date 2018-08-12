using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace JSONPlaceHolderClient
{
    public class APIResourceContent : StringContent
    {
        public static APIResourceContent From(object data)
        {
            return data == null ? null : new APIResourceContent(data);
        }

        public APIResourceContent(object data)
            : base(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json")
        {
        }
    }
}