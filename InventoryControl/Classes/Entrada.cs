using System;
using System.Collections.Generic;
using System.Data;
using InventoryControl.Persistencia;
using MySql.Data.MySqlClient;

namespace InventoryControl.Classes
{
    public class Entrada
    {
        private string nome;
        private int quantidade;
        private DateTime dataAlteracao;
        private int idProduto;
        private string textoPesquisa;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public DateTime DataAlteracao
        {
            get { return dataAlteracao; }
            set { dataAlteracao = value; }
        }

        public int IdProduto
        {
            get { return idProduto; }
            set { idProduto = value; }
        }

        public string TextoPesquisa
        {
            get { return textoPesquisa; }
            set { textoPesquisa = value; }
        }

        private string RetornarValor()
        {
            string cmdSelect = "SELECT IdProduto FROM Produto WHERE Nome = @Nome;";

            var parametros = new List<MySqlParameter>
            {
                new MySqlParameter("@Nome", Nome)
            };

            ConexaoDB conexao = new ConexaoDB();

            string resultado = conexao.ExecutarComandoSelect(cmdSelect, parametros);

            if(Convert.ToInt32(resultado) <= 0)
            {
                return "O produto não foi encontrado";
            }

            return resultado;
        }

        private string VerificarCamposAdcEntrada()
        {
            string cmdSelect = "SELECT Nome FROM Produto WHERE Nome = @Nome;";

            var parametros = new List<MySqlParameter>
            {
                new MySqlParameter("@Nome", Nome)
            };

            ConexaoDB conexao = new ConexaoDB();

            string resultado = conexao.ExecutarComandoSelect(cmdSelect, parametros);

            if (string.IsNullOrEmpty(Nome) || Quantidade <= 0)
            {
                return "Preencha todos os campos obrigatórios";
            }

            if (resultado != Nome)
            {
                return "O nome do produto não foi encontrado ou não existe!";
            }

            return "";
        }


        public string AdicionarEntrada()
        {
            string resultado = VerificarCamposAdcEntrada();

            if (resultado != "")
            {
                return resultado;
            }

            try
            {
                int pegarIdProduto = Convert.ToInt32(RetornarValor());

                if (pegarIdProduto > 0)
                {
                    IdProduto = pegarIdProduto;
                }

                string cmdInsert = "INSERT INTO EntradaProduto (Nome, Quantidade, DataAlteracao, IdProduto) " +
                    "VALUES (@Nome, @Quantidade, @DataAlteracao, @IdProduto)";

                var parametros = new List<MySqlParameter>
                {
                    new MySqlParameter("@Nome", Nome),
                    new MySqlParameter("@Quantidade", Quantidade),
                    new MySqlParameter("@DataAlteracao", DateTime.Now),
                    new MySqlParameter("@IdProduto", IdProduto)
                };

                ConexaoDB conexao = new ConexaoDB();

                conexao.ExecutarComando(cmdInsert, parametros);

                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public DataTable PuxarDadosTabela()
        {
            string cmdSelect = "SELECT IdEntradaProduto, Nome, Quantidade, DataAlteracao FROM EntradaProduto;";

            ConexaoDB conexao = new ConexaoDB();

            DataTable dataTable = conexao.ComandoSelectTable(cmdSelect, new List<MySqlParameter>());

            return dataTable;
        }

        public DataTable RetornoPesquisa()
        {
            if (!string.IsNullOrEmpty(TextoPesquisa))
            {
                try
                {
                    string cmdSelect = "SELECT IdEntradaProduto, Nome, Quantidade, DataAlteracao FROM EntradaProduto WHERE Nome LIKE @Search;";

                    var parametros = new List<MySqlParameter>
                    {
                        new MySqlParameter("@Search", $"%{TextoPesquisa}%")
                    };

                    ConexaoDB conexao = new ConexaoDB();

                    DataTable dataTable = conexao.ComandoSelectTable(cmdSelect, parametros);

                    return dataTable;
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao executar a pesquisa no banco de dados.", ex);
                }
            }
            else
            {
                return PuxarDadosTabela();
            }
        }

        public string ExcluirProduto()
        {
            try
            {
                string cmdDelete = "DELETE FROM EntradaProduto WHERE IdEntradaProduto = @IdEntradaProduto;";

                var parametros = new List<MySqlParameter>
                {
                    new MySqlParameter("@IdEntradaProduto", IdProduto)
                };

                ConexaoDB conexao = new ConexaoDB();

                conexao.ExecutarComando(cmdDelete, parametros);

                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
