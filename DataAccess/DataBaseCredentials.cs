namespace DataAccess;

public class DataBaseCredentials
{
    public DataBaseCredentials(string connectionString, string userName, string userPassword) => 
        ConnectionString = connectionString
            .Replace(UserNameKey, userName)
            .Replace(UserPasswordKey, userPassword);

    private const string UserNameKey = "{UserName}";
    private const string UserPasswordKey = "{UserPassword}";

    public string ConnectionString { get; }
}