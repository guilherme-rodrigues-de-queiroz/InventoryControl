using System;
using System.Data;
using System.Windows.Forms;
using InventoryControl.Classes;

namespace InventoryControl.Formularios
{
    public partial class frmEditProduto : Form
    {
        private frmProdutos FrmProdutos;
        private int IdProduto;
        public frmEditProduto(frmProdutos frmProdutos, int idProduto)
        {
            InitializeComponent();
            FrmProdutos = frmProdutos;
            IdProduto = idProduto;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.IdProduto = IdProduto;
            produto.Nome = txtNome.Text;
            produto.QtdEstoque = Convert.ToInt32(numTotalEstoque.Value);
            produto.Corredor = txtCorredor.Text;
            produto.Prateleira = txtPrateleira.Text;
            produto.Estante = txtEstante.Text;
            produto.Posicao = txtPosicao.Text;

            string retorno = produto.EditarProduto();

            if (retorno == "")
            {
                MessageBox.Show("Produto modificado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNome.Clear();
                numTotalEstoque.Value = 0;
                txtCorredor.Clear();
                txtPrateleira.Clear();
                txtEstante.Clear();
                txtPosicao.Clear();
            }
            else
            {
                MessageBox.Show(retorno, "Negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmEditProduto_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmProdutos.AtualizarDataGrid();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmEditProduto_Load(object sender, EventArgs e)
        {
            txtNome.SelectionStart = txtNome.Text.Length;
            txtNome.SelectionLength = 0;

            Produto produto = new Produto();
            produto.IdProduto = IdProduto;

            DataTable resultado = produto.receberInfoProduto();

            if(resultado.Rows.Count > 0)
            {
                DataRow row = resultado.Rows[0];

                txtNome.Text = row["Nome"].ToString();
                numTotalEstoque.Value = Convert.ToInt32(row["QtdEstoque"]);
                txtCorredor.Text = row["Corredor"].ToString();
                txtPrateleira.Text = row["Prateleira"].ToString();
                txtEstante.Text = row["Estante"].ToString();
                txtPosicao.Text = row["Posicao"].ToString();
            }
            else
            {
                MessageBox.Show("Produto não encontrado!", "Negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmEditProduto_Shown(object sender, EventArgs e)
        {
            txtNome.SelectionStart = txtNome.Text.Length;
            txtNome.SelectionLength = 0;
        }
    }
}
