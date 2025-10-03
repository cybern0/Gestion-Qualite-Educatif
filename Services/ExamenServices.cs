namespace QUALITE.Services;

using QUALITE.Models.RegularEntity;
using System.Data.SqlClient;
public class ExamenServices
{
    public static List<Sexe> GetSexes()
    {
        List<Sexe> sexes = new List<Sexe>();
        try
        {
            using (SqlConnection sql = Connection.GetConnection())
            {
                sql.Open();
                SqlCommand cmd = new SqlCommand("select * from sexe", sql);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Sexe sexe = new Sexe
                    {
                        CodeTypeSexe = (int)reader["CODE_TYPE_SEXE"],
                        TypeSexe = (string?)reader["TYPE_SEXE"],
                    };
                    sexes.Add(sexe);
                }
                sql.Close();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        return sexes;
    }
}