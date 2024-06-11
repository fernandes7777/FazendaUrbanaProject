using FazendaUrbana.Forms;

namespace FazendaUrbana
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormClosed += FrmMenu_FormClosed;
        }

        private void FrmMenu_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmSupplierUC = new FrmSupplierUC();
            frmSupplierUC.Dock = DockStyle.Fill;
            var tabPage = new TabPage();
            tabPage.Name = "Controle de Fornecedores";
            tabPage.Text = "Controle de Fornecedores";
            tabPage.ImageIndex = 3;
            tabPage.Controls.Add(frmSupplierUC);
            tabPages.TabPages.Add(tabPage);
        }

        private void inputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmInputUC = new FrmInputUC();
            frmInputUC.Dock = DockStyle.Fill;
            var tabPage = new TabPage();
            tabPage.Name = "Controle de Insumos";
            tabPage.Text = "Controle de Insumos";
            tabPage.ImageIndex = 3;
            tabPage.Controls.Add(frmInputUC);
            tabPages.TabPages.Add(tabPage);
        }

        private void productionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmProductionUC = new FrmProductionUC();
            frmProductionUC.Dock = DockStyle.Fill;
            var tabPage = new TabPage();
            tabPage.Name = "Controle de Produção";
            tabPage.Text = "Controle de Produção";
            tabPage.ImageIndex = 3;
            tabPage.Controls.Add(frmProductionUC);
            tabPages.TabPages.Add(tabPage);
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmProductUC = new FrmProductUC();
            frmProductUC.Dock = DockStyle.Fill;
            var tabPage = new TabPage();
            tabPage.Name = "Cadastro de Produtos";
            tabPage.Text = "Cadastro de Produtos";
            tabPage.ImageIndex = 3;
            tabPage.Controls.Add(frmProductUC);
            tabPages.TabPages.Add(tabPage);
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmSaleUC = new FrmSalesUC();
            frmSaleUC.Dock = DockStyle.Fill;
            var tabPage = new TabPage();
            tabPage.Name = "Controle de Vendas";
            tabPage.Text = "Controle de Vendas";
            tabPage.ImageIndex = 3;
            tabPage.Controls.Add(frmSaleUC);
            tabPages.TabPages.Add(tabPage);
        }

        private void productionProductRelationshipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmProductionProductUC = new FrmProductionProductRelationship();
            frmProductionProductUC.Dock = DockStyle.Fill;
            var tabPage = new TabPage();
            tabPage.Name = "Relacionamento de Produção e Produto";
            tabPage.Text = "Relacionamento de Produção e Produto";
            tabPage.ImageIndex = 3;
            tabPage.Controls.Add(frmProductionProductUC);
            tabPages.TabPages.Add(tabPage);
        }

        private void supplierInputRelationshipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmSupplierInputUC = new FrmSupplierInpuRelationshipUC();
            frmSupplierInputUC.Dock = DockStyle.Fill;
            var tabPage = new TabPage();
            tabPage.Name = "Relacionamento de Fornecedor e Insumo";
            tabPage.Text = "Relacionamento de Fornecedor e Insumo";
            tabPage.ImageIndex = 3;
            tabPage.Controls.Add(frmSupplierInputUC);
            tabPages.TabPages.Add(tabPage);
        }

        // TODO: Descomentar se for continuar a evoluir o projeto no menu
        //private void productionInputRelationshipToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    var frmProductionInputUC = new FrmProductionInputRelationship();
        //    frmProductionInputUC.Dock = DockStyle.Fill;
        //    var tabPage = new TabPage();
        //    tabPage.Name = "Relacionamento de Produção e Insumo";
        //    tabPage.Text = "Relacionamento de Produção e Insumo";
        //    tabPage.ImageIndex = 3;
        //    tabPage.Controls.Add(frmProductionInputUC);
        //    tabPages.TabPages.Add(tabPage);
        //}
    }
}
