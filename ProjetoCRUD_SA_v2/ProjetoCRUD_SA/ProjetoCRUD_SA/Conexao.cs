using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace ProjetoCRUD_SA
{
    internal class Conexao
    {
        MySqlConnection conn;

        private void Conectar()
        {
            string dadosConexao = "Persist security info = false; server = localhost; database = DB_SAComidaChinesa; uid = root; pwd = ; CharSet = utf8mb4;";

            try
            {
                conn = new MySqlConnection(dadosConexao);
                conn.Open();
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Conexão não foi estabelecida.\n{dadosConexao}\n{ex.Message}");
            }
        }

        // Método de execução de instruções: INSERT, UPDATE e DELETE
        // Os valores entram por parâmetros (@nome, @preco...), assim aceita aspas no texto
        // e o preço não quebra por causa da vírgula decimal do Brasil.
        public void ExecutarComando(string sql, params MySqlParameter[] parametros)
        {
            Conectar();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conn);
                comando.Parameters.AddRange(parametros);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Erro ao tentar executar a instrução:\n{sql}\n{ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        //Método capaz de executar QUALQUER instrução SELECT:
        public DataTable ExecutarConsulta(string query)
        {
            Conectar();

            try
            {
                DataTable dt = new DataTable();
                MySqlDataAdapter dados = new MySqlDataAdapter(query, conn);
                dados.Fill(dt);
                return dt;
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Instrução SELECT com erro.\n{query}\n{ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
