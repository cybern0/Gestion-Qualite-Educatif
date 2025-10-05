using QUALITE.Models.PrincipalEntity;
using QUALITE.Models.DerivedEntity;
using QUALITE.Models.WeakEntity;
using System.Data.SqlClient;
namespace QUALITE.Services;
public class ExamenServices
{
    public static async Task<IEnumerable<Examen>> GetAll()
    {
        List<Examen> examens = new List<Examen>();
        SqlConnection sql = Connection.GetConnection();
        try
        {
            await sql.OpenAsync();
            SqlCommand command = new SqlCommand("SELECT A.CODE_ETAB, A.NOM_ETAB, ("+
            "SUM(B.SERIE_A_ADMIS_G)/"+
            "SUM(B.SERIE_A_INSCRITS_G)) AS indicateur FROM etablissement A JOIN M1 B ON A.CODE_ETAB = B.CODE_ETAB", sql);
            SqlDataReader reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                Examen examen = new Examen
                {
                    CodeEtab= reader.GetInt32(0),
                    NOM_ETAB = reader.GetString(1),
                    GetIndicateur = reader.GetInt32(2)
                };
                examens.Add(examen);
            }
            reader.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            sql.Close();
        }
        return examens;
    }
}