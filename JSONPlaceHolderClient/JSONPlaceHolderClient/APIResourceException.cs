using System;
using System.Net.Http;

namespace JSONPlaceHolderClient
{
    public class APIResourceException : Exception
    {
        public APIResourceException(HttpResponseMessage response)
            : base(String.Format("Error retrieving data from \"{0}\". Response status code: {1}", response.RequestMessage.RequestUri, response.StatusCode))
        {
        }
    }
}