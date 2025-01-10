using System;
using System.Windows.Forms;
using InventoryControl.Classes;

namespace InventoryControl.Formularios
{
    public partial class frmAdcSaida : Form
    {
        private frmSaida FrmSaida;
        public frmAdcSaida(frmSaida frmSaida)
        {
            InitializeComponent();
            FrmSaida = frmSaida;
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

        private void frmAdcSaida_Shown(object sender, EventArgs e)
        {
            txtNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Saida saida = new Saida();
            saida.Nome = txtNome.Text;
            saida.Quantidade = Convert.ToInt32(numQuantidade.Value);

            string resultado = saida.AdicionarSaida();

            if (resultado == "")
            {
                MessageBox.Show("Produto Adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNome.Clear();
                numQuantidade.Value = 0;
            }
            else
            {
                MessageBox.Show(resultado, "Negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAdcSaida_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmSaida.AtualizarDataGrid();
        }
    }
}
