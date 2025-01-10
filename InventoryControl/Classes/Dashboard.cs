using System.Collections.Generic;
using InventoryControl.Persistencia;
using MySql.Data.MySqlClient;

namespace InventoryControl.Classes
{
    public class Dashboard
    {
        public string TotalEntradaProduto()
        {
            string cmdSelect = "SELECT COUNT(*) FROM EntradaProduto;";

            ConexaoDB conexao = new ConexaoDB();

            string resultado = conexao.ExecutarComandoSelect(cmdSelect, new List<MySqlParameter>());

            return resultado;
        }

        public string TotalSaidaProduto()
        {
            string cmdSelect = "SELECT COUNT(*) FROM SaidaProduto;";

            ConexaoDB conexao = new ConexaoDB();

            string resultado = conexao.ExecutarComandoSelect(cmdSelect, new List<MySqlParameter>());

            return resultado;
        }

        public string TotalProdutosCadastrados()
        {
            string cmdSelect = "SELECT COUNT(*) FROM Produto;";

            ConexaoDB conexao = new ConexaoDB();

            string resultado = conexao.ExecutarComandoSelect(cmdSelect, new List<MySqlParameter>());

            return resultado;
        }
    }
}
