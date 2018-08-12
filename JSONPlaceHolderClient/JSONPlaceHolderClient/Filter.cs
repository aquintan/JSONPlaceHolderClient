using System;
using System.Collections.Specialized;
using System.Linq;

namespace JSONPlaceHolderClient
{
    public class Filter : IFilter
    {
        public NameValueCollection Parameters { get; private set; }

        public Filter(NameValueCollection parameters)
        {
            Parameters = parameters;
        }

        public string QueryString
        {
            get
            {
                var collection = BuildCollection();
                return "?" + String.Join("&", collection.AllKeys.Select(a => a + "=" + collection[a]).ToArray());
            }
        }

        private NameValueCollection BuildCollection()
        {
            var collection = new NameValueCollection();

            if (Parameters != null)
            {
                collection.Add(Parameters);
            }

            return collection;
        }
    }
}