using System;
using System.Data;
using System.Windows.Forms;
using InventoryControl.Classes;

namespace InventoryControl.Formularios
{
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmAdc = new frmAdcProduto(this);
            frmAdc.Show();
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            AtualizarDataGrid();
        }

        public void AtualizarDataGrid()
        {
            Produto produto = new Produto();
            DataTable dt = produto.PuxarDadosTabela();
            dtgProd.DataSource = dt;
            dtgProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgProd.ClearSelection();
        }

        private void frmProdutos_Shown(object sender, EventArgs e)
        {
            dtgProd.ClearSelection();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.TextoPesquisa = txtSearch.Text;

            DataTable dt = produto.RetornoPesquisa();
            dtgProd.DataSource = dt;
            dtgProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgProd.ClearSelection();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            if (dtgProd.SelectedRows.Count > 0)
            {
                produto.IdProduto = Convert.ToInt32(dtgProd.SelectedRows[0].Cells["IdProduto"].Value);

                string resultado = produto.ExcluirProduto();

                if (resultado == "")
                {
                    MessageBox.Show("O Produto foi excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarDataGrid();
                }
                else
                {
                    MessageBox.Show(resultado);
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto da tabela para excluir!", "Negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            if(dtgProd.SelectedRows.Count > 0)
            {
                int idProduto = Convert.ToInt32(dtgProd.SelectedRows[0].Cells["IdProduto"].Value);

                var frmEdit = new frmEditProduto(this, idProduto);
                frmEdit.Show();
            }
            else
            {
                MessageBox.Show("Selecione um produto da tabela para alterar!", "Negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
