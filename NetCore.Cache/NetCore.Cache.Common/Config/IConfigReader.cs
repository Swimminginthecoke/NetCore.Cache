namespace NetCore.Cache.Common.Config
{
    public interface IConfigReader
    {
        int? GetIntNullable(string appKey);
        bool GetBool(string key);
        string GetString(string key);
    }
}
