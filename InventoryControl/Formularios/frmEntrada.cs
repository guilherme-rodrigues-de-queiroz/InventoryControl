using System;
using System.Data;
using System.Windows.Forms;
using InventoryControl.Classes;

namespace InventoryControl.Formularios
{
    public partial class frmEntrada : Form
    {
        public frmEntrada()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var fAdcEntrada = new frmAdcEntrada(this);
            fAdcEntrada.Show();
        }

        private void frmEntrada_Load(object sender, EventArgs e)
        {
            AtualizarDataGrid();
        }

        public void AtualizarDataGrid()
        {
            Entrada entrada = new Entrada();
            DataTable dt = entrada.PuxarDadosTabela();
            dtgEntradaProd.DataSource = dt;
            dtgEntradaProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgEntradaProd.ClearSelection();
        }

        private void frmEntrada_Shown(object sender, EventArgs e)
        {
            dtgEntradaProd.ClearSelection();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Entrada entrada = new Entrada();
            entrada.TextoPesquisa = txtSearch.Text;

            DataTable dt = entrada.RetornoPesquisa();
            dtgEntradaProd.DataSource = dt;
            dtgEntradaProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgEntradaProd.ClearSelection();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Entrada entrada = new Entrada();

            if (dtgEntradaProd.SelectedRows.Count > 0)
            {
                entrada.IdProduto = Convert.ToInt32(dtgEntradaProd.SelectedRows[0].Cells["IdEntradaProduto"].Value);

                string resultado = entrada.ExcluirProduto();

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
    }
}
