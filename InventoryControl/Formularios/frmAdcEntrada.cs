using System;
using System.Windows.Forms;
using InventoryControl.Classes;

namespace InventoryControl.Formularios
{
    public partial class frmAdcEntrada : Form
    {
        private frmEntrada FrmEntrada;
        public frmAdcEntrada(frmEntrada frmEntrada)
        {
            InitializeComponent();
            FrmEntrada = frmEntrada;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAdcEntrada_Shown(object sender, EventArgs e)
        {
            txtNome.Focus();
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
            Entrada entrada = new Entrada();
            entrada.Nome = txtNome.Text;
            entrada.Quantidade = Convert.ToInt32(numQuantidade.Value);

            string resultado = entrada.AdicionarEntrada();

            if(resultado == "")
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

        private void frmAdcEntrada_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmEntrada.AtualizarDataGrid();
        }
    }
}
