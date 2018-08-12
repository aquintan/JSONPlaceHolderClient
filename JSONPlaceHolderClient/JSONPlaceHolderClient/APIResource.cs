using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace JSONPlaceHolderClient
{
    /// <summary>
    /// <para>Abstract class that defines the base methods for JSON based endpoints calls. Internally this method use an unique <code>HttpClient</code> class for all endpoint calls.</para>
    /// <para>This unique usage of <code>HttpClient</code> is based on this article: "https://aspnetmonsters.com/2016/08/2016-08-27-httpclientwrong/" that suggest this class should not be used
    /// inside <code>using</code> statements and it is safe to use in concurrent environments</para>
    /// </summary>
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
                string content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(content, Settings);
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