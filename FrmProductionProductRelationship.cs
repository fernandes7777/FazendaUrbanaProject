using FazendaUrbana.Forms.Model;
using FazendaUrbana.Forms.Service;

namespace FazendaUrbana.Forms
{
    public partial class FrmProductionProductRelationship : UserControl
    {
        ProductionProductService ProductionProductService = new ProductionProductService();
        ProductService ProductService = new ProductService();
        ProductionService ProductionService = new ProductionService();

        public FrmProductionProductRelationship()
        {
            InitializeComponent();
            productionProductBindingSource.DataSource = new ProductionProduct();
            productionProductBindingSourceGridView.DataSource = ProductionProductService.GetAll();

            productionCbx.DataSource = ProductionService.GetAll();
            productionCbx.DisplayMember = "Description";
            productionCbx.ValueMember = "Id";

            productCbx.DataSource = ProductService.GetAll();
            productCbx.DisplayMember = "Name";
            productCbx.ValueMember = "Id";
        }

        private void relationshipBtn_Click(object sender, EventArgs e)
        {
            var productionProduct = productionProductBindingSource.Current as ProductionProduct ?? new ProductionProduct();

            ValidateFields(productionProduct);

            if (errorProvider1.HasErrors)
            {
                MessageBox.Show("Existem campos obrigatórios não preenchidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var success = ProductionProductService.Save(productionProduct);
            if (!success)
            {
                MessageBox.Show("Falha ao realizar o relacionamento!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ClearFields();

            productionProductBindingSourceGridView.DataSource = ProductionProductService.GetAll();

            MessageBox.Show("Relacionamento realizado com sucesso!");
        }

        private void deleteRelationshipBtn_Click(object sender, EventArgs e)
        {
            int rowIndex = productionProductDataGridView.CurrentCell.RowIndex;
            if (rowIndex < 0)
            {
                MessageBox.Show("Para continuar a deleção, é necessário selecionar um dos itens da grid", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = productionProductDataGridView.Rows[rowIndex];
            var productionId = Convert.ToInt32(row.Cells[0].Value); // ProductionId
            var productId = Convert.ToInt32((row.Cells[1].Value)); // ProductId

            var success = ProductionProductService.Delete(productionId, productId);
            if (!success)
            {
                MessageBox.Show("Erro ao deletar o registro selecionado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            productionProductBindingSourceGridView.DataSource = ProductionProductService.GetAll();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            productionProductBindingSource.DataSource = new ProductionProduct();
        }

        /// <summary>
        /// Valida a obrigatoriedade dos campos do formulário, setando erro no errorProvider1 se não forem válidos
        /// <para>O errorProvider1 exibe erros nos campos da tela</para>
        /// </summary>
        /// <param name="productionProduct"></param>
        private void ValidateFields(ProductionProduct productionProduct)
        {
            errorProvider1.Clear(); // Clear para sempre limpar os erros antes de checar novamente
            var message = "Campo obrigatório";

            if (productionProduct.ProductionId == 0)
            {
                errorProvider1.SetError(productionCbx, message);
            }

            if (productionProduct.ProductId == 0)
            {
                errorProvider1.SetError(productCbx, message);
            }

            if (productionProduct.QuantityProduced == 0)
            {
                errorProvider1.SetError(quantityTxt, message);
            }

            if (productionProduct.TotalPrice == 0.0M)
            {
                errorProvider1.SetError(totalPriceTxt, message);
            }
        }
    }
}
