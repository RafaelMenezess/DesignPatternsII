using System;
using System.Data;

namespace DesignPatternsII
{
    public class Program
    {
        static void Main(string[] args)
        {
            IDbConnection conexao = new ConnectionFactory().GetConnection();

            IDbCommand comando = conexao.CreateCommand();
            comando.CommandText = "select * from tabela";


            Console.ReadKey();
        }
    }
}
