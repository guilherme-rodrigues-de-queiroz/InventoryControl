using System;
using System.Collections.Generic;
using System.Data;
using InventoryControl.Persistencia;
using MySql.Data.MySqlClient;

namespace InventoryControl.Classes
{
    public class Produto
    {
        private int idProduto;
        private string nome;
        private int qtdEstoque;
        private string corredor;
        private string prateleira;
        private string estante;
        private string posicao;
        private DateTime dataAlteracao;
        private string textoPesquisa;

        public int IdProduto
        {
            get { return idProduto; }
            set { idProduto = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int QtdEstoque
        {
            get { return qtdEstoque; }
            set { qtdEstoque = value; }
        }

        public string Corredor
        {
            get { return corredor; }
            set { corredor = value; }
        }

        public string Prateleira
        {
            get { return prateleira; }
            set { prateleira = value; }
        }

        public string Estante
        {
            get { return estante; }
            set { estante = value; }
        }

        public string Posicao
        {
            get { return posicao; }
            set { posicao = value; }
        }

        public DateTime DataAlteracao
        {
            get { return dataAlteracao; }
            set { dataAlteracao = value; }
        }

        public string TextoPesquisa
        {
            get { return textoPesquisa; }
            set { textoPesquisa = value; }
        }

        private string VerificarCamposAdcProduto()
        {
            if(string.IsNullOrEmpty(nome) || qtdEstoque <= 0)
            {
                return "Preencha todos os campos obrigatórios";
            }

            return "";
        }

        public string AdicionarProduto()
        {
            string resultado = VerificarCamposAdcProduto();

            if(resultado != "")
            {
                return resultado;
            }

            try
            {
                string cmdInsert = "INSERT INTO Produto (Nome, QtdEstoque, Corredor, Prateleira, Estante, Posicao, DataAlteracao) " +
                    "VALUES (@Nome, @QtdEstoque, @Corredor, @Prateleira, @Estante, @Posicao, @DataAlteracao)";

                var parametros = new List<MySqlParameter>
                {
                    new MySqlParameter("@Nome", Nome),
                    new MySqlParameter("@QtdEstoque", QtdEstoque),
                    new MySqlParameter("@Corredor", Corredor),
                    new MySqlParameter("@Prateleira", Prateleira),
                    new MySqlParameter("@Estante", Estante),
                    new MySqlParameter("@Posicao", Posicao),
                    new MySqlParameter("@DataAlteracao", DateTime.Now)
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
            string cmdSelect = "SELECT IdProduto, Nome, QtdEstoque, Corredor, Prateleira, Estante, Posicao, DataAlteracao FROM Produto;";

            ConexaoDB conexao = new ConexaoDB();

            DataTable dataTable = conexao.ComandoSelectTable(cmdSelect, new List<MySqlParameter>());

            return dataTable;
        }

        public DataTable RetornoPesquisa()
        {
            if (!string.IsNullOrEmpty(TextoPesquisa)){
                try
                {
                    string cmdSelect = "SELECT IdProduto, Nome, QtdEstoque, Corredor, Prateleira, Estante, Posicao, DataAlteracao FROM Produto WHERE Nome LIKE @Search;";

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
                string cmdDelete = "DELETE FROM Produto WHERE IdProduto = @IdProduto;";

                var parametros = new List<MySqlParameter>
                {
                    new MySqlParameter("@IdProduto", IdProduto)
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

        public DataTable receberInfoProduto()
        {
            try
            {
                string cmdSelect = "SELECT Nome, QtdEstoque, Corredor, Prateleira, Estante, Posicao " +
                "FROM Produto WHERE IdProduto = @IdProduto;";

                var parametros = new List<MySqlParameter>
                {
                    new MySqlParameter("@IdProduto", IdProduto),
                };

                ConexaoDB conexao = new ConexaoDB();

                DataTable dataTable = conexao.ComandoSelectTable(cmdSelect, parametros);

                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string EditarProduto()
        {
            string resultado = VerificarCamposAdcProduto();

            if (resultado != "")
            {
                return resultado;
            }

            try
            {
                string cmdUpdate = "UPDATE Produto " +
                    "SET Nome = @Nome, QtdEstoque = @QtdEstoque, Corredor = @Corredor, Prateleira = @Prateleira, Estante = @Estante, Posicao = @Posicao, DataAlteracao = @DataAlteracao " +
                    "WHERE IdProduto = @IdProduto";

                var parametros = new List<MySqlParameter>
                {
                    new MySqlParameter("@IdProduto", IdProduto),
                    new MySqlParameter("@Nome", Nome),
                    new MySqlParameter("@QtdEstoque", QtdEstoque),
                    new MySqlParameter("@Corredor", Corredor),
                    new MySqlParameter("@Prateleira", Prateleira),
                    new MySqlParameter("@Estante", Estante),
                    new MySqlParameter("@Posicao", Posicao),
                    new MySqlParameter("@DataAlteracao", DateTime.Now)
                };

                ConexaoDB conexao = new ConexaoDB();

                conexao.ExecutarComando(cmdUpdate, parametros);

                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
