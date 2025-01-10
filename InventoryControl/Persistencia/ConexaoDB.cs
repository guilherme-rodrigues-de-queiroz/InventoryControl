using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace InventoryControl.Persistencia
{
    public class ConexaoDB
    {
        private MySqlConnection conexao;
        private MySqlCommand comando;

        private string ObterStringConexao()
        {
            string server = "127.0.0.1"; // ip = localhost
            string database = "InventoryControl"; // Nome da sua database
            string user = "root"; // Seu usuário do MySQL
            string password = "root"; // Sua senha do MySQL

            string stringConexao = $"Server={server}; Database={database}; Uid={user}; Pwd={password};";

            return stringConexao;
        }

        public ConexaoDB()
        {
            try
            {
                conexao = new MySqlConnection(ObterStringConexao());
                conexao.Open();
                comando = conexao.CreateCommand();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Ocorreu um erro ao conectar ao banco de dados.", ex);
            }
        }

        public string ExecutarComando(string pComando, List<MySqlParameter> parametros)
        {
            try
            {
                comando.CommandText = pComando;

                foreach (var parametro in parametros)
                {
                    comando.Parameters.Add(parametro);
                }

                comando.ExecuteNonQuery();

                return "";
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Ocorreu um erro ao executar o comando.", ex);
            }
        }

        public string ExecutarComandoSelect(string pComando, List<MySqlParameter> parametros)
        {
            try
            {
                comando.CommandText = pComando;

                foreach (var parametro in parametros)
                {
                    comando.Parameters.Add(parametro);
                }

                var resultado = comando.ExecuteScalar();

                return resultado?.ToString() ?? "0"; // caso o resultado seja null, retorna 0
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Ocorreu um erro ao executar o comando.", ex);
            }
        }

        public DataTable ComandoSelectTable(string pComando, List<MySqlParameter> parametros)
        {
            try
            {
                comando.CommandText = pComando;

                foreach (var parametro in parametros)
                {
                    comando.Parameters.Add(parametro);
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Ocorreu um erro ao executar o comando.", ex);
            }
        }
    }
}
