using System.Collections.Specialized;

namespace JSONPlaceHolderClient
{
    public interface IFilter
    {
        NameValueCollection Parameters { get; }
        string QueryString { get; }
    }
}