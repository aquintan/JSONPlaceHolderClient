using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

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
