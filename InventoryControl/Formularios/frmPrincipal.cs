using System;
using System.Drawing;
using System.Windows.Forms;
using InventoryControl.Classes;

namespace InventoryControl.Formularios
{
    public partial class frmPrincipal : Form
    {
        private Form frmAtivo;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panelForm.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void ActiveFormClose()
        {
            if (frmAtivo != null)
            {
                frmAtivo.Close();
            }
        }

        private class CoresPainel
        {
            public static readonly Color CorPanelAtivo = System.Drawing.ColorTranslator.FromHtml("#685cfe");
            public static readonly Color CorPanel = System.Drawing.Color.FromArgb(248, 249, 250);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActiveFormClose();
            panelDashboard.BackColor = CoresPainel.CorPanelAtivo;
            panelProdutos.BackColor = CoresPainel.CorPanel;
            panelEntrada.BackColor = CoresPainel.CorPanel;
            panelSaida.BackColor = CoresPainel.CorPanel;

            Dashboard dashboard = new Dashboard();
            totalEntradaProdutos.Text = dashboard.TotalEntradaProduto();
            totalSaidaProdutos.Text = dashboard.TotalSaidaProduto();
            totalProdutoCadastrados.Text = dashboard.TotalProdutosCadastrados();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FormShow(new frmProdutos());
            panelProdutos.BackColor = CoresPainel.CorPanelAtivo;
            panelDashboard.BackColor = CoresPainel.CorPanel;
            panelEntrada.BackColor = CoresPainel.CorPanel;
            panelSaida.BackColor = CoresPainel.CorPanel;
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            FormShow(new frmEntrada());
            panelEntrada.BackColor = CoresPainel.CorPanelAtivo;
            panelDashboard.BackColor = CoresPainel.CorPanel;
            panelProdutos.BackColor = CoresPainel.CorPanel;
            panelSaida.BackColor = CoresPainel.CorPanel;
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            FormShow(new frmSaida());
            panelSaida.BackColor = CoresPainel.CorPanelAtivo;
            panelDashboard.BackColor = CoresPainel.CorPanel;
            panelProdutos.BackColor = CoresPainel.CorPanel;
            panelEntrada.BackColor = CoresPainel.CorPanel;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            totalEntradaProdutos.Text = dashboard.TotalEntradaProduto();
            totalSaidaProdutos.Text = dashboard.TotalSaidaProduto();
            totalProdutoCadastrados.Text = dashboard.TotalProdutosCadastrados();
        }
    }
}
