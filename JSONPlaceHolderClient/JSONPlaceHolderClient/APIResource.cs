using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace JSONPlaceHolderClient
{
    public abstract class APIResource
    {
        #region Static

        private static readonly string baseEndpointUrl = "https://jsonplaceholder.typicode.com";

        private static readonly JsonSerializerSettings Settings = new JsonSerializerSettings()
        {
            Converters = new[] { new StringEnumConverter() }
        };

        #endregion Static

        #region Properties

        protected HttpClient Client { get; }

        #endregion Properties

        #region Constructor

        protected APIResource(HttpMessageHandler handler = null)
        {
            Client = handler == null ? new HttpClient() : new HttpClient(handler);
            Client.BaseAddress = new Uri(baseEndpointUrl);
            Client.DefaultRequestHeaders
                .Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        #endregion Constructor

        #region Private Methods

        private async Task<T> ParseJson<T>(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync(), Settings);
            }

            throw new APIResourceException(response);
        }

        #endregion Private Methods

        #region Protected Methods

        protected async Task<T> GetDataAsync<T>(string uri)
        {
            return await ParseJson<T>(await Client.GetAsync(uri));
        }

        protected async Task<T> PostDataAsync<T>(string uri, object data = null)
        {
            return await ParseJson<T>(await Client.PostAsync(uri, APIResourceContent.From(data)));
        }

        protected async Task<T> PutDataAsync<T>(string uri, object data = null)
        {
            return await ParseJson<T>(await Client.PutAsync(uri, APIResourceContent.From(data)));
        }

        protected async Task<T> DeleteDataAsync<T>(string uri, object data = null)
        {
            return await ParseJson<T>(await Client.DeleteAsync(uri));
        }

        #endregion Protected Methods
    }
}