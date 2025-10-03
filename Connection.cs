
using System.Data.SqlClient;
namespace QUALITE;
public class Connection
{
    readonly static string server = "localhost";
    readonly static string port = "1433";
    readonly static string database = "piste_aterrissage";
    readonly static string user = "root";
    readonly static string pass = "";
    private static string ConnectionString => $"Server={server},{port};Database={database}; user id={user};password={pass}";
    private static SqlConnection? sqlConnection = null;
    public Connection() => sqlConnection ??= new SqlConnection(ConnectionString);
    public static SqlConnection? GetConnection() => sqlConnection;
}
// SqlConnection sql = new SqlConnection("Server=localhost,1433;Database=DbStore; user id=sa;password=Password123");
// try
// {
//     sql.Open();
//     Console.WriteLine("Connection Opened");
//     SqlCommand cmd = new SqlCommand("select * from Product", sql);
//     SqlDataReader reader = cmd.ExecuteReader();
//     while (reader.Read())
//     {
//         Console.WriteLine($"{reader[0]} - {reader[1]} - {reader[2]:C2}");
//     }
// }
// catch (Exception ex)
// {
//     Console.WriteLine(ex.Message);
// }
// finally
// {
//     sql.Close();
//     Console.WriteLine("Connection Closed");
// }