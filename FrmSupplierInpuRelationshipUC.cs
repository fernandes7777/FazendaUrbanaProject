using FazendaUrbana.Forms.Model;
using FazendaUrbana.Forms.Service;

namespace FazendaUrbana.Forms
{
    public partial class FrmSupplierInpuRelationshipUC : UserControl
    {
        SupplierInputService SupplierInputService = new SupplierInputService();
        SupplierService SupplierService = new SupplierService();
        InputService InputService = new InputService();

        public FrmSupplierInpuRelationshipUC()
        {
            InitializeComponent();
            supplierInputBindingSource.DataSource = new SupplierInput();
            supplierInputBindingSourceGridView.DataSource = SupplierInputService.GetAll();

            supplierCbx.DataSource = SupplierService.GetAll();
            supplierCbx.DisplayMember = "Name";
            supplierCbx.ValueMember = "Id";

            inputCbx.DataSource = InputService.GetAll();
            inputCbx.DisplayMember = "Description";
            inputCbx.ValueMember = "Id";
        }

        private void relationshipBtn_Click(object sender, EventArgs e)
        {
            var supplierInput = supplierInputBindingSource.Current as SupplierInput ?? new SupplierInput();

            ValidateFields(supplierInput);

            if (errorProvider1.HasErrors)
            {
                MessageBox.Show("Existem campos obrigatórios não preenchidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var success = SupplierInputService.Save(supplierInput);
            if (!success)
            {
                MessageBox.Show("Falha ao realizar o relacionamento!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ClearFields();

            supplierInputBindingSourceGridView.DataSource = SupplierInputService.GetAll();

            MessageBox.Show("Relacionamento realizado com sucesso!");
        }

        private void deleteRelationshipBtn_Click(object sender, EventArgs e)
        {
            int rowIndex = supplierInputDataGridView.CurrentCell.RowIndex;
            if (rowIndex < 0)
            {
                MessageBox.Show("Para continuar a deleção, é necessário selecionar um dos itens da grid", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = supplierInputDataGridView.Rows[rowIndex];
            var supplierId = Convert.ToInt32(row.Cells[0].Value); // SupplierId
            var inputId = Convert.ToInt32((row.Cells[1].Value)); // InputId

            var success = SupplierInputService.Delete(inputId, supplierId);
            if (!success)
            {
                MessageBox.Show("Erro ao deletar o registro selecionado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            supplierInputBindingSourceGridView.DataSource = SupplierInputService.GetAll();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            supplierInputBindingSource.DataSource = new SupplierInput();
        }

        /// <summary>
        /// Valida a obrigatoriedade dos campos do formulário, setando erro no errorProvider1 se não forem válidos
        /// <para>O errorProvider1 exibe erros nos campos da tela</para>
        /// </summary>
        /// <param name="supplierInput"></param>
        private void ValidateFields(SupplierInput supplierInput)
        {
            errorProvider1.Clear(); // Clear para sempre limpar os erros antes de checar novamente
            var message = "Campo obrigatório";

            if (supplierInput.SupplierId == 0)
            {
                errorProvider1.SetError(supplierCbx, message);
            }

            if (supplierInput.InputId == 0)
            {
                errorProvider1.SetError(inputCbx, message);
            }

            if (supplierInput.PurchasePrice == 0)
            {
                errorProvider1.SetError(purchasePriceTxt, message);
            }

            if (string.IsNullOrWhiteSpace(supplierInput.PaymentTerms))
            {
                errorProvider1.SetError(paymentTermsTxt, message);
            }
        }
    }
}
