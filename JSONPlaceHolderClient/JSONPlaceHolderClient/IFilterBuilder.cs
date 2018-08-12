namespace JSONPlaceHolderClient
{
    public interface IFilterBuilder
    {
        IFilterBuilder AddParameter(string parameterName, string parameterValue);

        IFilter Build();
    }
}