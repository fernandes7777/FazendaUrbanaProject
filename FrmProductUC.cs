using FazendaUrbana.Forms.Model;
using FazendaUrbana.Forms.Service;

namespace FazendaUrbana
{
    public partial class FrmProductUC : UserControl
    {
        ProductService ProductService = new ProductService();

        public FrmProductUC()
        {
            InitializeComponent();
            productBindingSource.DataSource = new Product();

            productBindingSourceGridView.DataSource = ProductService.GetAll();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var production = productBindingSource.Current as Product ?? new Product();

            ValidateFields(production);

            if (errorProvider1.HasErrors)
            {
                MessageBox.Show("Existem campos obrigatórios não preenchidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(productIdTxt.Text))
            {
                production.Id = Convert.ToInt32(productIdTxt.Text);
            }

            var success = ProductService.Save(production);
            if (!success)
            {
                MessageBox.Show("Falha ao salvar as alterações!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ClearFields();

            productBindingSourceGridView.DataSource = ProductService.GetAll();

            MessageBox.Show("Alterações salvas com sucesso!");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (!ProductService.GetAll().Any())
            {
                MessageBox.Show("Não existem dados para serem editados, por favor cadastre um produto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rowIndex = productGridView.CurrentCell.RowIndex;
            if (rowIndex < 0)
            {
                MessageBox.Show("Para continuar a edição, é necessário selecionar um dos itens da grid", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = productGridView.Rows[rowIndex];
            productIdTxt.Text = row.Cells[0].Value.ToString(); // ID
            nameTxt.Text = row.Cells[1].Value.ToString(); // Name
            descriptionTxt.Text = row.Cells[2].Value.ToString(); // Description
            priceTxt.Text = row.Cells[3].Value.ToString(); // Price
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int rowIndex = productGridView.CurrentCell.RowIndex;
            if (rowIndex < 0)
            {
                MessageBox.Show("Para continuar a deleção, é necessário selecionar um dos itens da grid", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = productGridView.Rows[rowIndex];
            var productId = Convert.ToInt32(row.Cells[0].Value); // ID

            var success = ProductService.Delete(productId);
            if (!success)
            {
                MessageBox.Show("Erro ao deletar o registro selecionado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            productGridView.DataSource = ProductService.GetAll();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            productBindingSource.DataSource = new Product();
            productIdTxt.Text = string.Empty;
        }

        /// <summary>
        /// Valida a obrigatoriedade dos campos do formulário, setando erro no errorProvider1 se não forem válidos
        /// <para>O errorProvider1 exibe erros nos campos da tela</para>
        /// </summary>
        /// <param name="product"></param>
        private void ValidateFields(Product product)
        {
            errorProvider1.Clear(); // Clear para sempre limpar os erros antes de checar novamente
            var message = "Campo obrigatório";

            if (string.IsNullOrWhiteSpace(product.Name))
            {
                errorProvider1.SetError(nameTxt, message);
            }

            if (string.IsNullOrWhiteSpace(product.Description))
            {
                errorProvider1.SetError(descriptionTxt, message);
            }

            if (product.Price == 0.0M)
            {
                errorProvider1.SetError(priceTxt, message);
            }
        }
    }
}
