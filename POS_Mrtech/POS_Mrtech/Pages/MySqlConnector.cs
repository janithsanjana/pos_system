using MySql.Data.MySqlClient;

public static class MySqlConnector
{
    private static string connectionString = "Server=localhost;Port=3307;Database=mrtechpos_db;Uid=root;Pwd=1234";

    public static MySqlConnection CreateConnection()
    {
        return new MySqlConnection(connectionString);
    }
}
