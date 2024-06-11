using FazendaUrbana.Forms.Model;
using FazendaUrbana.Forms.Service;

namespace FazendaUrbana
{
    public partial class FrmInputUC : UserControl
    {
        InputService InputService = new InputService();

        public FrmInputUC()
        {
            InitializeComponent();
            inputBindingSource.DataSource = new Input();

            inputBindingSourceGridView.DataSource = InputService.GetAll();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var input = inputBindingSource.Current as Input ?? new Input();

            ValidateFields(input);

            if (errorProvider1.HasErrors)
            {
                MessageBox.Show("Existem campos obrigatórios não preenchidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(inputIdTxt.Text))
            {
                input.Id = Convert.ToInt32(inputIdTxt.Text);
            }

            var success = InputService.Save(input);
            if (!success)
            {
                MessageBox.Show("Falha ao salvar as alterações!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ClearFields();

            inputBindingSourceGridView.DataSource = InputService.GetAll();

            MessageBox.Show("Alterações salvas com sucesso!");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var input = inputBindingSource.Current as Input ?? new Input();
            var lstInput = InputService.GetAll();
            var lstInputTemporary = new List<Input>();

            if (!string.IsNullOrWhiteSpace(input.Name))
            {
                lstInputTemporary = lstInput.FindAll(p => p.Name.ToUpper().Contains(input.Name.ToUpper()));
            }

            if (!lstInputTemporary.Any())
            {
                inputBindingSourceGridView.DataSource = InputService.GetAll();
                MessageBox.Show("Não foram encontrados registros com os filtros selecionados!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            inputBindingSourceGridView.DataSource = lstInputTemporary;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (!InputService.GetAll().Any())
            {
                MessageBox.Show("Não existem dados para serem editados, por favor cadastre um insumo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rowIndex = inputDataGridView.CurrentCell.RowIndex;
            if (rowIndex < 0)
            {
                MessageBox.Show("Para continuar a edição, é necessário selecionar um dos itens da grid", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = inputDataGridView.Rows[rowIndex];
            inputIdTxt.Text = row.Cells[0].Value.ToString(); // ID
            nameTxt.Text = row.Cells[1].Value.ToString(); // Name
            descriptionTxt.Text = row.Cells[2].Value.ToString(); // Description
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int rowIndex = inputDataGridView.CurrentCell.RowIndex;
            if (rowIndex < 0)
            {
                MessageBox.Show("Para continuar a deleção, é necessário selecionar um dos itens da grid", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = inputDataGridView.Rows[rowIndex];
            var inputId = Convert.ToInt32(row.Cells[0].Value); // ID

            var success = InputService.Delete(inputId);
            if (!success)
            {
                MessageBox.Show("Erro ao deletar o registro selecionado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            inputBindingSourceGridView.DataSource = InputService.GetAll();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            inputBindingSource.DataSource = new Input();
            inputIdTxt.Text = string.Empty;
        }

        /// <summary>
        /// Valida a obrigatoriedade dos campos do formulário, setando erro no errorProvider1 se não forem válidos
        /// <para>O errorProvider1 exibe erros nos campos da tela</para>
        /// </summary>
        /// <param name="input"></param>
        private void ValidateFields(Input input)
        {
            errorProvider1.Clear(); // Clear para sempre limpar os erros antes de checar novamente
            var message = "Campo obrigatório";

            if (string.IsNullOrWhiteSpace(input.Name))
            {
                errorProvider1.SetError(nameTxt, message);
            }

            if (string.IsNullOrWhiteSpace(input.Description))
            {
                errorProvider1.SetError(descriptionTxt, message);
            }
        }
    }
}
