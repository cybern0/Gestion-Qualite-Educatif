
using System.Data.SqlClient;
namespace QUALITE;
public class Connection
{
    readonly static string server = "DESKTOP-431DIOU\\SQLEXPRESS";
    // readonly static string port = "1433";
    readonly static string database = "DHM";
    // readonly static string user = "gigolo";
    // readonly static string pass = "q4l1t3";
    // string connectionString = "Server=localhost\\SQLEXPRESS;Database=YourDatabaseName;User Id=sa;Password=yourpassword;";
    private static string ConnectionString => $"Server={server};Database={database};Trusted_Connection=True;";
    public static SqlConnection GetConnection()
    {
        return new SqlConnection(ConnectionString);
    }
}