using System.Data;
using System.Data.SqlClient;

namespace DesignPatternsII
{
    public class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            IDbConnection conexao = new SqlConnection();
            conexao.ConnectionString = "User Id=root;Password=;Server=Localhost;Database=meuBanco";//new LeitorConfiguracao().LerConnectionString;
            conexao.Open();

            return conexao;
        }
    }
}
