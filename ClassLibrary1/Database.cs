using MySql.Data.MySqlClient;

namespace ClassLibrary1;

public class Database : IDisposable
{
    private string connectionString = new MySqlConnectionStringBuilder
    {
        UserID = "root",
        Password = "root",
        Port = 3306,
        Server = "localhost",
        Database = " "
    }.ToString();
    private MySqlConnection connection;

    public Database()
    {
        connection = new(connectionString);
        connection.Open();
    }

    public void Dispose()
    {
        connection.Close();
        GC.SuppressFinalize(this);
    }
}
