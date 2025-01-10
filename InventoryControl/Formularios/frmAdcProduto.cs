using System;
using System.Windows.Forms;
using InventoryControl.Classes;

namespace InventoryControl.Formularios
{
    public partial class frmAdcProduto : Form
    {
        private frmProdutos FrmProdutos;
        public frmAdcProduto(frmProdutos frmProdutos)
        {
            InitializeComponent();
            FrmProdutos = frmProdutos;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Nome = txtNome.Text;
            produto.QtdEstoque = Convert.ToInt32(numTotalEstoque.Value);
            produto.Corredor = txtCorredor.Text;
            produto.Prateleira = txtPrateleira.Text;
            produto.Estante = txtEstante.Text;
            produto.Posicao = txtPosicao.Text;

            string retorno = produto.AdicionarProduto();

            if(retorno == "")
            {
                MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNome.Clear();
                numTotalEstoque.Value = 0;
                txtCorredor.Clear();
                txtPrateleira.Clear();
                txtEstante.Clear();
                txtPosicao.Clear();
                txtNome.Focus();
            }
            else
            {
                MessageBox.Show(retorno, "Negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAdcProduto_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmProdutos.AtualizarDataGrid();
        }
    }
}
