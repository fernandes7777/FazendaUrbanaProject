using FazendaUrbana.Forms.Model;
using FazendaUrbana.Forms.Service;
using FazendaUrbana.Forms.Service.CsvExporter;

namespace FazendaUrbana
{
    public partial class FrmSalesUC : UserControl
    {
        ProductService ProductService = new ProductService();
        SaleService SaleService = new SaleService();

        public FrmSalesUC()
        {
            InitializeComponent();
            saleBindingSource.DataSource = new Sale();
            saleBindingSourceGridView.DataSource = SaleService.GetAll();

            productCbx.DataSource = ProductService.GetAll();
            productCbx.DisplayMember = "Name";
            productCbx.ValueMember = "Id";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var sale = saleBindingSource.Current as Sale ?? new Sale();

            ValidateFields(sale);

            if (errorProvider1.HasErrors)
            {
                MessageBox.Show("Existem campos obrigatórios não preenchidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(saleIdTxt.Text))
            {
                sale.Id = Convert.ToInt32(saleIdTxt.Text);
            }

            var success = SaleService.Save(sale);
            if (!success)
            {
                MessageBox.Show("Falha ao salvar as alterações!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ClearFields();

            saleBindingSourceGridView.DataSource = SaleService.GetAll();

            MessageBox.Show("Alterações salvas com sucesso!");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (!SaleService.GetAll().Any())
            {
                MessageBox.Show("Não existem dados para serem editados, por favor cadastre uma venda!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rowIndex = saleDataGridView.CurrentCell.RowIndex;
            if (rowIndex < 0)
            {
                MessageBox.Show("Para continuar a edição, é necessário selecionar um dos itens da grid", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = saleDataGridView.Rows[rowIndex];
            saleIdTxt.Text = row.Cells[0].Value.ToString(); // ID
            quantityTxt.Text = row.Cells[1].Value.ToString(); // Quantity
            saleDateTxt.Text = row.Cells[2].Value.ToString(); // SaleDate
            buyerTxt.Text = row.Cells[3].Value.ToString(); // Buyer
            methodCbx.Text = row.Cells[4].Value.ToString(); // PaymentMethod
            totalPriceTxt.SelectedText = row.Cells[5].Value.ToString(); // TotalPrice
            productCbx.SelectedValue = Convert.ToInt32(row.Cells[6].Value); // Product
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (!SaleService.GetAll().Any())
            {
                MessageBox.Show("Não existem dados para serem deletados, por favor cadastre uma venda!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rowIndex = saleDataGridView.CurrentCell.RowIndex;
            if (rowIndex < 0)
            {
                MessageBox.Show("Para continuar a deleção, é necessário selecionar um dos itens da grid", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = saleDataGridView.Rows[rowIndex];
            var saleId = Convert.ToInt32(row.Cells[0].Value); // ID

            var success = SaleService.Delete(saleId);
            if (!success)
            {
                MessageBox.Show("Erro ao deletar o registro selecionado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            saleBindingSourceGridView.DataSource = SaleService.GetAll();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            saleBindingSource.DataSource = new Sale();
            saleIdTxt.Text = string.Empty;
        }

        /// <summary>
        /// Valida a obrigatoriedade dos campos do formulário, setando erro no errorProvider1 se não forem válidos
        /// <para>O errorProvider1 exibe erros nos campos da tela</para>
        /// </summary>
        /// <param name="sale"></param>
        private void ValidateFields(Sale sale)
        {
            errorProvider1.Clear(); // Clear para sempre limpar os erros antes de checar novamente
            var message = "Campo obrigatório";

            if (sale.ProductId == 0)
            {
                errorProvider1.SetError(productCbx, message);
            }

            if (sale.SaleDate == DateTime.MinValue)
            {
                errorProvider1.SetError(saleDateTxt, message);
            }

            if (string.IsNullOrWhiteSpace(sale.PaymentMethod))
            {
                errorProvider1.SetError(methodCbx, message);
            }

            if (sale.TotalPrice == 0.0M)
            {
                errorProvider1.SetError(totalPriceTxt, message);
            }
        }

        private void quantityTxt_Leave(object sender, EventArgs e)
        {
            var sale = saleBindingSource.Current as Sale ?? new Sale();
            if (sale.ProductId != 0)
            {
                var product = ProductService.GetById(sale.ProductId);
                sale.TotalPrice = sale.Quantity * product.Price;
            }

            saleBindingSource.DataSource = sale;
        }

        private void exportCsvBtn_Click(object sender, EventArgs e)
        {
            var sale = saleBindingSourceGridView.DataSource as List<Sale>;
            if (sale == null || !sale.Any())
            {
                MessageBox.Show("Não existem dados para serem exportados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var csvExporter = new CsvExporterService();
            csvExporter.ExportCsv(sale, "sale", ["Product"]);

            MessageBox.Show("Exportação realizada com sucesso! Consulte o caminho C:\\Relatorios para ver seus relatórios exportados");
        }
    }
}
