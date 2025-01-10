using System;
using System.Data;
using System.Windows.Forms;
using InventoryControl.Classes;

namespace InventoryControl.Formularios
{
    public partial class frmSaida : Form
    {
        public frmSaida()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fAdcSaida = new frmAdcSaida(this);
            fAdcSaida.Show();
        }

        private void frmSaida_Load(object sender, EventArgs e)
        {
            AtualizarDataGrid();
        }

        public void AtualizarDataGrid()
        {
            Saida saida = new Saida();
            DataTable dt = saida.PuxarDadosTabela();
            dtgSaidaProd.DataSource = dt;
            dtgSaidaProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgSaidaProd.ClearSelection();
        }

        private void frmSaida_Shown(object sender, EventArgs e)
        {
            dtgSaidaProd.ClearSelection();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Saida saida = new Saida();
            saida.TextoPesquisa = txtSearch.Text;

            DataTable dt = saida.RetornoPesquisa();
            dtgSaidaProd.DataSource = dt;
            dtgSaidaProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgSaidaProd.ClearSelection();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Saida saida = new Saida();

            if(dtgSaidaProd.SelectedRows.Count > 0)
            {
                saida.IdProduto = Convert.ToInt32(dtgSaidaProd.SelectedRows[0].Cells["IdSaidaProduto"].Value);

                string resultado = saida.ExcluirProduto();

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
