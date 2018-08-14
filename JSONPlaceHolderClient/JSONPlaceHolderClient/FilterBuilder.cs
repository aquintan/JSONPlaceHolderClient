using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Specialized;

namespace JSONPlaceHolderClient
{
    public class FilterBuilder<T> : IFilterBuilder
        where T : IFilterable
    {
        private NameValueCollection _parameters;

        public FilterBuilder()
        {
            this._parameters = new NameValueCollection();
        }

        public IFilterBuilder AddParameter(string parameterName, string parameterValue)
        {
            var name = typeof(T).GetCustomAttributesData();
            IFilterable f = (T) Activator.CreateInstance(typeof(T));

            if (f.FilteredFields.Contains(parameterName))
            {
                _parameters.Add(parameterName, parameterValue);

                return this;
            } else
            {
                throw new ArgumentException($"{parameterName} is not a valid filter parameter");
            }
        }

        public IFilter Build()
        {
            return new Filter(_parameters);
        }
    }
}