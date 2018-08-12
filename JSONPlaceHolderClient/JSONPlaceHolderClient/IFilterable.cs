using System.Collections.Generic;

namespace JSONPlaceHolderClient
{
    public interface IFilterable
    {
        IList<string> FilteredFields { get; }
    }
}